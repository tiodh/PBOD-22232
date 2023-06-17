using frontendpbo.Models;
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

        public bool Read()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=PETAJEMBER";

            using(NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM objek_wisata";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = conStr;
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
