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
    public class RIAsController : Controller
    {
        private readonly ILogger<RIAsController> _logger;
        private readonly RIAsService _riasService;
        //private readonly IUsersService _usersService;

        //public UsersController(ILogger<UsersController> logger, IUsersService usersService)
        public RIAsController(ILogger<RIAsController> logger, RIAsService riasService)
        {
            _logger = logger;
            _riasService = riasService;
        }

        public ActionResult Index()
        {
            var rias = _riasService.GetRIAs();
            ViewBag.RIAs = rias;
            return View();
        }


        [HttpGet("/add_ria")]
        public IActionResult RIA()
        {
            return View();
        }
       

        [HttpPost]
        public IActionResult RIAs(RIA ria)
        {
            _riasService.AddRIA(ria);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/edit_ria/{id}")]
        public new IActionResult ChangingRIA(int id)
        {
            var ria = _riasService.GetRIAs().FirstOrDefault(x => x.Id == id);
            return View(ria);
        }

        [HttpPost("/edit_ria")]
        public IActionResult Edit(RIA ria)
        {
            _riasService.UpdateRIA(ria);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_ria/{id}")]
        public IActionResult Delete(int id)
        {
            _riasService.DeleteRIA(id);
            return Ok();
        }
        
    }
}
