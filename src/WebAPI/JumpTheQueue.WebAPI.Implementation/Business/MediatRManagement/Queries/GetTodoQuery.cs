using Devon4Net.Infrastructure.MediatR.Query;
using JumpTheQueue.WebAPI.Implementation.Business.MediatRManagement.Dto;

namespace JumpTheQueue.WebAPI.Implementation.Business.MediatRManagement.Queries
{
    public class GetTodoQuery : QueryBase<TodoResultDto>
    {


        public long TodoId{ get; set; }

        /// <summary>
        /// Constructor of the query 
        /// </summary>
        /// <param name="todoId"></param>
        public GetTodoQuery(long todoId)
        {
            TodoId = todoId;
        }
    }
}
