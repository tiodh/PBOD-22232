using frontendpbo.Contexts;
using frontendpbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
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
        private List<Wisata> listWisata;
        private List<Wisata> searchResults;
        public wisata()
        {
            InitializeComponent();
            contextWisata = new ContextWisata();

            ReadData();
            datagridcrudwisata1.DataSource = contextWisata.GetListWisata();
        }

        private void ReadData()
        {
            contextWisata.Read();
            datagridcrudwisata1.DataSource = contextWisata.listWisata;
        }

        private void Clear()
        {
            textBox1_Nama_Wisata.Text = "";
            textBox2_Deskripsi_Wisata.Text = "";
            textBox3_Lokasi_Wisata.Text = "";
        }

        public Models.Wisata GetWisata()
        {
            Models.Wisata wst = new Models.Wisata();
            wst.Nama_Wisata = textBox1_Nama_Wisata.Text;
            wst.Deskripsi = textBox2_Deskripsi_Wisata.Text;
            wst.Lokasi = textBox3_Lokasi_Wisata.Text;

            return wst;
        }

        private void wisata_Load(object sender, EventArgs e)
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
            Models.Wisata wisatas = this.GetWisata();
            contextWisata.Insert(wisatas);
            datagridcrudwisata1.DataSource = null;
            ReadData();
            Clear();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            List<Wisata> searchResults = contextWisata.Search(textBox1.Text);
            datagridcrudwisata1.DataSource = searchResults;
        }

    }
}
