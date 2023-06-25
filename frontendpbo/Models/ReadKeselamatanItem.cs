using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    internal class ReadKeselamatanItem
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailKeselamatan));
        Panel panelDetail = new Panel();
        Label lbDeskripsi = new Label();
        Label lbAlamat = new Label();       
        Label lbNomor = new Label();
        Label lbNama = new Label();
        PictureBox pbIcon = new PictureBox();

        public ReadKeselamatanItem(string nama, string noTlp, string alamat, string deskripsi)
        {
            panelDetail.BackColor = SystemColors.ButtonFace;
            panelDetail.Controls.Add(lbDeskripsi);
            panelDetail.Controls.Add(lbAlamat);
            panelDetail.Controls.Add(lbNomor);
            panelDetail.Controls.Add(lbNama);
            panelDetail.Controls.Add(pbIcon);
            panelDetail.Location = new Point(3, 3);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(1264, 240);
            panelDetail.TabIndex = 6;
            
            // 
            // lbDeskripsi
            // 
            lbDeskripsi.AutoSize = true;
            lbDeskripsi.Location = new Point(387, 169);
            lbDeskripsi.Name = "lbDeskripsi";
            lbDeskripsi.Size = new Size(69, 20);
            lbDeskripsi.TabIndex = 9;
            lbDeskripsi.Text = "Deskripsi";
            
            // 
            // lbAlamat
            // 
            lbAlamat.AutoSize = true;
            lbAlamat.Location = new Point(387, 128);
            lbAlamat.Name = "lbAlamat";
            lbAlamat.Size = new Size(57, 20);
            lbAlamat.TabIndex = 8;
            lbAlamat.Text = "Alamat";
            
            // 
            // lbNomor
            // 
            lbNomor.AutoSize = true;
            lbNomor.Location = new Point(387, 90);
            lbNomor.Name = "lbNomor";
            lbNomor.Size = new Size(86, 20);
            lbNomor.TabIndex = 7;
            lbNomor.Text = "No Telepon";
            
            // 
            // lbNama
            // 
            lbNama.AutoSize = true;
            lbNama.Location = new Point(387, 52);
            lbNama.Name = "lbNama";
            lbNama.Size = new Size(115, 20);
            lbNama.TabIndex = 6;
            lbNama.Text = "Nama Lembaga";
            // 
            // pbIcon
            // 
            pbIcon.Dock = DockStyle.Left;
            pbIcon.Image = Properties.Resources.shield_safe_secure_safety_protection_security_tick_icon_224700;
            pbIcon.Location = new Point(0, 0);
            pbIcon.Name = "pbIcon";
            pbIcon.Size = new Size(330, 240);
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.TabIndex = 0;
            pbIcon.TabStop = false;

            lbNama.Text = nama;
            lbNomor.Text = noTlp;
            lbAlamat.Text = alamat;
            lbDeskripsi.Text = deskripsi;
        }
        public Panel CreateItem()
        {
            return panelDetail;
        }

    }
}
