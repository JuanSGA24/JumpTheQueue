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
        Task<long> DeleteUser(int id);
        Task<IEnumerable<UserDto>> GetUsers(Expression<Func<User, bool>> predicate = null);
        Task<UserDto> GetGetUserById(long id);
        Task<UserDto> ModifyUserById(long id, UserDto User);
    }
}