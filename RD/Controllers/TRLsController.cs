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
            var trls1 = _trlsService.GetTrls1(themeName);
            ViewBag.Trls1 = trls1;
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

        //[HttpPost("/save_trl1/{themeName}/{trl1_1}/{trl1_2}/{trl1_3}/{trl1_4}/{trl2_1}/{trl2_2}/{trl2_3}/{trl2_4}/{trl2_5}/{trl2_6}/{trl2_7}/{trl2_8}/{trl2_9}" +
        //    "/{trl3_1}/{trl3_2}/{trl3_3}/{trl3_4}/{trl3_5}/{trl3_6}/{trl3_7}/{trl3_8}/{trl3_9}/{trl3_10}/{trl3_11}/{trl3_12}" +
        //    "/{trl4_1}/{trl4_2}/{trl4_3}/{trl4_4}/{trl4_5}/{trl4_6}/{trl4_7}/{trl4_8}/{trl4_9}/{trl4_10}/{trl4_11}/{trl4_12}/{trl4_13}/{trl4_14}/{trl4_15}/{trl4_16}/{trl4_17}")]

        //[HttpPost("/save_trl1/{themeName}/{trl3}/{trl4}")]

        //public IActionResult SaveTRL1(string themeName, bool trl1_1 = false, bool trl1_2 = false, bool trl1_3 = false, bool trl1_4 = false,

        //    bool trl2_1 = false, bool trl2_2 = false, bool trl2_3 = false, bool trl2_4 = false, bool trl2_5 = false, bool trl2_6 = false,
        //    bool trl2_7 = false, bool trl2_8 = false, bool trl2_9 = false,

        //    bool trl3_1 = false, bool trl3_2 = false, bool trl3_3 = false, bool trl3_4 = false, bool trl3_5 = false, bool trl3_6 = false,
        //    bool trl3_7 = false, bool trl3_8 = false, bool trl3_9 = false, bool trl3_10 = false, bool trl3_11 = false, bool trl3_12 = false,

        //    bool trl4_1 = false, bool trl4_2 = false, bool trl4_3 = false, bool trl4_4 = false, bool trl4_5 = false, bool trl4_6 = false,
        //    bool trl4_7 = false, bool trl4_8 = false, bool trl4_9 = false, bool trl4_10 = false, bool trl4_11 = false, bool trl4_12 = false,
        //    bool trl4_13 = false, bool trl4_14 = false, bool trl4_15 = false, bool trl4_16 = false, bool trl4_17 = false)


        [HttpPost]
        public IActionResult SaveTRL1(TRL1 trl1, string themeName)
        {
            _trlsService.SaveTRL1(themeName, trl1);

            //, trl2_1, trl2_2, trl2_3, trl2_4, trl2_5, trl2_6, trl2_7, trl2_8, trl2_9,
            //    trl3_1, trl3_2, trl3_3, trl3_4, trl3_5, trl3_6, trl3_7, trl3_8, trl3_9, trl3_10, trl3_11, trl3_12, 

            //    trl4_1, trl4_2, trl4_3, trl4_4, trl4_5, trl4_6, trl4_7, trl4_8, trl4_9, trl4_10, trl4_11, trl4_12, trl4_13, trl4_14, trl4_15, trl4_16, trl4_17

            //return RedirectToAction(nameof(Index));


            return RedirectToAction("TRLPage1", "TRLs", new { themeName = themeName });

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
