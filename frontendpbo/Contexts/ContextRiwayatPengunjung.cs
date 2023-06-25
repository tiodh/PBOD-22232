using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    public class ContextRiwayatPengunjung
    {
        public List<PengunjungWisata> Read()
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
