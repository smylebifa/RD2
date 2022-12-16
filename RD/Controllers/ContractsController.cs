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

        public ContractsController(ILogger<ContractsController> logger, ContractsService contractsService)
        {
            _logger = logger;
            _contractsService = contractsService;
        }

        public ActionResult Index()
        {
            var contracts = _contractsService.GetContracts();
            ViewBag.Contracts = contracts;
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
