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

        public ContractsController(ILogger<ContractsController> logger, ContractsService contractsService, StagesService stageService, FilesService filesService)
        {
            _logger = logger;
            _contractsService = contractsService;

            _stageService = stageService;
            _filesService = filesService;
        }

        public ActionResult Index()
        {
            var contracts = _contractsService.GetContracts();
            ViewBag.Contracts = contracts;
            return View();
        }

        public ActionResult ContractDetail(int themId)
        {
            var contracts = _contractsService.GetContracts().FirstOrDefault(x => x.ThemeId == themId);
            ViewBag.CurrentContract = contracts;

            var stages = _stageService.GetStages();
            ViewBag.Stages = stages;

            var files = _filesService.GetFiles();
            ViewBag.Files = files;

            return View();
        }

        //[HttpPost]
        //public IActionResult AddContract(Contract contract)
        //{
        //    _contractsService.AddContract(contract);
        //    return RedirectToAction(nameof(Index));
        //}

        [HttpGet("/add_contract")]
        public IActionResult Contract()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Contracts(Contract contract)
        {
            _contractsService.AddContract(contract);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/edit_contract/{id}")]
        public new IActionResult ChangingContract(int id)
        {
            var contract = _contractsService.GetContracts().FirstOrDefault(x => x.Id == id);
            return View(contract);
        }

        [HttpPost("/edit_contract")]
        public IActionResult Edit(Contract contract)
        {
            _contractsService.UpdateContract(contract);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_contract/{id}")]
        public IActionResult Delete(int id)
        {
            _contractsService.DeleteContract(id);
            return Ok();
        }  

    }
}
