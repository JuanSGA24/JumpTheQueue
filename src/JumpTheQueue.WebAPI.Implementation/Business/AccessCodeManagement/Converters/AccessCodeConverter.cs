using JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Converters
{
    public static class AccessCodeConverter
    {
        /// <summary>
        /// ModelToDto AccessCode transformation
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static AccessCodeDto ModelToDto(AccessCode item)
        {
            if (item == null) return new AccessCodeDto();

            return new AccessCodeDto
            {

                Code = item.Code, 
                CreatedTime = item.CreatedTime, 
                StartTime = item.StartTime,
                EndTime = item.EndTime, 
                Status = item.Status, 
                VisitorId = item.VisitorId, 
                QueueId = item.QueueId, 
                Id = item.Id, 

            };
        }
    }
}
