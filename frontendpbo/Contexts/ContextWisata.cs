﻿using frontendpbo.Models;
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

        public List<Wisata> listWisata = new List<Wisata>() { };
        public bool insert(Wisata wisata)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=PETAJEMBER;";
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
        public bool Read()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;Username=postgres;Password=1;Database=PETAJEMBER;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
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

    }
}