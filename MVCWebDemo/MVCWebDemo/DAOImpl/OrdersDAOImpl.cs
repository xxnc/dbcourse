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
    public class OrdersDAOImpl : OrdersDAO
    {
        public ISessionFactory factory { set; get; }

        public Dictionary<string, object> getEntity(Dictionary<string, string> info)
        {
            ISession session = factory.OpenSession();
            Dictionary<string, object> result = new Dictionary<string, object>();

            string pageNow = info["pageNow"];

            string hsql = "select count(*) from orders";// where from_station = " + info["station_id"] + "or to_station = " + info["station_id"];
            int allPages = Decimal.ToInt32((decimal)session.CreateSQLQuery(hsql).UniqueResult());
            string order_state = info["order_state"];

            ///////////////////////////////////////////
            string flagstate;
            if (order_state == null)
            {
                flagstate = "";
            }
            else
            {
                flagstate = "where order_state ='" + order_state + "'";
            }
            ///////////////////////////////////////////

            hsql = "select * from (select t.*,rownum r from orders t "+ flagstate + ")where r > (" + pageNow + " - 1) * 10 and r<= (" + pageNow + ") * 10";
            var query = session.CreateSQLQuery(hsql);
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

        public bool createEntity(Dictionary<string, string> info) //未完成
        {
            
            //bool result = false;
            Orders orders = new Orders();

            orders.order_id = (string)info["order_id"];
            orders.from_name = (string)info["from_name"];
            orders.from_phone = (string)info["from_phone"];

            orders.to_name = (string)info["to_name"];
            orders.to_phone = (string)info["to_phone"];

            orders.weight = float.Parse((string)info["weight"]);

            ISession session = factory.OpenSession();

            session.Save(orders);
            session.Flush();
            session.Close();

            //string hsql = "insert into orders (order_id,from_name,from_phone,to_name,to_phone,weight,pay_mode) values("
            //    + info["order_id"] + "," + info["from_name"] + "," + info["from_phone"] + ","
            //    + info["to_name"] + "," + info["to_phone"] + "," + info["weight"] + "," + info["pay_mode"] + ")";
            //var query = session.CreateSQLQuery(hsql);

            return true;
        }
    }
}