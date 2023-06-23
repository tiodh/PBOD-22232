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
    public class ContextPengunjung
    {
        List<Models.Pengunjung> pengunjungList = new List<Models.Pengunjung>() { };

        public DataTable Read()
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

        public List<PengunjungWisata> Readata()
        {
            List<PengunjungWisata> pengunjungList = new List<PengunjungWisata>() { };
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "select * from pengunjung";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        PengunjungWisata pgnj = new PengunjungWisata();

                        pgnj.Id = (int)reader["id_pengunjung"];
                        pgnj.Name = (string)reader["nama_pengunjung"];
                        pgnj.Asal = (string)reader["asal_pengunjung"];

                        pengunjungList.Add(pgnj);
                    }
                }
            }
            return pengunjungList;
        }
    }
}
