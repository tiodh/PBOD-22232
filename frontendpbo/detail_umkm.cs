using frontendpbo;
using Npgsql;
using System.Data;

namespace tampil_data_umkm
{
    public partial class detail_umkm : Form
    {
        public detail_umkm()
        {
            InitializeComponent();
            textBox_searchumkm.TextChanged += textBox_searchumkm_TextChanged;
        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void Second_Load(object sender, EventArgs e)
        {

        }

        private void label2_umkm_Click(object sender, EventArgs e)
        {

        }

        private void txtsearchdetailumkm_TextChanged(object sender, EventArgs e)
        {
            //if (txtsearchdetailumkm.Text == ;)   
        }

        private void pu2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ink2_Click_1(object sender, EventArgs e)
        {

        }

        private void ink1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox_searchumkm_TextChanged(object sender, EventArgs e)
        {
            string searchTextumkm = textBox_searchumkm.Text.ToLower();
            Searchlabelumkm(pu1, searchTextumkm);
            Searchlabelumkm(pu2, searchTextumkm);
            Searchlabelumkm(pu3, searchTextumkm);
            Searchlabelumkm(pu4, searchTextumkm);
            Searchlabelumkm(pu5, searchTextumkm);
            Searchlabelumkm(pu6, searchTextumkm);
            Searchlabelumkm(pu7, searchTextumkm);
            Searchlabelumkm(pu8, searchTextumkm);

            if(string.IsNullOrWhiteSpace(searchTextumkm))
            {
                allpanel();
            }

        }

        private void pu1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void allpanel()
        {
            pu1.Visible = true;
            pu2.Visible = true;
            pu3.Visible = true;
            pu4.Visible = true;
            pu5.Visible = true;
            pu6.Visible = true;
            pu7.Visible = true;
            pu8.Visible = true;

        }

        private void Searchlabelumkm(Panel panel, String searchTextumkm)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Label label)
                {
                    if(label.Text.ToLower().Contains(searchTextumkm))
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

        private void pu3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pu4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pu5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pu6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pu7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pu8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_umkm_Click_1(object sender, EventArgs e)
        {

        }
    }
}