using frontendpbo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace frontendpbo.Contexts
{
    internal class ContextUlasan
    {
        public List<Ulasan> listUlasan = new List<Ulasan>() { };

        public bool Insert(Ulasan ulasan)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection connection = new NpgsqlConnection(conStr))
            {
                string sql = "INSERT INTO ulasan (nama_user, deskripsi_ulasan, wisata_id) " +
                     "VALUES (:Nama, :Deskripsi, :IDWisata)";
                connection.Open();

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, connection))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":Nama", ulasan.nama_user));
                    cmd.Parameters.Add(new NpgsqlParameter(":Deskripsi", ulasan.deskripsi_ulasan));
                    cmd.Parameters.Add(new NpgsqlParameter(":IDWisata", ulasan.wisata_id));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSuccess = true;
                        this.listUlasan.Add(ulasan);
                    }
                }
                MessageBox.Show(sql);
            }
            return isSuccess;
        }

        public bool Read()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT ulasan.id_ulasan, ulasan.nama_user, ulasan.deskripsi_ulasan, objek_wisata.id_wisata " +
                             "FROM ulasan " +
                             "JOIN objek_wisata ON ulasan.wisata_id = objek_wisata.id_wisata";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listUlasan.Clear();
                    while (reader.Read())

                    {
                        Ulasan ulasan = new Ulasan();
                        ulasan.id_ulasan = (int)reader["id_ulasan"];
                        ulasan.nama_user = (string)reader["nama_user"];
                        ulasan.deskripsi_ulasan= (string)reader["deskripsi_ulasan"];
                        ulasan.wisata_id = (int)reader["id_wisata"];
                        listUlasan.Add(ulasan);
                    }
                }
            }
            return isSuccess;
        }

        public List<Wisata> GetNamaWisataList()
        {
            List<Wisata> namaWisataList = new List<Wisata>();
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT id_wisata, nama_wisata FROM objek_wisata";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Wisata wisata = new Wisata();
                        wisata.Id_Wisata = (int)reader["id_wisata"];
                        wisata.Nama_Wisata = (string)reader["nama_wisata"];
                        namaWisataList.Add(wisata);
                    }
                }
            }

            return namaWisataList;
        }

        public void Delete(int ulasanId)
        {
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";
            using (NpgsqlConnection connection = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT ulasan.id_ulasan, ulasan.nama_user, ulasan.deskripsi_ulasan, objek_wisata.id_wisata " +
             "FROM ulasan " +
             "JOIN objek_wisata ON ulasan.wisata_id = objek_wisata.id_wisata";
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("DELETE FROM ulasan WHERE id_ulasan = @id_ulasan", connection))
                {
                    command.Parameters.AddWithValue("@id_ulasan", ulasanId);

                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Ulasan> Search(string query)
        {
            List<Ulasan> searchResults = new List<Ulasan>();

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM ulasan WHERE nama_user ILIKE @query OR deskripsi_ulasan ILIKE @query";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@query", "%" + query + "%");

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Ulasan ulasan = new Ulasan();
                        ulasan.id_ulasan = (int)reader["id_ulasan"];
                        ulasan.nama_user = (string)reader["nama_user"];
                        ulasan.deskripsi_ulasan = (string)reader["deskripsi_ulasan"];
                        ulasan.wisata_id = (int)reader["wisata_id"];
                        searchResults.Add(ulasan);
                    }
                }
            }
            return searchResults;
        }

    }
}