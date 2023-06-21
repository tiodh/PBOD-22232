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
    public partial class DataPengguna : Form
    {
        private int idadmin;
        public DataPengguna()
        {
            InitializeComponent();
            showDB();
        }

        void showDB()
        {
            tbPassword.Visible = false;
            label5.Visible = false;
            DGVdataPengguna.DataSource = CRU_DataPengguna.ReadData();
            DGVdataPengguna.Columns[4].Visible = false;

        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            CRU_DataPengguna.Create_Data_Pengguna(tbNama.Text, tbUsername.Text, tbEmail.Text, tbPassword.Text);
            showDB();
            tbNama.Text = "";
            tbEmail.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void tbSearchDataPengguna_TextChanged(object sender, EventArgs e)
        {
            ConnectDB koneksidb = new ConnectDB();
            string searchText = tbSearchDataPengguna.Text.Trim();
            string search = $"SELECT * FROM admin WHERE nama_lengkap ILIKE '%{searchText}%' " +
                               $"OR username ILIKE '%{searchText}%' " +
                               $"OR email_admin ILIKE '%{searchText}%' ";
            DGVdataPengguna.DataSource = koneksidb.ExecuteSQL(search);
        }

        private void DGVDataPengguna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CRU_DataPengguna.UpdateData(tbEmail.Text, tbNama.Text, tbUsername.Text, tbPassword.Text, idadmin);
            showDB();
            tbPassword.Visible = false;
            label5.Visible = false;
            tbNama.Text = "";
            tbEmail.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void tbSearchDataPengguna_Click(object sender, EventArgs e)
        {
            tbSearchDataPengguna.Text = "";
        }

        private void DGVdataPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPassword.Visible = true;
            label5.Visible = true;
            DGVdataPengguna.CurrentRow.Selected = true;
            idadmin = Convert.ToInt32(DGVdataPengguna.Rows[e.RowIndex].Cells[0].Value);
            tbEmail.Text = DGVdataPengguna.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbNama.Text = DGVdataPengguna.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbUsername.Text = DGVdataPengguna.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbPassword.Text = DGVdataPengguna.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
