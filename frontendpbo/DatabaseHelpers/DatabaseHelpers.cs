using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace frontendpbo.Helpers
{
    internal class DatabaseHelpers
    {
        string connString = "Host=localhost;Username=postgres;Password=1234;Database=peta_jember";
        NpgsqlConnection conn;

        public void connect()
        {
            if (conn == null)
            {
                conn = new NpgsqlConnection(connString);
            }
            conn.Open();
        }

        public DataTable getData(string sql)
        {
            DataTable table = new DataTable();
            connect();
            try
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, conn);
                adapter.Fill(table);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            return table;
        }

        public String getValue(String sql, String col)
        {
            String value = "";
            connect();
            try
            {
                NpgsqlCommand command = new NpgsqlCommand(sql, conn);
                NpgsqlDataReader reader = command.ExecuteReader();
                reader.Read();
                value = (string)reader.GetValue(reader.GetOrdinal(col)).ToString();
                reader.Close();
                command.Dispose();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return value;
        }

        public void exc(String sql)
        {
            connect();
            try
            {
                NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
