using System;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Models;
using RD.Services;

namespace RD.Controllers
{
    //[Authorize]
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IUsersService _usersService;

        public UsersController(ILogger<UsersController> logger, IUsersService usersService)
        {
            _logger = logger;
            _usersService = usersService;
        }

        public ActionResult Index()
        {
            var users = _usersService.GetUsers();
            ViewBag.Users = users;
            return View();
        }

        [HttpPost]
        public IActionResult Users(User user)
        {
            user.IsActive = true;
            _usersService.AddUser(user);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/edit/{id}")]
        public new IActionResult User(int id)
        {
            var user = _usersService.GetUsers().FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        [HttpPost("/edit")]
        public IActionResult Edit(User user)
        {
            _usersService.UpdateUser(user);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete/{id}")]
        public IActionResult Delete(int id)
        {
            _usersService.DeleteUser(id);
            return Ok();
        }
    }
}