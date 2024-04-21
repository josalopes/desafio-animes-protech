using Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IAnimeService> _animeService;

        public ServiceManager(Interfaces.Repositories.IRepositoryManager repositoryManager, ILoggerManager logger)
        {
            _animeService = new Lazy<IAnimeService>(() => new AnimeService(repositoryManager, logger));
        }

        public IAnimeService AnimeService => _animeService.Value;

    }
}
