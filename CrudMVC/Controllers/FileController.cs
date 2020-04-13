using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudMVC.Models.ViewModels;

namespace CrudMVC.Controllers
{
    public class FileController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
            if (TempData["Message"]!=null)
            {
                ViewBag.Message = TempData["Message"].ToString();
            }

            return View();
        }

        [HttpPost]
        public ActionResult SaveFiles(FileViewModel model)
        {

            string rootPath=Server.MapPath("~/");

            string pathFile1 = Path.Combine(rootPath + "/Files/archivo1.png");
            string pathFile2 = Path.Combine(rootPath + "/Files/archivo2.png");

            if (!ModelState.IsValid)
            {
                return View("Index",model);
            }
            model.Archivo1.SaveAs(pathFile1);
            model.Archivo2.SaveAs(pathFile2);

            TempData["Message"] = "Se cargaron los archivos exitosamente";
            return RedirectToAction("Index");
        }
    }
}