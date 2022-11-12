using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Models;
using RD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Controllers
{
    //[Authorize]
    public class ThemesController : Controller
    {
        private readonly ILogger<ThemesController> _logger;
        //private readonly IThemesService _themeService;
        private readonly ThemesService _themeService;

        public ThemesController(ILogger<ThemesController> logger, ThemesService themesService)
        {
            _logger = logger;
            _themeService = themesService;
        }
        public IActionResult Index()
        {
            var themes = _themeService.GetThemes();
            ViewBag.Themes = themes;
            return View();
        }

        [HttpGet("/add_theme")]
        public IActionResult Theme()
        {
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
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult AddTheme(Theme theme)
        {
            _themeService.AddTheme(theme);
            return RedirectToAction(nameof(Index));
        }
    }
}
