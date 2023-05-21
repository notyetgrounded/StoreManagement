using StoreManagement.Domain.Models.User;

namespace StoreManagement.Repository.Repositories.User
{
    public interface IUserRepository
    {
        void CreateUser(UserModel userModel);
        void DeleteUser(UserModel userRecord);
        Task<IList<UserModel>> GetAllUsersAsync();
        Task<UserModel> GetUserByCodeAsync(string code);
    }
}