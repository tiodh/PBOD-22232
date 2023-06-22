using System;
using frontendpbo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;

namespace frontendpbo.Contexts
{
    internal class ContextPengunjung
    {
        public static DataTable Read()
        {
            NpgsqlConnection connection = new NpgsqlConnection();

            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;";
            connection.ConnectionString = constr;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                string StrSql = "select * from Pengunjung";
                cmd.CommandText = StrSql;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return dt;
        }
    }
}
