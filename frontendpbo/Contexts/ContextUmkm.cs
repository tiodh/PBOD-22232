using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextUMKM
    {
        public List<UMKM> listUMKM = new List<UMKM>() { };
        UMKM umkm = new UMKM();
        public bool Create(UMKM umkm)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql =
                    "INSERT INTO umkm(id_umkm, nama_umkm, deskripsi_umkm, pemilik_umkm, no_telpon_umkm, wisata_id) values (:id_umkm,:nama_umkm,:deskripsi_umkm,:pemilik_umkm,:no_telpon_umkm,:wisata_id)";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":id_umkm", umkm.Id));
                    cmd.Parameters.Add(new NpgsqlParameter(":nama_umkm", umkm.Name));
                    cmd.Parameters.Add(new NpgsqlParameter(":deskripsi_umkm", umkm.Description));
                    cmd.Parameters.Add(new NpgsqlParameter(":pemilik_umkm", umkm.Pemilik_UMKM));
                    cmd.Parameters.Add(new NpgsqlParameter(":no_telpon_umkm", umkm.No_Telepon_UMKM));
                    cmd.Parameters.Add(new NpgsqlParameter(":wisata_id", umkm.Wisata_ID));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int newdata = cmd.ExecuteNonQuery();
                    if (newdata > 0)
                    {
                        isSuccess = true;
                        this.listUMKM.Add(umkm);
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
                string sql = "SELECT * FROM umkm";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listUMKM.Clear();
                    while (reader.Read())
                    {
                        UMKM umkm = new UMKM();
                        umkm.Id = (int)reader["id_umkm"];
                        umkm.Name = (string)reader["nama_umkm"];
                        umkm.Description = (string)reader["deskripsi_umkm"];
                        umkm.Pemilik_UMKM = (string)reader["pemilik_umkm"];
                        umkm.No_Telepon_UMKM = (string)reader["no_telpon_umkm"];
                        umkm.Wisata_ID = (int)reader["wisata_id"];

                        listUMKM.Add(umkm);
                    }
                }
            }
            return isSuccess;
        }
    }
}