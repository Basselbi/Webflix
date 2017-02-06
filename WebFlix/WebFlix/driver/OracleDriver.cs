using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;

using NHibernate.Driver;
using Oracle.ManagedDataAccess.Client;

namespace WebFlix.driver
{
    public class OracleDriver : DriverBase
    {
        public override IDbCommand CreateCommand()
        {
            return new OracleCommand();
        }
        public override IDbConnection CreateConnection()
        {
            return new OracleConnection();
        }
        public override string NamedPrefix
        {
            get { return string.Empty; }
        }
        public override bool UseNamedPrefixInParameter
        {
            get { return false; }
        }
        public override bool UseNamedPrefixInSql
        {
            get { return false; }
        }
    }
}
