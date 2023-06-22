﻿using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextPenginapan
    {
        public List<Penginapan> listPenginapan = new List<Penginapan>() { };
        Penginapan penginapan = new Penginapan();

        public bool Insert(Penginapan penginapan)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql =
                    "INSERT INTO penginapan(nama_penginapan, deskripsi_penginapan) values (:nama_penginapan,:deskripsi_penginapan)";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":nama_penginapan", penginapan.Name));
                    cmd.Parameters.Add(new NpgsqlParameter(":deskripsi_penginapan", penginapan.Description));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSuccess = true;
                        this.listPenginapan.Add(penginapan);
                    }
                }
            }
            return isSuccess;
        }

        public bool Read()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM penginapan";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listPenginapan.Clear();
                    while (reader.Read())
                    {
                        Penginapan penginapan = new Penginapan();
                        penginapan.ID = (int)reader["id_penginapan"];
                        penginapan.Name = (string)reader["nama_penginapan"];
                        penginapan.Description = (string)reader["deskripsi_penginapan"];
                        penginapan.Wisata_ID = (int)reader["wisata_id"];
                        listPenginapan.Add(penginapan);
                    }
                }
            }
            return isSuccess;
        }
    }
}