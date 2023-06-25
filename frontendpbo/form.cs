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
    public partial class form : Form
    {
        DatabaseHelper db;
        public form()
        {
            InitializeComponent();
            ShowDataTiket();
        }

        private void ShowDataTiket()
        {
            var db = new DatabaseHelper();
            var reader = db.Select("SELECT id_tiket,nama_tiket,wisata,deskripsi_tiket,harga_tiket FROM public.tiket_wisata;");
            dataGridView1.Rows.Clear();


            while (reader.Read())
            {
                dataGridView1.Rows.Add((int)reader["id_tiket"], (string)reader["nama_tiket"], (string)reader["wisata"], (string)reader["deskripsi_tiket"], (int)reader["harga_tiket"]);
            }

            reader.Close();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var db = new DatabaseHelper();
            var reader = db.Select($"SELECT * FROM tiket_wisata WHERE nama_tiket LIKE '%{textBox1.Text}%'");
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add((int)reader["id_tiket"], (string)reader["nama_tiket"], (string)reader["wisata"], (string)reader["deskripsi_tiket"], (int)reader["harga_tiket"]);
            }
            reader.Close();
        }


        // Define a variable to store the current DataGridView style
        private DataGridViewCellStyle dataGridView2Style;
        private void StoreDataGridViewStyle()
        {
            // Store the current DataGridView style
            dataGridView2Style = dataGridView2.DefaultCellStyle.Clone();
        }

        private void RestoreDataGridViewStyle()
        {
            // Restore the stored DataGridView style
            dataGridView2.DefaultCellStyle = dataGridView2Style;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                // Menampilkan data pada button1
                DisplayHargaTiket("roda dua");
                dataGridView2.Visible = true;
                RestoreDataGridViewStyle();
            }
            else
            {
                // Menyembunyikan data pada button1
                StoreDataGridViewStyle();
                dataGridView2.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                // Menampilkan data pada button2
                DisplayHargaTiket("roda empat");
                dataGridView2.Visible = true;
                RestoreDataGridViewStyle();
            }
            else
            {
                // Menyembunyikan data pada button2
                StoreDataGridViewStyle();
                dataGridView2.Visible = false;
            }
        }

        private void DisplayHargaTiket(string jenisTiket)
        {
            var db = new DatabaseHelper();
            var reader = db.Select($"SELECT harga_tiket_parkir FROM parkir WHERE nama_tiket_parkir LIKE '{jenisTiket}'");
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();


            // Menambahkan kolom harga tiket
            dataGridView2.Columns.Add("Harga Tiket", "Harga Tiket");

            // Mengatur properti ColumnHeadersVisible menjadi false
            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.ScrollBars = ScrollBars.None;


            while (reader.Read())
            {
                var hargaTiket = reader["harga_tiket_parkir"];
                dataGridView2.Rows.Add(hargaTiket);
            }

            reader.Close();
        }
    }
}
