using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Location
    {
       public virtual LocationPK location_pk
        {
            get;
            set;
        }

        public virtual DateTime arrive_time
        {
            get;
            set;
        }

        public virtual DateTime start_time
        {
            get;
            set;
        }

        public virtual string schedule_id
        {
            get;
            set;
        }
    }
}