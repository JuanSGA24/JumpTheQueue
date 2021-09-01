using Devon4Net.Domain.UnitOfWork.Repository;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces
{
    /// <summary>
    /// Visitor repository interface
    /// </summary>
    public interface IVisitorRepository : IRepository<Visitor>
    {
        /// <summary>
        /// Get Visitor with predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IList<Visitor>> GetVisitor(Expression<Func<Visitor, bool>> predicate = null);

        /// <summary>
        /// Get Visitor by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Visitor> GetVisitorById(Guid id);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surName"></param>
        /// <param name="mail"></param>
        /// <returns></returns>
        Task<Visitor> Create(Guid Id);

        /// <summary>
        /// Delete Visitor by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Guid> DeleteVisitorById(Guid id);
    }
}
