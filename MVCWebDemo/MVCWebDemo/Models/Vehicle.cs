using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Vehicle
    {
        public virtual string vehicle_id
        {
            get;
            set;
        }

        public virtual string plate_number
        {
            get;
            set;
        }

        public virtual string type_id
        {
            get;
            set;
        }

        public virtual string vehicle_state
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