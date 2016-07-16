using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCWebDemo.Models;
using MVCWebDemo.Service;
using System.Collections;
using MVCWebDemo.Filter;
namespace MVCWebDemo.Controllers
{
    [LoginFilter]
    public class OrderController : Controller
    {

        public OrdersService ordersService { get; set; }
        //
        // GET: /Order/
        public ActionResult Index()
        {
            return View();
        }


        public void QueryOrder()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            info.Add("station_id",Session["station_id"].ToString());
            info.Add("page_id", Request["page_id"]);//默认一页十行

            Dictionary<string,object> result=ordersService.AllOrders(info);
            IList<Orders> orderInfo = (IList<Orders>)result["orderInfo"];
            int pageNum = (int)result["pageNum"];
            JsonResult json = Json(result, JsonRequestBehavior.AllowGet);
            Response.Write(json);
        }


        public void TracePackage()
        {
            
        }

      
        //新建订单 所有信息 
        public void CreateNewOrder()
        {
            Dictionary<string, string> info = new Dictionary<string, string>();
            info.Add("order_id", Request["order_id"]);
            info.Add("from_name", Request["from_name"]);
            info.Add("from_phone", Request["from_phone"]);
            /*Address*/
            info.Add("to_name", Request["to_name"]);
            info.Add("to_phone", Request["to_phone"]);

            info.Add("weight", Request["weight"]);
            info.Add("pay_mode", Request["pay_mode"]);




        }

        //修改订单信息
        public void EditOrder()
        {

        }
        
	}
}