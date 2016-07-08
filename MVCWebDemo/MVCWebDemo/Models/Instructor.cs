using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MVCWebDemo.Models
{
    [Serializable]
    public class Instructor
    {
        public virtual string id
        {
            get;
            set;
        }

        public virtual string name
        {
            get;
            set;
        }

        public virtual string dept_name
        {
            get;
            set;
        }

        public virtual double salary
        {
            get;
            set;
        }

    }
}
