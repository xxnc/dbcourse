using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Orders
    {
        public virtual string order_id
        {
            get;
            set;
        }

        public virtual string from_name
        {
            get;
            set;
        }

        public virtual int from_address
        {
            get;
            set;
        }

        public virtual string from_phone
        {
            get;
            set;
        }

        public virtual string from_zip
        {
            get;
            set;
        }

        public virtual string to_name
        {
            get;
            set;
        }

        public virtual int to_address
        {
            get;
            set;
        }

        public virtual string to_phone
        {
            get;
            set;
        }

        public virtual string to_zip
        {
            get;
            set;
        }

        public virtual float cost
        {
            get;
            set;
        }

        public virtual float weight
        {
            get;
            set;
        }

        public virtual string pay_mode
        {
            get;
            set;
        }

        public virtual string order_state
        {
            get;
            set;
        }
        //DateTime Date类型 数据结构待定
        public virtual DateTime create_time
        {
            get;
            set;
        }

        public virtual DateTime edit_time
        {
            get;
            set;
        }
    }
}