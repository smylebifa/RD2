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
    public class FilesController : Controller
    {
        private readonly ILogger<FilesController> _logger;
        private readonly FilesService _filesService; 
        public string dirPath;

        Microsoft.AspNetCore.Hosting.IWebHostEnvironment _appEnvironment;
        private static IEnumerable<Models.File> Files;

        //private readonly IUsersService _usersService;

        //public UsersController(ILogger<UsersController> logger, IUsersService usersService)
        public FilesController(ILogger<FilesController> logger, FilesService filesService, Microsoft.AspNetCore.Hosting.IWebHostEnvironment appEnvironment)
        {
            _logger = logger;
            _filesService = filesService;
            _appEnvironment = appEnvironment;
            dirPath = _appEnvironment.WebRootPath;
        }

        public ActionResult Index()
        {
            Files = _filesService.GetFiles();
            ViewBag.Files = Files;
            return View();
        }

        //[HttpGet("/add_file")]
        //public IActionResult File()
        //{
        //    return View();
        //}

      
        [HttpPost]
        public async Task<IActionResult> AddFile(int themeId, string themeName, IFormFile uploadedFile)
        {
            Files = _filesService.GetFiles();
            ViewBag.Files = Files;

            if (uploadedFile != null)
            {
                // путь к папке Files
                string filePath = "/docs/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(dirPath + filePath, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }

                int LastId = Files.Max(file => file.Id);
                if (LastId is int)
                {
                    LastId++;
                }

                Models.File file = new Models.File { Id = LastId, Filename = uploadedFile.FileName, FileType = uploadedFile.ContentType, Path = filePath };
                _filesService.AddFile(file);
            }

            return RedirectToAction("Index", "Stages", new {themeId, themeName });

        }

        [HttpGet("/edit_file/{id}")]
        public IActionResult ChangingFile(int id)
        {
            var doc = _filesService.GetFiles().FirstOrDefault(x => x.Id == id);
            ViewBag.Doc = doc;
            return View(doc);
        }

        [HttpPost("/edit_file")]
        public IActionResult Edit(Models.File file)
        {
            _filesService.UpdateFile(file);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete("/delete_file/{id}")]
        public IActionResult Delete(int id)
        {
            _filesService.DeleteFile(id);
            return Ok();
        }

    }
}
