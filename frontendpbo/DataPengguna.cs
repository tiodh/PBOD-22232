using frontendpbo.Contexts;
using frontendpbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frontendpbo
{
    public partial class DataPengguna : Form
    {
        Contexts.ContextPengguna contextPengguna = new Contexts.ContextPengguna();
        public int CurrentIdAdmin;
        private List<Pengguna> listPengguna = new List<Pengguna>() { };
        private List<Pengguna> searchresult = new List<Pengguna>() { };

        public DataPengguna()
        {
            InitializeComponent();
            ReadDataPengguna();
        }
        private void SetDataGrid()
        {
            DGVdataPengguna.Columns["id_admin"].HeaderText = "Id Admin";
            DGVdataPengguna.Columns["email"].HeaderText = "Email Admin";
            DGVdataPengguna.Columns["nama_lengkap"].HeaderText = "Nama Lengkap";
            DGVdataPengguna.Columns["username"].HeaderText = "Username";
            DGVdataPengguna.Columns["password"].HeaderText = "Password";
        }
        private Models.Pengguna GetPengguna()
        {
            Models.Pengguna pengguna = new Models.Pengguna();
            pengguna.Id_Admin = CurrentIdAdmin;
            pengguna.Email = tbEmail.Text;
            pengguna.Nama_Lengkap = tbNama.Text;
            pengguna.Username = tbUsername.Text;
            pengguna.Password = tbPassword.Text;

            return pengguna;
        }
        private void ReadDataPengguna()
        {

            contextPengguna.listPengguna = listPengguna;
            contextPengguna.Read();
            DGVdataPengguna.DataSource = contextPengguna.listPengguna;
            SetDataGrid();
        }
        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            Models.Pengguna pengguna = this.GetPengguna();
            contextPengguna.Create(pengguna);
            DGVdataPengguna.DataSource = null;
            ReadDataPengguna();
            tbEmail.Text = "";
            tbNama.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Models.Pengguna pengguna = this.GetPengguna();
            contextPengguna.Update(pengguna);
            DGVdataPengguna.DataSource = null;
            ReadDataPengguna();
            tbEmail.Text = "";
            tbNama.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";

        }
        private void DGVDataPengguna_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Pengguna pengguna = listPengguna[e.RowIndex];
            CurrentIdAdmin = pengguna.Id_Admin;
            tbEmail.Text = pengguna.Email;
            tbNama.Text = pengguna.Nama_Lengkap;
            tbUsername.Text = pengguna.Username;
            tbPassword.Text = pengguna.Password;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEmail.Text = "";
            tbNama.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void tbSearchDataPengguna_TextChanged(object sender, EventArgs e)
        {
            if (tbSearchDataPengguna.Text == "")
            {
                ReadDataPengguna();
            }

            else;
            {
                List<Pengguna> cari = contextPengguna.Search(tbSearchDataPengguna.Text);
                DGVdataPengguna.DataSource = cari;
                SetDataGrid();
            }
            
        }

        private void tbSearchDataPengguna_Click(object sender, EventArgs e)
        {
            tbSearchDataPengguna.Text = "";
        }
    }

}
