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
            Configuration cfg = new Configuration();
            cfg.SetProperty("dialect", "NHibernate.Dialect.Oracle10gDialect");
            cfg.SetProperty("connection.driver_class", "NHibernate.Driver.OracleManagedDataClientDriver");
            cfg.SetProperty("connection.connection_string", "User Id=equipe15;Password=7fUXztFc;Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=big-data-3.logti.etsmtl.ca)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=Log660)))");
            cfg.AddAssembly("WebFlix");
            sessionFactory = cfg.BuildSessionFactory();

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