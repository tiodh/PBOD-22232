﻿using CUD_DataTiket;
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

namespace frontendpbo
{
    public partial class Form2 : Form
    {
        private string pengguna;
        private Form activeForm = null;
        public Form2(string pngna)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            if (pngna != "user" )
            {
                Button logout = new Button();
                logout.Text = "Log Out";
                logout.Font = new Font("Roboto", 12);
                logout.BringToFront();
                logout.Dock = DockStyle.Right;
                logout.FlatStyle = FlatStyle.Flat;
                logout.FlatAppearance.BorderSize = 0;
                logout.Click += (sender, e) =>
                {
                    pengguna = "user";
                    logout.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;
                    panel1.Visible = false;
                };
                panel3.Controls.Add(logout);
            }
            else
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
            }
            pengguna = pngna;
            panel1.Visible = false;
            edit1.Visible = false;
            edit2.Visible = false;
            edit3.Visible = false;
            editTempatMakan.Visible = false;
            editSarana.Visible = false;
            editEvent.Visible = false;
            edit7.Visible = false;
            edit8.Visible = false;
            edit9.Visible = false;
            edit10.Visible = false;
            edit11.Visible = false;
            MinimizeBox = false;
            MaximizeBox = false;
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

        private void wisata_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailWisata());
            showSubMenu(edit1);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void showSubMenu(Button subMenu)
        {
            if (subMenu.Visible == false && pengguna != "user")
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
            this.Close();
            //Form1 form = new Form1();
            //form.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginAdmin form = new LoginAdmin();
            form.ShowDialog();
        }

        private void transportasi_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailTransportasi());
            showSubMenu(edit3);
        }


        private void penginapan_Click(object sender, EventArgs e)
        {
            //openChildForm(new ); Belum Ada Form Detail
            showSubMenu(edit2);
        }


        private void tempatMakan_Click(object sender, EventArgs e)
        {
            showSubMenu(editTempatMakan);
            openChildForm(new DetaildanReadDataTempatMakan());


        }

        private void edit4_Click(object sender, EventArgs e)
        {
            openChildForm(new DeletedanUpdateDataTempatMakan());
        }

        private void saranaPrasarana_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailSarpras());
            showSubMenu(editSarana);

        }

        private void edit5_Click(object sender, EventArgs e)
        {
            openChildForm(new CRUDSarana());
        }

        private void acara_Click(object sender, EventArgs e)
        {
            showSubMenu(editEvent);
            openChildForm(new DetailEvent());

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


        private void informasi_Click(object sender, EventArgs e)
        {
            showSubMenu(edit8);
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


        private void edit1_Click_1(object sender, EventArgs e)
        {
            openChildForm(new wisata());
        }

        private void edit2_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CRUDDataPenginapan());
        }

        private void edit3_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CRUDTransportasi());

        }

        private void editTempatMakan_Click(object sender, EventArgs e)
        {
            openChildForm(new DetaildanReadDataTempatMakan());
        }

        private void editSarana_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailSarpras());
        }

        private void editEvent_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEditEvent());
        }

        private void edit7_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CRUDUmkm());
        }

        private void edit8_Click_1(object sender, EventArgs e)
        {
            openChildForm(new crud_informasi_pengumuman());

        }

        private void edit11_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CRUDUlasan());
        }

        private void umkm_Click_1(object sender, EventArgs e)
        {
            showSubMenu(edit7);
            openChildForm(new detail_umkm());

        }

        private void transaksi_Click_1(object sender, EventArgs e)
        {
            showSubMenu(edit7);
            openChildForm(new DetailTiket());

        }

        private void ulasan_Click_1(object sender, EventArgs e)
        {
            showSubMenu(edit11);
            openChildForm(new DetailUlasan());

        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new CUR_Pengunjung());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new DetailRiwayatKunjungan());

        }
    }
}
