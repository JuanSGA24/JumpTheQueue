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
    public class QueueRepository : Repository<Queue>, IQueueRepository
    {
        public QueueRepository(JumpTheQueueContext context) : base(context)
        {
        }

        public Task<Queue> Create(Guid Id,  string Name,  string Logo,  string Description,  string AccessLink,  int MinAttentionTime,  DateTime OpenTime,  DateTime CloseTime,  bool Started,  bool Closed,  Guid UserId)
        {
            //Devon4NetLogger.Debug($"Create method from repository QueueRepository with value : {title}");
            return Create(new Queue { Id = Id,  Name = Name,  Logo = Logo,  Description = Description,  AccessLink = AccessLink,  MinAttentionTime = MinAttentionTime,  OpenTime = OpenTime,  CloseTime = CloseTime,  Started = Started,  Closed = Closed,  UserId = UserId,   });
        }

        public async Task<long> DeleteQueueById(long id)
        {
            Devon4NetLogger.Debug($"DeleteQueueById method from repository QueueRepository with value : {id}");
            var deleted = await Delete(t => t.Id.Equals(id)).ConfigureAwait(false);

            if (deleted)
            {
                return id;
            }

            throw new ApplicationException($"The Todo entity {id} has not been deleted.");
        }

        public Task<IList<Queue>> GetQueue(Expression<Func<Queue, bool>> predicate = null)
        {
            Devon4NetLogger.Debug("GetQueue method from QueueRepository");
            return Get(predicate);
        }

        public Task<Queue> GetQueueById(long id)
        {
            Devon4NetLogger.Debug($"GetTodoById method from repository QueueRepository with value : {id}");
            return GetFirstOrDefault(t => t.Id.Equals(id));
        }
    }
}
