using System.Web;
using System.Web.Mvc;
using MVCWebDemo.Filter;
namespace MVCWebDemo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new LoginFilterAttribute());
        }
    }
}
