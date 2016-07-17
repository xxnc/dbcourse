using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Warehouse_Info
    {
        public virtual string station_id
        {
            get;
            set;
        }

        public virtual string order_id
        {
            get;
            set;
        }

        public virtual string warehouse_state
        {
            get;
            set;
        }
    }
}