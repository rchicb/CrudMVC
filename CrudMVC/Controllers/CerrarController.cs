using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVC.Controllers
{
    public class CerrarController : Controller
    {
        // GET: Cerrar
        public ActionResult Index()
        {
            Session["User"] = null;

            return RedirectToAction("Index","Login");
        }
    }
}