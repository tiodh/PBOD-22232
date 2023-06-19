using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    internal class ReadKeselamatanContext
    {
        public List<readKeselamatan> readKeselamatanList= new List<readKeselamatan>();

        public bool Read()
        {
            bool isSuccess = false;
            string constr = " Host=localhost;Port=5432;Database=PETAJEMBER;Username=postgres;Password=1";

            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                string sql =
                    @"SELECT * FROM ""data_keamanan""";
                //JOIN wisata ON transaksi.id_wisata = wisata.id_wisata
                //JOIN tiket ON trasaksi.id_tiket = tiket.id_tiket";

                conn.Open();
                using NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader Reader = cmd.ExecuteReader();
                    readKeselamatanList.Clear();
                    while (Reader.Read())
                    {
                        readKeselamatan newRead = new readKeselamatan();

                        newRead.nama = (string)Reader["nama_keamanan"];
                        //newRead.noTlp = (string)Reader["no_tlp"];
                        //newRead.alamat = (string)Reader["alamat_keamanan"];
                        newRead.deskripsi = (string)Reader["deskripsi_keamanan"];

                        readKeselamatanList.Add(newRead);
                    }
                }
            }
            return isSuccess;
        }
    }
}
