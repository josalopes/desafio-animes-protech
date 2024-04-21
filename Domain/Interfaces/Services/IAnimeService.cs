using Domain.Dto;
using Entities.Models;

namespace Domain.Interfaces.Services
{
    public interface IAnimeService
    {
        IEnumerable<Anime> GetAllAnimes(bool trackChanges);
        Anime GetAnime(Guid animeId, bool trackChanges);
        Anime CreateAnime(Anime anime);
    }
}
