using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextSarana
    {
        public void create(string nama, string deskrip)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=peta_jember;user id=postgres;password=123"))
            {
                connection.Open();
                NpgsqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "insert into sarana_prasarana(nama_sarana,deskripsi_sarana) values(@nama_sarana,@deskripsi_sarana)";
                command.Parameters.Add(new NpgsqlParameter("@nama_sarana", nama));
                command.Parameters.Add(new NpgsqlParameter("@deskripsi_sarana", deskrip));
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data berhasil diinput");
            }
        }
    }
}
