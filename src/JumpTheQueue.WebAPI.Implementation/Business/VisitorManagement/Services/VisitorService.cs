using Devon4Net.Domain.UnitOfWork.Service;
using Devon4Net.Domain.UnitOfWork.UnitOfWork;
using Devon4Net.Infrastructure.Log;
using JumpTheQueue.WebAPI.Implementation.Business.VisitorManagement.Converters;
using JumpTheQueue.WebAPI.Implementation.Business.VisitorManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Database;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using JumpTheQueue.WebAPI.Implementation.Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.VisitorManagement.Services
{
    public class VisitorService : Service<JumpTheQueueContext>, IVisitorService
    {
        private readonly IVisitorRepository _VisitorRepository;
        public VisitorService(IUnitOfWork<JumpTheQueueContext> uoW) : base(uoW)
        {
            _VisitorRepository = uoW.Repository<IVisitorRepository>();
        }

        public async Task<IEnumerable<VisitorDto>> GetVisitors(Expression<Func<Visitor, bool>> predicate = null)
        {
            Devon4NetLogger.Debug($"GetVisitors method from service VisitorService");
            var result = await _VisitorRepository.Get(predicate).ConfigureAwait(false);
            return result.Select(VisitorConverter.ModelToDto);
        }

        public async Task<VisitorDto> GetGetVisitorById(Guid id)
        {
            Devon4NetLogger.Debug($"GetGetVisitorById method from service VisitorService with value : {id}");
            var result = await _VisitorRepository.GetVisitorById(id).ConfigureAwait(false);
            return VisitorConverter.ModelToDto(result);
        }

        public async Task<VisitorDto> CreateVisitor(VisitorDto Visitor)
        {
            //TODO: Add validation if required
            var swap = Visitor;            
            var result = await _VisitorRepository.Create( swap.Id ).ConfigureAwait(false);
            return VisitorConverter.ModelToDto(result);
        }

        public async Task<Guid> DeleteVisitor(Guid id)
        {
            var Visitor = await _VisitorRepository.GetFirstOrDefault(t => t.Id == id).ConfigureAwait(false);

            if (Visitor == null)
            {
                throw new ArgumentException($"The provided Id {id} does not exists");
            }

            return await _VisitorRepository.DeleteVisitorById(id).ConfigureAwait(false);
        }

        public async Task<VisitorDto> ModifyVisitorById(Guid id, VisitorDto Visitor)
        {
            Devon4NetLogger.Debug($"ModifyVisitorById method from service VisitorService with value : {id}");

            var ToUpdate = await _VisitorRepository.GetFirstOrDefault(t => t.Id == id).ConfigureAwait(false);

            if (ToUpdate == null)
            {
                throw new ArgumentException($"The provided Id {id} does not exists");
            }
            var swap = Visitor;
            ToUpdate.Id = swap.Id;
                                
            var result = await _VisitorRepository.Update(ToUpdate).ConfigureAwait(false);
            return VisitorConverter.ModelToDto(result);
        }
    }
}
