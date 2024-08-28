using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SuperMarket
{
    internal class Class1
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1901TR8\SPARTA;Initial Catalog=SuperMarketttt;Integrated Security=True");

        public SqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
