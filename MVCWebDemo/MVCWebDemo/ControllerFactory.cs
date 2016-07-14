using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Mvc;
using Spring.Web;
using Spring.Web.Mvc;
using Spring.Context;
using Spring.Context.Support;
namespace MVCWebDemo
{
    public class ControllerFactory : DefaultControllerFactory
    {
        

        private static DefaultControllerFactory defaultControllerFactory = null;


        #region IControllerFactory 成员

        public override IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (requestContext == null)
            {
                throw new ArgumentNullException("requestContext");
            }
            if (String.IsNullOrEmpty(controllerName))
            {
                throw new ArgumentException("controllerName");
            }

            IApplicationContext ctx = ContextRegistry.GetContext();
            if (ctx.ContainsObject(controllerName))
            {
                return ctx.GetObject(controllerName) as IController;
            }
            else
            {
                if (defaultControllerFactory == null)
                {
                    defaultControllerFactory = new DefaultControllerFactory();
                }
                return defaultControllerFactory.CreateController(requestContext, controllerName);
            }
        }

        public override void ReleaseController(IController controller)
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            if (!ctx.ContainsObject(controller.GetType().Name.Replace("Controller", "")))
            {
                if (defaultControllerFactory == null)
                {
                    defaultControllerFactory = new DefaultControllerFactory();
                }
                defaultControllerFactory.ReleaseController(controller);
            }
        }

        #endregion
    }
}