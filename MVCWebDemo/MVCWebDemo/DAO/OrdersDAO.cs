using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebDemo.Models;

namespace MVCWebDemo.DAO
{
    public interface OrdersDAO
    {
        Dictionary<string, object> getEntity(Dictionary<string, string> info);

        bool createEntity(Dictionary<string, string> info);
    }


}