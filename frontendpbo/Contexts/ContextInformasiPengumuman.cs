using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextInformasiPengumuman
    {
        public List<Pengumuman> ListInformasiPengumuman = new List<Pengumuman>() { };

        public void Read()
        {
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM informasi_pengumuman";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    ListInformasiPengumuman.Clear();
                    while (reader.Read())
                    {
                        Pengumuman pengumuman = new Pengumuman();
                        pengumuman.Id = (int)reader["id_wisata"];
                        pengumuman.Name = (string)reader["nama_informasi"];
                        pengumuman.Description = (string)reader["deskripsi_informasi"];
                        pengumuman.Tanggal_Informasi = (DateTime)reader["tanggal_informasi"];
                        //pengumuman.Id = (int)reader["wisata_id"];
                        ListInformasiPengumuman.Add(pengumuman);
                    }
                }

            }
        }
    }
}
