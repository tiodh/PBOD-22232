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
    public partial class crud_umkm : Form
    {
        public crud_umkm()
        {
            InitializeComponent();
        }
        void loadgrid()
        {
            dataGridView1_umkm.DataSource = Class_crud_umkm.read();
        }
        private void textBox1_nama_umkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void crud_umkm_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void textBox2_desk_umkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_pemilik_umkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_telepon_umkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_umkm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_clear_umkm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_read_umkm_Click(object sender, EventArgs e)
        {

        }

        private void button5_edit_umkm_Click(object sender, EventArgs e)
        {

        }

        private void button2_add_umkm_Click(object sender, EventArgs e)
        {
            Class_crud_umkm.made(Convert.ToInt32(textBox5_id_umkm.Text), textBox1_nama_umkm.Text, textBox2_desk_umkm.Text, textBox3_pemilik_umkm.Text, textBox4_telepon_umkm.Text);
            loadgrid();
            textBox5_id_umkm.Text = "";
            textBox1_nama_umkm.Text = "";
            textBox2_desk_umkm.Text = "";
            textBox3_pemilik_umkm.Text = "";
            textBox4_telepon_umkm.Text = "";
        }

        private void dataGridView1_umkm_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_id_umkm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
