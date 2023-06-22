﻿using frontendpbo.Models;
using frontendpbo.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextWisata
    {

        private int? CurrentID;
        public List<Wisata> listWisata = new List<Wisata>() { };

        public bool Read()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using(NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM objek_wisata";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listWisata.Clear();
                    while (reader.Read())
                    {
                        Wisata wisata = new Wisata();
                        wisata.Id_Wisata = (int)reader["id_wisata"];
                        wisata.Nama_Wisata = (string)reader["nama_wisata"];
                        wisata.Deskripsi = (string)reader["deskripsi_wisata"];
                        wisata.Lokasi = (string)reader["lokasi_wisata"];
                        listWisata.Add(wisata);
                    }
                }

            }
            return isSuccess;
        }

        public List<Wisata> Search(string query)
        {
            List<Wisata> searchResults = new List<Wisata>();

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM objek_wisata WHERE nama_wisata ilike @query OR deskripsi_wisata ilike @query OR lokasi_wisata ilike @query";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@query", "%" + query + "%");
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Wisata wisata = new Wisata();

                        wisata.Id_Wisata = (int)reader["id_wisata"];
                        wisata.Nama_Wisata = (string)reader["nama_wisata"];
                        wisata.Deskripsi = (string)reader["deskripsi_wisata"];
                        wisata.Lokasi = (string)reader["lokasi_wisata"];

                        searchResults.Add(wisata);
                    }
                }
            }

            return searchResults;
        }

        public List<Wisata> GetListWisata()
        {
            return listWisata;
        }


        public bool Insert(Wisata wisata)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql =
                    "INSERT INTO objek_wisata(nama_wisata, deskripsi_wisata, lokasi_wisata) values (:nama_wisata,:deskripsi_wisata,:lokasi_wisata)";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":nama_wisata", wisata.Nama_Wisata));
                    cmd.Parameters.Add(new NpgsqlParameter(":deskripsi_wisata", wisata.Deskripsi));
                    cmd.Parameters.Add(new NpgsqlParameter(":lokasi_wisata", wisata.Lokasi));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSuccess = true;
                        this.listWisata.Add(wisata);
                    }
                }
            }
            return isSuccess;
        }

        public bool Update(Wisata wisata)
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "UPDATE public.objek_wisata SET nama_wisata=:namawisata, deskripsi_wisata=:desc, lokasi_wisata=:lok WHERE id_wisata=:id;";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    CurrentID = wisata.Id_Wisata;
                    cmd.Parameters.Add(new NpgsqlParameter(":id", CurrentID));
                    cmd.Parameters.Add(new NpgsqlParameter(":namawisata", wisata.Nama_Wisata));
                    cmd.Parameters.Add(new NpgsqlParameter(":desc", wisata.Deskripsi));
                    cmd.Parameters.Add(new NpgsqlParameter(":lok", wisata.Lokasi));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jumlahData = cmd.ExecuteNonQuery();
                    if (jumlahData > 0)
                    {
                        isSuccess = true;
                        this.listWisata.Add(wisata);
                    }
                }
            }

            return isSuccess;
        }


        public List<Wisata> ReadtoCard()
        {

            List<Wisata> listWisata = new List<Wisata>();

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM objek_wisata";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Wisata wisata = new Wisata();
                        wisata.Id_Wisata = (int)reader["id_wisata"];
                        wisata.Nama_Wisata = (string)reader["nama_wisata"];
                        wisata.Deskripsi = (string)reader["deskripsi_wisata"];
                        wisata.Lokasi = (string)reader["lokasi_wisata"];
                        listWisata.Add(wisata);
                    }
                }
            }

            return listWisata;
        }

        public bool Delete(string id)
        {
            bool isSuccess = false;
            return isSuccess;
        }
    }
}
