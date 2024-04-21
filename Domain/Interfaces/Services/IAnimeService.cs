using Domain.Dto;
using Entities.Models;

namespace Domain.Interfaces.Services
{
    public interface IAnimeService
    {
        IEnumerable<AnimeDto> GetAllAnimes(bool trackChanges);
        AnimeDto GetAnime(Guid animeId, bool trackChanges);
        AnimeDto CreateAnime(AnimeForCreationDto anime);

        void UpdateAnime(Guid id, AnimeForUpdateDto anime, bool trackChanges);

        void DeleteAnime(Guid id, bool trackChanges);
    }
}
