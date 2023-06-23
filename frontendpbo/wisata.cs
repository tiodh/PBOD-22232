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
        public List<Wisata> listWisatas = new List<Wisata>();

        public int CurrentID;

        public wisata()
        {
            InitializeComponent();
            datagridcrudwisata1.AutoGenerateColumns = false;
            contextWisata = new ContextWisata();

            ReadData();
        }

        private void ReadData()
        {
            contextWisata.listWisata = listWisatas;
            contextWisata.Read();
            datagridcrudwisata1.DataSource = contextWisata.listWisata;
        }

        private void Clear()
        {
            textBox1_Nama_Wisata.Text = "";
            textBox2_Deskripsi_Wisata.Text = "";
            textBox3_Lokasi_Wisata.Text = "";
            CurrentID = 0;
        }

        public Models.Wisata GetWisata()
        {
            Models.Wisata wst = new Models.Wisata();
            wst.Id_Wisata = CurrentID;
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
            if (datagridcrudwisata1.Columns[e.ColumnIndex].Name == "Edit")
            {
                Wisata wisata = listWisatas[e.RowIndex];
                CurrentID = wisata.Id_Wisata;
                textBox1_Nama_Wisata.Text = wisata.Nama_Wisata;
                textBox2_Deskripsi_Wisata.Text = wisata.Deskripsi;
                textBox3_Lokasi_Wisata.Text = wisata.Lokasi;
            }
        }

        private void btnclearwisata_Click(object sender, EventArgs e)
        {

        }

        private void label2_Deskripsi_Click(object sender, EventArgs e)
        {

        }

        private void btntambahwisata_Click(object sender, EventArgs e)
        {
            if (CurrentID > 0)
            {
                Models.Wisata wisatas = this.GetWisata();
                contextWisata.Update(wisatas);
                datagridcrudwisata1.DataSource = null;
                ReadData();
                Clear();
            }
            else
            {
                Models.Wisata wisatas = this.GetWisata();
                contextWisata.Insert(wisatas);
                datagridcrudwisata1.DataSource = null;
                ReadData();
                Clear();

            }

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            List<Wisata> searchResults = contextWisata.Search(textBox1.Text);
            datagridcrudwisata1.DataSource = searchResults;
        }

        private void btnhapuswisata_Click(object sender, EventArgs e)
        {

        }
    }
}
