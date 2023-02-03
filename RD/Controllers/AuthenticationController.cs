using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace RD.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly Services.AuthenticationService _authenticationService;

        public AuthenticationController(Services.AuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpGet("/login")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/login")]
        public async Task<IActionResult> Login()
        {
            var context = HttpContext;
            var form = context.Request.Form;

            // Проверка на заполненность полей формы
            if (!form.ContainsKey("login") || !form.ContainsKey("password"))
                return RedirectToPage("400");
                //throw new UnauthorizedAccessException();

            var login = form["login"];
            var password = form["password"];

            if (!_authenticationService.Login(login, password))
                return RedirectToPage("401");
                //throw new InvalidOperationException();

            var claims = new List<Claim> { new Claim(ClaimTypes.Name, login) };
            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await context.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction("Index", "Home");
        }

        [HttpGet("/logout")]
        public async Task<IActionResult> Logout()
        {
            var context = HttpContext;
            await context.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Authentication");
        }

        [Authorize]
        [HttpGet("/authenticated")]
        public string IsAuthenticated()
        {
            var userClaims = HttpContext.User.Claims;
            var name = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Name)?.Value;
            if (string.IsNullOrEmpty(name))
            {
                // Код ошибки - не авторизован
                HttpContext.Response.StatusCode = 401;
                return string.Empty;
            }

            return name;
        }

        [HttpGet]
        public IActionResult RegisterPage(string status = "", string login = "")
        {
            ViewBag.Status = status;
            ViewBag.Login = login;

            // Передаем пользователю представление RegisterPage 
            return View();
        }

        [HttpPost]
        public IActionResult Register(string login, string password, string password2, string email)
        {
            if (_authenticationService.IsUserExist(login))
            {
                return RedirectToAction("RegisterPage", "Authentication", new { status = "error", login = login });
            }

            else
            {               
                if (password == null || password == "")
                {
                    return RedirectToAction("RegisterPage", "Authentication", new { status = "success" , login = login});
                }

                else
                {
                    _authenticationService.Register(login, password, email);
                    return RedirectToAction("Index");
                }

            }
        }
    }
}
