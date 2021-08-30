using Devon4Net.Infrastructure.Log;
using JumpTheQueue.WebAPI.Implementation.Business.VisitorManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Business.VisitorManagement.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.VisitorManagement.Controllers
{
    [EnableCors("CorsPolicy")]
    [ApiController]
    [Route("[controller]")]
    public class VisitorController : ControllerBase
    {
        private readonly IVisitorService _VisitorService;

        public VisitorController(IVisitorService VisitorService)
        {
            _VisitorService = VisitorService;
        }

        /// <summary>
        /// Gets the entire list of Visitors
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<VisitorDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetVisitor()
        {
            Devon4NetLogger.Debug("Executing GetVisitor from controller VisitorController");
            return Ok(await _VisitorService.GetVisitors().ConfigureAwait(false));
        }
        /// <summary>
        /// Get Visitor by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get")]
        [ProducesResponseType(typeof(List<VisitorDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetVisitorById(int id)
        {
            Devon4NetLogger.Debug("Executing GetVisitor from controller VisitorController");
            return Ok(await _VisitorService.GetGetVisitorById(id).ConfigureAwait(false));
        }

        /// <summary>
        /// Creates the Visitor
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(VisitorDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Create([FromBody]VisitorDto Visitor)
        {
            Devon4NetLogger.Debug("Executing Create from controller VisitorController");
            var result = await _VisitorService.CreateVisitor(Visitor).ConfigureAwait(false);
            return StatusCode(StatusCodes.Status201Created, result);
        }

        /// <summary>
        /// Deletes the Visitor provided the id
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [ProducesResponseType(typeof(long), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Delete(int VisitorId)
        {
            Devon4NetLogger.Debug("Executing Delete from controller VisitorController");
            return Ok(await _VisitorService.DeleteVisitor(VisitorId).ConfigureAwait(false));
        }

        /// <summary>
        /// Modifies the done status of the TODO provided the id
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(typeof(VisitorDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> ModifyVisitor(int VisitorId, [FromBody]VisitorDto Visitor)
        {
            Devon4NetLogger.Debug("Executing ModifyVisitor from controller VisitorController");
            return Ok(await _VisitorService.ModifyVisitorById(VisitorId, Visitor).ConfigureAwait(false));
        }
    }
}
