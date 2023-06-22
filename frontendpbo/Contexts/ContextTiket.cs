using frontendpbo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;
using System.Collections;
using System.DirectoryServices;


namespace frontendpbo.Contexts
{
    internal class ContextTiket
    {
        public List<Tiket> listTiket = new List<Tiket>() { };

        public List<Tiket> GetListTiket()
        {
            return listTiket;
        }
        public bool Read()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT tiket.id_tiket, tiket.nama_tiket, tiket.deskripsi_tiket, tiket.harga_tiket, objek_wisata.id_wisata " +
                             "FROM tiket " +
                             "JOIN objek_wisata ON tiket.wisata_id = objek_wisata.id_wisata";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listTiket.Clear();
                    while (reader.Read())

                    {
                        Tiket tiket = new Tiket();
                        tiket.id_tiket = (int)reader["id_tiket"];
                        tiket.nama_tiket = (string)reader["nama_tiket"];
                        tiket.deskripsi_tiket = (string)reader["deskripsi_tiket"];
                        tiket.harga_tiket = (int)reader["harga_tiket"];
                        tiket.wisata_id = (int)reader["id_wisata"];
                        listTiket.Add(tiket);
                    }
                }
            }
            return isSuccess;
        }
        public List<Tiket> Search(string query, string column)
        {
            List<Tiket> searchResults = new List<Tiket>();

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM Tiket WHERE CAST(" + column + " AS VARCHAR) ILIKE @query";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@query", "%" + query + "%");

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Tiket tiket = new Tiket();
                        tiket.id_tiket = (int)reader["id_tiket"];
                        tiket.nama_tiket = (string)reader["nama_tiket"];
                        tiket.deskripsi_tiket = (string)reader["deskripsi_tiket"];
                        tiket.harga_tiket = (int)reader["harga_tiket"];
                        tiket.wisata_id = (int)reader["wisata_id"];
                        searchResults.Add(tiket);
                    }
                }
            }
            return searchResults;
        }


        public int GetHargaTiketByRoda(int jumlahRoda)
        {
            int hargaTiket = 0;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT harga_tiket FROM Tiket WHERE deskripsi_tiket LIKE @deskripsi";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@deskripsi", "Kendaraan Roda " + jumlahRoda);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        hargaTiket = (int)reader["harga_tiket"];
                    }
                }
            }

            return hargaTiket;
        }
    }
}
