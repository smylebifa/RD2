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

        public ActionResult Index()
        {
            var counterparties = _counterpartiesService.GetCounterparties();
            ViewBag.Counterparties = counterparties;
            return View();
        }

        [HttpPost]
        public IActionResult Counterparties(Counterparty counterparty)
        {
            _counterpartiesService.AddCounterparty(counterparty);
            return RedirectToAction(nameof(Index));
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
