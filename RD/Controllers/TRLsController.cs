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
    public class TRLsController : Controller
    {
        private readonly ILogger<TRLsController> _logger;
        private readonly ITRLsService _trlsService;

        public TRLsController(ILogger<TRLsController> logger, ITRLsService trlsService)
        {
            _logger = logger;
            _trlsService = trlsService;
        }


        public ActionResult Index()
        {
            var trls = _trlsService.GetTrls();
            ViewBag.Trls = trls;
            return View();
        }

        [HttpPost("/save/{trl1}/{trl2}")]
        public IActionResult Edit(bool trl1, bool trl2)
        {
            TRL trl = new TRL(trl1, trl2);
            trl.StageName = "a";

            _trlsService.Save(trl);
            return RedirectToAction(nameof(Index));
        }


    }
}
