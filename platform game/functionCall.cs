using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace platform_game
{
    internal class functionCall
    {
        private string connectionString = "Data Source=DESKTOP-GTCAF1U\\SQLEXPRESS;Initial Catalog=Registration;Integrated Security=True";

        public SqlConnection GetSqlConnection()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }

        public void CloseSqlConnection(SqlConnection sqlConnection)
        {
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }
    }
}
