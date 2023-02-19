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


        public ActionResult Index(string themeName)
        {
            ViewBag.ThemeName = themeName;
            return View();
        }

        public ActionResult TRLPage1(string themeName)
        {
            var trls = _trlsService.GetTrls1(themeName);
            ViewBag.Trls1 = trls;
            ViewBag.ThemeName = themeName;
            return View();
        }

        public ActionResult TRLPage2(string themeName)
        {
            //var trls = _trlsService.GetTrls2(themeName);
            //ViewBag.Trls = trls;
            ViewBag.ThemeName = themeName;
            return View();
        }

        //public ActionResult TRLPage3(string themeName)
        //{
        //    var trls = _trlsService.GetTrls3(themeName);
        //    ViewBag.Trls = trls;
        //    ViewBag.ThemeName = themeName;
        //    return View();
        //}

        [HttpPost("/save_trl1/{themeName}/{trl1_1}/{trl1_2}/{trl1_3}/{trl1_4}/{trl2_1}/{trl2_2}/{trl2_3}/{trl2_4}/{trl2_5}/{trl2_6}/{trl2_7}/{trl2_8}/{trl2_9}")]
        public IActionResult SaveTRL1(string themeName, bool trl1_1 = false, bool trl1_2 = false, bool trl1_3 = false, bool trl1_4 = false, 
            bool trl2_1 = false, bool trl2_2 = false, bool trl2_3 = false, bool trl2_4 = false, bool trl2_5 = false, bool trl2_6 = false, 
            bool trl2_7 = false, bool trl2_8 = false, bool trl2_9 = false)

        {
            _trlsService.SaveTRL1(themeName, trl1_1, trl1_2, trl1_3, trl1_4, trl2_1, trl2_2, trl2_3, trl2_4, trl2_5, trl2_6, trl2_7, trl2_8, trl2_9);
            return RedirectToAction(nameof(Index));
        }

        //[HttpPost("/save_trl2/{themeName}/{trl1_1}/{trl1_2}/{trl1_3}/{trl1_4}/{trl1_5}/{trl2_1}/{trl2_2}/{trl2_3}/{trl2_4}/{trl2_5}")]
        //public IActionResult SaveTRL2(string themeName, bool? trl1_1, bool? trl1_2, bool? trl1_3, bool? trl1_4, bool? trl1_5,
        //    bool? trl2_1, bool? trl2_2, bool? trl2_3, bool? trl2_4, bool? trl2_5)
        //{
        //    _trlsService.SaveTRL2(themeName, trl1_1, trl1_2, trl1_3, trl1_4, trl1_5, trl2_1, trl2_2, trl2_3, trl2_4, trl2_5);
        //    return RedirectToAction(nameof(Index));
        //}

        //[HttpPost("/save_trl3/{themeName}/{trl1_1}/{trl1_2}/{trl1_3}/{trl1_4}/{trl1_5}/{trl2_1}/{trl2_2}/{trl2_3}/{trl2_4}/{trl2_5}")]
        //public IActionResult SaveTRL3(string themeName, bool? trl1_1, bool? trl1_2, bool? trl1_3, bool? trl1_4, bool? trl1_5,
        //    bool? trl2_1, bool? trl2_2, bool? trl2_3, bool? trl2_4, bool? trl2_5)
        //{
        //    _trlsService.SaveTRL3(themeName, trl1_1, trl1_2, trl1_3, trl1_4, trl1_5, trl2_1, trl2_2, trl2_3, trl2_4, trl2_5);
        //    return RedirectToAction(nameof(Index));
        //}


    }
}
