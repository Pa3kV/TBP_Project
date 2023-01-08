using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalaryCalculationApp
{
    public class Database
    {
        private string ConnectionString = "Host=localhost; Port=5433;Username=postgres;Password=1234;Database=TBP_database";
        private NpgsqlConnection Connection { get; set; }
        public void Connect()
        {
            Connection = new NpgsqlConnection(ConnectionString);
            Connection.Open();
        }
        public void Disconnect()
        {
            if (Connection.State != System.Data.ConnectionState.Closed)
            {
                Connection.Close();
            }
        }
        public NpgsqlDataReader ExecuteQuery(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            return cmd.ExecuteReader();
        }
        public void ExecuteNonQuery(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, Connection);
            cmd.ExecuteNonQuery();
        }
    }
}
