using Devon4Net.Infrastructure.Log;
using JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Dto;
using JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JumpTheQueue.WebAPI.Implementation.Business.AccessCodeManagement.Controllers
{
    [EnableCors("CorsPolicy")]
    [ApiController]
    [Route("[controller]")]
    public class AccessCodeController : ControllerBase
    {
        private readonly IAccessCodeService _AccessCodeService;

        public AccessCodeController(IAccessCodeService AccessCodeService)
        {
            _AccessCodeService = AccessCodeService;
        }

        /// <summary>
        /// Gets the entire list of AccessCodes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(List<AccessCodeDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAccessCode()
        {
            Devon4NetLogger.Debug("Executing GetAccessCode from controller AccessCodeController");
            return Ok(await _AccessCodeService.GetAccessCodes().ConfigureAwait(false));
        }
        /// <summary>
        /// Get AccessCode by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("get")]
        [ProducesResponseType(typeof(List<AccessCodeDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> GetAccessCodeById(Guid id)
        {
            Devon4NetLogger.Debug("Executing GetAccessCode from controller AccessCodeController");
            return Ok(await _AccessCodeService.GetGetAccessCodeById(id).ConfigureAwait(false));
        }

        /// <summary>
        /// Creates the AccessCode
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(AccessCodeDto), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Create([FromBody]AccessCodeDto AccessCode)
        {
            Devon4NetLogger.Debug("Executing Create from controller AccessCodeController");
            var result = await _AccessCodeService.CreateAccessCode(AccessCode).ConfigureAwait(false);
            return StatusCode(StatusCodes.Status201Created, result);
        }

        /// <summary>
        /// Deletes the AccessCode provided the id
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [ProducesResponseType(typeof(Guid), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> Delete(Guid AccessCodeId)
        {
            Devon4NetLogger.Debug("Executing Delete from controller AccessCodeController");
            return Ok(await _AccessCodeService.DeleteAccessCode(AccessCodeId).ConfigureAwait(false));
        }

        /// <summary>
        /// Modifies the done status of the TODO provided the id
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(typeof(AccessCodeDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult> ModifyAccessCode(Guid AccessCodeId, [FromBody]AccessCodeDto AccessCode)
        {
            Devon4NetLogger.Debug("Executing ModifyAccessCode from controller AccessCodeController");
            return Ok(await _AccessCodeService.ModifyAccessCodeById(AccessCodeId, AccessCode).ConfigureAwait(false));
        }
    }
}
