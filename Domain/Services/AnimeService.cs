using Domain.Dto;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Entities.Exceptions;
using Entities.Models;

namespace Domain.Services
{
    internal sealed class AnimeService : IAnimeService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public AnimeService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public Anime CreateAnime(Anime anime)
        {
            //var animeEntity = _mapper.Map<Anime>(anime);
            _repository.Anime.CreateAnime(anime);
            _repository.Save();

            //var animeToReturn = _mapper.Map<AnimeDto>(animeEntity);

            return anime;
        }

        public IEnumerable<Anime> GetAllAnimes(bool trackChanges)
        {
            var animes = _repository.Anime.GetAllAnimes(trackChanges);
            //var animesDto = IEnumerable<AnimeDto>(animes);

            return animes;
        }

        public Anime GetAnime(Guid animeId, bool trackChanges)
        {
            var anime = _repository.Anime.GetAnime(animeId, trackChanges);
            if (anime == null)
            {
                throw new AnimeNotFoundException(animeId);
            }

            //var animeDto = _mapper.Map<AnimeDto>(anime);
            return anime;
        }
    }
}
