using StoreManagement.Service.Contracts.User;

namespace StoreManagement.Service.Services.UserService
{
    public interface IUserService
    {
        Task<UserDto> CreateUser(UserCreateDto userDto);
        Task DeleteUserAsync(string code);
        Task<IList<UserDto>> GetAllUsersAsync();
    }
}