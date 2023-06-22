using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace frontendpbo.Contexts
{
    internal class ContextRiwayatKunjungan
    {
        private int IdRiwayatKunjungan;
        public List<Riwayat> ListRiwayat = new List<Riwayat>() { };


        public void search(string cari)
        {

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                //string sql = $"SELECT * FROM riwayat_kunjungan where id_wisata = {cari} OR jumlah_tiket = {cari} OR tiket_id = {cari}";  where id_wisata = {cari} OR jumlah_tiket = {cari} OR t.nama_tiket = '{cari}' or p.nama_pengunjung = '{cari}'
                string sql = $"SELECT id_riwayat, tanggal_kunjungan, jumlah_tiket, t.nama_tiket, p.nama_pengunjung FROM riwayat_kunjungan JOIN tiket t ON tiket_id = t.id_tiket JOIN pengunjung p ON pengunjung_id = p.id_pengunjung where p.nama_pengunjung ilike '%{cari}%'";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    ListRiwayat.Clear();
                    while (reader.Read())
                    {
                        Riwayat riwayat = new Riwayat();
                        riwayat.Id = (int)reader["id_riwayat"];
                        riwayat.nama = (string)reader["nama_pengunjung"];
                        riwayat.Tanggal_Kunjungan = (DateTime)reader["tanggal_kunjungan"];
                        riwayat.Jumlah_Tiket = (int)reader["jumlah_tiket"];
                        riwayat.nama_tiket = (string)reader["nama_tiket"];
                        ListRiwayat.Add(riwayat);
                    }
                }
            }
        }
        public void Read()
        {
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            { 
                string sql = $"SELECT id_riwayat, tanggal_kunjungan, jumlah_tiket, t.nama_tiket, p.nama_pengunjung FROM riwayat_kunjungan JOIN tiket t ON tiket_id = t.id_tiket JOIN pengunjung p ON pengunjung_id = p.id_pengunjung";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    ListRiwayat.Clear();
                    while (reader.Read())
                    {
                        Riwayat riwayat = new Riwayat();
                        riwayat.Id = (int)reader["id_riwayat"];
                        riwayat.nama = (string)reader["nama_pengunjung"];
                        riwayat.Tanggal_Kunjungan = (DateTime)reader["tanggal_kunjungan"];
                        riwayat.Jumlah_Tiket = (int)reader["jumlah_tiket"];
                        riwayat.nama_tiket = (string)reader["nama_tiket"];
                        ListRiwayat.Add(riwayat);
                    }
                }
            }
        }

        public void Insert()
        {

        }

    }
}
