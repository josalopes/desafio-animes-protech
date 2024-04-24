using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Entities.Models;

namespace Domain.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAnimeService> _animeService;
        private readonly Lazy<IAuthenticationService> _authenticationService;

        public ServiceManager(IRepositoryManager repositoryManager, 
            ILoggerManager logger, 
            IMapper mapper,
            UserManager<User> userManager,
            IConfiguration configuration)
        {
            _animeService = new Lazy<IAnimeService>(() => new AnimeService(repositoryManager, logger, mapper));
            _authenticationService = new Lazy<IAuthenticationService>(() => new AuthenticationService(logger, mapper, userManager, configuration));
        }

        public IAnimeService AnimeService => _animeService.Value;
        public IAuthenticationService AuthenticationService => _authenticationService.Value;

    }
}
