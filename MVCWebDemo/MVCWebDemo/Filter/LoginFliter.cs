using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http.Controllers;
//using System.Web.Http.Filters;

namespace MVCWebDemo.Filter
{
    public class LoginFilter : ActionFilterAttribute
    {
        #region 属性

        /// <summary>
        /// 数据权限编码
        /// </summary>
        public string Code
        { get; set; }

        #endregion

        //public override void OnActionExecuting(HttpActionContext actionContext)
        //{
        //    actionContext.
        //    UserInfo service = new UserInfo();

        //    try
        //    {
        //        if (!service.IsInPermission(Code))
        //        {
        //            actionContext.Response = new HttpResponseMessage(HttpStatusCode.Forbidden);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        SmartCardCommon.LogHelper.WriteErrorLog(ex.Message, ex);
        //        throw ex;
        //    }
        //    finally
        //    {
        //        SmartCardCommon.NhibernaterSessionHelper.CloseSession();
        //    }
        //}
    }
}