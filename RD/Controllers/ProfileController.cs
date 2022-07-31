using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RD.Controllers
{
    //[Authorize]
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IUsersService _usersService;

        public ProfileController(ILogger<ProfileController> logger, IUsersService usersService)
        {
            _logger = logger;
            _usersService = usersService;
        }

        public IActionResult Index()
        {
            var userClaims = HttpContext.User.Claims;
            var name = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

            ViewBag.UserName = name;
            return View();
        }

        [HttpPost("/change_login/{newLogin}")]
        public IActionResult ChangeLogin(string newLogin)
        {
            var userClaims = HttpContext.User.Claims;
            var oldLogin = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

            if (_usersService.ChangeLogin(oldLogin, newLogin))
                userClaims.Append(new Claim(ClaimTypes.Name, newLogin));

            return RedirectToAction(nameof(Index));
        }

        [HttpPost("/change_password/{oldPassword}/{newPassword}/{newPassword2}")]
        public IActionResult ChangePassword(string oldPassword, string newPassword, string newPassword2)
        {
            var userClaims = HttpContext.User.Claims;
            var name = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

            _usersService.ChangePassword(name, oldPassword, newPassword, newPassword2);
            return RedirectToAction(nameof(Index));
        }
    }
}
