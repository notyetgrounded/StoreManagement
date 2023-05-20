using Microsoft.EntityFrameworkCore;
using StoreManagement.Domain.Constants;
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

        public async void CreateUser(UserModel userModel)
        {
            userModel.Code = await UserCodeGeneterator();
            _storeDbContext.Users.Add(userModel);
        }

        private async Task<string> UserCodeGeneterator()
        {
            var count = 0;
            var maxCode= _storeDbContext.Users.Max(u => u.Code);
            if (!string.IsNullOrEmpty(maxCode))
            {
                count=Int32.Parse(maxCode.Substring(ApplicationConstants.UserCodePrefix.Length));
            }
            count += 1;
            var code = count.ToString().PadLeft((ApplicationConstants.CodeLength - ApplicationConstants.UserCodePrefix.Length),'0');
            return string.Concat(ApplicationConstants.UserCodePrefix, code);

        }

        public async Task<IList<UserModel>> GetAllUsersAsync()
        {
            return await _storeDbContext.Users.ToListAsync();
        }

        public async Task<UserModel> GetUserByCodeAsync(string code)
        {
            return await _storeDbContext.Users.FirstOrDefaultAsync(u => u.Code == code);
        }

        public void DeleteUser(UserModel userRecord)
        {
            _storeDbContext.Remove(userRecord);
        }
    }
}
