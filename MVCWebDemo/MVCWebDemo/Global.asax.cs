using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Spring.Web;
using Spring.Web.Mvc;


namespace MVCWebDemo
{
    public class MvcApplication : SpringMvcApplication
    {
        protected void Application_Start()
        {
            ControllerBuilder.Current.SetControllerFactory(typeof(ControllerFactory));
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
