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
        Task<long> DeleteQueue(int id);
        Task<IEnumerable<QueueDto>> GetQueues(Expression<Func<Queue, bool>> predicate = null);
        Task<QueueDto> GetGetQueueById(long id);
        Task<QueueDto> ModifyQueueById(long id, QueueDto Queue);
    }
}