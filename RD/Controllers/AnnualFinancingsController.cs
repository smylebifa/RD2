﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Models;
using RD.Services;

namespace RD.Controllers
{
    public class AnnualFinancingsController : Controller
    {
        private readonly ILogger<AnnualFinancingsController> _logger;
        private readonly AnnualFinancingsService _annualFinancingsService;
        private static int ThemeId;
        private static string ThemeName;

        //private readonly IUsersService _usersService;

        //public UsersController(ILogger<UsersController> logger, IUsersService usersService)
        public AnnualFinancingsController(ILogger<AnnualFinancingsController> logger, AnnualFinancingsService annualFinancings)
        {
            _logger = logger;
            _annualFinancingsService = annualFinancings;
        }

        public ActionResult Index(int themeId, string themeName)
        {
            //var theme = _themesService.GetThemes().FirstOrDefault(x => x.Name == themeName);
            var annualFinancings = _annualFinancingsService.GetAnnualFinancings();
            ViewBag.AnnualFinancings = annualFinancings;

            ThemeId = themeId;
            ThemeName = themeName;

            return View();
        }

        [HttpPost("/add_annual_financing")]
        public IActionResult AddAnnualFinancing(AnnualFinancing annualFinancing)
        {
            _annualFinancingsService.AddAnnualFinancing(annualFinancing);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/edit_annual_financing/{id}")]
        public new IActionResult AnnualFinancing(int id, string themeName)
        {
            var annualFinancing = _annualFinancingsService.GetAnnualFinancings().FirstOrDefault(x => x.Id == id);

            ThemeId = annualFinancing.ThemeId;
            ThemeName = themeName;

            return View(annualFinancing);
        }

        [HttpPost("/edit_annual_financing")]
        public IActionResult Edit(AnnualFinancing annualFinancing)
        {
            _annualFinancingsService.UpdateAnnualFinancing(annualFinancing);
            return RedirectToAction("Index", "Stages", new { id = ThemeId, themeName = ThemeName });
        }

        [HttpDelete("/delete_annual_financing/{id}")]
        public IActionResult Delete(int id)
        {
            _annualFinancingsService.DeleteAnnualFinancing(id);
            return Ok();
        }
    }
}