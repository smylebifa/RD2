using System;
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
        //private readonly IUsersService _usersService;

        //public UsersController(ILogger<UsersController> logger, IUsersService usersService)
        public AnnualFinancingsController(ILogger<AnnualFinancingsController> logger, AnnualFinancingsService annualFinancings)
        {
            _logger = logger;
            _annualFinancingsService = annualFinancings;
        }

        public ActionResult Index(string themeName)
        {
            //var theme = _themesService.GetThemes().FirstOrDefault(x => x.Name == themeName);
            var annualFinancings = _annualFinancingsService.GetAnnualFinancings();
            ViewBag.AnnualFinancings = annualFinancings;
            return View();
        }

        [HttpPost]
        public IActionResult AnnualFinancings(AnnualFinancing annualFinancing)
        {
            _annualFinancingsService.AddAnnualFinancing(annualFinancing);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/edit_annual_financing/{id}")]
        public new IActionResult AnnualFinancing(int id)
        {
            var user = _annualFinancingsService.GetAnnualFinancings().FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        [HttpPost("/edit_annual_financing")]
        public IActionResult Edit(AnnualFinancing annualFinancing)
        {
            _annualFinancingsService.UpdateAnnualFinancing(annualFinancing);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_annual_financing/{id}")]
        public IActionResult Delete(int id)
        {
            _annualFinancingsService.DeleteAnnualFinancing(id);
            return Ok();
        }
    }
}