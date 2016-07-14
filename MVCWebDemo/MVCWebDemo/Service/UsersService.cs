using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
namespace MVCWebDemo.Service
{
    public interface UsersService
    {
        Boolean conflict(Dictionary<string, string> info);

        Boolean register(Dictionary<string, string> info);

        string login(Dictionary<string, string> info);
    }
}