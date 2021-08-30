using JumpTheQueue.WebAPI.Implementation.Business.VisitorManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace JumpTheQueue.WebAPI.Implementation.Business.VisitorManagement.Converters
{
    public static class VisitorConverter
    {
        /// <summary>
        /// ModelToDto Visitor transformation
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static VisitorDto ModelToDto(Visitor item)
        {
            if (item == null) return new VisitorDto();

            return new VisitorDto
            {

                Id = item.Id, 

            };
        }
    }
}
