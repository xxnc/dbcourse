using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Deliver
    {
        public virtual string order_id
        {
            get;
            set;
        }

        public virtual DateTime start_time
        {
            get;
            set;
        }

        public virtual string delivery_state
        {
            get;
            set;
        }

        public virtual string employee_id
        {
            get;
            set;
        }

        public virtual DateTime sign_time
        {
            get;
            set;
        }
    }
}