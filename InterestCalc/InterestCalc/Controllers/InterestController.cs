using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterestCalc.Models;
using Microsoft.AspNetCore.Mvc;
using Softplan.Test.Interface.Service;

namespace InterestCalc.Controllers
{
    public class InterestController : ControllerBase
    {
        [HttpGet]
        [Route("calculajuros")]
        public Interest Index([FromServices] IInterestService interestService,
                                   [FromQuery] decimal valorinicial,
                                   [FromQuery] int meses)
        {
            var model = new Interest();
            model.Result = interestService.Calc(valorinicial, meses).ToString();
            return model;
        }
    }
}