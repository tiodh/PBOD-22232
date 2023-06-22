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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics.CodeAnalysis;


namespace frontendpbo
{
    public partial class DetailTiket : Form
    {
        ContextTiket contextTiket;
        private List<Tiket> listTiket;
        private List<Tiket> searchResults;

        public DetailTiket()
        {
            InitializeComponent();
            contextTiket = new ContextTiket();
        }
        private void FormDetailDataTiket_Load(object sender, EventArgs e)
        {
            PanelReadDataTiket.Dock = DockStyle.Fill;
            ReadData();
            DataGridViewTiket.DataSource = contextTiket.GetListTiket();
            pictureBoxKendaraan.Image = imageListKendaraan.Images[0];
            pictureBoxNamaTiket.Image = imageListDetailTiket.Images[0];
        }
        private void ReadData()
        {
            contextTiket.Read();
            DataGridViewTiket.DataSource = contextTiket.listTiket;
            DataGridViewTiket.Columns[4].Visible = false;
        }

        private void radioButtonRoda2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxKendaraan.Image = imageListKendaraan.Images[1];

            if (radioButtonRoda2.Checked)
            {
                int hargaTiket = contextTiket.GetHargaTiketByRoda(2);
                textBoxTiketParkir.Text = hargaTiket.ToString();
            }
        }

        private void radioButtonRoda4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxKendaraan.Image = imageListKendaraan.Images[2];

            if (radioButtonRoda4.Checked)
            {
                int hargaTiket = contextTiket.GetHargaTiketByRoda(4);
                textBoxTiketParkir.Text = hargaTiket.ToString();
            }
        }


        private void SearchTiket_TextChanged(object sender, EventArgs e)
        {
            string kolom = KolomTiket.Text;

            if (kolom == "id_tiket")
            {
                List<Tiket> searchResults = contextTiket.Search(SearchTiket.Text, kolom);
                DataGridViewTiket.DataSource = searchResults;
            }
            else if (kolom == "nama_tiket")
            {
                List<Tiket> searchResults = contextTiket.Search(SearchTiket.Text, kolom);
                DataGridViewTiket.DataSource = searchResults;
            }
            else if (kolom == "deskripsi_tiket")
            {
                List<Tiket> searchResults = contextTiket.Search(SearchTiket.Text, kolom);
                DataGridViewTiket.DataSource = searchResults;
            }
            else if (kolom == "harga_tiket")
            {
                List<Tiket> searchResults = contextTiket.Search(SearchTiket.Text, kolom);
                DataGridViewTiket.DataSource = searchResults;
            }
            else if (kolom == "wisata_id")
            {
                List<Tiket> searchResults = contextTiket.Search(SearchTiket.Text, kolom);
                DataGridViewTiket.DataSource = searchResults;
            }

        }

        private void DataGridViewTiket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = DataGridViewTiket;

                IDTiket.Text = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);
                NamaTiket.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                DeskTiket.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                HargaTiket.Text = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
            }
        }

        private void btnClearTket_Click(object sender, EventArgs e)
        {
            ReadData();
            DataGridViewTiket.DataSource = contextTiket.GetListTiket();
            SearchTiket.Text = "";
            KolomTiket.Text = "";
        }

        private void InformationTiketPopUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klik salah satu data pada tabel untuk melihat detail data secara lengkap.", "Informasi Detail Tiket",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
