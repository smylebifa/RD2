using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RD.Models;

namespace RD.Controllers
{
    public class StagesController : Controller
    {
        private readonly ILogger<StagesController> _logger;
        //private readonly IStagesService _stageService;
        private readonly StagesService _stageService;
        private static string ThemeName;

        public StagesController(ILogger<StagesController> logger, StagesService stageService)
        {
            _logger = logger;
            _stageService = stageService;
        }

        public IActionResult Index(string themeName)
        {
            var stages = _stageService.GetStages();
            ViewBag.Stages = stages;
            if (themeName == null)
            {
                ViewBag.ThemeName = ThemeName;
            }

            else
            {
                ViewBag.ThemeName = themeName;
                ThemeName = themeName;
            }

            return View();
        }

        [HttpGet("/edit_stage/{id}")]
        public IActionResult ChangingStage(int id)
        {
            var stage = _stageService.GetStages().FirstOrDefault(x => x.Id == id);
            ViewBag.CurrentStage = stage;
            return View(stage);
        }

        [HttpPost("/edit_stage")]
        public IActionResult Edit(Stage stage)
        {
            _stageService.UpdateStage(stage);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/add_stage")]
        public IActionResult Stage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddStage(Stage stage)
        {
            _stageService.AddStage(stage);
            return RedirectToAction("Index", "Stages", ThemeName);
        }

    }
}
