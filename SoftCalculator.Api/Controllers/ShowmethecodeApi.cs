using Microsoft.AspNetCore.Mvc;
using SoftCalculator.Api.Attributes;
using Swashbuckle.AspNetCore.Annotations;

namespace SoftCalculator.Api.Controllers
{
    public class ShowmethecodeApiController : Controller
    { 
        /// <summary>
        /// Retorna repositorio no github
        /// </summary>
        
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid request</response>
        [HttpGet]
        [Route("//showmethecode")]
        [ValidateModelState]
        [SwaggerOperation("ReturnCodeRepository")]
        [SwaggerResponse(statusCode: 200, type: typeof(string), description: "successful operation")]
        public virtual IActionResult ReturnCodeRepository()
        {
            return Ok("https://github.com/claudioct/Softcalculator");
        }
    }
}
