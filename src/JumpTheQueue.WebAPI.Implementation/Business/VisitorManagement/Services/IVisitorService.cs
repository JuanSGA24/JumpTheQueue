using JumpTheQueue.WebAPI.Implementation.Business.VisitorManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.VisitorManagement.Services
{
    public interface IVisitorService
    {
        Task<VisitorDto> CreateVisitor(VisitorDto Visitor);
        Task<Guid> DeleteVisitor(Guid id);
        Task<IEnumerable<VisitorDto>> GetVisitors(Expression<Func<Visitor, bool>> predicate = null);
        Task<VisitorDto> GetGetVisitorById(Guid id);
        Task<VisitorDto> ModifyVisitorById(Guid id, VisitorDto Visitor);
    }
}