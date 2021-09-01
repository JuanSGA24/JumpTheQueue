using JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Services
{
    public interface IAccessCodeService
    {
        Task<AccessCodeDto> CreateAccessCode(AccessCodeDto AccessCode);
        Task<Guid> DeleteAccessCode(Guid id);
        Task<IEnumerable<AccessCodeDto>> GetAccessCodes(Expression<Func<AccessCode, bool>> predicate = null);
        Task<AccessCodeDto> GetGetAccessCodeById(Guid id);
        Task<AccessCodeDto> ModifyAccessCodeById(Guid id, AccessCodeDto AccessCode);
    }
}