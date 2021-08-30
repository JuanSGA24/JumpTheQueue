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
    public class AccessCodeRepository : Repository<AccessCode>, IAccessCodeRepository
    {
        public AccessCodeRepository(JumpTheQueueContext context) : base(context)
        {
        }

        public Task<AccessCode> Create(string Code,  DateTime CreatedTime,  DateTime StartTime,  DateTime EndTime,  string Status,  Guid VisitorId,  Guid QueueId,  Guid Id)
        {
            //Devon4NetLogger.Debug($"Create method from repository AccessCodeRepository with value : {title}");
            return Create(new AccessCode { Code = Code,  CreatedTime = CreatedTime,  StartTime = StartTime,  EndTime = EndTime,  Status = Status,  VisitorId = VisitorId,  QueueId = QueueId,  Id = Id,   });
        }

        public async Task<long> DeleteAccessCodeById(long id)
        {
            Devon4NetLogger.Debug($"DeleteAccessCodeById method from repository AccessCodeRepository with value : {id}");
            var deleted = await Delete(t => t.Id.Equals(id)).ConfigureAwait(false);

            if (deleted)
            {
                return id;
            }

            throw new ApplicationException($"The Todo entity {id} has not been deleted.");
        }

        public Task<IList<AccessCode>> GetAccessCode(Expression<Func<AccessCode, bool>> predicate = null)
        {
            Devon4NetLogger.Debug("GetAccessCode method from AccessCodeRepository");
            return Get(predicate);
        }

        public Task<AccessCode> GetAccessCodeById(long id)
        {
            Devon4NetLogger.Debug($"GetTodoById method from repository AccessCodeRepository with value : {id}");
            return GetFirstOrDefault(t => t.Id.Equals(id));
        }
    }
}
