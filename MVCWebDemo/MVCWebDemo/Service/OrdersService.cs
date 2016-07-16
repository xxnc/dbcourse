using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using MVCWebDemo.Models;
using MVCWebDemo.DAO;

namespace MVCWebDemo.Service
{
    public interface OrdersService
    {
        Dictionary<string, object> AllOrders(Dictionary<string, string> info);
    }
}