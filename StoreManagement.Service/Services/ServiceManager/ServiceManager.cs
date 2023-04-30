using StoreManagement.Repository.Repositories.RepositoryManager;
using StoreManagement.Service.Services.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Service.Services.ServiceManager
{
    public class ServiceManager : IServiceManager
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly Lazy<IUserService> _lazyUserService;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
            _lazyUserService = new Lazy<IUserService>(() => new UserService.UserService(_repositoryManager));
        }
        public IUserService UserService => _lazyUserService.Value;
    }
}
