
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RD.Models;
using RD.Services;
//using System.IO;

namespace RD.Controllers
{
    public class FilesController : Controller
    {
        private readonly ILogger<FilesController> _logger;
        private readonly FilesService _filesService; 
        
        IWebHostEnvironment _appEnvironment;
        //private readonly IUsersService _usersService;

        //public UsersController(ILogger<UsersController> logger, IUsersService usersService)
        public FilesController(ILogger<FilesController> logger, FilesService filesService, IWebHostEnvironment appEnvironment)
        {
            _logger = logger;
            _filesService = filesService;
            IWebHostEnvironment _appEnvironment;
        }

        public ActionResult Index()
        {
            var files = _filesService.GetFiles();
            ViewBag.Files = files;
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Files(IFormFile uploadedFile)
        //{
        //    //file.IsActive = true;


        //    if (uploadedFile != null)
        //    {
        //        // путь к папке Files
        //        string path = "/Files/" + uploadedFile.FileName;
        //        // сохраняем файл в папку Files в каталоге wwwroot
        //        using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
        //        {
        //            await uploadedFile.CopyToAsync(fileStream);
        //        }

        //        _filesService.AddFile(path);
        //    }

        //    return RedirectToAction(nameof(Index));
        //}


        [HttpPost]
        public IActionResult Files(File file)
        {
            _filesService.AddFile(file.Filename);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/download/{id}")]
        public new IActionResult File(int id)
        {
            return Ok();
        }


        //[HttpPost("/download")]
        //public IActionResult Edit(File file)
        //{
        //    //_filesService.UpdateFile(file);
        //    return RedirectToAction(nameof(Index));
        //}

        [HttpDelete("/delete_file/{id}")]
        public IActionResult Delete(int id)
        {
            _filesService.DeleteFile(id);
            return Ok();
        }



        //        string path = "/Files/" + uploadedFile.FileName;
        //                // сохраняем файл в папку Files в каталоге wwwroot
        //                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
        //                {
        //                    await uploadedFile.CopyToAsync(fileStream);
        //}
        //FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
        //_context.Files.Add(file);

    }
}
