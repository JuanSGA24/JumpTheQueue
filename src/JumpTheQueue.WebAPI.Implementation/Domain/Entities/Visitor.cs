using System;
using System.Collections.Generic;

namespace JumpTheQueue.WebAPI.Implementation.Domain.Entities
{
    public partial class Visitor
    {
        public Visitor()
        {
            AccessCode = new HashSet<AccessCode>();
        }

        public Guid Id { get; set; }

        public virtual ICollection<AccessCode> AccessCode { get; set; }
    }
}
