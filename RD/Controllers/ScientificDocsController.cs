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
    public class ScientificDocsController : Controller
    {
        private readonly ILogger<ScientificDocsController> _logger;
        private readonly ScientificDocsService _scientificDocsService;
        
        public ScientificDocsController(ILogger<ScientificDocsController> logger, ScientificDocsService scientificDocsService)
        {
            _logger = logger;
            _scientificDocsService = scientificDocsService;
        }

        public ActionResult Index()
        {
            var scientificDocs = _scientificDocsService.GetScientificDocs();
            ViewBag.ScientificDocs = scientificDocs;
            return View();
        }

        [HttpGet("/add_scientific_doc")]
        public IActionResult ScientificDoc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ScientificDocs(ScientificDoc scientificDoc)
        {
            _scientificDocsService.AddScientificDoc(scientificDoc);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/edit_scientific_doc/{id}")]
        public new IActionResult ChangingScientificDoc(int id)
        {
            var scientificDoc = _scientificDocsService.GetScientificDocs().FirstOrDefault(x => x.Id == id);
            return View(scientificDoc);
        }

        [HttpPost("/edit_scientific_doc")]
        public IActionResult Edit(ScientificDoc scientificDoc)
        {
            _scientificDocsService.UpdateScientificDoc(scientificDoc);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_scientific_doc/{id}")]
        public IActionResult Delete(int id)
        {
            _scientificDocsService.DeleteScientificDoc(id);
            return Ok();
        }
    }
}
