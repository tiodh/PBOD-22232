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
        public DataPengguna()
        {
            InitializeComponent();
            showDB();
        }

        void showDB()
        {
            dataGridView1.DataSource = CRU_DataPengguna.ReadData();
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
            CRU_DataPengguna.CreateData(tbNama.Text, tbUsername.Text, tbEmail.Text, tbPassword.Text);
            showDB();
            tbNama.Text = "";
            tbEmail.Text = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
        }

        private void DataPengguna_Load(object sender, EventArgs e)
        {

        }
    }
}
