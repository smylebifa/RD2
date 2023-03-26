using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Models;
using RD.Services;
using System.Collections.Generic;
using System.Linq;

namespace RD.Controllers
{
    //[Authorize]
    public class ThemesController : Controller
    {
        private readonly ILogger<ThemesController> _logger;
        //private readonly IThemesService _themeService;
        private readonly ThemesService _themeService;
        private readonly CustomersService _customersService;

        private static IEnumerable <Customer> Customers;

        public ThemesController(ILogger<ThemesController> logger, ThemesService themesService, CustomersService customersService)
        {
            _logger = logger;
            _themeService = themesService;
            _customersService = customersService;
        }
        public IActionResult Index(string status = "")
        {
            var themes = _themeService.GetThemes();
            ViewBag.Themes = themes;
            ViewBag.Status = status;

            Customers = _customersService.GetCustomers();
            
            return View();
        }

        [HttpGet("/add_theme")]
        public IActionResult Theme(string status = "")
        {
            ViewBag.Status = status;
            ViewBag.Customers = Customers;
            return View();
        }

        [HttpGet("/edit_theme/{id}")]
        public IActionResult ChangingTheme(int id)
        {
            var theme = _themeService.GetThemes().FirstOrDefault(x => x.Id == id);
            ViewBag.CurrentTheme = theme;
            return View(theme);
        }

        [HttpPost("/edit_theme")]
        public IActionResult Edit(Theme theme)
        {
            _themeService.UpdateTheme(theme);
            return RedirectToAction("Index", "Themes");
        }

        [HttpPost]
        public IActionResult AddTheme(Theme theme)
        {
            bool themeWasAdded = _themeService.AddTheme(theme);
            if (!themeWasAdded)
                return RedirectToAction("Theme", "Themes", new { status = "errorWithNameOrNumberTheme" });
            else
                return RedirectToAction("Index", "Themes");
        }

        [HttpDelete("/delete_theme/{id}")]
        public IActionResult Delete(int id)
        {
            _themeService.DeleteTheme(id);
            return Ok();
        }
    }
}
