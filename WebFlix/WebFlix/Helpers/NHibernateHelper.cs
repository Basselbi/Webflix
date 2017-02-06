using System.Reflection;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace WebFlix.Helpers
{
    /*
     * Inspiré de
     * http://nhibernate.info/doc/nhibernate-reference/quickstart.html#quickstart-persistentclass
     */
    public sealed class NHibernateHelper
    {
        private static readonly ISessionFactory sessionFactory;
        private static ISession currentSession;

        static NHibernateHelper()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["WebFlix.Properties.Settings.ConnectionString"].ToString();
          //  Configuration cfg = new Configuration();
            NHibernate.Cfg.Configuration nHibernateConfiguration =
                                               new NHibernate.Cfg.Configuration();
            var configuration = nHibernateConfiguration;
            nHibernateConfiguration.SetProperty(
                NHibernate.Cfg.Environment.ProxyFactoryFactoryClass,
             typeof(NHibernate.ByteCode.Castle.ProxyFactoryFactory).AssemblyQualifiedName);
            nHibernateConfiguration.SetProperty(
                  NHibernate.Cfg.Environment.Dialect,
                typeof(NHibernate.Dialect.Oracle12cDialect).AssemblyQualifiedName);
            nHibernateConfiguration.SetProperty(
              NHibernate.Cfg.Environment.ConnectionString, connectionString);
            nHibernateConfiguration.SetProperty(
              NHibernate.Cfg.Environment.FormatSql, "true");
            nHibernateConfiguration.AddAssembly(Assembly.GetCallingAssembly());

            //            cfg.SetProperty("dialect", "NHibernate.Dialect.Oracle10gDialect");
            //            cfg.SetProperty("connection.driver_class", "NHibernate.Driver.OracleManagedDataClientDriver");
            //            cfg.SetProperty("connection.connection_string", connectionString);
            //            cfg.AddAssembly("WebFlix");
            // sessionFactory = cfg.BuildSessionFactory();
            sessionFactory = nHibernateConfiguration .BuildSessionFactory();
            currentSession = null;
        }

        public static ISession GetCurrentSession()
        {
            if (currentSession == null)
            {
                currentSession = sessionFactory.OpenSession();
            }

            return currentSession;
        }

        public static void CloseSession()
        {
            if (currentSession == null)
            {
                // No current session
                return;
            }

            currentSession.Close();
        }

        public static void CloseSessionFactory()
        {
            if (sessionFactory != null)
            {
                sessionFactory.Close();
            }
        }
    }
}