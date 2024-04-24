using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

using Domain.Dto;
using Domain.Interfaces.Services;
using Domain.RequestFeatures;

namespace Api.Controllers
{
    [Route("api/animes")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class AnimeController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly ILoggerManager _logger;

        public AnimeController(IServiceManager service, ILoggerManager logger)
        {
            _service = service;
            _logger = logger;
        }

        /// <summary>
        /// Obtem uma lista de todos os Animes
        /// </summary>
        /// <param name="animeParameters"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        public IActionResult GetAnimes([FromQuery] AnimeParameters animeParameters)
        {
            var pagedResult = _service.AnimeService.GetAllAnimes(animeParameters, trackChanges: false);

            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metadata));
            _logger.LogInfo("Busca de todos Animes realizada com sucesso");

            return Ok(pagedResult.animes);
        }

        /// <summary>
        /// Obtem um Anime pelo Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("{Id:Guid}", Name = "AnimeById")]
        public IActionResult GetAnime(Guid Id)
        {
            var anime = _service.AnimeService.GetAnime(Id, trackChanges: false);
            _logger.LogInfo($"Busca do Anime {Id} realizada com sucesso");

            return Ok(anime);
        }

        /// <summary>
        /// Retorna uma lista de Animes filtrada por um valor da propriedde Nome
        /// </summary>
        /// <param name="animeParameters"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet, Route("name")]
        [Authorize]
        public IActionResult GetAnimesByName([FromQuery] AnimeParameters animeParameters, [FromQuery] string name)
        {
            var pagedResult = _service.AnimeService.GetAnimesByName(animeParameters, name);

            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metadata));
            _logger.LogInfo("Busca de todos Animes filtrados por Nome realizada com sucesso");

            return Ok(pagedResult.animes);
        }

        /// <summary>
        /// Retorna uma lista de Animes filtrada por um valor da propriedde Diretor
        /// </summary>
        /// <param name="animeParameters"></param>
        /// <param name="director"></param>
        /// <returns></returns>
        [HttpGet, Route("director")]
        [Authorize]
        public IActionResult GetAnimesByDirector([FromQuery] AnimeParameters animeParameters, [FromQuery] string director)
        {
            var pagedResult = _service.AnimeService.GetAnimesByDirector(animeParameters, director);

            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metadata));
            _logger.LogInfo("Busca de todos Animes filtrados por Diretor realizada com sucesso");

            return Ok(pagedResult.animes);
        }

        /// <summary>
        /// Retorna uma lista de Animes filtrada pelo valor de uma palavra contida na propriedde Resumo
        /// </summary>
        /// <param name="animeParameters"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        [HttpGet, Route("summary")]
        [Authorize]
        public IActionResult GetAnimesByWordInSummary([FromQuery] AnimeParameters animeParameters, [FromQuery] string word)
        {
            var pagedResult = _service.AnimeService.GetAnimesByWordInSummary(animeParameters, word);

            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metadata));
            _logger.LogInfo("Busca de todos Animes filtrados por palavra no resumo realizada com sucesso");

            return Ok(pagedResult.animes);
        }

        // POST api/todo
        /// <summary>
        /// Cria um novo Anime.
        /// </summary>
        /// <remarks>
        /// Exemplo:
        ///
        ///     POST api/animes
        ///     {
        ///        "nome": "Kimi No Na Wa",
        ///        "diretor": "Makoto Shinkai",
        ///        "resumo": "Vencedor de vários prêmios, dentre os quais o Japan Awards, Your Name conta a história de Mitsuha, uma garota que vive no campo e deseja conhecer Tóquio, e Taki, um garoto qu vive na capital. Certo dia, Mitsuha leva seu desejo a um templo religioso. E é atendida. Ela acorda no corpo de Taki, e ele no corpo dela!",
        ///        "ativo": true
        ///     }
        ///
        /// </remarks>
        /// <param name="anime"></param>
        /// <returns>Um novo Anime criado</returns>
        /// <response code="201">Retorna o novo item criado</response>
        /// <response code="400">Se o item não for criado</response>      
        /// <response code="422">Se o model estiver inválido</response>      
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(422)]
        public IActionResult CreateAnime([FromBody] AnimeForCreationDto anime)
        {
            var createdAnime = _service.AnimeService.CreateAnime(anime);
            _logger.LogInfo($"Anime {anime.Nome} salvo com sucesso");

            return CreatedAtRoute("AnimeById", new { id = createdAnime.Id }, createdAnime);
        }

        /// <summary>
        /// Atualiza um Anime pelo Id e com os valores a serem atualizados
        /// </summary>
        /// <param name="id"></param>
        /// <param name="anime"></param>
        /// <returns></returns>
        [HttpPut("{id:guid}")]
        [Authorize]
        public IActionResult UpdateAnime(Guid id, [FromBody] AnimeForUpdateDto anime)
        {
            if (anime == null) 
            {
                return BadRequest("O objeto AnimeForUpdateDto é nulo");
            }

            _service.AnimeService.UpdateAnime(id, anime, trackChanges: true);
            _logger.LogInfo($"Anime {id} atualizado com sucesso");

            return NoContent();
        }

        /// <summary>
        /// Efetua a exclusão lógica de um Anime (Ativo = false)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id:guid}")]
        [Authorize(Roles = "Administrator")]
        public IActionResult DeleteAnime(Guid id)
        {
            _service.AnimeService.DeleteAnime(id);
            _logger.LogInfo($"Anime {id} foi desativado com sucesso");

            return NoContent();
        }
    }
}
