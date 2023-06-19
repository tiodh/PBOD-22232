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

            ShowItems();
        }

        private void DetailWisata_Load(object sender, EventArgs e)
        {

        }

        private void ShowItems()
        {
            List<Wisata> wisataList = contextWisata.ReadtoCard();
            cardDetail(wisataList);
        }

        private void cardDetail(List<Wisata> wisataList)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (Wisata w in wisataList)
            {
                DWisata dWisata = new DWisata();
                dWisata.SetData(w);
                flowLayoutPanel1.Controls.Add(dWisata);
            }
        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}