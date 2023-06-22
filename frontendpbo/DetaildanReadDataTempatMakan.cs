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

            SearchDataTempatMakantextBox1.TextChanged += SearchDataTempatMakantextBox1_TextChanged;
        }

        private void SearchDataTempatMakantextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = SearchDataTempatMakantextBox1.Text.ToLower();

            SearchLabelsInPanel(RestoRembanganpanel1, searchText);
            SearchLabelsInPanel(CafeRembanganpanel2, searchText);

            if (string.IsNullOrWhiteSpace(searchText))
            {
                semuapanel();
            }
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

        private void HapusTempatMakanbutton4_click(object sender, EventArgs e)
        {

        }
        private void SearchButtonTempatMakan_Click(object sender, EventArgs e)
        {

        }


        private void semuapanel()
        {
            RestoRembanganpanel1.Visible = true;
            CafeRembanganpanel2.Visible = true;
        }

        private void SearchLabelsInPanel(Panel panel, string searchText)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Label label)
                {
                    if (label.Text.ToLower().Contains(searchText))
                    {
                        panel.Visible = true;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }
        }
        private void CafeRembanganpanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
