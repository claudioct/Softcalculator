using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using SoftCalculator.Api.Attributes;
using Swashbuckle.AspNetCore.Annotations;
using SoftCalculator.Application;

namespace SoftCalculator.Api.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    public class CalculajurosApiController : Controller
    {
        private readonly IInsterestCalculatorService _insterestCalculatorService;
        public CalculajurosApiController(IInsterestCalculatorService insterestCalculatorService)
        {
            _insterestCalculatorService = insterestCalculatorService;
        }


        /// <summary>
        /// Realiza calculo de juros compostos
        /// </summary>
        
        /// <param name="valorInicial">Valor Inicial</param>
        /// <param name="meses">Tempo é um inteiro, que representa meses</param>
        /// <response code="200">successful operation</response>
        /// <response code="400">Invalid request</response>
        [HttpGet]
        [Route("//calculajuros")]
        [ValidateModelState]
        [SwaggerOperation("CalculateInterestRate")]
        [SwaggerResponse(statusCode: 200, type: typeof(decimal), description: "successful operation")]
        public virtual IActionResult CalculateInterestRate([FromQuery][Required()]decimal? valorInicial,
                                                           [FromQuery][Required()]int? meses)

        { 
            if (!valorInicial.HasValue || valorInicial.Value < 0)
            {
                BadRequest("Valor inicial inválido.");
            }

            if (!meses.HasValue || meses.Value < 0)
            {
                BadRequest("Quatidade de meses inválido.");
            }

            var finalAmount = _insterestCalculatorService.Calculate(valorInicial.Value, meses.Value);

            return Ok(finalAmount); 
        }
    }
}
