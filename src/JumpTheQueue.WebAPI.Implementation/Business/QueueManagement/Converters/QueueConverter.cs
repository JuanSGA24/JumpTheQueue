using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Converters
{
    public static class QueueConverter
    {
        /// <summary>
        /// ModelToDto Queue transformation
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static QueueDto ModelToDto(Queue item)
        {
            if (item == null) return new QueueDto();

            return new QueueDto
            {

                Id = item.Id, 
                Name = item.Name, 
                Logo = item.Logo, 
                Description = item.Description, 
                AccessLink = item.AccessLink, 
                MinAttentionTime = item.MinAttentionTime, 
                OpenTime = item.OpenTime, 
                CloseTime = item.CloseTime, 
                Started = item.Started, 
                Closed = item.Closed, 
                UserId = item.UserId, 

            };
        }
    }
}
