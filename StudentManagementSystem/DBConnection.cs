using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    class DBConnection
    {        
        SqlConnection connection = new SqlConnection("Data Source=***;Initial Catalog=***;user=admin;password=admin;TrustServerCertificate=True");


        public SqlConnection getConnection
        {
            get
            {
                return connection;
            }
        }

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public SqlCommand GetSqlCommand(string query)
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                return new SqlCommand(query, getConnection);
            }
            else
            {
                return null;
            }
        }
    }
}
