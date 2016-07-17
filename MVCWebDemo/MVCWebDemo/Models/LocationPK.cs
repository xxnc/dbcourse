using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebDemo.Models
{
    public class LocationPK
    {
        public virtual string order_id
        {
            get;
            set;
        }

        public virtual string arrive_station
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
            var entity = obj as LocationPK;
            if (entity == null)
            {
                return false;
            }
            return entity.arrive_station == this.arrive_station && entity.to_station == this.to_station && entity.order_id==this.order_id;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}