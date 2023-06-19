using frontendpbo.Contexts;
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
        public wisata()
        {
            InitializeComponent();
            contextWisata = new ContextWisata();

            contextWisata.Read();
            datagridcrudwisata1.DataSource = contextWisata.listWisata;
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

        }
    }
}
