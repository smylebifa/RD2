using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Controllers
{
    public class TRL : Controller
    {
        // GET: TRL
        public ActionResult Index()
        {
            return View();
        }

        // GET: TRL/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TRL/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TRL/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TRL/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TRL/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TRL/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TRL/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
