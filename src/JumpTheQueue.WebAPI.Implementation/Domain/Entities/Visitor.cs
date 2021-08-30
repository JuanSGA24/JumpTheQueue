using System;
using System.Collections.Generic;

namespace JumpTheQueue.WebAPI.Implementation.Domain.Entities
{
    public partial class Visitor
    {
        public Guid Id { get; set; }

        public virtual AccessCode IdNavigation { get; set; }
    }
}
