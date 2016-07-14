using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebDemo.Models;
using System.Collections;

namespace MVCWebDemo.DAO
{
    public interface UsersDAO
    {
        IList<Users> getEntity(Dictionary<string,string> info);
        Boolean updateEntity();
        Boolean deleteEntity();
        Boolean insertEntity(Dictionary<string, string> info);
    }
}