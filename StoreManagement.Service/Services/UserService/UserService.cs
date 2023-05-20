using Mapster;
using StoreManagement.Domain.Models.User;
using StoreManagement.Repository.Repositories.RepositoryManager;
using StoreManagement.Service.Contracts.User;
using System;
using System.Collections.Generic;
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

        public async Task<IList<UserDto>> GetAllUsers()
        {
            return (await _repositoryManager.UsersRepository.GetAllUsers()).Adapt<IList<UserDto>>();
        }
    }
}
