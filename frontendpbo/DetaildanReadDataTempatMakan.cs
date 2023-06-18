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
    public partial class DetaildanReadDataTempatMakan : Form
    {
        public DetaildanReadDataTempatMakan()
        {
            InitializeComponent();
        }

        private void SearchDataTempatMakantextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RestoRembanganpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LokasiRestoRembanganlabel2_Click(object sender, EventArgs e)
        {

        }

        private void RestoRembanganTempatMakanpictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DetaildanReadDataTempatMakan_Load(object sender, EventArgs e)
        {

        }

        private void SearchButtonTempatMakan_Click(object sender, EventArgs e)
        {
            string keyword = SearchDataTempatMakantextBox1.Text.ToLower();

            bool labelFound = false;
            foreach (Label label in CafeRembanganpanel2.Controls.OfType<Label>())
            {
                bool match = label.Text.ToLower().Contains(keyword);
                label.Visible = match;

                if (match)
                {
                    labelFound = true;
                }
                else
                {
                    Panel panel = label.Parent as Panel;
                    if (panel != null)
                    {
                        panel.Visible = false;
                    }
                }
            }

        }

    }
}
