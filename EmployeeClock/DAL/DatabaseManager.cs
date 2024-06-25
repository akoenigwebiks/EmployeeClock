using System.Data.SqlClient;
using System.Data;

namespace EmployeeClock.DAL
{
    public class DatabaseManager
    {
        private SqlConnection connection;

        public DatabaseManager(string connectionString)
        {
            // Connection string example
            connection = new SqlConnection(connectionString);
        }

        public void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
                connection.Close();
        }

        public DataTable ExecuteQuery(string query)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            CloseConnection();
            return data;
        }

        public int ExecuteNonQuery(string query)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand(query, connection);
            int result = command.ExecuteNonQuery();
            CloseConnection();
            return result;
        }
    }
}
