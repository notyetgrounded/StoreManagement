using StoreManagement.Service.Services.UserService;

namespace StoreManagement.Service.Services.ServiceManager
{
    public interface IServiceManager
    {
        IUserService UserService { get; }
    }
}