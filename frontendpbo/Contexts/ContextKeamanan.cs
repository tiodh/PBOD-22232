using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontendpbo.Contexts
{
    internal class ContextKeamanan
    {
        public List<Keamanan> keamananList = new List<Keamanan>();
        public List<Keamanan> GetlistKeamanan()
        {
            return keamananList;
        }

        public bool create(Keamanan newKeamanan)
        {
            bool isSucces = false;
            using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=peta_jember;user id=postgres;password=123"))
            {
                connection.Open();
                NpgsqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "insert into data_keamanan(nama_keamanan, alamat_keamanan, no_tlp, deskripsi_keamanan) values(@nama_keamanan, @alamat_keamanan, @no_tlp, @deskripsi_keamanan)";
                command.Parameters.Add(new NpgsqlParameter("@nama_keamanan", newKeamanan.Name));
                command.Parameters.Add(new NpgsqlParameter("@deskripsi_keamanan", newKeamanan.Description));
                command.Parameters.Add(new NpgsqlParameter("@alamat_keamanan", newKeamanan.Alamat));
                command.Parameters.Add(new NpgsqlParameter("@no_tlp", newKeamanan.No_Tlp));

                command.CommandType = System.Data.CommandType.Text;
                int jmlDataBaru = command.ExecuteNonQuery();
                if(jmlDataBaru > 0)
                {
                    isSucces = true;
                    keamananList.Add(newKeamanan);
                }
                //connection.Close();
                MessageBox.Show("Data berhasil diinput");
            }
            return isSucces;
        }

        public void edit(Keamanan data)
        {
            
            using (NpgsqlConnection connection = new NpgsqlConnection("Host = localhost; Port = 5432; Database = peta_jember; Username = postgres; Password = 123"))
            {
                try
                {
                    connection.Open();
                    string queryupdate = $"update data_keamanan set nama_keamanan = @DataA, deskripsi_keamanan = @DataB, alamat_keamanan = @DataC, no_tlp = @DataD where id_keamanan = @ID";
                    using (NpgsqlCommand command = new NpgsqlCommand(queryupdate, connection))
                    {
                        command.Parameters.AddWithValue("@DataA", data.Name);
                        command.Parameters.AddWithValue("@DataB", data.Description);
                        command.Parameters.AddWithValue("@DataC", data.Alamat);
                        command.Parameters.AddWithValue("@DataD", data.No_Tlp);
                        command.Parameters.AddWithValue("@ID", data.Id);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }
        public List<Keamanan> Search(string query)
        {
            List<Keamanan> searchResults = new List<Keamanan>();

            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT * FROM data_keamanan WHERE nama_keamanan ILIKE @query or deskripsi_keamanan ILIKE @query or alamat_keamanan ILIKE @query or no_tlp ILIKE @query ";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@query", "%" + query + "%");

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Keamanan keamanan = new Keamanan();
                        keamanan.Id = (int)reader["id_keamanan"];
                        keamanan.Name = (string)reader["nama_keamanan"];
                        keamanan.No_Tlp = (string)reader["no_tlp"];
                        keamanan.Alamat = (string)reader["alamat_keamanan"];
                        keamanan.Description = (string)reader["deskripsi_keamanan"];
                        //                        tiket.wisata_id = (int)reader["wisata_id"];
                        searchResults.Add(keamanan);
                    }
                }
            }
            return searchResults;
        }
    }
}
