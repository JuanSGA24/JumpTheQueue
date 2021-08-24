using Devon4Net.Infrastructure.RabbitMQ.Commands;

namespace JumpTheQueue.WebAPI.Implementation.Business.RabbitMqManagement.Commands
{
    /// <summary>
    /// TO-DO command creation via RabbitMq
    /// </summary>
    public class TodoCommand : Command
    {
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }
    }
}
