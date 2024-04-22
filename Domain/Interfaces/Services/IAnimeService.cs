using Domain.Dto;
using Domain.RequestFeatures;
using Entities.Models;

namespace Domain.Interfaces.Services
{
    public interface IAnimeService
    {
        IEnumerable<AnimeDto> GetAllAnimes(AnimeParameters animeParameters, bool trackChanges);
        AnimeDto GetAnime(Guid animeId, bool trackChanges);
        AnimeDto CreateAnime(AnimeForCreationDto anime);

        void UpdateAnime(Guid id, AnimeForUpdateDto anime, bool trackChanges);

        void DeleteAnime(Guid id, bool trackChanges);

        void DeactivateAnime(Guid id, bool trackChanges);
    }
}
