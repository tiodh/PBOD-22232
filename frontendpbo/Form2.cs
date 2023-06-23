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
using tampil_data_umkm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            showSubMenu(edit1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new System.Drawing.Point(25, (panel3.Height - pictureBox1.Height) / 2);

        }

        private void showSubMenu(Button subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void showSubMenuPanel(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenuPanel(panel1);

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
            showSubMenu(edit3);
        }

        private void keamanan_Click(object sender, EventArgs e)
        {

        }

        private void penginapan_Click(object sender, EventArgs e)
        {
            showSubMenu(edit2);
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDDataPenginapan());
        }

        private void edit3_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDTransportasi());
        }

        private void tempatMakan_Click(object sender, EventArgs e)
        {
            openChildForm(new DetaildanReadDataTempatMakan());
            showSubMenu(edit4);

        }

        private void edit4_Click(object sender, EventArgs e)
        {
            openChildForm(new DeletedanUpdateDataTempatMakan());
        }

        private void saranaPrasarana_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailSarpras());
            showSubMenu(edit5);
        }

        private void edit5_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDSarana());
        }

        private void acara_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailEvent());
            showSubMenu(edit6);
        }

        private void edit6_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEditEvent());
        }

        private void umkm_Click(object sender, EventArgs e)
        {
            openChildForm(new detail_umkm());
            showSubMenu(edit7);
        }

        private void edit7_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDUmkm());

        }

        private void informasi_Click(object sender, EventArgs e)
        {
            showSubMenu(edit8);
        }

        private void edit8_Click(object sender, EventArgs e)
        {
            openChildForm(new crud_informasi_pengumuman());
        }

        private void transaksi_Click(object sender, EventArgs e)
        {
            openChildForm(new detail_umkm());
            showSubMenu(edit9);
        }

        private void keamanan_Click_1(object sender, EventArgs e)
        {
            openChildForm(new detail_dataKeselamatan());
            showSubMenu(edit10);
        }

        private void edit10_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUD_Data_Keselamatan());

        }

        private void ulasan_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailUlasan());
            showSubMenu(edit11);
        }

        private void edit11_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDUlasan());

        }
    }
}
