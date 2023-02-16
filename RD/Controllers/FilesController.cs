
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

        //public IActionResult Load(string FileName)
        //{
        //    return Ok;
        //}

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
        public new IActionResult File(string Filename)
        {
            string file_path = ("Files/" + Filename + "." + "txt");
            // Тип файла - content-type
            string file_type = "application/pdf";
            // Имя файла - необязательно
            string file_name = "PDFIcon.pdf";
            return File(file_path, file_type, file_name);
            
            //return Ok();
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


        [HttpPost]
        public ActionResult Upload(IFormFile upload)
        {
            string fileName;
            if (upload != null)
            {
                // получаем имя файла
                fileName = upload.FileName;
                // сохраняем файл в папку Files в проекте

                _filesService.AddFile(fileName);

            }
            return RedirectToAction("Index");
        }

        

        //public IActionResult PrivateFiles(string file, string mode)
        //{
        //    // Путь к закрытому каталогу.
        //    string pathDirectory =
        //        System.IO.Path.Combine(MyConstants.PrivateDownloadDirectory);

        //    return SelectiveResult(file, mode, pathDirectory);
        //}

        //public IActionResult PublicFiles(string file, string mode)
        //{
        //    // Путь к открытому каталогу.
        //    string pathDirectory =
        //        System.IO.Path.Combine(_environment.WebRootPath, MyConstants.PublicDownloadDirectory);

        //    return SelectiveResult(file, mode, pathDirectory);
        //}

        //// =======

        //[NonAction]
        //private IActionResult SelectiveResult(string file, string mode, string pathDirectory)
        //{
        //    if (file == null)
        //    {
        //        var model = new Download();

        //        // Заполняем список данными файлов для показа на странице.
        //        var di = new System.IO.DirectoryInfo(pathDirectory);

        //        // При первом извлечении свойств FileInfo вызывает Refresh метод и 
        //        // кэширует сведения о файле.
        //        // При последующих вызовах необходимо вызвать, Refresh чтобы 
        //        // получить последнюю копию информации.
        //        model.ListFiles = di.GetFiles().ToList();

        //        return View(model);
        //    }
        //    else
        //    {
        //        var fi = new System.IO.FileInfo(Path.Combine(pathDirectory, file));
        //        // Обновляем информацию о запрошенном файле.
        //        fi.Refresh();

        //        if (fi.Exists == true)
        //        {
        //            // Конструкция оператора switch начиная с C# 8.0
        //            return mode switch
        //            {
        //                "virtual" => VirtualDownload(fi),
        //                "stream" => StreamDownload(fi),
        //                "bytes" => BytesDownload(fi),
        //                _ => new EmptyResult(),
        //            };
        //        }
        //        else
        //        {
        //            // Обработка ситуации отсутствия файла.
        //            // 1. Запись в файл регистрации ошибок 
        //            // 2. Отправка оповещения на e-mail
        //            //  и другое

        //            return new EmptyResult();
        //        }
        //    }
        //}


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
