using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace BDDR_DM1
{
    public static class DBManager
    {
        public static OracleConnection Connection;
        public static string User;
        public static string Password;
        public const string DataSource = "Data Source=localhost:1521/XE";

        public static void SetConnection(string user, string password)
        {
            User = user;
            Password = password;
            string connectionString = "User Id=" + User + ";" + "Password=" + Password + ";" + DataSource;
            Connection = new OracleConnection(connectionString);
            Connection.Open();
            Connection.Close();
        }

        public static DataTable Select(string sqlStatement)
        {
            try
            {
                Connection.Open();
                OracleCommand cmd = Connection.CreateCommand();
                cmd.BindByName = true;
                cmd.CommandText = sqlStatement;
                DataTable table = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter { SelectCommand = cmd };
                adapter.Fill(table);
                Connection.Close();
                return table;
            }
            catch (Exception e)
            {
                Connection.Close();
                throw e;
            }
        }

        public static DataTable SelectAll(string table)
        {
            string sql = "select * from " + table + ";";
            return Select(sql);
        }

        public static void Insert(string sqlStatement)
        {
            try
            {
                Connection.Open();
                OracleCommand cmd = Connection.CreateCommand();
                cmd.CommandText = sqlStatement;
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
            catch (Exception e)
            {
                Connection.Close();
                throw e;
            }
        }
    }
}
