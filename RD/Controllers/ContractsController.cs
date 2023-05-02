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
    public class ContractsController : Controller
    {
        private readonly ILogger<ContractsController> _logger;
        private readonly ContractsService _contractsService;
        private readonly StagesService _stageService;
        private readonly FilesService _filesService;
        private readonly CounterpartiesService _counterpartiesService;

        private static int ThemeId;
        private static string ThemeName;

        private static IEnumerable<Counterparty> Counterparties;


        public ContractsController(ILogger<ContractsController> logger, ContractsService contractsService, StagesService stageService, FilesService filesService, CounterpartiesService counterpartiesService)
        {
            _logger = logger;
            _contractsService = contractsService;

            _stageService = stageService;
            _filesService = filesService;

            _counterpartiesService = counterpartiesService;
        }

        public ActionResult Index()
        {
            var contracts = _contractsService.GetContracts();
            ViewBag.Contracts = contracts;
            return View();
        }

        public ActionResult ContractDetail(int themeId, string themeName, int contractId)
        {
            var contract = _contractsService.GetContracts().FirstOrDefault(x => x.ThemeId == themeId && x.Id == contractId);
            ViewBag.CurrentContract = contract;

            var stages = _stageService.GetStages().Where(x => x.ThemeId == themeId && x.Id == contractId);
            ViewBag.Stages = stages;

            var files = _filesService.GetFiles();
            ViewBag.Files = files;

            var counterparties = _counterpartiesService.GetCounterparties();

            ViewBag.Counterparties = counterparties;

            ViewBag.ThemeId = themeId;
            ViewBag.ThemeName = themeName;
            

            return View();
        }

        //[HttpPost]
        //public IActionResult AddContract(Contract contract)
        //{
        //    _contractsService.AddContract(contract);
        //    return RedirectToAction(nameof(Index));
        //}

        [HttpGet("/add_contract")]
        public IActionResult Contract(int themeId, string themeName)
        {
            ViewBag.ThemeName = themeName;
            ViewBag.ThemeId = themeId;

            ThemeId = themeId;
            ThemeName = themeName;

            Counterparties = _counterpartiesService.GetCounterparties();

            ViewBag.Counterparties = Counterparties;

            return View();
        }


        [HttpPost]
        public IActionResult Contracts(Contract contract)
        {
            _contractsService.AddContract(contract);
            return RedirectToAction("Index", "Stages", new { themeId = ThemeId, themeName = ThemeName });
        }

        public new IActionResult ChangingContract(int contractId, int themeId, string themeName)
        {
            var contract = _contractsService.GetContracts().FirstOrDefault(x => x.Id == contractId);

            ViewBag.ThemeId = themeId;
            ViewBag.ThemeName = themeName;

            ThemeId = themeId;
            ThemeName = themeName;

            Counterparties = _counterpartiesService.GetCounterparties();

            ViewBag.Counterparties = Counterparties;
            ViewBag.CurrentContract = contract;

            return View(contract);
        }

        [HttpPost("/edit_contract")]
        public IActionResult Edit(Contract contract)
        {
            _contractsService.UpdateContract(contract);
            return RedirectToAction("Index", "Stages", new { themeId = ThemeId, themeName = ThemeName });

        }

        [HttpDelete("/delete_contract/{id}")]
        public IActionResult Delete(int id)
        {
            _contractsService.DeleteContract(id);
            return Ok();
        }

    }
}
