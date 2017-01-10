using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public class clsKetNoi
    {
        protected static string _connectionString;

        protected SqlConnection connection = new SqlConnection();
        protected SqlCommand command = new SqlCommand();
        protected SqlDataAdapter adapter = new SqlDataAdapter();

        public clsKetNoi()
        {
            //string databasePath = Directory.GetCurrentDirectory();
            connection.ConnectionString = @"Data Source=(local);Initial Catalog=STORE_PROD;User ID=sa;Password=sa123;";
            //connection.ConnectionString = "Data Source=(local);Initial Catalog=QUANLYHOCSINH;Integrated Security=True";
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public DataTable LoadData(string sql)
        {
            command = new SqlCommand(sql, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public int Update(string sql, string[] name, object[] value, int nparameter)
        {
            command = new SqlCommand(sql, connection);
            for (int i = 0; i < nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            return command.ExecuteNonQuery();
        }

        public int UpdateST(string storeprocedure, string[] name, object[] value, int nparameter)
        {
            command = new SqlCommand(storeprocedure, connection);
            command.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < nparameter; i++)
            {
                command.Parameters.AddWithValue(name[i], value[i]);
            }
            return command.ExecuteNonQuery();
        }

        public IDataReader executeQuery(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);
            return command.ExecuteReader();
        }

        public void executeNonQuery(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);
            command.ExecuteNonQuery();
        }

        public object executeScalar(string sqlString)
        {
            command = new SqlCommand(sqlString, connection);
            return command.ExecuteScalar();
        }

        public void closeConnect()
        {
            connection.Close();
        }
    }
}
