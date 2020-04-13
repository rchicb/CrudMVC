using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudMVC.Models.ViewModels;
using CrudMVC.Models;

namespace CrudMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    return View("Index",model);
                }
                using (var db = new crudDBEntities())
                {
                    var existUser = from d in db.User
                                    where d.email == model.Email && d.password == model.Password
                                    select d;

                    if (existUser.Count() > 0)
                    {
                        User oUser = existUser.First();
                        Session["User"] = oUser;
                        return Redirect( Url.Content("~/Home/Index"));
                    }
                    else
                    {

                        model.LoginMessageError = "Credenciales incorrectas";
                        return View("Index", model);
                    }

                }
            }
            catch (Exception w)
            {
                return Content("Encontramos error en = " + w.Message);
            }
        }
    }
}