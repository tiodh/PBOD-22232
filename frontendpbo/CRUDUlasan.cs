using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using frontendpbo.Helpers;
using frontendpbo.Contexts;
using System.Runtime.InteropServices;
using frontendpbo.Models;
using Npgsql;

namespace frontendpbo
{

    public partial class CRUDUlasan : Form
    {

        Contexts.ContextUlasan ulasanContext;
        List<Ulasan> ulasanList;
        public CRUDUlasan()
        {
            InitializeComponent();
            ulasanContext = new Contexts.ContextUlasan();
            ulasanList = new List<Ulasan>();

            ulasanContext.Read();
            dataGridViewEditUlasan.DataSource = ulasanContext.listUlasan;

            LoadComboBox();
        }

        private Ulasan GetUlasan()
        {
            Ulasan ulasan = new Ulasan();
            ulasan.nama_user = textBoxNamaPenggunaE.Text;
            ulasan.deskripsi_ulasan = textBoxDeskripsiUlasanE.Text;
            ulasan.wisata_id = ((Wisata)comboBox1.SelectedItem).Id_Wisata;

            return ulasan;
        }

        private void LoadComboBox()
        {
            List<Wisata> namaWisataList = ulasanContext.GetNamaWisataList();

            comboBox1.DataSource = namaWisataList;
            comboBox1.ValueMember = "Id_Wisata";
            comboBox1.DisplayMember = "Nama_Wisata";
        }

        private void FormEditUlasan_Load(object sender, EventArgs e)
        {

        }

        private void FormEditUlasan_Click(object sender, EventArgs e)
        {

        }


        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Ulasan ulasan = this.GetUlasan();
            ulasanContext.Insert(ulasan);
            dataGridViewEditUlasan.DataSource = null;
            dataGridViewEditUlasan.DataSource = ulasanList;

            ulasanContext.Read();
            dataGridViewEditUlasan.DataSource = ulasanContext.listUlasan;
        }

        private void dataGridViewEditUlasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewEditUlasan.Rows[e.RowIndex];

                // Mengisi data ke TextBox
                textBoxNamaPenggunaE.Text = selectedRow.Cells["nama_user"].Value.ToString();
                textBoxDeskripsiUlasanE.Text = selectedRow.Cells["deskripsi_ulasan"].Value.ToString();

                // Menampilkan data terkait di ComboBox
                int wisataId = Convert.ToInt32(selectedRow.Cells["wisata_id"].Value);
                comboBox1.SelectedValue = wisataId;
            }
        }

        private void RefreshDataGridView()
        {
            dataGridViewEditUlasan.DataSource = null;
            dataGridViewEditUlasan.DataSource = ulasanList;

            ulasanContext.Read();
            dataGridViewEditUlasan.DataSource = ulasanContext.listUlasan;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEditUlasan.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewEditUlasan.SelectedRows[0];

                // Dapatkan objek Ulasan dari baris yang dipilih
                Ulasan selectedUlasan = selectedRow.DataBoundItem as Ulasan;

                // Hapus data dari database menggunakan ContextUlasan
                ulasanContext.Delete(selectedUlasan.id_ulasan);

                // Hapus objek Ulasan dari sumber data (BindingList)
                ulasanList.Remove(selectedUlasan);

                RefreshDataGridView();
            }
        }

        private void buttonSearchE_Click(object sender, EventArgs e)
        {
            List<Ulasan> cari = ulasanContext.Search(buttonSearchE.Text);
            dataGridViewEditUlasan.DataSource = cari;
        }

        private void textBoxCariBerdasarkanE_TextChanged(object sender, EventArgs e)
        {
           
                string searchText = textBoxCariBerdasarkanE.Text;

                if (string.IsNullOrEmpty(searchText))
                {
                    dataGridViewEditUlasan.DataSource = ulasanContext.listUlasan;
                }
                else
                {
                    List<Ulasan> searchResults = ulasanContext.Search(searchText);
                    dataGridViewEditUlasan.DataSource = searchResults;
                }
            
        }
    }
}
