using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextKeamanan
    {

        public void create(string nama, string no_tlp, string alamat, string deskripsi)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=peta_jember;user id=postgres;password=123"))
            {
                connection.Open();
                NpgsqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "insert into data_keamanan(nama_keamanan, alamat_keamanan, no_tlp, deskripsi_keamanan) values(@nama_keamanan, @alamat_keamanan, @no_tlp, @deskripsi_keamanan)";
                command.Parameters.Add(new NpgsqlParameter("@nama_keamanan", nama));
                command.Parameters.Add(new NpgsqlParameter("@deskripsi_keamanan", deskripsi));
                command.Parameters.Add(new NpgsqlParameter("@alamat_keamanan", alamat));
                command.Parameters.Add(new NpgsqlParameter("@no_tlp", no_tlp));

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data berhasil diinput");
                //RefreshUlasanTerakhir();
                //RefreshRatingTerakhir();
            }
        }
    }
}
