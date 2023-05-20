using Mapster;
using StoreManagement.Domain.Exceptions;
using StoreManagement.Domain.Models.User;
using StoreManagement.Repository.Repositories.RepositoryManager;
using StoreManagement.Service.Contracts.User;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement.Service.Services.UserService
{
    public class UserService : IUserService
    {
        IRepositoryManager _repositoryManager;
        public UserService(IRepositoryManager irepositoryManager)
        {
            _repositoryManager = irepositoryManager;
        }

        public async Task<UserDto> CreateUser(UserCreateDto userDto)
        {
            var userModel = userDto.Adapt<UserModel>();
            _repositoryManager.UsersRepository.CreateUser(userModel);
            await _repositoryManager.UnitOfWorkRepository.SaveChangesAsync();
            return userModel.Adapt<UserDto>();
        }

        public async Task DeleteUserAsync(string code)
        {
            var userRecord = await _repositoryManager.UsersRepository.GetUserByCodeAsync(code);
            if (userRecord == null) {
                throw new NotFoundException("NotFound");
            }
            _repositoryManager.UsersRepository.DeleteUser(userRecord);
            await _repositoryManager.UnitOfWorkRepository.SaveChangesAsync();
        }

        public async Task<IList<UserDto>> GetAllUsersAsync()
        {
            return (await _repositoryManager.UsersRepository.GetAllUsersAsync()).Adapt<IList<UserDto>>();
        }
    }
}
