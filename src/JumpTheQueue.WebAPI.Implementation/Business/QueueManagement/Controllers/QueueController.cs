using Devon4Net.Infrastructure.Log;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.QueueManagement.Controllers
{
    [EnableCors("CorsPolicy")]
    [ApiController]
    [Route("[controller]")]
    public class QueueController : ControllerBase
    {
        private readonly IQueueService _QueueService;

        public QueueController(IQueueService QueueService)
        {
            _QueueService = QueueService;
        }

        /// <summary>
        /// Gets the entire list of Queues
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<QueueDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetQueue()
        {
            Devon4NetLogger.Debug("Executing GetQueue from controller QueueController");
            return Ok(await _QueueService.GetQueues().ConfigureAwait(false));
        }
        /// <summary>
        /// Get Queue by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get")]
        [ProducesResponseType(typeof(List<QueueDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetQueueById(int id)
        {
            Devon4NetLogger.Debug("Executing GetQueue from controller QueueController");
            return Ok(await _QueueService.GetGetQueueById(id).ConfigureAwait(false));
        }

        /// <summary>
        /// Creates the Queue
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(QueueDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Create([FromBody]QueueDto Queue)
        {
            Devon4NetLogger.Debug("Executing Create from controller QueueController");
            var result = await _QueueService.CreateQueue(Queue).ConfigureAwait(false);
            return StatusCode(StatusCodes.Status201Created, result);
        }

        /// <summary>
        /// Deletes the Queue provided the id
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [ProducesResponseType(typeof(long), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Delete(int QueueId)
        {
            Devon4NetLogger.Debug("Executing Delete from controller QueueController");
            return Ok(await _QueueService.DeleteQueue(QueueId).ConfigureAwait(false));
        }

        /// <summary>
        /// Modifies the done status of the TODO provided the id
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(typeof(QueueDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> ModifyQueue(int QueueId, [FromBody]QueueDto Queue)
        {
            Devon4NetLogger.Debug("Executing ModifyQueue from controller QueueController");
            return Ok(await _QueueService.ModifyQueueById(QueueId, Queue).ConfigureAwait(false));
        }
    }
}
