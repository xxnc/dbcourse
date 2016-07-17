using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Station
    {
        public virtual string station_id
        {
            get;
            set;
        }

        public virtual double capacity
        {
            get;
            set;
        }

        public virtual double remain_capacity
        {
            get;
            set;
        }

        public virtual string address
        {
            get;
            set;
        }
    }
}