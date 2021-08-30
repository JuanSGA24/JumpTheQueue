using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Dto
{
    public class QueueDto
    {

        public Guid Id { get; set; } 
        public string Name { get; set; } 
        public string Logo { get; set; } 
        public string Description { get; set; } 
        public string AccessLink { get; set; } 
        public int MinAttentionTime { get; set; } 
        public DateTime OpenTime { get; set; } 
        public DateTime CloseTime { get; set; } 
        public bool Started { get; set; } 
        public bool Closed { get; set; } 
        public Guid UserId { get; set; } 
        
    }
}
