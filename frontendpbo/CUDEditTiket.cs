using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CUD_DataTiket
{
    class CUDEditTiket
    {
        public class search_ticket
        {
            //dataGridView1.DataSource = koneksidb.Eksekusi(search);
        }
        public static void BuatTIket(string nama, string desc, int harga, int idTIket)
        {
            konek koneksidb = new konek();
            string create = $"INSERT INTO public.tiket(\r\n\tnama_tiket, deskripsi_tiket, harga_tiket, id_tiket)\r\n\tVALUES ('{nama}', '{desc}', {harga}, {idTIket});";
            koneksidb.Eksekusi(create);
        }
        public static DataTable BacaTiket()
        {
            konek koneksidb = new konek();
            DataTable dt = koneksidb.Eksekusi("select * from public.tiket \n Order By id_tiket");

            return dt;
        }

        public static void UpdateTiket(string nama, string desc, int harga, int idtiket)
        {
            konek koneksidb = new konek();
            string update = $"UPDATE public.tiket SET nama_tiket = '{nama}', deskripsi_tiket = '{desc}', harga_tiket = '{harga}' WHERE id_tiket = {idtiket}";
            koneksidb.Eksekusi(update);
        }

        public class konek
        {
            public NpgsqlConnection connection;
            public konek()
            {
                NpgsqlConnection connection = new NpgsqlConnection();
                connection.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;password = 09102022;Database=Tugas PBO";
            }
            public DataTable Eksekusi(string sql)
            {
                NpgsqlConnection connection = new NpgsqlConnection();
                connection.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;password = 09102022;Database=Tugas PBO";
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
                    }

                return dt;
            }



        }
    }


}


