using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class TariffPK
    {
        public virtual string from_station
        {
            get;
            set;
        }

        public virtual string to_station
        {
            get;
            set;
        }

        public override bool Equals(object obj)
        {
            var entity = obj as TariffPK;
            if (entity == null)
            {
                return false;
            }
            return entity.from_station==this.from_station && entity.to_station==this.to_station;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}