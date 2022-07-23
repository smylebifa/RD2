using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Controllers
{
    public class ThemesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/add_theme")]
        public IActionResult Theme()
        {
            return View();
        }
    }
}
