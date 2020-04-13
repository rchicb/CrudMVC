using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudMVC.Models;
using CrudMVC.Controllers;

namespace CrudMVC.Filters
{
    public class VerifySession : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var oUser = (User)HttpContext.Current.Session["User"];

            if (oUser != null)
            {
                if (filterContext.Controller is LoginController  == true)
                {
                    filterContext.HttpContext.Response.Redirect("~/Home/Index");
                }
            }
            else
            {
                if (filterContext.Controller is LoginController == false)
                {
                    filterContext.HttpContext.Response.Redirect("~/Login/Index");
                }

            }
         

        base.OnActionExecuting(filterContext);
        }
    }
}