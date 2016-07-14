using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Users
    {
        public virtual string name
        {
            get;
            set;
        }

        public virtual string pwd
        {
            get;
            set;
        }

        public virtual string phone
        {
            get;
            set;
        }

        public virtual int role
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