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
    public partial class DetailInformasi : Form
    {
        ContextInformasiPengumuman contextIP;
        public DetailInformasi(int lebar)
        {
            InitializeComponent();
            TampilInformasiPengumuman(lebar);
        }
        private void TampilInformasiPengumuman(int lebar)
        {
            contextIP = new ContextInformasiPengumuman();

            // Mengakses properti ListInformasiPengumuman
            List<Pengumuman> informasiPengumuman = contextIP.ListInformasiPengumuman;
            contextIP.Read(1);
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


                panel1.Location = new Point((lebar / 6) - 170 + (550 * posisix), 30 + (360 * posisiy));
                panel1.Size = new Size(490, 300);
                panel1.BackColor = Color.AntiqueWhite;
                panel1.BackColor = Color.FromArgb(217, 217, 217);



                textBox1.Location = new Point(10, 10);
                textBox1.Size = new Size(250, 20);
                textBox1.ReadOnly = true;
                textBox1.Enabled = false;
                textBox1.Text = pengumuman.nama_informasi;
                textBox1.Font = new Font("Arial", 13);
                textBox1.BorderStyle = BorderStyle.None;
                textBox1.BackColor = Color.FromArgb(217, 217, 220);



                textBox2.Location = new Point(10, 55);
                textBox2.Size = new Size(470, 180);
                textBox2.ReadOnly = true;
                textBox2.Multiline = true;
                textBox2.Enabled = false;
                textBox2.Text = pengumuman.deskripsi_informasi;
                textBox2.Font = new Font("Arial", 13);
                textBox2.BorderStyle = BorderStyle.None;
                textBox2.BackColor = Color.FromArgb(217, 217, 220);



                textBox3.Location = new Point(370, 260);
                textBox3.Size = new Size(110, 20);
                textBox3.ReadOnly = true;
                textBox3.Enabled = false;
                textBox3.Text = pengumuman.tanggal_informasi.ToString();
                textBox3.Font = new Font("Arial", 13);
                textBox3.BorderStyle = BorderStyle.None;
                textBox3.BackColor = Color.FromArgb(217, 217, 220);


                panel1.Controls.Add(textBox1);
                panel1.Controls.Add(textBox2);
                panel1.Controls.Add(textBox3);

                this.Controls.Add(panel1);




                if (i % 2 == 0)
                    posisiy += 1;
                i++;


            }
        }
    }
}
