using Devon4Net.Domain.UnitOfWork.Repository;
using Devon4Net.Infrastructure.Log;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(JumpTheQueueContext context) : base(context)
        {
        }

        public Task<User> Create(Guid Id,  string Username,  string Password,  string Role)
        {
            //Devon4NetLogger.Debug($"Create method from repository UserRepository with value : {title}");
            return Create(new User { Id = Id,  Username = Username,  Password = Password,  Role = Role,   });
        }

        public async Task<long> DeleteUserById(long id)
        {
            Devon4NetLogger.Debug($"DeleteUserById method from repository UserRepository with value : {id}");
            var deleted = await Delete(t => t.Id.Equals(id)).ConfigureAwait(false);

            if (deleted)
            {
                return id;
            }

            throw new ApplicationException($"The Todo entity {id} has not been deleted.");
        }

        public Task<IList<User>> GetUser(Expression<Func<User, bool>> predicate = null)
        {
            Devon4NetLogger.Debug("GetUser method from UserRepository");
            return Get(predicate);
        }

        public Task<User> GetUserById(long id)
        {
            Devon4NetLogger.Debug($"GetTodoById method from repository UserRepository with value : {id}");
            return GetFirstOrDefault(t => t.Id.Equals(id));
        }
    }
}
