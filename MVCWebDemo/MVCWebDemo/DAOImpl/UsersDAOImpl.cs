



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCWebDemo.Models;
using MVCWebDemo.DAO;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using System.Collections;

namespace MVCWebDemo.DAOImpl
{
    public class UsersDAOImpl:UsersDAO
    {
        public ISessionFactory factory { set; get; }
        public IList<Users> getEntity(Dictionary<string, string> info)
        {
            string hsql = "from Users as u where ";
            ArrayList keys = new ArrayList();
            for (int i = 0; i < info.Count; i++)
            {
                string key=info.Keys.ElementAt(i);
                keys.Add(key);
                if (i < info.Count()-1)
                {
                    hsql += "u." + key + "=:" + key +" and ";
                }
                else
                {
                    hsql += "u." + key + "=:" + key;
                }
                
            }
            ISession session = factory.OpenSession();
            var query=session.CreateQuery(hsql);
            for (int i = 0; i < keys.Count; i++)
            {
                query.SetString((string)keys[i],(string)info[(string)keys[i]]);
            }
            return query.List<Users>();
        }

        public Boolean updateEntity() 
        {
            return false;
        }
        public Boolean deleteEntity() 
        {
            return false;
        }
        public Boolean insertEntity(Dictionary<string, string> info)
        {
            Users users = new Users();
            users.name=(string)info["name"];
            users.pwd=(string)info["pwd"];
            users.phone=(string)info["phone"];
            users.role=int.Parse((string)info["role"]);
            ISession session = factory.OpenSession();
            session.Save(users);
            session.Flush();
            session.Close();
            return true;
        }

    }
}