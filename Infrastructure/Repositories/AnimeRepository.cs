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

        public IEnumerable<Anime> GetAllAnimes(EmployeeParameters employeeParameters, bool trackChanges) => FindAll(trackChanges)
                .OrderBy(c => c.Nome)
                .Skip((employeeParameters.PageNumber - 1) * employeeParameters.PageSize)
                .Take(employeeParameters.PageSize)
                .ToList();

        public Anime GetAnime(Guid animeId, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(animeId), trackChanges)
            .SingleOrDefault();
        }
    }
}
