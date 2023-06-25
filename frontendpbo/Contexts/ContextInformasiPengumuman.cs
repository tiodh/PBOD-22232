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

        public void Read(int id_w)
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
                        Models.Pengumuman pengumuman = new Models.Pengumuman();
                        pengumuman.id_wisata = (int)reader["id_informasi"];
                        pengumuman.nama_informasi = (string)reader["nama_informasi"];
                        pengumuman.deskripsi_informasi = (string)reader["deskripsi_informasi"];
                        pengumuman.tanggal_informasi = (DateTime)reader["tanggal_informasi"];
                        ListInformasiPengumuman.Add(pengumuman);
                    }
                }

            }
        }
    }
}