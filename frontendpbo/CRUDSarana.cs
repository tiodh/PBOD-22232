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

namespace frontendpbo
{
    public partial class CRUDSarana : Form
    {
        ContextSarana Sarana;
        private int id_sarana;
        List<SaranaPrasarana> listsarpras;

        public CRUDSarana()
        {
            InitializeComponent();
            Sarana = new ContextSarana();
        }
        public frontendpbo.Models.SaranaPrasarana GetSarana()
        {
            frontendpbo.Models.SaranaPrasarana sr = new frontendpbo.Models.SaranaPrasarana();
            sr.id_sarana = id_sarana;
            sr.nama_sarana = tbxNama.Text;
            sr.deskripsi_sarana = tbxDeskripsi.Text;
            return sr;
        }
        private void LoadData()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Host = localhost; Port = 5432; Database = Julpangmumet; Username = postgres; Password = 123"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id_sarana,nama_sarana,deskripsi_sarana FROM sarana_prasarana ORDER BY id_sarana ASC";

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
        private void simpan_Click(object sender, EventArgs e)
        {
            string Nama_sarana = tbxNama.Text;
            string Deskripsi_sarana = tbxDeskripsi.Text;

            SaranaPrasarana newSarana = new SaranaPrasarana();
            {
                newSarana.nama_sarana = Nama_sarana;
                newSarana.deskripsi_sarana = Deskripsi_sarana;
            };
            bool isSuccess = Sarana.create(newSarana);
            if (isSuccess)
            {
                MessageBox.Show("input sukses");
                LoadData();

            }
            else
            {
                MessageBox.Show("input gagal");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            id_sarana = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            tbxNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxDeskripsi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //id_w = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        }

        private void CreateSarana_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Cari_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text).Length != 0)
            {
                Sarana = new ContextSarana();
                List<SaranaPrasarana> ListSarana = Sarana.ListSarana;
                Sarana.search(textBox1.Text);
                dataGridView1.DataSource = ListSarana;
                textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("tidak ditemukan");
                LoadData();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                Sarana = new ContextSarana();
                List<SaranaPrasarana> ListSarana = Sarana.ListSarana;
                Sarana.search(textBox1.Text);
            }
            else
            {
                LoadData();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = id_sarana;
            string namaSarana = tbxNama.Text;
            string deskripsiSarana = tbxDeskripsi.Text;
            //int WisataID = id_w;
            SaranaPrasarana updatedSarana = new SaranaPrasarana
            {
                id_sarana = id,
                nama_sarana = namaSarana,
                deskripsi_sarana = deskripsiSarana,
                // Wisata_ID = WisataID,
            };
            bool isSuccess = Sarana.Update(updatedSarana);
            if (isSuccess)
            {
                MessageBox.Show("Data Telah di Update");
                LoadData();
            }
            else
            {
                MessageBox.Show("Data Gagal di Update");
            }
        }

        private void tbxNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxDeskripsi_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }
    }
}