using JumpTheQueue.WebAPI.Implementation.Business.UserManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpTheQueue.WebAPI.Implementation.Business.UserManagement.Converters
{
    public static class UserConverter
    {
        /// <summary>
        /// ModelToDto User transformation
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static UserDto ModelToDto(User item)
        {
            if (item == null) return new UserDto();

            return new UserDto
            {

                Id = item.Id, 
Username = item.Username, 
Password = item.Password, 
Role = item.Role, 

            };
        }
    }
}
