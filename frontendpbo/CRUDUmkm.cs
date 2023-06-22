using frontendpbo.Contexts;
using frontendpbo.Models;
using Npgsql;
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
    public partial class CRUDUmkm : Form
    {
        Contexts.ContextUMKM contextUMKM = new Contexts.ContextUMKM();
        public int CurrentIdUMKM;
        public int CurrentWisataID;
        private List<UMKM> listumkm = new List<UMKM>() { };

        public CRUDUmkm()
        {
            InitializeComponent();
            ReadDataUMKM();
        }

        private Models.UMKM GetUMKM()
        {
            Models.UMKM umkm = new Models.UMKM();
            umkm.Id = CurrentIdUMKM;
            umkm.Name = textBox1_nama_umkm.Text;
            umkm.Description = textBox2_desk_umkm.Text;
            umkm.Pemilik_UMKM = textBox3_pemilik_umkm.Text;
            umkm.No_Telepon_UMKM = textBox4_telepon_umkm.Text;
            umkm.Wisata_ID = CurrentWisataID;

            return umkm;

        }
        private void ReadDataUMKM()
        {
            contextUMKM.listUMKM = listumkm;
            contextUMKM.Read();
            dataGridView1_umkm.DataSource = contextUMKM.listUMKM;
        }

        private void textBox1_nama_umkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void crud_umkm_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_umkm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UMKM umkm = listumkm[e.RowIndex];
            CurrentIdUMKM = umkm.Id;
            CurrentWisataID = umkm.Wisata_ID;
            textBox5_id_umkm.Text = CurrentIdUMKM.ToString();
            textBox6_wisata_id.Text = CurrentWisataID.ToString();
            textBox1_nama_umkm.Text = umkm.Name;
            textBox2_desk_umkm.Text = umkm.Description;
            textBox3_pemilik_umkm.Text = umkm.Pemilik_UMKM;
            textBox4_telepon_umkm.Text = umkm.No_Telepon_UMKM;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox6_wisata_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_id_umkm_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_clear_umkm_Click(object sender, EventArgs e)
        {
            textBox1_nama_umkm.Text = "";
            textBox2_desk_umkm.Text = "";
            textBox3_pemilik_umkm.Text = "";
            textBox4_telepon_umkm.Text = "";
            textBox5_id_umkm.Text = "";
            textBox6_wisata_id.Text = "";

        }

        private void button2_edit_umkm_Click(object sender, EventArgs e)
        {
            Models.UMKM umkm = this.GetUMKM();
            contextUMKM.edit(umkm);
            dataGridView1_umkm.DataSource = null;
            ReadDataUMKM();
            textBox1_nama_umkm.Text = "";
            textBox2_desk_umkm.Text = "";
            textBox3_pemilik_umkm.Text = "";
            textBox4_telepon_umkm.Text = "";
            textBox5_id_umkm.Text = "";
            textBox6_wisata_id.Text = "";

        }

        private void button3_read_umkm_Click(object sender, EventArgs e)
        {
            contextUMKM.listUMKM = listumkm;
            contextUMKM.Read();
            dataGridView1_umkm.DataSource = contextUMKM.listUMKM;

        }

        private void button4_add_umkm_Click(object sender, EventArgs e)
        {
            Models.UMKM umkm = this.GetUMKM();
            contextUMKM.Create(umkm);
            dataGridView1_umkm.DataSource = null;
            ReadDataUMKM();
            textBox1_nama_umkm.Text = "";
            textBox2_desk_umkm.Text = "";
            textBox3_pemilik_umkm.Text = "";
            textBox4_telepon_umkm.Text = "";
            textBox5_id_umkm.Text = "";
            textBox6_wisata_id.Text = "";

        }

    }
}

