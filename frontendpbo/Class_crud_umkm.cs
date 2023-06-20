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
    public class  Class_crud_umkm : Form
    {
        public static void made(int idumkm, string namumkm, string deskripsiumkm, string pemilikumkm, string noteleponumkm)
        {
            conec conecsidb = new conec();
            string create = "insert peta_jember(id_umkm,nama_umkm, deskripsi_umkm, pemilik_umkm, no_telepon_umkm)\r" +
                $"\nvalues ('{idumkm}','{namumkm}','{deskripsiumkm}','{pemilikumkm}','{noteleponumkm}');";
            conecsidb.Eksekusi(create);
        }

        public static void edit(int idumkm, string namumkm, string deskripsiumkm, string pemilikumkm, string noteleponumkm)
        {
            conec conecsidb = new conec();
            string update = $"UPDATE peta_jember " +
                $"SET nama_umkm = '{namumkm}', deskripsi_umkm = '{deskripsiumkm}', pemilik_umkm = '{pemilikumkm}', no_telepon_umkm = '{noteleponumkm}' " +
                $"WHERE id_umkm = {idumkm};";
            conecsidb.Eksekusi(update);
        }

        public static DataTable read()
        {
            conec conecsidb = new conec();
            DataTable dt = conecsidb.Eksekusi("SELECT * FROM \"umkm\";");

            return dt;
        }
    }




    class conec
    {
        public NpgsqlConnection connection;
        public conec()
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            connection.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;password=aini123;Database=peta_jember";
        }

        public DataTable Eksekusi(string sql)
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            connection.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;password=aini123;Database=peta_jember";
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
