using System;
using System.Collections.Generic;

namespace JumpTheQueue.WebAPI.Implementation.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            Queue = new HashSet<Queue>();
        }

        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Queue> Queue { get; set; }
    }
}
