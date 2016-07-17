using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class After_Sale
    {
        public virtual string order_id
        {
            get;
            set;
        }

        public virtual string after_sale_state
        {
            get;
            set;
        }

        public virtual string note
        {
            get;
            set;
        }
    }
}