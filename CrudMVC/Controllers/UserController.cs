using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudMVC.Models.ViewModels;
using CrudMVC.Models.TableViewModels;
using CrudMVC.Models;
using System.Data.Entity;

namespace CrudMVC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            using (var db=new crudDBEntities())
            {
                List<UserTableViewModel> lst = (from d in db.User
                                                where d.idState == 1
                                                select new UserTableViewModel
                                                {
                                                    Id = d.IdUser,
                                                    Name = d.name,
                                                    Edad = d.edad,
                                                    Email = d.email
                                                }).ToList();
                return View(lst);
            }
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db=new crudDBEntities()) {

                var oExistUser = from d in db.User
                                  where d.email == model.Email
                                  select d;

                if (oExistUser.FirstOrDefault()!=null)
                {
                    model.UserMessageError = "El Email ya se encuentra utilizado";
                    return View(model);
                }


                User oUser = new User();
                oUser.name = model.Name;
                oUser.email = model.Email;
                oUser.edad = model.Edad;
                oUser.password = model.Password;
                oUser.idState = 1;

                db.User.Add(oUser);
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/User/Index"));
        }

        public ActionResult Editar(int Id)
        {
            using (var db=new crudDBEntities())
            {
                User oUser = db.User.Find(Id);

                var model = new EditUserViewModel();
                model.Name = oUser.name;
                model.Email = oUser.email;
                model.Edad = oUser.edad;
                model.Id = oUser.IdUser;

                return View(model);
            }

                
        }


        [HttpPost]
        public ActionResult Editar(EditUserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            using (var db = new crudDBEntities())
            {

                User oUser = db.User.Find(model.Id);

                oUser.name = model.Name;
                oUser.email = model.Email;
                oUser.edad = model.Edad;

                if (model.Password!=null && model.Password.Trim()!="")
                {
                    oUser.password = model.Password;
                }


                db.Entry(oUser).State = EntityState.Modified;
                db.SaveChanges();
            }
            return Redirect(Url.Content("~/User/Index"));
        }

        public ActionResult Eliminar(int Id)
        {
            using (var db=new crudDBEntities())
            {
                User oUser = db.User.Find(Id);
                oUser.idState = 3;
                db.Entry(oUser).State = EntityState.Modified;
                db.SaveChanges();
            }
                return Redirect(Url.Content("~/User/Index"));
        }


        public ActionResult Eliminar2(int Id)
        {
            using (var db = new crudDBEntities())
            {
                User oUser = db.User.Find(Id);
                oUser.idState = 3;
                db.Entry(oUser).State = EntityState.Modified;
                db.SaveChanges();
            }
            return Content("1");
        }

    }
}