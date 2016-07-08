using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using MVCWebDemo.DAO;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using MVCWebDemo.Models;


namespace MVCWebDemo.DAOImpl
{
    public class InstructorDAOImpl:InstructorDAO
    {

        public ISessionFactory factory { set; get; } 
        public IList<Instructor> getEntity(string hsql)
        {
            ISession session = null;
            session = factory.OpenSession();
            //if (!SessionContext.HasBind(factory))
            //{
            //    session = factory.OpenSession();
            //    CurrentSessionContext.Bind(session);
            //}
            //else
            //{
            //    session = factory.GetCurrentSession();
            //    if (!session.IsConnected)
            //    {
            //        session.Reconnect();
            //    }
            //}
            IList<Instructor> list = session.CreateQuery(hsql).List<Instructor>();
            session.Disconnect();
            return list;
        }
        public Boolean updateEntity()
        {
            return false;
        }
        public Boolean deleteEntity()
        {
            return false;
        }
        public Boolean insertEntity()
        {
            return false;
        }
    }
}
