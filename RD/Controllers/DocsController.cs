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
    public class DocsController : Controller
    {
        private readonly ILogger<DocsController> _logger;
        private readonly DocsService _docsService;
        //private readonly IUsersService _usersService;

        //public UsersController(ILogger<UsersController> logger, IUsersService usersService)
        public DocsController(ILogger<DocsController> logger, DocsService docsService)
        {
            _logger = logger;
            _docsService = docsService;
        }

        public ActionResult Index()
        {
            var docs = _docsService.GetDocs();
            ViewBag.Docs = docs;
            return View();
        }


        [HttpGet("/add_doc")]
        public IActionResult Doc()
        {
            return View();
        }
       

        [HttpPost]
        public IActionResult Docs(Doc doc)
        {
            _docsService.AddDoc(doc);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/edit_doc/{id}")]
        public new IActionResult ChangingDoc(int id)
        {
            var doc = _docsService.GetDocs().FirstOrDefault(x => x.Id == id);
            ViewBag.Doc = doc;
            return View(doc);
        }

        [HttpPost("/edit_doc")]
        public IActionResult Edit(Doc doc)
        {
            _docsService.UpdateDoc(doc);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_doc/{id}")]
        public IActionResult Delete(int id)
        {
            _docsService.DeleteDoc(id);
            return Ok();
        }
        
    }
}
