using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Spring.Web;
using Spring.Web.Mvc;
using Spring.Data.NHibernate;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using NHibernate.Engine;
namespace MVCWebDemo
{
    public class SessionContext : CurrentSessionContext
    {
        private readonly ISessionFactoryImplementor sessionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpringSessionContext"/> class
        /// </summary>
        /// <param name="sessionFactory">The NHibernate session factory.</param>
        public SessionContext(ISessionFactoryImplementor sessionFactory)
        {
            this.sessionFactory = sessionFactory;
        }

        #region ICurrentSessionContext Members

        /// <summary>
        /// Retrieve the Spring-managed Session for the current thread.
        /// </summary>
        /// <returns>Current session associated with the thread</returns>
        /// <exception cref="HibernateException">On errors retrieving thread bound session.</exception>
        public override ISession CurrentSession()
        {
            try
            {
                return SessionFactoryUtils.DoGetSession(sessionFactory, false);
            }
            catch (InvalidOperationException ex)
            {
                throw new HibernateException(ex.Message);
            }
        }

        #endregion

        protected override ISession Session
        {
            get
            {
                return CurrentSession();
            }
            set
            {
               //a way to set the session
            }
        }
    }
}