namespace Domain.Interfaces.Services
{
    public interface IServiceManager
    {
        IAnimeService AnimeService { get; }
        IAuthenticationService AuthenticationService { get; }
    }
}
