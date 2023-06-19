using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CUD_DataTiket.CUDEditTiket;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frontendpbo
{
    public partial class DataPengguna : Form
    {
        public int idadmin;
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

        private void btnCreateDataPengguna_Click(object sender, EventArgs e)
        {
            CRU_DataPengguna.CreateData(tbNama.Text, tbUsername.Text, tbEmail.Text, tbPassword.Text);
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

        private void btnUpdateDataPengguna_Click(object sender, EventArgs e)
        {
            CRU_DataPengguna.UpdateData(tbNama.Text, tbEmail.Text, tbUsername.Text, tbPassword.Text, idadmin);
            showDB();
            tbPassword.Visible = false;
            label5.Visible = false;
            tbNama.Text = "";
            tbEmail.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void DGVdataPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbPassword.Visible = true;
            label5.Visible = true;
            DGVdataPengguna.CurrentRow.Selected = true;
            idadmin = Convert.ToInt32(DGVdataPengguna.Rows[e.RowIndex].Cells[0].Value);
            tbNama.Text = DGVdataPengguna.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbEmail.Text = DGVdataPengguna.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbUsername.Text = DGVdataPengguna.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbPassword.Text = DGVdataPengguna.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void tbSearchDataPengguna_Click(object sender, EventArgs e)
        {
            tbSearchDataPengguna.Text = "";
        }

    }
}
