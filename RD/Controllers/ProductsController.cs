using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Models;
using RD.Services;

namespace RD.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        private readonly ProductsService _productsService;
        //private readonly IUsersService _usersService;

        //public UsersController(ILogger<UsersController> logger, IUsersService usersService)
        public ProductsController(ILogger<ProductsController> logger, ProductsService productsService)
        {
            _logger = logger;
            _productsService = productsService;
        }

        public ActionResult Index()
        {
            var products = _productsService.GetProducts();
            ViewBag.Products = products;
            return View();
        }


        [HttpGet("/add_product")]
        public IActionResult Product()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productsService.AddProduct(product);
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public IActionResult Products(Product product)
        {
            _productsService.AddProduct(product);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/edit_product/{id}")]
        public new IActionResult Product(int id)
        {
            var product = _productsService.GetProducts().FirstOrDefault(x => x.Id == id);
            return View(product);
        }

        [HttpPost("/edit_product")]
        public IActionResult Edit(Product product)
        {
            _productsService.UpdateProduct(product);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_product/{id}")]
        public IActionResult Delete(int id)
        {
            _productsService.DeleteProduct(id);
            return Ok();
        }
    }
}
