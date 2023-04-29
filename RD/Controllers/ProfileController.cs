using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Services;
using System.Linq;
using System.Security.Claims;

namespace RD.Controllers
{
    //[Authorize]
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;
        //private readonly IUsersService _usersService;
        private readonly UsersService _usersService;

        public ProfileController(ILogger<ProfileController> logger, UsersService usersService)
        {
            _logger = logger;
            _usersService = usersService;
        }

        public IActionResult Index(string status = "")
        {
            var userClaims = HttpContext.User.Claims;
            var name = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

            ViewBag.UserName = name;

            var currentUser = _usersService.GetUsers().FirstOrDefault(x => x.Login == name);

            if (currentUser != null)
            {
                ViewBag.FullName = currentUser.FullName;
            }

            ViewBag.Status = status;

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

        public IActionResult ChangePassword(string oldPassword, string newPassword, string newPassword2)
        {
            var userClaims = HttpContext.User.Claims;
            var name = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;

            bool passwordChanged = _usersService.ChangePassword(name, oldPassword, newPassword, newPassword2);
            if (passwordChanged)
                return RedirectToAction("Index", "Profile", new { status = "success" });
            else
                return RedirectToAction("Index", "Profile", new { status = "error" });


        }
    }
}
