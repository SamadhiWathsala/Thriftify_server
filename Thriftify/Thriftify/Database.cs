using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thriftify
{
    internal class Database
    {
        protected SqlConnection Connection;

        public Database()
        {
            string connectionString = $"Server={DatabaseConfig.ServerName};Database={DatabaseConfig.Database};Integrated Security=true;";
            Connection = new SqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                Connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public void CloseConnection()
        {
            Connection.Close();
        }
    }
}
