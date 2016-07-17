using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Driver
    {
        public virtual string employee_id
        {
            get;
            set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual int phone
        {
            get;
            set;
        }

        public virtual string station_id
        {
            get;
            set;
        }
    }
}