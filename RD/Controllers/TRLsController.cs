using Microsoft.AspNetCore.Http;
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
    public class TRLsController : Controller
    {
        private readonly ILogger<TRLsController> _logger;
        //private readonly ITRLsService _trlsService;
        private readonly TRLsService _trlsService;

        public TRLsController(ILogger<TRLsController> logger, TRLsService trlsService)
        {
            _logger = logger;
            _trlsService = trlsService;
        }


        public ActionResult Index(int themeId, string themeName)
        {
            ViewBag.ThemeId = themeId;
            ViewBag.ThemeName = themeName;
            return View();
        }

        public ActionResult TRLPage1(int themeId, string themeName)
        {
            var trls1 = _trlsService.GetTrls1(themeName);
            ViewBag.Trls1 = trls1;
            ViewBag.ThemeId = themeId;
            ViewBag.ThemeName = themeName;
            return View();
        }

        public ActionResult TRLPage2(int themeId, string themeName)
        {
            var trls2 = _trlsService.GetTrls2(themeName);
            ViewBag.Trls2 = trls2;
            ViewBag.ThemeId = themeId;
            ViewBag.ThemeName = themeName;
            return View();
        }

        public ActionResult TRLPage3(int themeId, string themeName)
        {
            var trls3 = _trlsService.GetTrls3(themeName);
            ViewBag.Trls3 = trls3;
            ViewBag.ThemeId = themeId;
            ViewBag.ThemeName = themeName;
            return View();
        }

        [HttpPost]
        public IActionResult SaveTRL1(TRL1 trl1, string themeName)
        {
            _trlsService.SaveTRL1(themeName, trl1);
            return RedirectToAction("TRLPage1", "TRLs", new { themeName = themeName });
        }

        [HttpPost]
        public IActionResult SaveTRL2(TRL2 trl2, string themeName)
        {
            _trlsService.SaveTRL2(themeName, trl2);
            return RedirectToAction("TRLPage2", "TRLs", new { themeName = themeName });

        }

        [HttpPost]
        public IActionResult SaveTRL3(TRL3 trl3, string themeName)
        {
            _trlsService.SaveTRL3(themeName, trl3);
            return RedirectToAction("TRLPage3", "TRLs", new { themeName = themeName });

        }
    }
}
