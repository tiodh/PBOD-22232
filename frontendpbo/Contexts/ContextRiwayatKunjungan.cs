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
        public List<RiwayatKunjungan> Listriwayat = new List<RiwayatKunjungan>() { };


        public void search(string cari)
        {

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                //string sql = $"SELECT * FROM riwayat_kunjungan where id_wisata = {cari} OR jumlah_tiket = {cari} OR tiket_id = {cari}";  where id_wisata = {cari} OR jumlah_tiket = {cari} OR t.nama_tiket = '{cari}' or p.nama_pengunjung = '{cari}'
                string sql = $"SELECT id_riwayat, tanggal_kunjungan, jumlah_tiket, t.nama_tiket, p.nama_pengunjung, pengunjung_id, tiket_id FROM riwayat_kunjungan JOIN tiket t ON tiket_id = t.id_tiket JOIN pengunjung p ON pengunjung_id = p.id_pengunjung where p.nama_pengunjung ilike '%{cari}%'";

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
                        riwayat.Tanggal_Kunjungan = DateOnly.FromDateTime((DateTime)reader["tanggal_kunjungan"]);
                        riwayat.Jumlah_Tiket = (int)reader["jumlah_tiket"];
                        riwayat.nama_tiket = (string)reader["nama_tiket"];
                        riwayat.Pengunjung_ID = (int)reader["pengunjung_id"];
                        riwayat.Tiket_ID = (int)reader["tiket_id"];
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
                string sql = $"SELECT id_riwayat, tanggal_kunjungan, jumlah_tiket, t.nama_tiket, p.nama_pengunjung, pengunjung_id, tiket_id FROM riwayat_kunjungan JOIN tiket t ON tiket_id = t.id_tiket JOIN pengunjung p ON pengunjung_id = p.id_pengunjung";
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
                        riwayat.Tanggal_Kunjungan = DateOnly.FromDateTime((DateTime)reader["tanggal_kunjungan"]);
                        riwayat.Jumlah_Tiket = (int)reader["jumlah_tiket"];
                        riwayat.nama_tiket = (string)reader["nama_tiket"];
                        riwayat.Pengunjung_ID = (int)reader["pengunjung_id"];
                        riwayat.Tiket_ID = (int)reader["tiket_id"];
                        ListRiwayat.Add(riwayat);
                    }
                }
            }
        }

        public bool Update(Riwayat riwayat)
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "UPDATE riwayat_kunjungan SET pengunjung_id = @pengunjung, tanggal_kunjungan = @tanggal_kunjungan, jumlah_tiket = @jumlah_tiket, tiket_id = @tiket WHERE id_riwayat = @id_riwayat_kunjungan";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    IdRiwayatKunjungan = riwayat.Id;
                    cmd.Parameters.AddWithValue("@id_riwayat_kunjungan", IdRiwayatKunjungan);
                    cmd.Parameters.AddWithValue("@pengunjung", riwayat.Pengunjung_ID);
                    cmd.Parameters.AddWithValue("@tanggal_kunjungan", riwayat.Tanggal_Kunjungan);
                    cmd.Parameters.AddWithValue("@jumlah_tiket", riwayat.Jumlah_Tiket);
                    cmd.Parameters.AddWithValue("@tiket", riwayat.Tiket_ID);

                    int rowsAffected = cmd.ExecuteNonQuery(); 
                    if (rowsAffected > 0)
                    {
                        isSuccess = true;
                        // Optionally, update the corresponding object in ListRiwayat
                        var updatedRiwayat = ListRiwayat.FirstOrDefault(r => r.Id == riwayat.Id);
                        if (updatedRiwayat != null)
                        {
                            updatedRiwayat.Pengunjung_ID = riwayat.Pengunjung_ID;
                            updatedRiwayat.Tanggal_Kunjungan = riwayat.Tanggal_Kunjungan;
                            updatedRiwayat.Jumlah_Tiket = riwayat.Jumlah_Tiket;
                            updatedRiwayat.Tiket_ID = riwayat.Tiket_ID;
                        }
                    }
                }
            }

            return isSuccess;
        }

        /*public bool Update(RiwayatKunjungan riwayat)
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "UPDATE riwayat_kunjungan SET pengunjung_id = @pengunjung, tanggal_kunjungan = @tanggal_kunjungan, jumlah_tiket = @jumlah_tiket, tiket_id = @tiket WHERE id_riwayat = @id_riwayat_kunjungan";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id_riwayat_kunjungan", riwayat.IdKunjungan);
                    cmd.Parameters.AddWithValue("@pengunjung", riwayat.Pengunjung_ID);
                    cmd.Parameters.AddWithValue("@tanggal_kunjungan", riwayat.Tanggal_Kunjungan);
                    cmd.Parameters.AddWithValue("@jumlah_tiket", riwayat.Jumlah_Tiket);
                    cmd.Parameters.AddWithValue("@tiket", riwayat.Tiket_ID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        isSuccess = true;
                        // Optionally, update the corresponding object in ListRiwayat
                        var updatedRiwayat = Listriwayat.FirstOrDefault(r => r.IdKunjungan == riwayat.IdKunjungan);
                        if (updatedRiwayat != null)
                        {
                            updatedRiwayat.Pengunjung_ID = riwayat.Pengunjung_ID;
                            updatedRiwayat.Tanggal_Kunjungan = riwayat.Tanggal_Kunjungan;
                            updatedRiwayat.Jumlah_Tiket = riwayat.Jumlah_Tiket;
                            updatedRiwayat.Tiket_ID = riwayat.Tiket_ID;
                        }
                    }
                }
            }

            return isSuccess;
        }*/

        public bool Insert(Riwayat riwayatKunjungan)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=dewi2493;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql =
                    "INSERT INTO public.riwayat_kunjungan(tanggal_kunjungan, jumlah_tiket, tiket_id, pengunjung_id) VALUES (:tanggal_kunjungan, :jumlah_tiket, :tiket_id, :pengunjung_id);";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":tanggal_kunjungan", riwayatKunjungan.Tanggal_Kunjungan));
                    cmd.Parameters.Add(new NpgsqlParameter(":jumlah_tiket", riwayatKunjungan.Jumlah_Tiket));
                    cmd.Parameters.Add(new NpgsqlParameter(":tiket_id", riwayatKunjungan.Tiket_ID));
                    cmd.Parameters.Add(new NpgsqlParameter(":pengunjung_id", riwayatKunjungan.Pengunjung_ID));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSuccess = true;
                        this.ListRiwayat.Add(riwayatKunjungan);
                    }
                }
            }
            return isSuccess;
        }


        /*public bool Insert(RiwayatKunjungan riwayatKunjungan)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=dewi2493;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql =
                    "INSERT INTO public.riwayat_kunjungan(tanggal_kunjungan, jumlah_tiket, tiket_id, pengunjung_id) VALUES (:tanggal_kunjungan, :jumlah_tiket, :tiket_id, :pengunjung_id);";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":tanggal_kunjungan", riwayatKunjungan.Tanggal_Kunjungan));
                    cmd.Parameters.Add(new NpgsqlParameter(":jumlah_tiket", riwayatKunjungan.Jumlah_Tiket));
                    cmd.Parameters.Add(new NpgsqlParameter(":tiket_id", riwayatKunjungan.Tiket_ID));
                    cmd.Parameters.Add(new NpgsqlParameter(":pengunjung_id", riwayatKunjungan.Pengunjung_ID));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSuccess = true;
                        this.Listriwayat.Add(riwayatKunjungan);
                    }
                }
            }
            return isSuccess;
        }*/
    }
}
