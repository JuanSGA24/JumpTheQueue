using Devon4Net.Domain.UnitOfWork.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using Devon4Net.Infrastructure.Log;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Converters;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Services
{
    public class QueueService : Service<JumpTheQueueContext>, IQueueService
    {
        private readonly IQueueRepository _QueueRepository;
        public QueueService(IUnitOfWork<JumpTheQueueContext> uoW) : base(uoW)
        {
            _QueueRepository = uoW.Repository<IQueueRepository>();
        }

        public async Task<IEnumerable<QueueDto>> GetQueues(Expression<Func<Queue, bool>> predicate = null)
        {
            Devon4NetLogger.Debug($"GetQueues method from service QueueService");
            var result = await _QueueRepository.Get(predicate).ConfigureAwait(false);
            return result.Select(QueueConverter.ModelToDto);
        }

        public async Task<QueueDto> GetGetQueueById(long id)
        {
            Devon4NetLogger.Debug($"GetGetQueueById method from service QueueService with value : {id}");
            var result = await _QueueRepository.GetQueueById(id).ConfigureAwait(false);
            return QueueConverter.ModelToDto(result);
        }

        public async Task<QueueDto> CreateQueue(QueueDto Queue)
        {
            //TODO: Add validation if required
            var swap = Queue;            
            var result = await _QueueRepository.Create( swap.Id,  swap.Name,  swap.Logo,  swap.Description,  swap.AccessLink,  swap.MinAttentionTime,  swap.OpenTime,  swap.CloseTime,  swap.Started,  swap.Closed,  swap.UserId).ConfigureAwait(false);
            return QueueConverter.ModelToDto(result);
        }

        public async Task<long> DeleteQueue(int id)
        {
            var Queue = await _QueueRepository.GetFirstOrDefault(t => t.Id.Equals(id)).ConfigureAwait(false);

            if (Queue == null)
            {
                throw new ArgumentException($"The provided Id {id} does not exists");
            }

            return await _QueueRepository.DeleteQueueById(id).ConfigureAwait(false);
        }

        public async Task<QueueDto> ModifyQueueById(long id, QueueDto Queue)
        {
            Devon4NetLogger.Debug($"ModifyQueueById method from service QueueService with value : {id}");

            var ToUpdate = await _QueueRepository.GetFirstOrDefault(t => t.Id.Equals(id)).ConfigureAwait(false);

            if (ToUpdate == null)
            {
                throw new ArgumentException($"The provided Id {id} does not exists");
            }
            var swap = Queue;
            ToUpdate.Id = swap.Id;
            ToUpdate.Name = swap.Name;
            ToUpdate.Logo = swap.Logo;
            ToUpdate.Description = swap.Description;
            ToUpdate.AccessLink = swap.AccessLink;
            ToUpdate.MinAttentionTime = swap.MinAttentionTime;
            ToUpdate.OpenTime = swap.OpenTime;
            ToUpdate.CloseTime = swap.CloseTime;
            ToUpdate.Started = swap.Started;
            ToUpdate.Closed = swap.Closed;
            ToUpdate.UserId = swap.UserId;
                                
            var result = await _QueueRepository.Update(ToUpdate).ConfigureAwait(false);
            return QueueConverter.ModelToDto(result);
        }
    }
}
