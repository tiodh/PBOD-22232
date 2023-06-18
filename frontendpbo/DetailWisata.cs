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
    public partial class DetailWisata : Form
    {
        ContextWisata contextWisata;
        Wisata wisata = new Wisata();
        public DetailWisata()
        {
            InitializeComponent();
            contextWisata = new Contexts.ContextWisata();
        }

        private void DetailWisata_Load(object sender, EventArgs e)
        {

        }
    }
}
