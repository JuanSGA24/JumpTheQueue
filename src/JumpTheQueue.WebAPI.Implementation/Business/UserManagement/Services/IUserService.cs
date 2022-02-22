using JumpTheQueue.WebAPI.Implementation.Business.UserManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.UserManagement.Services
{
    public interface IUserService
    {
        Task<UserDto> CreateUser(UserDto User);
        Task<Guid> DeleteUser(Guid id);
        Task<IEnumerable<UserDto>> GetUsers(Expression<Func<User, bool>> predicate = null);
        Task<UserDto> GetGetUserById(Guid id);
        Task<UserDto> ModifyUserById(Guid id, UserDto User);
        Task<bool> CheckUserCredentials(UserDto userDto);
    }
}