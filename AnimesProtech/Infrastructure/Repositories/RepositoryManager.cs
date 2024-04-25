using Domain.Interfaces.Repositories;

namespace Infrastructure.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IAnimeRepository> _animeRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _animeRepository = new Lazy<IAnimeRepository>(() => new AnimeRepository(repositoryContext));
        }

        public IAnimeRepository Anime => _animeRepository.Value;

        public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
    }
}
