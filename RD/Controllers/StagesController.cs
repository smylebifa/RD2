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
        private readonly ThemesService _themeService;
        private readonly StagesService _stageService;
        private readonly AnnualFinancingsService _annualFinancingsService;
        private readonly ContractsService _сontractsService;
        private readonly FilesService _filesService;

        private readonly ScientificDocsService _scientificDocsService;
        private readonly ProductsService _productsService;
        private readonly RIAsService _riasService;

        private static int ThemeId;
        private static string ThemeName;

        public StagesController(ILogger<StagesController> logger, StagesService stageService, 
            ThemesService themeService, AnnualFinancingsService annualFinancings, ContractsService сontractsService, FilesService filesService,
            ScientificDocsService scientificDocsService, ProductsService productsService, RIAsService riasService)
        {
            _logger = logger;
            _stageService = stageService;
            _themeService = themeService;
            _annualFinancingsService = annualFinancings;
            _сontractsService = сontractsService;
            _filesService = filesService;

            _scientificDocsService = scientificDocsService;
            _productsService = productsService;
            _riasService = riasService;

        }

        public IActionResult Index(int id, string themeName)
        {
            var stages = _stageService.GetStages();
            ViewBag.Stages = stages;

            var theme = _themeService.GetThemes().FirstOrDefault(x => x.Id == id);
            ViewBag.CurrentTheme = theme;

            var annualFinancings = _annualFinancingsService.GetAnnualFinancings().FirstOrDefault(x => x.ThemeId == theme.Id);
            ViewBag.AnnualFinancings = annualFinancings;

            var сontracts = _сontractsService.GetContracts();
            ViewBag.Contracts = сontracts;

            var files = _filesService.GetFiles();
            ViewBag.Files = files;
            

            if (themeName == null)
            {
                ViewBag.ThemeName = ThemeName;
                ViewBag.ThemeId = ThemeId;
            }

            else
            {
                ViewBag.ThemeId = ThemeId;
                ViewBag.ThemeName = themeName;
                ThemeName = themeName;
                ThemeId = id;
            }

            return View();
        }


        public IActionResult StageDetail(int id)
        {
            var stage = _stageService.GetStages().FirstOrDefault(x => x.Id == id);
            ViewBag.Stage = stage;

            var scientificDocs = _scientificDocsService.GetScientificDocs();
            ViewBag.ScientificDocs = scientificDocs;
            
            var products = _productsService.GetProducts();
            ViewBag.Products = products;
           
            var rias = _riasService.GetRIAs();
            ViewBag.RIAs = rias;

            var files = _filesService.GetFiles();
            ViewBag.Files = files;

            return View();
        }

        [HttpGet("/edit_stage/{id}")]
        public IActionResult ChangingStage(int id)
        {
            var stage = _stageService.GetStages().FirstOrDefault(x => x.Id == id);
            ViewBag.CurrentStage = stage;
            ViewBag.ThemeName = ThemeName;
            ViewBag.ThemeId = ThemeId;
            return View(stage);
        }

        [HttpPost("/edit_stage")]
        public IActionResult Edit(Stage stage)
        {
            _stageService.UpdateStage(stage);
            return RedirectToAction("Index", "Stages", new { id = ThemeId, themeName = ThemeName });
        }

        [HttpGet("/add_stage")]
        public IActionResult Stage()
        {
            ViewBag.ThemeName = ThemeName;
            ViewBag.ThemeId = ThemeId;
            return View();
        }

        [HttpPost]
        public IActionResult AddStage(Stage stage)
        {
            _stageService.AddStage(stage);
            return RedirectToAction("Index", "Stages", new { id = ThemeId, themeName = ThemeName });
        }

        [HttpDelete("/delete_stage/{id}")]
        public IActionResult Delete(int id)
        {
            _stageService.DeleteStage(id);
            return Ok();
        }

    }
}
