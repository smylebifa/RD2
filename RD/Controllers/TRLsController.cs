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
        private readonly StagesService _stagesService;

        public TRLsController(ILogger<TRLsController> logger, TRLsService trlsService, StagesService stagesService)
        {
            _logger = logger;
            _trlsService = trlsService;
            _stagesService = stagesService;
        }


        public ActionResult Index(int stageId, int themeId, string themeName)
        {
            ViewBag.ThemeId = themeId;
            ViewBag.ThemeName = themeName;
            ViewBag.StageId = stageId;
            return View();
        }

        public ActionResult TRLPage1(int stageId, int themeId, string themeName)
        {
            var trls1 = _trlsService.GetTrls1(themeName, stageId);
            ViewBag.Trls1 = trls1;
            ViewBag.ThemeName = themeName;
            ViewBag.ThemeId = themeId;
            ViewBag.StageId = stageId;
            return View();
        }

        public ActionResult TRLPage2(int stageId, int themeId, string themeName)
        {
            var trls2 = _trlsService.GetTrls2(themeName, stageId);
            ViewBag.Trls2 = trls2;
            ViewBag.ThemeName = themeName;
            ViewBag.ThemeId = themeId;
            ViewBag.StageId = stageId;
            return View();
        }

        public ActionResult TRLPage3(int stageId, int themeId, string themeName)
        {
            var trls3 = _trlsService.GetTrls3(themeName, stageId);
            ViewBag.Trls3 = trls3;
            ViewBag.ThemeName = themeName;
            ViewBag.ThemeId = themeId;
            ViewBag.StageId = stageId;
            return View();
        }

        [HttpPost]
        public IActionResult SaveTRL1(TRL1 trl1, int themeId, int stageId, string themeName)
        {
            _trlsService.SaveTRL1(themeName, stageId, trl1);
            
            Stage stage = _stagesService.GetStages().FirstOrDefault(x => x.Id == stageId && x.ThemeName == themeName);
            stage.TRL = Math.Round((double)trl1.TotalCount / (4 + 9 + 12 + 17 + 12 + 16 + 7 + 5), 2);
            
            return RedirectToAction("TRLPage1", "TRLs", new { stageId, themeId, themeName });
        }

        [HttpPost]
        public IActionResult SaveTRL2(TRL2 trl2, int themeId, int stageId, string themeName)
        {
            _trlsService.SaveTRL2(themeName, stageId, trl2);

            Stage stage = _stagesService.GetStages().FirstOrDefault(x => x.Id == stageId && x.ThemeName == themeName);
            stage.TRL = Math.Round((double) trl2.TotalCount / (4 + 3 + 8 + 11 + 10 + 10 + 4 + 4) , 2);

            return RedirectToAction("TRLPage2", "TRLs", new { stageId, themeId, themeName });

        }

        [HttpPost]
        public IActionResult SaveTRL3(TRL3 trl3, int themeId, int stageId, string themeName)
        {
            _trlsService.SaveTRL3(themeName, stageId, trl3);

            Stage stage = _stagesService.GetStages().FirstOrDefault(x => x.Id == stageId && x.ThemeName == themeName);
            stage.TRL = Math.Round((double) trl3.TotalCount / (10 + 1) , 2);

            return RedirectToAction("TRLPage3", "TRLs", new { stageId, themeId, themeName });

        }
    }
}
