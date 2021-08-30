using Devon4Net.Domain.UnitOfWork.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using Devon4Net.Infrastructure.Log;
using JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Converters;
using JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Services
{
    public class AccessCodeService : Service<JumpTheQueueContext>, IAccessCodeService
    {
        private readonly IAccessCodeRepository _AccessCodeRepository;
        public AccessCodeService(IUnitOfWork<JumpTheQueueContext> uoW) : base(uoW)
        {
            _AccessCodeRepository = uoW.Repository<IAccessCodeRepository>();
        }

        public async Task<IEnumerable<AccessCodeDto>> GetAccessCodes(Expression<Func<AccessCode, bool>> predicate = null)
        {
            Devon4NetLogger.Debug($"GetAccessCodes method from service AccessCodeService");
            var result = await _AccessCodeRepository.Get(predicate).ConfigureAwait(false);
            return result.Select(AccessCodeConverter.ModelToDto);
        }

        public async Task<AccessCodeDto> GetGetAccessCodeById(long id)
        {
            Devon4NetLogger.Debug($"GetGetAccessCodeById method from service AccessCodeService with value : {id}");
            var result = await _AccessCodeRepository.GetAccessCodeById(id).ConfigureAwait(false);
            return AccessCodeConverter.ModelToDto(result);
        }

        public async Task<AccessCodeDto> CreateAccessCode(AccessCodeDto AccessCode)
        {
            //TODO: Add validation if required
            var swap = AccessCode;            
            var result = await _AccessCodeRepository.Create( swap.Code,  swap.CreatedTime,  swap.StartTime,  swap.EndTime,  swap.Status,  swap.VisitorId,  swap.QueueId,  swap.Id).ConfigureAwait(false);
            return AccessCodeConverter.ModelToDto(result);
        }

        public async Task<long> DeleteAccessCode(int id)
        {
            var AccessCode = await _AccessCodeRepository.GetFirstOrDefault(t => t.Id.Equals(id)).ConfigureAwait(false);

            if (AccessCode == null)
            {
                throw new ArgumentException($"The provided Id {id} does not exists");
            }

            return await _AccessCodeRepository.DeleteAccessCodeById(id).ConfigureAwait(false);
        }

        public async Task<AccessCodeDto> ModifyAccessCodeById(long id, AccessCodeDto AccessCode)
        {
            Devon4NetLogger.Debug($"ModifyAccessCodeById method from service AccessCodeService with value : {id}");

            var ToUpdate = await _AccessCodeRepository.GetFirstOrDefault(t => t.Id.Equals(id)).ConfigureAwait(false);

            if (ToUpdate == null)
            {
                throw new ArgumentException($"The provided Id {id} does not exists");
            }
            var swap = AccessCode;
            ToUpdate.Code = swap.Code;
ToUpdate.CreatedTime = swap.CreatedTime;
ToUpdate.StartTime = swap.StartTime;
ToUpdate.EndTime = swap.EndTime;
ToUpdate.Status = swap.Status;
ToUpdate.VisitorId = swap.VisitorId;
ToUpdate.QueueId = swap.QueueId;
ToUpdate.Id = swap.Id;
                                
            var result = await _AccessCodeRepository.Update(ToUpdate).ConfigureAwait(false);
            return AccessCodeConverter.ModelToDto(result);
        }
    }
}
