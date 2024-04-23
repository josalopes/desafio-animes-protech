using AutoMapper;
using Domain.Dto;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Domain.RequestFeatures;
using Entities.Exceptions;
using Entities.Models;

namespace Domain.Services
{
    internal sealed class AnimeService : IAnimeService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;

        public AnimeService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }

        public AnimeDto CreateAnime(AnimeForCreationDto anime)
        {
            var animeEntity = _mapper.Map<Anime>(anime);
            _repository.Anime.CreateAnime(animeEntity);
            _repository.SaveAsync();

            var animeToReturn = _mapper.Map<AnimeDto>(animeEntity);

            return animeToReturn;
        }

        public void DeleteAnime(Guid id, bool trackChanges)
        {
            var anime = _repository.Anime.GetAnime(id, trackChanges) ?? throw new AnimeNotFoundException(id);
            _repository.Anime.DeleteAnime(anime);
            _repository.SaveAsync();
        }

        public (IEnumerable<AnimeDto> animes, Metadata metadata) GetAllAnimes(AnimeParameters animeParameters, bool trackChanges)
        {
            var animes = _repository.Anime.GetAnimes(animeParameters, trackChanges);
            var animesDto = _mapper.Map<IEnumerable<AnimeDto>>(animes);

            return (animes: animesDto, metadata: animes.Metadata);
        }

        public (IEnumerable<AnimeDto> animes, Metadata metadata) GetAnimesByName(AnimeParameters animeParameters, string searchItems)
        {
            var animes = _repository.Anime.GetAnimesByName(animeParameters, searchItems);
            var animesDto = _mapper.Map<IEnumerable<AnimeDto>>(animes);

            return (animes: animesDto, metadata: animes.Metadata);
        }

        public AnimeDto GetAnime(Guid animeId, bool trackChanges)
        {
            var anime = _repository.Anime.GetAnime(animeId, trackChanges) ?? throw new AnimeNotFoundException(animeId);

            var animeDto = _mapper.Map<AnimeDto>(anime);
            return animeDto;
        }

        public void UpdateAnime(Guid id, AnimeForUpdateDto animeForUpdate, bool trackChanges)
        {
            var animeEntity = _repository.Anime.GetAnime(id, trackChanges) ?? throw new AnimeNotFoundException(id);

            _mapper.Map(animeForUpdate, animeEntity);
            _repository.SaveAsync();
        }

        public void DeactivateAnime(Guid id, bool trackChanges)
        {
            var animeEntity = _repository.Anime.GetAnime(id, trackChanges) ?? throw new AnimeNotFoundException(id);

            //animeEntity.Ativo = false;
            
           // UpdateAnime(animeEntity.Id, animeEntity, true);

        }

        
    }
}
