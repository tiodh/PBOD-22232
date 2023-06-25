using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using frontendpbo.Helpers;
using frontendpbo.Models;

namespace frontendpbo
{
    public partial class DetailUlasan : Form
    {
        Contexts.ContextUlasan ulasanContext;
        public DetailUlasan()
        {
            InitializeComponent();
            ulasanContext = new Contexts.ContextUlasan();

            ulasanContext.Read();
            dataGridViewsShowUlasan.DataSource = ulasanContext.listUlasan;

            LoadComboBox1();


            //dgv1.Columns[0].Width = 60;
            //dgv1.Columns[1].Width = 200;
            //dgv1.Columns[2].Width = 862;
            //dgv1.Columns[3].Width = 200;

        }

        private void LoadComboBox1()
        {
            List<Wisata> namaWisataList = ulasanContext.GetNamaWisataList();

            comboBox1.DataSource = namaWisataList;
            comboBox1.ValueMember = "Id_Wisata";
            comboBox1.DisplayMember = "Nama_Wisata";
        }






        /*private void loaddata(string keyword)
        {
            string sql = "SELECT ulasan.id_ulasan, ulasan.nama_user, ulasan.deskripsi_ulasan, objek_wisata.lokasi_wisata " +
             "FROM ulasan " +
             "JOIN objek_wisata ON ulasan.wisata_id = objek_wisata.id_wisata";

            DatabaseHelpers dbHelper = new DatabaseHelpers();
            DataTable dt = new DataTable();
            

            dt = dbHelper.getData(sql);
           
            DataGridView dgv1 = dataGridViewsShowUlasan;

            dgv1.MultiSelect = false;
            dgv1.AutoGenerateColumns = true;
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv1.DataSource = dt;

            dgv1.Columns[0].HeaderText = "ID";
            dgv1.Columns[1].HeaderText = "Nama User";
            dgv1.Columns[2].HeaderText = "Deskripsi Ulasan";
            dgv1.Columns[3].HeaderText = "Lokasi Wisata";

            dgv1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //dgv1.Columns[0].Width = 60;
            //dgv1.Columns[1].Width = 200;
            //dgv1.Columns[2].Width = 862;
            //dgv1.Columns[3].Width = 200;
        }*/

        private void FormShowUlasan_Load(object sender, EventArgs e)
        {
            //LoadData("");
        }

        private void textBoxCariBerdasarkan_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxCariBerdasarkan.Text;

            if (string.IsNullOrEmpty(searchText))
            {
                dataGridViewsShowUlasan.DataSource = ulasanContext.listUlasan;
            }
            else
            {
                List<Ulasan> searchResults = ulasanContext.Search(searchText);
                dataGridViewsShowUlasan.DataSource = searchResults;

            }
        }
        private void dataGridViewsShowUlasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewsShowUlasan.Rows[e.RowIndex];

                // Mengisi data ke TextBox
                textBoxNamaPengguna.Text = selectedRow.Cells["nama_user"].Value.ToString();
                textBoxDeskripsiUlasan.Text = selectedRow.Cells["deskripsi_ulasan"].Value.ToString();

                // Menampilkan data terkait di ComboBox
                int wisataId = Convert.ToInt32(selectedRow.Cells["wisata_id"].Value);
                comboBox1.SelectedValue = wisataId;
            }
        }
    }
}
