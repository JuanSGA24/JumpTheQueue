using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Services
{
    public interface IQueueService
    {
        Task<QueueDto> CreateQueue(QueueDto Queue);
        Task<Guid> DeleteQueue(Guid id);
        Task<IEnumerable<QueueDto>> GetQueues(Expression<Func<Queue, bool>> predicate = null);
        Task<QueueDto> GetGetQueueById(Guid id);
        Task<QueueDto> ModifyQueueById(Guid id, QueueDto Queue);
    }
}