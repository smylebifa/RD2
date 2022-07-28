using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Controllers
{
    public class StagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/add_stage")]
        public IActionResult Stage()
        {
            return View();
        }

    }
}
