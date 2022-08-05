using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Controllers
{
    public class StagesController : Controller
    {
        private readonly ILogger<StagesController> _logger;
        private readonly IStagesService _stageService;

        public StagesController(ILogger<StagesController> logger, IStagesService stageService)
        {
            _logger = logger;
            _stageService = stageService;
        }

        public IActionResult Index(string themeName)
        {
            var stages = _stageService.GetStages();
            ViewBag.Stages = stages;
            ViewBag.ThemeName = themeName;
            return View();
        }

        [HttpGet("/add_stage")]
        public IActionResult Stage()
        {
            return View();
        }

    }
}
