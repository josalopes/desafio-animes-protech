using Domain.Interfaces.Repositories;
using Entities.Models;

namespace Infrastructure.Repositories
{

    internal class AnimeRepository : RepositoryBase<Anime>, IAnimeRepository
    {
        public AnimeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateAnime(Anime anime) => Create(anime);

        public void DeleteAnime(Anime anime)
        {
            Delete(anime);
        }

        public IEnumerable<Anime> GetAllAnimes(bool trackChanges) =>
            FindAll(trackChanges)
                .OrderBy(c => c.Nome)
                .ToList();

        public Anime GetAnime(Guid animeId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(animeId), trackChanges)
            .SingleOrDefault();
    }
}
