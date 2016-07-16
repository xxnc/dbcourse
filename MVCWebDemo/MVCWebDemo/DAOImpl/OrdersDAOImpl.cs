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

        public Dictionary<string,object> getEntity(Dictionary<string, string> info)
        {
            ISession session = factory.OpenSession();
            Dictionary<string, object> result = new Dictionary<string, object>();
            string pageNow = info["pageNow"];

            string hsql = "select count(*) from orders";// where from_station = " + info["station_id"] + "or to_station = " + info["station_id"];
            int allPages = Decimal.ToInt32((decimal)session.CreateSQLQuery(hsql).UniqueResult());
            hsql = "select * from (select t.*,rownum r from orders t)where r > ("+ pageNow +" - 1) * 10 and r<= ("+pageNow+") * 10";
            var query = session.CreateSQLQuery(hsql );
            int pageNum = 0;
            if (allPages % 10 != 0)
            {
                pageNum = allPages / 10 + 1;
            }
            else
            {
                pageNum = allPages / 10;
            }
            result.Add("pageNum", pageNum);
            result.Add("orderInfo", query.List<object>());
            return result;
        }

    }
}