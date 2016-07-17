using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Domain
    {
        public virtual string zip
        {
            get;
            set;
        }

        public virtual string station_id
        {
            get;
            set;
        }

        public virtual string domain_name
        {
            get;
            set;
        }
    }
}