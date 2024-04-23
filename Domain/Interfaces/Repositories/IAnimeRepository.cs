using Domain.RequestFeatures;
using Entities.Models;

namespace Domain.Interfaces.Repositories
{
    public interface IAnimeRepository
    {
        IEnumerable<Anime> GetAllAnimes(bool trackChanges);

        PagedList<Anime> GetAnimes(AnimeParameters animeParameters, bool trackChanges);

        Anime GetAnime(Guid id, bool trackChanges);

        void CreateAnime(Anime anime);

        void DeleteAnime( Anime anime);
    }
}
