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
    public class VisitorRepository : Repository<Visitor>, IVisitorRepository
    {
        public VisitorRepository(JumpTheQueueContext context) : base(context)
        {
        }

        public Task<Visitor> Create(Guid Id)
        {
            //Devon4NetLogger.Debug($"Create method from repository VisitorRepository with value : {title}");
            return Create(new Visitor { Id = Id,   });
        }

        public async Task<Guid> DeleteVisitorById(Guid id)
        {
            Devon4NetLogger.Debug($"DeleteVisitorById method from repository VisitorRepository with value : {id}");
            var deleted = await Delete(t => t.Id == id).ConfigureAwait(false);

            if (deleted)
            {
                return id;
            }

            throw new ApplicationException($"The Todo entity {id} has not been deleted.");
        }

        public Task<IList<Visitor>> GetVisitor(Expression<Func<Visitor, bool>> predicate = null)
        {
            Devon4NetLogger.Debug("GetVisitor method from VisitorRepository");
            return Get(predicate);
        }

        public Task<Visitor> GetVisitorById(Guid id)
        {
            Devon4NetLogger.Debug($"GetTodoById method from repository VisitorRepository with value : {id}");
            return GetFirstOrDefault(t => t.Id == id);
        }
    }
}
