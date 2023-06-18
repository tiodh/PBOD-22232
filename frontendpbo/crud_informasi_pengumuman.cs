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
    public partial class crud_informasi_pengumuman : Form
    {
        public crud_informasi_pengumuman()
        {
            InitializeComponent();
        }
        void loadgrid()
        {
            dataGridView_informasipengumuman.DataSource = Class_crud_informasi_pengumuman.read();
        }

        private void crud_informasi_pengumuman_Load(object sender, EventArgs e)
        {

        }


        private void textBox_namainformasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_deskripsiinformasi_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox_tanggalinformasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_informasipengumuman_Click(object sender, EventArgs e)
        {
            textBox_namainformasi.Text = "";
            textBox_deskripsiinformasi.Text = "";
            textBox_tanggalinformasi.Text = "";
        }

        private void create_informasipengumuman_Click(object sender, EventArgs e)
        {
            Class_crud_informasi_pengumuman.buatdata(textBox_namainformasi.Text, textBox_deskripsiinformasi.Text, Convert.ToInt32(textBox_tanggalinformasi.Text));
            loadgrid();
            textBox_namainformasi.Text = "";
            textBox_deskripsiinformasi.Text = "";
            textBox_tanggalinformasi.Text = "";
        }

        private void update_informasipengumuman_Click(object sender, EventArgs e)
        {

        }

        private void delete_informasipengumuman_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_informasipengumuman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
