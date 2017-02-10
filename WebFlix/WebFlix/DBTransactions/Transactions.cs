using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace WebFlix.DBTransactions
{
    class Transactions
    {
        private string connectionString =
            System.Configuration.ConfigurationManager.ConnectionStrings["WebFlix.Properties.Settings.ConnectionString"]
                .ToString();

        private OracleCommand cmd;
        private OracleConnection con;


        public List<DataRow> selectFilmPays(string paysFilm)
        {

            // string titre = titreBox.Text.ToString().ToUpper();

            con = new OracleConnection();
            con.ConnectionString = connectionString;
            cmd = new OracleCommand("RecherchePayPays", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //ASSIGN PARAMETERS TO BE PASSED
            cmd.Parameters.Add("PARAM1", OracleDbType.Varchar2).Value = paysFilm;
            cmd.Parameters.Add("PARAM2", OracleDbType.RefCursor, ParameterDirection.Output);

            //CALL PROCEDURE
            con.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            var resultat = cmd.ExecuteReader();
            //   cmd.setParameter(1, "Action");
            //  List<string> count = (List<string>) cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(resultat);
            List<DataRow> dr = dt.AsEnumerable().ToList();
            return dr;
        }

        public List<DataRow> CONNEXIONCLIENT(string username, string password)
        {

            con = new OracleConnection();
            con.ConnectionString = connectionString;
            cmd = new OracleCommand("CONNEXIONCLIENT", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //ASSIGN PARAMETERS TO BE PASSED
            cmd.Parameters.Add("PARAM1", OracleDbType.Varchar2).Value = username;
            cmd.Parameters.Add("PARAM2", OracleDbType.Varchar2).Value = password;
            cmd.Parameters.Add("PARAM3", OracleDbType.RefCursor, ParameterDirection.Output);

            //CALL PROCEDURE
            con.Open();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            var resultat = cmd.ExecuteReader();
            //   cmd.setParameter(1, "Action");
            //  List<string> count = (List<string>) cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(resultat);
            List<DataRow> dr = dt.AsEnumerable().ToList();
            return dr;
        }

    }


}
