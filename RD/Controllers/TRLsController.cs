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
            var trls = _trlsService.GetTrls(themeName);
            ViewBag.Trls = trls;
            ViewBag.ThemeName = themeName;
            return View();
        }

        [HttpPost("/save/{themeName}/{trl1_1}/{trl1_2}/{trl1_3}/{trl1_4}/{trl1_5}/{trl2_1}/{trl2_2}/{trl2_3}/{trl2_4}/{trl2_5}")]
        public IActionResult Edit(string themeName, bool? trl1_1, bool? trl1_2, bool? trl1_3, bool? trl1_4, bool? trl1_5,
            bool? trl2_1, bool? trl2_2, bool? trl2_3, bool? trl2_4, bool? trl2_5)
        {
            _trlsService.Save(themeName, trl1_1, trl1_2, trl1_3, trl1_4, trl1_5, trl2_1, trl2_2, trl2_3, trl2_4, trl2_5);
            return RedirectToAction(nameof(Index));
        }


    }
}
