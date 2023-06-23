using CUD_DataTiket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontendpbo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void wisata_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailWisata());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new System.Drawing.Point(25, (panel3.Height - pictureBox1.Height) / 2);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new DataPengguna());
        }

        private void edit9_Click(object sender, EventArgs e)
        {
            openChildForm(new EditTiketing());
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 60;
            int width = panel3.Width;
            int height = panel3.Height;

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(width - cornerRadius, height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            path.CloseFigure();

            panel3.Region = new Region(path);
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginAdmin form = new LoginAdmin();
            form.ShowDialog();
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            openChildForm(new wisata());
        }

        private void transportasi_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailTransportasi());
        }

        private void keamanan_Click(object sender, EventArgs e)
        {

        }

        private void informasi_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailInformasi(panelContent.Width));
        }

        private void edit10_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUD_Data_Keselamatan());
            
        }
    }
}
