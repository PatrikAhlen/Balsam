/*
 * BalsamApi
 *
 * This is the API for createing Baslam artifcats.
 *
 * The version of the OpenAPI document: 2.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using BalsamApi.Server.Attributes;
using BalsamApi.Server.Models;

namespace BalsamApi.Server.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public abstract class KnowledgeLibraryApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Removes knowledge library</remarks>
        /// <param name="libraryId">id for the knowledge library</param>
        /// <response code="200">Success</response>
        /// <response code="400">Error respsone for 400</response>
        [HttpDelete]
        [Route("/api/v1/knowledge-libraries/{libraryId}")]
        [ValidateModelState]
        [SwaggerOperation("DeleteKnowledgeLibary")]
        [SwaggerResponse(statusCode: 400, type: typeof(Problem), description: "Error respsone for 400")]
        public abstract Task<IActionResult> DeleteKnowledgeLibary([FromRoute (Name = "libraryId")][Required]string libraryId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>List available knowledge Libraries</remarks>
        /// <response code="200">Success</response>
        [HttpGet]
        [Route("/api/v1/knowledge-libraries")]
        [ValidateModelState]
        [SwaggerOperation("ListKnowledgeLibaries")]
        [SwaggerResponse(statusCode: 200, type: typeof(List<KnowledgeLibrary>), description: "Success")]
        public abstract Task<IActionResult> ListKnowledgeLibaries();
    }
}
