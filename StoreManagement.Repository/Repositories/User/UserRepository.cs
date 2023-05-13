using Microsoft.EntityFrameworkCore;
using StoreManagement.Domain.Models.User;
using StoreManagement.Repository.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Repository.Repositories.User
{
    internal class UserRepository : IUserRepository
    {
        private StoreDbContext _storeDbContext;
        public UserRepository(StoreDbContext storeDbContext)
        {
            _storeDbContext = storeDbContext;
        }

        public void CreateUser(UserModel userModel)
        {
            _storeDbContext.Users.Add(userModel);
        }

        private string UserCodeGeneterator()
        {
            var count = 0;
            var maxCode= _storeDbContext.Users.MaxAsync(u => u.Code);
            maxcount
        }

        public Task<IList<UserModel>> GetAllUsersAsync()
        {
            return _storeDbContext.Users.ToListAsync();
        }
    }
}
