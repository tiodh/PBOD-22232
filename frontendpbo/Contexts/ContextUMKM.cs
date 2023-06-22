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

        public List<UMKM> GetListUMKM()
        {
            return listUMKM;
        }
        public bool Made()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT umkm.id_umkm, umkm.nama_umkm, umkm.deskripsi_umkm, umkm.pemilik_umkm, umkm.wisata_id, umkm.no_telepon_umkm " +
                             "FROM umkm " +
                             "JOIN objek_wisata ON tiket.wisata_id = objek_wisata.id_wisata";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    listUMKM.Clear();
                    while (reader.Read())

                    {
                        UMKM UMKM = new UMKM();
                        UMKM.Id = (int)reader["id_umkm"];
                        UMKM.Name = (string)reader["nama_umkm"];
                        UMKM.Description = (string)reader["deskripsi_umkm"];
                        UMKM.No_Telepon_UMKM = (string)reader["no_telepon_umkm"];
                        UMKM.Wisata_ID = (int)reader["wisata_id"];
                        UMKM.Pemilik_UMKM = (string)reader["pemilik_umkm`"];
                        listUMKM.Add(UMKM);
                    }
                }
            }
            return isSuccess;
        }
    }
}
