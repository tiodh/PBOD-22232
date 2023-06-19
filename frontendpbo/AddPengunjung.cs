using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontendpbo
{
    public partial class Pengunjung : Form
    {
        public Pengunjung()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=132435;Database=peta_jember";

            using (DatabaseContext context = new DatabaseContext(connectionString))
            {
                try
                {
                    if (radioButton_Cread.Checked)
                    {
                        // Lakukan tugas yang sesuai dengan opsi Cread
                        // Contoh: Menjalankan perintah INSERT
                        string sql = "INSERT INTO pengunjung (nama_pengunjung, asal_pengunjung, wisata_id) VALUES (@nama_pengunjung, @asal_pengunjung, @wisata_id)";
                        NpgsqlParameter parameterNama = new NpgsqlParameter("@nama_pengunjung", Nama.Text);
                        NpgsqlParameter parameterDaerah = new NpgsqlParameter("@asal_pengunjung", Daerah.Text);

                        int wisataId;
                        if (int.TryParse(ID_wisata.Text, out wisataId))
                        {
                            NpgsqlParameter parameterIdWisata = new NpgsqlParameter("@wisata_id", NpgsqlTypes.NpgsqlDbType.Integer);
                            parameterIdWisata.Value = wisataId;
                            context.ExecuteCommand(sql, parameterNama, parameterDaerah, parameterIdWisata);
                        }
                        else
                        {
                            MessageBox.Show("Wisata ID harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (radioButton_Update.Checked)
                    {
                        // Lakukan tugas yang sesuai dengan opsi Update
                        // Contoh: Menjalankan perintah UPDATE
                        string sql = "UPDATE pengunjung SET nama_pengunjung = @nama_pengunjung, asal_pengunjung = @asal_pengunjung WHERE wisata_id = @wisata_id";
                        NpgsqlParameter parameterNama = new NpgsqlParameter("@nama_pengunjung", Nama.Text);
                        NpgsqlParameter parameterDaerah = new NpgsqlParameter("@asal_pengunjung", Daerah.Text);

                        int wisataId;
                        if (int.TryParse(ID_wisata.Text, out wisataId))
                        {
                            NpgsqlParameter parameterIdWisata = new NpgsqlParameter("@wisata_id", NpgsqlTypes.NpgsqlDbType.Integer);
                            parameterIdWisata.Value = wisataId;
                            context.ExecuteCommand(sql, parameterNama, parameterDaerah, parameterIdWisata);
                        }
                        else
                        {
                            MessageBox.Show("Wisata ID harus berupa angka!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        // Lakukan tugas untuk opsi lainnya
                    }

                    context.Commit();
                }
                catch (Exception ex)
                {
                    context.Rollback();
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void radioButton_Cread_CheckedChanged(object sender, EventArgs e)
        {
            panel9.Enabled = !radioButton_Cread.Checked;
        }

        private void Daerah_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        /*        private void radioButton_Cread_CheckedChanged(object sender, EventArgs e)
                {
                    panel9.Enabled = !radioButton_Cread.Checked;
                }*/

    }

    public class DatabaseContext : IDisposable
    {
        private NpgsqlConnection _connection;
        private NpgsqlTransaction _transaction;

        public DatabaseContext(string connectionString)
        {
            _connection = new NpgsqlConnection(connectionString);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        // Method untuk menjalankan perintah SQL
        public void ExecuteCommand(string sql, params NpgsqlParameter[] parameters)
        {
            using (NpgsqlCommand command = new NpgsqlCommand(sql, _connection, _transaction))
            {
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            }
        }

        // Method untuk melakukan commit transaksi
        public void Commit()
        {
            _transaction.Commit();
        }

        // Method untuk melakukan rollback transaksi
        public void Rollback()
        {
            _transaction.Rollback();
        }

        public void Dispose()
        {
            _transaction.Dispose();
            _connection.Close();
            _connection.Dispose();
        }
    }
}
