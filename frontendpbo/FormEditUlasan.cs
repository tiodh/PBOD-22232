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

using System.Runtime.InteropServices;

namespace frontendpbo
{
    public partial class FormEditUlasan : Form
    {

        private string id = "";
        private int intRow = 0;

        public FormEditUlasan()
        {
            InitializeComponent();
        }

        private void FormEditUlasan_Load(object sender, EventArgs e)
        {
            LoadData("");
        }

        private void LoadData(string keyword)
        {
            string sql = "SELECT ulasan.id_ulasan, ulasan.nama_user, ulasan.deskripsi_ulasan, objek_wisata.lokasi_wisata " +
             "FROM ulasan " +
             "JOIN objek_wisata ON ulasan.wisata_id = objek_wisata.id_wisata";


            DatabaseHelpers dbHelper = new DatabaseHelpers();
            DataTable dt = dbHelper.getData(sql);

            DataGridView dgv1 = dataGridViewEditUlasan;

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
        }

        private void resetMe()
        {
            this.id = string.Empty;
            textBoxNamaPenggunaE.Text = "";
            

            //updateButton.Text = "Update";
            //deleteButton.Text = "Delete";
        }

        private void dataGridViewEditUlasan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = dataGridViewEditUlasan;

                this.id = Convert.ToString(dgv1.CurrentRow.Cells[0].Value);


                

                textBoxNamaPenggunaE.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                textBoxDeskripsiUlasanE.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);

            }
        }
    }
}
