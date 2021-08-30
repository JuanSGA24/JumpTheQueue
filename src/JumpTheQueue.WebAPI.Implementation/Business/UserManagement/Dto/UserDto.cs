using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpTheQueue.WebAPI.Implementation.Business.UserManagement.Dto
{
    public class UserDto
    {

        public Guid Id { get; set; } 
        public string Username { get; set; } 
        public string Password { get; set; } 
        public string Role { get; set; } 
        
    }
}
