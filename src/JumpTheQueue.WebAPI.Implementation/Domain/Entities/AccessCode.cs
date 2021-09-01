using System;
using System.Collections.Generic;

namespace JumpTheQueue.WebAPI.Implementation.Domain.Entities
{
    public partial class AccessCode
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string Status { get; set; }
        public Guid VisitorId { get; set; }
        public Guid QueueId { get; set; }

        public virtual Queue Queue { get; set; }
        public virtual Visitor Visitor { get; set; }
    }
}
