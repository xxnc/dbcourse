using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebDemo.Service;
using MVCWebDemo.DAO;
using System.Collections;
using MVCWebDemo.Models;

namespace MVCWebDemo.ServiceImpl
{
    public class OrdersServiceImpl:OrdersService
    {
        public OrdersDAO ordersDAO { set; get; }

        public Dictionary<string, object> allOrders(Dictionary<string, string> info)
        {
            return ordersDAO.getEntity(info);
        }

        
    }
}