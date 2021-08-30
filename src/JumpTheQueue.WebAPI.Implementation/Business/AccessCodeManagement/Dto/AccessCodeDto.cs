using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Dto
{
    public class AccessCodeDto
    {

        public string Code { get; set; } 
        public DateTime CreatedTime { get; set; } 
        public DateTime StartTime { get; set; } 
        public DateTime EndTime { get; set; } 
        public string Status { get; set; } 
        public Guid VisitorId { get; set; } 
        public Guid QueueId { get; set; } 
        public Guid Id { get; set; } 
        
    }
}
