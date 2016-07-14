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
            info.Add("station_id",Request["station_id"]);
            ordersService.AllOrders(info);
            
        }


        public void TracePackage()
        {
            
        }

      
        //新建订单 所有信息 
        public void CreateOrder()
        {
           
        }

        //修改订单信息
        public void EditOrder()
        {

        }
        
	}
}