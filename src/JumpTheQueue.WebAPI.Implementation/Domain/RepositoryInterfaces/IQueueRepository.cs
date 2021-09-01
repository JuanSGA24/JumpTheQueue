using Devon4Net.Domain.UnitOfWork.Repository;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    /// <summary>
    /// Queue repository interface
    /// </summary>
    public interface IQueueRepository : IRepository<Queue>
    {
        /// <summary>
        /// Get Queue with predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IList<Queue>> GetQueue(Expression<Func<Queue, bool>> predicate = null);

        /// <summary>
        /// Get Queue by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Queue> GetQueueById(Guid id);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surName"></param>
        /// <param name="mail"></param>
        /// <returns></returns>
        Task<Queue> Create(Guid Id,  string Name,  string Logo,  string Description,  string AccessLink,  int MinAttentionTime,  DateTime? OpenTime,  DateTime? CloseTime,  bool? Started,  bool? Closed,  Guid UserId);

        /// <summary>
        /// Delete Queue by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Guid> DeleteQueueById(Guid id);
    }
}
