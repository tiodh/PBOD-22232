using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace frontendpbo
{
    public class Class_crud_informasi_pengumuman
    {
        public static void buatdata(string namainformasi, string deskripsiinformasi, int tanggalinformasi)
        {
            connectpengumuman conecsidb = new connectpengumuman();
            string create = "insert into umkm_pbo_1.umkm (id_umkm,nama_umkm, deskripsi_umkm, pemilik_umkm, no_telepon_umkm)\r" +
                $"\nvalues ('{namainformasi}','{deskripsiinformasi}','{tanggalinformasi}');";
            conecsidb.Eksekusi(create);
        }
        public static DataTable read()
        {
            connectpengumuman conecsidb = new connectpengumuman();
            DataTable dt = conecsidb.Eksekusi("SELECT * FROM umkm_pbo_1.umkm;");

            return dt;
        }
    }

    class connectpengumuman
    {
        public NpgsqlConnection connection;

        public connectpengumuman()
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            connection.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;password = 123;Database=pengumuman";  
        }

        public DataTable Eksekusi(string sql)
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            connection.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;password = 123;Database=pengumuman";
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);

                da.Fill(dt);
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Kesalahan Data!" + ex.Message, "Mohon Mengisi Data dengan benar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

    }
}
