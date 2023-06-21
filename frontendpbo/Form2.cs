using CUD_DataTiket;
using frontendpbo.Contexts;
using frontendpbo.Models;
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
        ContextInformasiPengumuman contextIP;
        private Form activeForm = null;
        public Form2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void TampilInformasiPengumuman()
        {
            if (activeForm != null) activeForm.Close();

            contextIP = new ContextInformasiPengumuman();

            // Mengakses properti ListInformasiPengumuman
            List<Pengumuman> informasiPengumuman = contextIP.ListInformasiPengumuman;
            contextIP.Read();
            //List<string> data = contextIP.Pengumuman;
            int i = 1;
            int posisiy = 0;
            int posisix = 0;
            foreach (Pengumuman pengumuman in informasiPengumuman)
            {
                if (i % 2 == 0)
                {
                    posisix = 1;
                }

                else
                {
                    posisix = 0;
                }

                Panel panel1 = new Panel();
                TextBox textBox1 = new TextBox();
                TextBox textBox2 = new TextBox();
                TextBox textBox3 = new TextBox();


                panel1.Location = new Point(500 + (550 * posisix), 100 + (360 * posisiy));
                panel1.Size = new Size(490, 300);
                panel1.BackColor = Color.AntiqueWhite;
                panel1.BackColor = Color.FromArgb(217, 217, 217);



                textBox1.Location = new Point(10, 10);
                textBox1.Size = new Size(250, 20);
                textBox1.ReadOnly = true;
                textBox1.Enabled = false;
                textBox1.Text = pengumuman.Name;
                textBox1.Font = new Font("Arial", 13);
                textBox1.BorderStyle = BorderStyle.None;
                textBox1.BackColor = Color.FromArgb(217, 217, 220);



                textBox2.Location = new Point(10, 55);
                textBox2.Size = new Size(470, 180);
                textBox2.ReadOnly = true;
                textBox2.Multiline = true;
                textBox2.Enabled = false;
                textBox2.Text = pengumuman.Description;
                textBox2.Font = new Font("Arial", 13);
                textBox2.BorderStyle = BorderStyle.None;
                textBox2.BackColor = Color.FromArgb(217, 217, 220);



                textBox3.Location = new Point(370, 260);
                textBox3.Size = new Size(110, 20);
                textBox3.ReadOnly = true;
                textBox3.Enabled = false;
                textBox3.Text = pengumuman.Tanggal_Informasi.ToString();
                textBox3.Font = new Font("Arial", 13);
                textBox3.BorderStyle = BorderStyle.None;
                textBox3.BackColor = Color.FromArgb(217, 217, 220);


                panel1.Controls.Add(textBox1);
                panel1.Controls.Add(textBox2);
                panel1.Controls.Add(textBox3);
                panelContent.Controls.Add(panel1);
                this.Controls.Add(panelContent);




                if (i % 2 == 0)
                    posisiy += 1;
                i++;


            }
        }

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

        private void informasi_Click(object sender, EventArgs e)
        {
            TampilInformasiPengumuman();
        }
    }
}
