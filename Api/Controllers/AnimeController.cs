using Domain.Dto;
using Domain.Interfaces.Services;
using Domain.RequestFeatures;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Api.Controllers
{
    [Route("api/animes")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly IServiceManager _service;
        private readonly ILoggerManager _logger;

        public AnimeController(IServiceManager service, ILoggerManager logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAnimes([FromQuery] AnimeParameters animeParameters)
        {
            var pagedResult = _service.AnimeService.GetAllAnimes(animeParameters, trackChanges: false);

            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metadata));

            _logger.LogInfo("Busca de todos Animes realizada com sucesso");

            return Ok(pagedResult.animes);
        }

        [HttpGet]
        [Route("/name")]
        public IActionResult GetAnimesByName([FromQuery] AnimeParameters animeParameters, [FromQuery] string name)
        {
            var pagedResult = _service.AnimeService.GetAnimesByName(animeParameters, name);

            Response.Headers.Append("X-Pagination", JsonSerializer.Serialize(pagedResult.metadata));

            _logger.LogInfo("Busca de todos Animes filtrados por Nome realizada com sucesso");

            return Ok(pagedResult.animes);
        }

        [HttpGet]
        [Route("{Id:Guid}", Name = "AnimeById")]
        public IActionResult GetAnime(Guid Id)
        {
            var anime = _service.AnimeService.GetAnime(Id, trackChanges: false);

            _logger.LogInfo($"Busca do Anime {Id} realizada com sucesso");

            return Ok(anime);
        }

        [HttpPost]
        public IActionResult CreateAnime([FromBody] AnimeForCreationDto anime)
        {
            var createdAnime = _service.AnimeService.CreateAnime(anime);

            _logger.LogInfo($"Anime {anime.Nome} salvo com sucesso");

            return CreatedAtRoute("AnimeById", new { id = createdAnime.Id }, createdAnime);
        }

        [HttpPut("{id:guid}")]
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

        [HttpDelete("{id:guid}")]
        public IActionResult DeleteAnime(Guid id)
        {
            _service.AnimeService.DeleteAnime(id, trackChanges: false);

            _logger.LogInfo($"Anime {id} excluído com sucesso");

            return NoContent();
        }
    }
}
