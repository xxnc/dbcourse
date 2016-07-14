using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebDemo.Service;
using MVCWebDemo.DAO;
using System.Collections;
using MVCWebDemo.Models;
namespace MVCWebDemo.ServiceImpl
{
    public class UsersServiceImpl:UsersService
    {
        public UsersDAO usersDAO { set; get; }

        public Boolean conflict(Dictionary<string, string> info)
        {
            if (usersDAO.getEntity(info).Count == 0)
            {
                return false;
            }
            return true;
        }

        public Boolean register(Dictionary<string, string> info)
        {
            return usersDAO.insertEntity(info);
        }

        public string login(Dictionary<string, string> info)
        {
            IList<Users> result=usersDAO.getEntity(info);
            if (result.Count == 0)
            {
                return null;
            }
            return result[0].station_id;
        }
    }
}