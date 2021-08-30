using Devon4Net.Domain.UnitOfWork.Repository;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    /// <summary>
    /// User repository interface
    /// </summary>
    public interface IUserRepository : IRepository<User>
    {
        /// <summary>
        /// Get User with predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IList<User>> GetUser(Expression<Func<User, bool>> predicate = null);

        /// <summary>
        /// Get User by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<User> GetUserById(long id);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surName"></param>
        /// <param name="mail"></param>
        /// <returns></returns>
        Task<User> Create(Guid Id,  string Username,  string Password,  string Role);

        /// <summary>
        /// Delete User by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<long> DeleteUserById(long id);
    }
}
