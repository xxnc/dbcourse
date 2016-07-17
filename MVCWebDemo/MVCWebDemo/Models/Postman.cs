using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Postman
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

        public virtual string phone
        {
            get;
            set;
        }

        public virtual string station_id
        {
            get;
            set;
        }

        public virtual string zip
        {
            get;
            set;
        }
    }
}