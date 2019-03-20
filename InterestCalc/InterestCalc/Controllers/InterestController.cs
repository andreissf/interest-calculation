using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterestCalc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Softplan.Test.Interface.Service;

namespace InterestCalc.Controllers
{
    public class InterestController : Controller
    {
        public IActionResult Index([FromServices] IInterestService interestService,
                                   [FromQuery] decimal valorinicial,
                                   [FromQuery] int meses)
        {
            var viewModel = new InterestViewModel();
            viewModel.Title = "Result Interest";
            viewModel.Result = interestService.Calc(valorinicial, meses).ToString("C");
            return View(viewModel);
        }
    }
}