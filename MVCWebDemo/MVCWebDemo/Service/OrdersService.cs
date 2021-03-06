﻿using System;
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
        Dictionary<string, object> allOrders(Dictionary<string, string> info);

        bool createOrders(Dictionary<string, string> info);
    }
}