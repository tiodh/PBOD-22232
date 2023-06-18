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

namespace frontendpbo
{
    public partial class wisata : Form
    {
        ContextWisata contextWisata;
        Wisata wisatas = new Wisata();

        public wisata()
        {
            InitializeComponent();
            contextWisata = new Contexts.ContextWisata();
        }
        private Models.Wisata DataWisata()
        {
            wisatas.Nama_Wisata = textBox1_Nama_Wisata.Text;
            wisatas.Deskripsi = textBox2_Deskripsi_Wisata.Text;
            wisatas.Lokasi = textBox3_Lokasi_Wisata.Text;

            return wisatas;
        }

        private void wisata_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagridwisata1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclearwisata_Click(object sender, EventArgs e)
        {

        }

        private void label2_Deskripsi_Click(object sender, EventArgs e)
        {

        }

        private void btntambahwisata_Click(object sender, EventArgs e)
        {
            Models.Wisata wisata = this.DataWisata();
            contextWisata.insert(wisata);
            // menampilkan data list mahasiswa dalam DataGridView
            datagridcrudwisata1.DataSource = null;
            datagridcrudwisata1.DataSource = contextWisata.listWisata;
        }
    }
}
