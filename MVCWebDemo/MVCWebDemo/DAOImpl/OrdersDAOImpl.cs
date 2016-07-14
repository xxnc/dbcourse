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
    public class OrdersDAOImpl:OrdersDAO
    {
        public ISessionFactory factory { set; get; }
        public IList<Orders> getEntity(Dictionary<string, string> info)
        {
            ISession session = factory.OpenSession();
            var query = session.CreateSQLQuery("select * from orders where from_station = "+info["station_id"]+"or to_station = "+info["station_id"] );

            return query.List<Orders>();
        }

    }
}