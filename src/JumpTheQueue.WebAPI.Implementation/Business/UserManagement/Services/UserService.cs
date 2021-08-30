using Devon4Net.Domain.UnitOfWork.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using Devon4Net.Infrastructure.Log;
using JumpTheQueue.WebAPI.Implementation.Business.UserManagement.Converters;
using JumpTheQueue.WebAPI.Implementation.Business.UserManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.UserManagement.Services
{
    public class UserService : Service<JumpTheQueueContext>, IUserService
    {
        private readonly IUserRepository _UserRepository;
        public UserService(IUnitOfWork<JumpTheQueueContext> uoW) : base(uoW)
        {
            _UserRepository = uoW.Repository<IUserRepository>();
        }

        public async Task<IEnumerable<UserDto>> GetUsers(Expression<Func<User, bool>> predicate = null)
        {
            Devon4NetLogger.Debug($"GetUsers method from service UserService");
            var result = await _UserRepository.Get(predicate).ConfigureAwait(false);
            return result.Select(UserConverter.ModelToDto);
        }

        public async Task<UserDto> GetGetUserById(long id)
        {
            Devon4NetLogger.Debug($"GetGetUserById method from service UserService with value : {id}");
            var result = await _UserRepository.GetUserById(id).ConfigureAwait(false);
            return UserConverter.ModelToDto(result);
        }

        public async Task<UserDto> CreateUser(UserDto User)
        {
            //TODO: Add validation if required
            var swap = User;            
            var result = await _UserRepository.Create( swap.Id,  swap.Username,  swap.Password,  swap.Role).ConfigureAwait(false);
            return UserConverter.ModelToDto(result);
        }

        public async Task<long> DeleteUser(int id)
        {
            var User = await _UserRepository.GetFirstOrDefault(t => t.Id.Equals(id)).ConfigureAwait(false);

            if (User == null)
            {
                throw new ArgumentException($"The provided Id {id} does not exists");
            }

            return await _UserRepository.DeleteUserById(id).ConfigureAwait(false);
        }

        public async Task<UserDto> ModifyUserById(long id, UserDto User)
        {
            Devon4NetLogger.Debug($"ModifyUserById method from service UserService with value : {id}");

            var ToUpdate = await _UserRepository.GetFirstOrDefault(t => t.Id.Equals(id)).ConfigureAwait(false);

            if (ToUpdate == null)
            {
                throw new ArgumentException($"The provided Id {id} does not exists");
            }
            var swap = User;
            ToUpdate.Id = swap.Id;
ToUpdate.Username = swap.Username;
ToUpdate.Password = swap.Password;
ToUpdate.Role = swap.Role;
                                
            var result = await _UserRepository.Update(ToUpdate).ConfigureAwait(false);
            return UserConverter.ModelToDto(result);
        }
    }
}
