using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Models;
using RD.Services;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace RD.Controllers
{
    //[Authorize]
    public class ThemesController : Controller
    {
        private readonly ILogger<ThemesController> _logger;
        private readonly ThemesService _themeService;
        private readonly CustomersService _customersService;
        private readonly DocsService _docService;

        private static IEnumerable <Customer> Customers;
        private static IEnumerable<Doc> Docs;

        public string dirPath;

        Microsoft.AspNetCore.Hosting.IWebHostEnvironment _appEnvironment;

        public ThemesController(ILogger<ThemesController> logger, ThemesService themesService, CustomersService customersService, DocsService docService, Microsoft.AspNetCore.Hosting.IWebHostEnvironment appEnvironment)
        {
            _logger = logger;
            _themeService = themesService;
            _customersService = customersService;
            _docService = docService;
            _appEnvironment = appEnvironment;
            dirPath = _appEnvironment.WebRootPath;

        }
        public IActionResult Index(string status = "")
        {
            var themes = _themeService.GetThemes();
            ViewBag.Themes = themes;
            ViewBag.Status = status;

            Docs = _docService.GetDocs();
            Customers = _customersService.GetCustomers();

            ViewBag.Docs = Docs;

            ViewBag.DirPath = dirPath;

            return View();
        }

        [HttpGet("/add_theme")]
        public IActionResult Theme(string status = "")
        {
            ViewBag.Status = status;
            ViewBag.Customers = Customers;
            return View();
        }

        [HttpGet("/edit_theme/{id}")]
        public IActionResult ChangingTheme(int themeId)
        {
            var theme = _themeService.GetThemes().FirstOrDefault(x => x.Id == themeId);
            ViewBag.CurrentTheme = theme;
            return View(theme);
        }

        [HttpPost("/edit_theme")]
        public IActionResult Edit(Theme theme)
        {
            _themeService.UpdateTheme(theme);
            return RedirectToAction("Index", "Themes");
        }

        [HttpPost]
        public IActionResult AddTheme(Theme theme)
        {
            var context = HttpContext;
            var form = context.Request.Form;

            bool themeWasAdded = _themeService.AddTheme(theme);
            if (!themeWasAdded)
                return RedirectToAction("Theme", "Themes", new { status = "errorWithNameOrNumberTheme" });
            else
                return RedirectToAction("Index", "Themes");
        }


        [HttpPost]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                // путь к папке Files
                string filePath = "/docs/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(dirPath + filePath, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                int LastId = Docs.Max(file => file.Id);
                if (LastId is int)
                {
                    LastId++;
                }

                Doc doc = new Doc { Id = LastId, NameDoc = uploadedFile.FileName, DocType = "txt", Path = filePath };
                _docService.AddDoc(doc);
            }

            return RedirectToAction("AddTheme", "Themes");
        }

        //[HttpPost("/upload_doc")]
        //public ActionResult Upload(IFormFile upload)
        //{
        //    string fileName;

        //    if (upload != null)
        //    {
        //        // получаем имя файла
        //        fileName = upload.FileName;

        //        var memoryStream = new MemoryStream();
        //        upload.CopyToAsync(memoryStream);
        //        System.IO.File.WriteAllBytes(dirPath + "/docs/" + fileName, memoryStream.ToArray());
        //    }
        //    return RedirectToAction("Index");
        //}


        [HttpDelete("/delete_theme/{id}")]
        public IActionResult Delete(int id)
        {
            _themeService.DeleteTheme(id);
            return Ok();
        }
    }
}
