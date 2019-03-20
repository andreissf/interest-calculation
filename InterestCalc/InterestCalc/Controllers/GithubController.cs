using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterestCalc.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace InterestCalc.Controllers
{
    public class GithubController : Controller
    {
        public ActionResult Index([FromServices] IConfiguration configuration)
        {
            var viewModel = new GithubViewModel();
            viewModel.Title = "Show me the code";
            viewModel.CodeLink = configuration.GetSection("Github").GetValue<string>("Code");
            return View(viewModel);
        }
    }
}