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
    public class Class_crud_umkm
    {
        public static void made(string namumkm, string deskripsiumkm, string pemilikumkm, int noteleponumkm)
        {
            conec conecsidb = new conec();
            string create = "insert into umkm_pbo_1.umkm (nama_umkm, deskripsi_umkm, pemilik_umkm, no_telepon_umkm)\r" +
                $"\nvalues ('{namumkm}','{deskripsiumkm}','{pemilikumkm}','{noteleponumkm}');";
            conecsidb.Eksekusi(create);
        }
        public static DataTable read()
        {
            conec conecsidb = new conec();
            DataTable dt = conecsidb.Eksekusi("SELECT * FROM umkm_pbo_1.umkm;");

            return dt;
        }
    }
    class conec
    {
        public NpgsqlConnection connection;
        public conec()
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            connection.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;password = 140704;Database=umkm_pbo";
        }

        public DataTable Eksekusi(string sql)
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            connection.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;password = 140704;Database=umkm_pbo";
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
