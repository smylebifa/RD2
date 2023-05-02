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
    public class CustomersController : Controller
    {
        private readonly ILogger<CustomersController> _logger;
        private readonly CustomersService _customersService;
        
        public CustomersController(ILogger<CustomersController> logger, CustomersService customersService)
        {
            _logger = logger;
            _customersService = customersService;
        }

        public ActionResult Index(string status = "")
        {
            var customers = _customersService.GetCustomers();
            ViewBag.Customers = customers;
            ViewBag.Status = status;
            return View();
        }

        [HttpPost]
        public IActionResult Customers(Customer customer)
        {
            bool customerWasAdded = _customersService.AddCustomer(customer);
            
            if (customerWasAdded)
            {
                return RedirectToAction("Index", "Customers", new { status = "success" });
            }

            else 
            {
                return RedirectToAction("Index", "Customers", new { status = "error" });
            }

        }

        [HttpGet("/edit_customer/{id}")]
        public new IActionResult ChangingCustomer(int id)
        {
            var customer = _customersService.GetCustomers().FirstOrDefault(x => x.Id == id);
            return View(customer);
        }

        [HttpPost("/edit_customer")]
        public IActionResult Edit(Customer customer)
        {
            _customersService.UpdateCustomer(customer);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_customer/{id}")]
        public IActionResult Delete(int id)
        {
            _customersService.DeleteCustomer(id);
            return Ok();
        }
    }
}
