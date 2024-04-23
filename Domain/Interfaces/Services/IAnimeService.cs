using Domain.Dto;
using Domain.RequestFeatures;
using Entities.Models;

namespace Domain.Interfaces.Services
{
    public interface IAnimeService
    {
        (IEnumerable<AnimeDto> animes, Metadata metadata) GetAllAnimes(AnimeParameters animeParameters, bool trackChanges);

        (IEnumerable<AnimeDto> animes, Metadata metadata) GetAnimesByName(AnimeParameters animeParameters, string searchItems);
        AnimeDto GetAnime(Guid animeId, bool trackChanges);
        AnimeDto CreateAnime(AnimeForCreationDto anime);

        void UpdateAnime(Guid id, AnimeForUpdateDto anime, bool trackChanges);

        void DeleteAnime(Guid id, bool trackChanges);

        void DeactivateAnime(Guid id, bool trackChanges);
    }
}
