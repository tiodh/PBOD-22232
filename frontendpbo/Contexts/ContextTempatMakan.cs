using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextTempatMakan
    {
        private string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;";
        List<TempatMakan> tempatMakanList = new List<TempatMakan>() { };

        public List<TempatMakan> GetListtempatmakan()
        {
            return tempatMakanList;
        }

        public bool ReadTempatMakan()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM tempat_makan";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    tempatMakanList.Clear();
                    while (reader.Read())
                    {
                        TempatMakan tempatMakan = new TempatMakan();
                        tempatMakan.id_tempat_makan = (int)reader["id_tempat_makan"];
                        tempatMakan.nama_tempat_makan = (string)reader["nama_tempat_makan"];
                        tempatMakan.lokasi_tempat_makan = (string)reader["lokasi_tempat_makan"];
                        tempatMakan.deskripsi_tempat_makan = (string)reader["deskripsi_tempat_makan"];
                        tempatMakan.no_telepon_tempat_makan = (string)reader["no_telepon_tempat_makan"];
                        tempatMakanList.Add(tempatMakan);
                    }
                }

            }
            return isSuccess;
        }

        public List<TempatMakan> TempatMakan()
        {

            List<TempatMakan> daftarTempatMakan = new List<TempatMakan>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string sql = "SELECT id_tempat_makan, nama_tempat_makan, lokasi_tempat_makan, deskripsi_tempat_makan, no_telepon_tempat_makan, wisata_id FROM tempat_makan";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    connection.Open();
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TempatMakan tempatMakan = new TempatMakan();
                            tempatMakan.id_tempat_makan = Convert.ToInt32(reader["id_tempat_makan"]);
                            tempatMakan.nama_tempat_makan = reader["nama_tempat_makan"].ToString();
                            tempatMakan.lokasi_tempat_makan = reader["lokasi_tempat_makan"].ToString();
                            tempatMakan.deskripsi_tempat_makan = reader["deskripsi_tempat_makan"].ToString();
                            tempatMakan.no_telepon_tempat_makan = reader["no_telepon_tempat_makan"].ToString();
                            tempatMakan.wisata_id = Convert.ToInt32(reader["wisata_id"]);
                            tempatMakanList.Add(tempatMakan);
                        }
                    }
                }
            }

            return tempatMakanList;
        }

        public void CreateTempatMakan(TempatMakan tempatMakan)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string sql = "INSERT INTO tempat_makan (nama_tempat_makan, lokasi_tempat_makan, deskripsi_tempat_makan, no_telepon_tempat_makan) VALUES (@nama_tempat_makan, @lokasi_Tempat_makan, @deskripsi_tempat_makan, @no_telepon_tempat_makan)";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@nama_tempat_makan", tempatMakan.nama_tempat_makan);
                    command.Parameters.AddWithValue("@lokasi_tempat_makan", tempatMakan.lokasi_tempat_makan);
                    command.Parameters.AddWithValue("@deskripsi_tempat_makan", tempatMakan.deskripsi_tempat_makan);
                    command.Parameters.AddWithValue("@no_telepon_tempat_makan", tempatMakan.no_telepon_tempat_makan);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateTempatMakan(TempatMakan tempatMakan)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string sql = "UPDATE tempat_makan SET nama_tempat_makan = @nama_tempat_makan, lokasi_tempat_makan = @lokasi_tempat_makan, deskripsi_tempat_makan = @deskripsi_tempat_makan, no_telepon_tempat_makan = @no_telepon_tempat_makan WHERE id_tempat_makan = @id_tempat_makan";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id_tempat_makan", tempatMakan.id_tempat_makan);
                    command.Parameters.AddWithValue("@nama_tempat_makan", tempatMakan.nama_tempat_makan);
                    command.Parameters.AddWithValue("@lokasi_tempat_makan", tempatMakan.lokasi_tempat_makan);
                    command.Parameters.AddWithValue("@deskripsi_tempat_makan", tempatMakan.deskripsi_tempat_makan);
                    command.Parameters.AddWithValue("@no_telepon_tempat_makan", tempatMakan.no_telepon_tempat_makan);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

        }

       
    }
}
