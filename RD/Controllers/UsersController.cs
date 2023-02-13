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

        public ActionResult Index()
        {
            var users = _usersService.GetUsers();
            ViewBag.Status = "";
            ViewBag.Users = users;

            ViewBag.Login = "";
            ViewBag.Email = "";
            ViewBag.FullName = "";
            ViewBag.Password = "";
            ViewBag.IsAdmin = false;
            ViewBag.IsActive = false;

            return View();
        }

        [HttpGet("/add_user")]
        public IActionResult User(string error = "", string login = "", string email = "", string fullName = "", string password = "", bool isAdmin = false, bool isActive = false)
        {
            if (error == "errorWithLogin")
            {
                var users = _usersService.GetUsers();
                ViewBag.Status = "errorWithLogin";
                ViewBag.Users = users;

                ViewBag.Login = login;
                ViewBag.Email = email;
                ViewBag.FullName = fullName;
                ViewBag.Password = password;
                ViewBag.IsAdmin = isAdmin;
                ViewBag.IsActive = isActive;

                return View();
            }

            else if (error == "errorWithEmail")
            {
                var users = _usersService.GetUsers();
                ViewBag.Status = "errorWithEmail";
                ViewBag.Users = users;

                ViewBag.Login = login;
                ViewBag.Email = email;
                ViewBag.FullName = fullName;
                ViewBag.Password = password;
                ViewBag.IsAdmin = isAdmin;
                ViewBag.IsActive = isActive;

                return View();
            }

            return View();
        }


        [HttpGet("/edit_user/{id}")]
        public new IActionResult ChangingUser(int id)
        {
            var user = _usersService.GetUsers().FirstOrDefault(x => x.Id == id);
            return View(user);
        }

        [HttpPost("/edit_user")]
        public IActionResult Edit(User user)
        {
            _usersService.UpdateUser(user);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            bool isUserExist = _usersService.IsUserExist(user.Login);
            bool isEmailExist = _usersService.IsEmailExist(user.Email);

            if (isUserExist)
                return RedirectToAction("User", "Users", new
                {
                    error = "errorWithLogin",
                    login = user.Login,
                    email = user.Email,
                    fullname = user.FullName,
                    password = user.Password,
                    isActive = user.IsActive,
                    isAdmin = user.IsAdmin
                });
            else if (isEmailExist)
                return RedirectToAction("User", "Users", new
                {
                    error = "errorWithEmail",
                    login = user.Login,
                    email = user.Email,
                    fullname = user.FullName,
                    password = user.Password,
                    isActive = user.IsActive,
                    isAdmin = user.IsAdmin
                });
            else
            {
                _usersService.AddUser(user);
                return RedirectToAction(nameof(Index));
            }
                
        }

        [HttpDelete("/delete_user/{id}")]
        public IActionResult Delete(int id)
        {
            _usersService.DeleteUser(id);
            return Ok();
        }
    }
}