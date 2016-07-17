using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class Tariff
    {
        public virtual TariffPK tariff_pk
        {
            get;
            set;
        }

        public virtual string first_heavy
        {
            get;
            set;
        }

        public virtual string forwarding_heavy
        {
            get;
            set;
        }
    }
}