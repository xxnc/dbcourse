using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using MVCWebDemo.Models;
using NHibernate;

namespace MVCWebDemo.DAO
{
    public interface InstructorDAO
    {
        IList<Instructor> getEntity(string hsql);
        Boolean updateEntity();
        Boolean deleteEntity();
        Boolean insertEntity();

    }
}
