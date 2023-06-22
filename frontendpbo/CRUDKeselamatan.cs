using frontendpbo.Contexts;
using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace frontendpbo
{
    public partial class CRUD_Data_Keselamatan : Form
    {
        private int id_;
        private int id_w;

        ContextKeamanan Keamanan;
        public CRUD_Data_Keselamatan()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            id_ = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox_nama_lembaga_dataKeamanan.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxnoHp_dataKeamanan.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxalamat_dataKeamanan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxdeskripsi_dataKeamanan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            id_w = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
        }

        private void Data_Keselamatan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ReadData()
        {

        }
        private void LoadData()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Host = localhost; Port = 5432; Database = peta_jember; Username = postgres; Password = 123"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM data_keamanan ORDER BY id_keamanan ASC";

                    // Membuat objek perintah dan menentukan koneksi
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        // Membaca data dari database ke dalam DataSet
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "TabelData");

                        // Menampilkan data dalam DataGridView
                        dataGridView1.DataSource = dataSet.Tables["TabelData"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void Edit_Keamanan_Click(object sender, EventArgs e)
        {
            if (id_ == 0)
            {
                MessageBox.Show("Pilih baris dahulu", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                readKeselamatan data = new readKeselamatan();
                data.id = id_;
                data.nama = textBox_nama_lembaga_dataKeamanan.Text;
                data.deskripsi = textBoxdeskripsi_dataKeamanan.Text;
                data.alamat = textBoxalamat_dataKeamanan.Text;
                data.noTlp = textBoxnoHp_dataKeamanan.Text;

                Keamanan = new ContextKeamanan();
                Keamanan.edit(data.nama, data.deskripsi, data.alamat, data.noTlp, data.id);
                LoadData();
                textBox_nama_lembaga_dataKeamanan.Text = "";
                textBoxnoHp_dataKeamanan.Text = "";
                textBoxalamat_dataKeamanan.Text = "";
                textBoxdeskripsi_dataKeamanan.Text = "";
                dataGridView1.CurrentRow.Selected = false;




                //using (NpgsqlConnection connection = new NpgsqlConnection("Host = localhost; Port = 5432; Database = peta_jember; Username = postgres; Password = 123"))
                //{
                //    try
                //    {
                //        connection.Open();
                //        string queryupdate = $"update data_keamanan set nama_lembaga = @DataA, deskripsi_keamanan = @DataB, alamat_keamanan = @DataC, no_tlp = @DataD where id_keamanan = @ID";
                //        using (NpgsqlCommand command = new NpgsqlCommand(queryupdate, connection))
                //        {
                //            // Defina os valores dos parâmetros
                //            command.Parameters.AddWithValue("@DataA", textBox_nama_lembaga_dataKeamanan.Text);
                //            command.Parameters.AddWithValue("@DataB", textBoxnoHp_dataKeamanan.Text);
                //            command.Parameters.AddWithValue("@DataC", textBoxalamat_dataKeamanan.Text);
                //            command.Parameters.AddWithValue("@DataD", textBoxdeskripsi_dataKeamanan.Text);
                //            command.Parameters.AddWithValue("@ID", id_);
                //            command.ExecuteNonQuery();
                //        }
                //        LoadData();

                //        textBox_nama_lembaga_dataKeamanan.Text = "";
                //        textBoxnoHp_dataKeamanan.Text = "";
                //        textBoxalamat_dataKeamanan.Text = "";
                //        textBoxdeskripsi_dataKeamanan.Text = "";

                //        dataGridView1.CurrentRow.Selected = false;
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                //    }
                //}
            }
        }

        private void Tambah_Keselamatan_Click(object sender, EventArgs e)
        {
            Keamanan = new ContextKeamanan();
            Keamanan.create(textBox_nama_lembaga_dataKeamanan.Text, textBoxnoHp_dataKeamanan.Text, textBoxalamat_dataKeamanan.Text, textBoxdeskripsi_dataKeamanan.Text);
            textBox_nama_lembaga_dataKeamanan.Text = "";
            textBoxnoHp_dataKeamanan.Text = "";
            textBoxalamat_dataKeamanan.Text = "";
            textBoxdeskripsi_dataKeamanan.Text = "";
            LoadData();
            //using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=peta_jember;user id=postgres;password=123"))
            //{
            //    connection.Open();
            //    NpgsqlCommand command = connection.CreateCommand();
            //    command.Connection = connection;
            //    command.CommandText = "insert into data_keamanan(nama_keamanan, deskripsi_keamanan, alamat_keamanan, no_tlp) values(@nama_keamanan, @deskripsi_keamanan, @alamat_keamanan, @no_tlp)";
            //    command.Parameters.Add(new NpgsqlParameter("@nama_keamanan", textBox_nama_lembaga_dataKeamanan.Text));
            //    command.Parameters.Add(new NpgsqlParameter("@no_tlp", textBoxnoHp_dataKeamanan.Text));
            //    command.Parameters.Add(new NpgsqlParameter("@alamat_keamanan", textBoxalamat_dataKeamanan.Text));
            //    command.Parameters.Add(new NpgsqlParameter("@deskripsi_keamanan", textBoxdeskripsi_dataKeamanan.Text));

            //textBox_nama_lembaga_dataKeamanan.Text = "";
            //textBoxnoHp_dataKeamanan.Text = "";
            //textBoxalamat_dataKeamanan.Text = "";
            //textBoxdeskripsi_dataKeamanan.Text = "";
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //    MessageBox.Show("Data berhasil diinput");
            //    //RefreshUlasanTerakhir();
            //    //RefreshRatingTerakhir();
            //}
        }
    }
}







