using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http.Controllers;
//using System.Web.Http.Filters;

namespace MVCWebDemo.Filter
{
    public class LoginFilterAttribute : AuthorizeAttribute
    {
        
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext == null)
            {
                throw new ArgumentNullException("HttpContext");
            }
            return false;
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            var controllerName = filterContext.RouteData.Values["controller"].ToString();
            var actionName = filterContext.RouteData.Values["action"].ToString();
            if (filterContext.HttpContext.Session["station_id"] == null)// && controllerName != "Home" && actionName != "Validate" && actionName != "CreateCodeImg" && actionName != "Login")
            {
                filterContext.HttpContext.Response.Redirect("/Home/");
            }
        }  

      
    }
}