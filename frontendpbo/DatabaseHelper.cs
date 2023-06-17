using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo
{
    internal class DatabaseHelper
    {
        string ConnectionString = $"Host=localhost;Port=5432;Username=postgres;Password=1234;Database=Tiketing;";
        NpgsqlConnection conn = null;

        public DatabaseHelper()
        { 
            conn = new NpgsqlConnection(ConnectionString);
        }

        public void Execute(string Query)
        {

            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(Query, conn);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        public NpgsqlDataReader Select(string Query)
        {
            try
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand(Query, conn);
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}