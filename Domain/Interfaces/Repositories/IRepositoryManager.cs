namespace Domain.Interfaces.Repositories
{
    public interface IRepositoryManager
    {
        IAnimeRepository Anime { get; }

        Task SaveAsync();
    }
}
