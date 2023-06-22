using System;
using frontendpbo.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace frontendpbo.Contexts
{
    internal class ContextPengunjung
    {
        private string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=peta_jember;";

        public DataTable Read()
        {
            DataTable dt = new DataTable();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string strSql = "SELECT * FROM Pengunjung";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(strSql, connection))
                    {
                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }

        public void Create(Pengunjung pengunjung)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string strSql = "INSERT INTO Pengunjung (Id, Name, Asal, Wisata_ID) VALUES (@Id, @Name, @Asal, @Wisata_ID)";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(strSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", pengunjung.Id);
                        cmd.Parameters.AddWithValue("@Name", pengunjung.Name);
                        cmd.Parameters.AddWithValue("@Asal", pengunjung.Asal);
                        cmd.Parameters.AddWithValue("@Wisata_ID", pengunjung.Wisata_ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(Pengunjung pengunjung)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string strSql = "UPDATE Pengunjung SET Name = @Name, Asal = @Asal, Wisata_ID = @Wisata_ID WHERE Id = @Id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(strSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Id", pengunjung.Id);
                        cmd.Parameters.AddWithValue("@Name", pengunjung.Name);
                        cmd.Parameters.AddWithValue("@Asal", pengunjung.Asal);
                        cmd.Parameters.AddWithValue("@Wisata_ID", pengunjung.Wisata_ID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string strSql = "SELECT * FROM Pengunjung WHERE Name ILIKE @Keyword OR Asal ILIKE @Keyword";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(strSql, connection))
                    {
                        cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");
                        using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt;
        }
    }
}
