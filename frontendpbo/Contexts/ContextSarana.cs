using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextSarana
    {
        public List<SaranaPrasarana> ListSarana = new List<SaranaPrasarana>() { };

        public void search(string cari)
        {

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = $"SELECT nama_sarana, deskripsi_sarana FROM sarana_prasarana where nama_sarana = '{cari}' ";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    ListSarana.Clear();
                    while (reader.Read())
                    {
                        SaranaPrasarana Sarana = new SaranaPrasarana();
                        Sarana.nama_sarana = (string)reader["nama_sarana"];
                        Sarana.deskripsi_sarana = (string)reader["deskripsi_sarana"];
                        ListSarana.Add(Sarana);
                    }
                }
            }
        }
        public bool create(SaranaPrasarana newSarana)
        {
            bool isSuccess = false;
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember"))
            {
                connection.Open();
                NpgsqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "insert into sarana_prasarana(nama_sarana,deskripsi_sarana) values(@nama_sarana,@deskripsi_sarana)";
                command.Parameters.Add(new NpgsqlParameter("@nama_sarana", newSarana.nama_sarana));
                command.Parameters.Add(new NpgsqlParameter("@deskripsi_sarana", newSarana.deskripsi_sarana));

                command.CommandType = System.Data.CommandType.Text;
                int jmlDataBaru = command.ExecuteNonQuery();
                if (jmlDataBaru > 0)
                {
                    isSuccess = true;
                    ListSarana.Add(newSarana);
                }
                //connection.Close();
                MessageBox.Show("Data berhasil diinput");
            }
            return isSuccess;
        }

        public DataTable ReadAll()
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=Julpangmumet;user id=postgres;password=123"))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("SELECT * FROM sarana_prasarana", connection);

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                adapter.Fill(dataTable);

                connection.Close();
            }

            return dataTable;
        }
    }
}
