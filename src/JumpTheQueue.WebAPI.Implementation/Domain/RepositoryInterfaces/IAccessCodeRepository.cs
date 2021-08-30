using Devon4Net.Domain.UnitOfWork.Repository;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    /// <summary>
    /// AccessCode repository interface
    /// </summary>
    public interface IAccessCodeRepository : IRepository<AccessCode>
    {
        /// <summary>
        /// Get AccessCode with predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IList<AccessCode>> GetAccessCode(Expression<Func<AccessCode, bool>> predicate = null);

        /// <summary>
        /// Get AccessCode by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<AccessCode> GetAccessCodeById(long id);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surName"></param>
        /// <param name="mail"></param>
        /// <returns></returns>
        Task<AccessCode> Create(string Code,  DateTime CreatedTime,  DateTime StartTime,  DateTime EndTime,  string Status,  Guid VisitorId,  Guid QueueId,  Guid Id);

        /// <summary>
        /// Delete AccessCode by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<long> DeleteAccessCodeById(long id);
    }
}
