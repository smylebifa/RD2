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
    public class CounterpartiesController : Controller
    {
        private readonly ILogger<CounterpartiesController> _logger;
        private readonly CounterpartiesService _counterpartiesService;

        public CounterpartiesController(ILogger<CounterpartiesController> logger, CounterpartiesService counterpartiesService)
        {
            _logger = logger;
            _counterpartiesService = counterpartiesService;
        }

        public ActionResult Index(string status = "")
        {
            var counterparties = _counterpartiesService.GetCounterparties();
            ViewBag.Counterparties = counterparties;
            ViewBag.Status = status; 
            return View();
        }

        [HttpPost]
        public IActionResult Counterparties(Counterparty counterparty)
        {
            bool counterpartyWasAdded = _counterpartiesService.AddCounterparty(counterparty);
            if (counterpartyWasAdded)
            {
                return RedirectToAction("Index", "Counterparties", new { status = "success" });
            }

            else
            {
                return RedirectToAction("Index", "Counterparties", new { status = "error" });
            }
        }

        [HttpGet("/edit_counterparty/{id}")]
        public new IActionResult ChangingCounterparty(int id)
        {
            var counterparty = _counterpartiesService.GetCounterparties().FirstOrDefault(x => x.Id == id);
            return View(counterparty);
        }

        [HttpPost("/edit_counterparty")]
        public IActionResult Edit(Counterparty counterparty)
        {
            _counterpartiesService.UpdateCounterparty(counterparty);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_counterparty/{id}")]
        public IActionResult Delete(int id)
        {
            _counterpartiesService.DeleteCounterparty(id);
            return Ok();
        }
    }
}
