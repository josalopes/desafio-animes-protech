using Domain.Interfaces.Repositories;
using Domain.RequestFeatures;
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

        public IEnumerable<Anime> GetAllAnimes(AnimeParameters animeParameters, bool trackChanges) => FindAll(trackChanges)
                .OrderBy(c => c.Nome)
                .Skip((animeParameters.PageNumber - 1) * animeParameters.PageSize)
                .Take(animeParameters.PageSize)
                .ToList();

        public Anime GetAnime(Guid animeId, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(animeId), trackChanges)
            .SingleOrDefault();
        }
    }
}
