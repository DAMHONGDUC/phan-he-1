using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace PH1
{
    public class Functions
    {
        protected static OracleConnection _conn = null;

        //Data Source = IP:Port/Database name (SID)
        //UserID = username
        //Password = password
        public static void InitConnection(String username, String password, String dbName)
        {
            String connectionString = $"Data Source=localhost:1521/{dbName};Persist Security Info=True;User ID = {username}; Password={password}";

            OracleConnection connection = null;
            try
            {
                connection = new OracleConnection(connectionString);
                _conn = connection;
                _conn.Open();
                _conn.Close();
                dbaUsername = username;
            }
            catch (OracleException ex)
            {
                _conn = null;
                throw new Exception(ex.Message);
            }

        }


        protected static String dbaUsername;

        public String DBAUsername
        {
            get { return dbaUsername.ToUpper(); }
            set { dbaUsername = value; }
        }
    }
}
