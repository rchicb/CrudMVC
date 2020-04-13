using System.Web;
using System.Web.Mvc;
using CrudMVC.Filters;

namespace CrudMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new VerifySession());
        }
    }
}
