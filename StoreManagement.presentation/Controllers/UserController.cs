using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StoreManagement.Service.Contracts.User;
using StoreManagement.Service.Services.ServiceManager;

namespace StoreManagement.Presentation.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public UserController(IServiceManager serviceManager) 
        {
            _serviceManager = serviceManager;
        }

        [HttpPost]
        public async Task<UserDto> CreateUser(UserCreateDto userCreateDto)
        {
           return await _serviceManager.UserService.CreateUser(userCreateDto);
        }

        [HttpGet]
        public async Task<IList<UserDto>> GetAllUsers()
        {
            return await _serviceManager.UserService.GetAllUsers();
        }
    }
}
