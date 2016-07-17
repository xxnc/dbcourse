using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Vehicle_Type
    {
        public virtual string type_id
        {
            get;
            set;
        }

        public virtual double capacity
        {
            get;
            set;
        }
    }
}