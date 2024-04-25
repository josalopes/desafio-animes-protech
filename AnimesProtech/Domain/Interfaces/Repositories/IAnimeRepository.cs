using Domain.RequestFeatures;
using Entities.Models;

namespace Domain.Interfaces.Repositories
{
    public interface IAnimeRepository
    {
        IEnumerable<Anime> GetAllAnimes(bool trackChanges);

        PagedList<Anime> GetAnimes(AnimeParameters animeParameters, bool trackChanges);

        PagedList<Anime> GetAnimesByName(AnimeParameters animeParameters, string searchItem);

        PagedList<Anime> GetAnimesByDirector(AnimeParameters animeParameters, string searchItem);

        PagedList<Anime> GetAnimesByWordInSummary(AnimeParameters animeParameters, string searchItem);

        Anime GetAnime(Guid id, bool trackChanges);

        void CreateAnime(Anime anime);

        void DeleteAnime(Anime anime);
    }
}
