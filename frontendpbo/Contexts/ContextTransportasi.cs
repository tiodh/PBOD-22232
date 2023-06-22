using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace frontendpbo.Contexts
{
    internal class ContextTransportasi
    {
        private string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

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

        public bool InsertTransportasi(Transportasi transportasi)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "INSERT INTO transportasi (nama_transportasi, jenis_transportasi, deskripsi_transportasi) " +
                               "VALUES (@Nama_transportasi, @Jenis_transportasi, @Deskripsi_transportasi)";

                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nama_transportasi", transportasi.Nama_transportasi);
                    command.Parameters.AddWithValue("@Jenis_transportasi", transportasi.Jenis_transportasi);
                    command.Parameters.AddWithValue("@Deskripsi_transportasi", transportasi.Deskripsi_transportasi);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public bool UpdateTransportasi(Transportasi transportasi)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "UPDATE transportasi " +
                               "SET nama_transportasi = @Nama_transportasi, jenis_transportasi = @Jenis_transportasi, " +
                               "deskripsi_transportasi = @Deskripsi_transportasi " +
                               "WHERE id_transportasi = @Id_transportasi";

                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nama_transportasi", transportasi.Nama_transportasi);
                    command.Parameters.AddWithValue("@Jenis_transportasi", transportasi.Jenis_transportasi);
                    command.Parameters.AddWithValue("@Deskripsi_transportasi", transportasi.Deskripsi_transportasi);
                    command.Parameters.AddWithValue("@Id_transportasi", transportasi.Id_transportasi);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
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
    }
}