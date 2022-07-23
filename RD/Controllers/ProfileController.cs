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
            return View();
        }

        [HttpPost("/edit")]
        public IActionResult ChangeLogin(string Login)
        {
            _usersService.ChangeLogin(Login);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost("/edit")]
        public IActionResult ChangePassword(string OldPassword, string NewPassword, string NewPassword2)
        {
            var userClaims = HttpContext.User.Claims;
            var name = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

            _usersService.ChangePassword(name, OldPassword, NewPassword, NewPassword2);
            return RedirectToAction(nameof(Index));
        }
    }
}
