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
        private readonly UsersService _usersService;
        //private readonly IUsersService _usersService;

        //public UsersController(ILogger<UsersController> logger, IUsersService usersService)
        public UsersController(ILogger<UsersController> logger, UsersService usersService)
        {
            _logger = logger;
            _usersService = usersService;
        }

        public ActionResult Index(string error = "")
        {
            if (error == "error")
            {
                var users = _usersService.GetUsers();
                ViewBag.Error = "error";
                ViewBag.Users = users; 
                return View();
            }

            else
            {
                var users = _usersService.GetUsers();
                ViewBag.Error = "";
                ViewBag.Users = users;
                return View();
            }
        }

        [HttpPost]
        public IActionResult Users(User user)
        {
            user.IsActive = true;
            bool addingUserCompleteSucces = _usersService.AddUser(user);
            if (!addingUserCompleteSucces)
                return RedirectToAction("Index", "Users", new { error = "error" });
            else 
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