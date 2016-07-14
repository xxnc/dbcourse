using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebDemo.Models;

namespace MVCWebDemo.DAO
{
    public interface OrdersDAO
    {
        IList<Orders> getEntity(Dictionary<string, string> info);

    }


}