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
    public partial class DWisata : UserControl
    {
        public DWisata()
        {
            InitializeComponent();
        }

        public void SetData(Wisata w)
        {
            label1.Text = w.Nama_Wisata;
            label2.Text = w.Lokasi;
            label3.Text = w.Deskripsi;
        }

        private void DWisata_Load(object sender, EventArgs e)
        {

        }
    }
}
