using Domain.Interfaces.Repositories;
using Domain.RequestFeatures;
using Entities.Models;

namespace Infrastructure.Repositories
{

    internal class AnimeRepository : RepositoryBase<Anime>, IAnimeRepository
    {
        private readonly RepositoryContext _context;
        public AnimeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _context = repositoryContext;
        }

        public void CreateAnime(Anime anime) => Create(anime);

        public void DeleteAnime(Anime anime)
        {
            Delete(anime);
        }

        public IEnumerable<Anime> GetAllAnimes(bool trackChanges)
        {
            return FindAll(trackChanges)
            .OrderBy(c => c.Nome).ToList();
        }
        public PagedList<Anime> GetAnimes(AnimeParameters animeParameters, bool trackChanges)
        {
            return PagedList<Anime>
                .ToPagedList(GetAllAnimes(trackChanges), animeParameters.PageNumber,
                animeParameters.PageSize);
        }

        public Anime GetAnime(Guid animeId, bool trackChanges)
        {
            return FindByCondition(c => c.Id.Equals(animeId), trackChanges)
            .SingleOrDefault();
        }

        public PagedList<Anime> GetAnimesByName(AnimeParameters animeParameters, string searchItem)
        {
            IEnumerable<Anime> animes = FindByCondition(c => c.Nome.ToLower().Contains(searchItem.ToLower()), false)
                .OrderBy(c => c.Nome);

            return PagedList<Anime>
                .ToPagedList(animes, animeParameters.PageNumber,
                animeParameters.PageSize);
        }

        public PagedList<Anime> GetAnimesByDirector(AnimeParameters animeParameters, string searchItem)
        {
            IEnumerable<Anime> animes = FindByCondition(c => c.Diretor.ToLower().Contains(searchItem.ToLower()), false)
                .OrderBy(c => c.Nome);

            return PagedList<Anime>
                .ToPagedList(animes, animeParameters.PageNumber,
                animeParameters.PageSize);
        }

        public PagedList<Anime> GetAnimesByWordInSummary(AnimeParameters animeParameters, string searchItem)
        {
            IEnumerable<Anime> animes = FindByCondition(c => c.Resumo.ToLower().Contains(searchItem.ToLower()), false)
                .OrderBy(c => c.Nome);

            return PagedList<Anime>
                .ToPagedList(animes, animeParameters.PageNumber,
                animeParameters.PageSize);
        }
    }
}
