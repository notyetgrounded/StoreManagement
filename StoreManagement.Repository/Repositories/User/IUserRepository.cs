using StoreManagement.Domain.Models.User;

namespace StoreManagement.Repository.Repositories.User
{
    public interface IUserRepository
    {
        void CreateUser(UserModel userModel);
        Task<IList<UserModel>> GetAllUsersAsync();
    }
}