using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterestCalc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace InterestCalc.Controllers
{
    public class GithubController : ControllerBase
    {
        [HttpGet]
        [Route("showmethecode")]
        public Github Index([FromServices] IConfiguration configuration)
        {
            var model = new Github();
            model.CodeLink = configuration.GetSection("Github").GetValue<string>("Code");
            return model;
        }
    }
}