using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterestCalc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace InterestCalc.Controllers
{
    public class HomeController : ControllerBase
    {
        public ActionResult Index()
        {
            return Redirect("showmethecode");
        }
    }
}