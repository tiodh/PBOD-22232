using frontendpbo.Models;
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
    public bool Update(Penginapan penginapan)
    {
        bool isSuccess = false;

        string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=dewi2493;Database=peta_jember;";
        using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
        {
            string sql = @"UPDATE SET id_penginapan = :id_penginapan, nama_penginapan = :nama_penginapan,deskripsi_penginapan = :deskripsi_penginapan where id_wisata = :id_wisata";
            conn.Open();
            using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
            {
                cmd.Parameters.Add(new NpgsqlParameter(":id_penginapan", Penginapan.ID));
                cmd.Parameters.Add(new NpgsqlParameter(":nama_penginapan", Penginapan.Name));
                cmd.Parameters.Add(new NpgsqlParameter(":deskripsi_penginapan", Penginapan.Description));
                cmd.Parameters.Add(new NpgsqlParameter(":wisata_id", Penginapan.Wisata_ID));

                cmd.CommandType = System.Data.CommandType.Text;
                int JumlahData = cmd.ExecuteNonQuery();
                if (JumlahData > 0)
                {
                    isSuccess = true;
                    foreach (var temp in this.listWisata)
                    {
                        var t = temp as Penginapan;
                        if (t != null && t.Id_Penginapan.Equals(penginapan.Id_penginapan))
                        {
                            t.ID = penginapan.ID;
                            t.Name = penginapan.Nama_Penginapan;
                            t.Description = penginapan.Description;
                            t.Wisata_ID = penginapan.Wisata_ID;
                        }
                    }
                }
                MessageBox.Show("Sukses Mengupdate Data");
            }

        }
        return isSuccess;
    }
}