using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tampil_data_umkm
{

    public partial class jenis_umkm : Form
    {
        bool sidebarExpand;
        public jenis_umkm()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void first_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            detail_umkm secondForm = new detail_umkm();
            secondForm.Show();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void umkm1_Click(object sender, EventArgs e)
        {

        }

        private void umkm2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sidebartick(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
