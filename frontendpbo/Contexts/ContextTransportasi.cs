using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace frontendpbo.Contexts
{
    internal class ContextTransportasi
    {
        private string CurrentIDTransportasi;
        public List<Transportasi> TransportasiList = new List<Transportasi>() { };
        private string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Alvio28;Database=peta_jember";

        public List<Transportasi> GetTransportasiList()
        {
            List<Transportasi> transportasiList = new List<Transportasi>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT id_transportasi, nama_transportasi, jenis_transportasi, deskripsi_transportasi " +
                                "FROM transportasi";

                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transportasi transportasi = new Transportasi();
                            transportasi.Id_transportasi = Convert.ToInt32(reader["id_transportasi"]);
                            transportasi.Nama_transportasi = reader["nama_transportasi"].ToString();
                            transportasi.Jenis_transportasi = reader["jenis_transportasi"].ToString();
                            transportasi.Deskripsi_transportasi = reader["deskripsi_transportasi"].ToString();

                            transportasiList.Add(transportasi);
                        }
                    }
                }
            }
            return transportasiList;
        }


        public List<Transportasi> SearchTransportasi(string nama_transportasi)
        {
            List<Transportasi> searchResults = new List<Transportasi>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "SELECT id_transportasi, nama_transportasi, jenis_transportasi, deskripsi_transportasi " +
                               "FROM transportasi " +
                               "WHERE nama_transportasi ILIKE '%' || @Nama_transportasi || '%' ";

                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nama_transportasi", nama_transportasi);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Transportasi transportasi = new Transportasi();
                            transportasi.Id_transportasi = Convert.ToInt32(reader["id_transportasi"]);
                            transportasi.Nama_transportasi = reader["nama_transportasi"].ToString();
                            transportasi.Jenis_transportasi = reader["jenis_transportasi"].ToString();
                            transportasi.Deskripsi_transportasi = reader["deskripsi_transportasi"].ToString();

                            searchResults.Add(transportasi);
                        }
                    }
                }
            }
            return searchResults;
        }

        public bool Update(Transportasi transportasi)
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=Paulus21.;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "UPDATE transportasi " +
                               "SET nama_transportasi = @nama_transportasi, jenis_transportasi = @jenis_transportasi, " +
                               "deskripsi_transportasi = @deskripsi_transportasi " +
                               "WHERE id_transportasi = @id_transportasi";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_transportasi", transportasi.Nama_transportasi);
                    cmd.Parameters.AddWithValue("@jenis_transportasi", transportasi.Jenis_transportasi);
                    cmd.Parameters.AddWithValue("@deskripsi_transportasi", transportasi.Deskripsi_transportasi);
                    cmd.Parameters.AddWithValue("@id_transportasi", transportasi.Id_transportasi);
                    //cmd.Parameters.AddWithValue("@idwisata", transportasi.Wisata_ID);

                    cmd.CommandType = System.Data.CommandType.Text;
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        isSuccess = true;
                        var existingTransportasi = TransportasiList.Find(t => t.Id_transportasi == transportasi.Id_transportasi);
                        if (existingTransportasi != null)
                        {
                            existingTransportasi.Nama_transportasi = transportasi.Nama_transportasi;
                            existingTransportasi.Jenis_transportasi = transportasi.Jenis_transportasi;
                            existingTransportasi.Deskripsi_transportasi = transportasi.Deskripsi_transportasi;
                        }
                    }
                }
            }
            return isSuccess;
        }

        public bool Read()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT id_transportasi, nama_transportasi, jenis_transportasi, deskripsi_transportasi, objek_wisata.id_wisata FROM transportasi JOIN objek_wisata ON transportasi.wisata_id = objek_wisata.id_wisata";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    TransportasiList.Clear();
                    while (reader.Read())
                    {
                        Transportasi transportasi = new Transportasi();
                        transportasi.Id_transportasi = (int)reader["id_transportasi"];
                        transportasi.Nama_transportasi = (string)reader["nama_transportasi"];
                        transportasi.Jenis_transportasi = (string)reader["jenis_transportasi"];
                        transportasi.Deskripsi_transportasi = (string)reader["deskripsi_transportasi"];
                        //transportasi.Wisata_ID = (int)reader["wisata_id"];
                        TransportasiList.Add(transportasi);

                    }
                }
            }
            return isSuccess;

        }

        public bool Insert(Transportasi transportasi)
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=Paulus21.;Database= peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "INSERT INTO transportasi (nama_transportasi, jenis_transportasi, deskripsi_transportasi, wisata_id) " +
                             "VALUES (@nama_transportasi, @jenis_transportasi, @deskripsi_transportasi, @idwisata) RETURNING id_transportasi";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_transportasi", transportasi.Nama_transportasi);
                    cmd.Parameters.AddWithValue("@jenis_transportasi", transportasi.Jenis_transportasi);
                    cmd.Parameters.AddWithValue("@deskripsi_Transportasi", transportasi.Deskripsi_transportasi);
                    cmd.Parameters.AddWithValue("@idwisata", 1);


                    cmd.CommandType = System.Data.CommandType.Text;
                    int rowsAffected = cmd.ExecuteNonQuery();
                    //return rowsAffected > 0;
                    if (rowsAffected > 0)
                    {
                        isSuccess = true;
                        this.TransportasiList.Add(transportasi);
                    }

                }
                return isSuccess;
            }

        }

        public bool Delete(Transportasi transportasi)
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=Paulus21.;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "DELETE FROM transportasi WHERE id_transportasi = CAST(@id_transportasi AS INTEGER);";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    CurrentIDTransportasi = transportasi.Id_transportasi.ToString();
                    cmd.Parameters.AddWithValue("@id_transportasi", int.Parse(CurrentIDTransportasi));


                    cmd.CommandType = System.Data.CommandType.Text;
                    int jumlahData = cmd.ExecuteNonQuery();
                    if (jumlahData > 0)
                    {
                        isSuccess = true;
                        var itemToRemove = TransportasiList.Single(rec => rec.Id_transportasi == transportasi.Id_transportasi);
                        TransportasiList.Remove(itemToRemove);
                    }
                }
            }
            return isSuccess;
        }
    }
}