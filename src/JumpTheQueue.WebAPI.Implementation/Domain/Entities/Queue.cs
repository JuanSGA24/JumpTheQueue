using System;
using System.Collections.Generic;

namespace JumpTheQueue.WebAPI.Implementation.Domain.Entities
{
    public partial class Queue
    {
        public Queue()
        {
            AccessCode = new HashSet<AccessCode>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public string AccessLink { get; set; }
        public int MinAttentionTime { get; set; }
        public DateTime? OpenTime { get; set; }
        public DateTime? CloseTime { get; set; }
        public bool? Started { get; set; }
        public bool? Closed { get; set; }
        public Guid UserId { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<AccessCode> AccessCode { get; set; }
    }
}
