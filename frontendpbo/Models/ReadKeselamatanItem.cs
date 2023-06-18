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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detail_dataKeselamatan));
        Panel panelDetail = new Panel();
        Panel panelDeskripsi = new Panel();
        Label lbDeskripsi = new Label();
        Panel panelAlamat = new Panel();
        Label lbAlamat = new Label();
        Panel panelNomor = new Panel();
        Label lbNomor = new Label();
        Panel panelNama = new Panel();
        Label lbNama = new Label();
        PictureBox pbIcon = new PictureBox();

        public ReadKeselamatanItem(string nama, string noTlp, string alamat, string deskripsi)
        {
            panelDetail.BackColor = SystemColors.ButtonFace;
            panelDetail.Controls.Add(panelDeskripsi);
            panelDetail.Controls.Add(panelAlamat);
            panelDetail.Controls.Add(panelNomor);
            panelDetail.Controls.Add(panelNama);
            panelDetail.Controls.Add(pbIcon);
            panelDetail.Location = new Point(3, 3);
            panelDetail.Name = "panelDetail";
            panelDetail.Size = new Size(1264, 240);
            panelDetail.TabIndex = 6;
            // 
            // panelDeskripsi
            // 
            panelDeskripsi.BackColor = SystemColors.Window;
            panelDeskripsi.Controls.Add(lbDeskripsi);
            panelDeskripsi.Location = new Point(374, 170);
            panelDeskripsi.Name = "panelDeskripsi";
            panelDeskripsi.Size = new Size(850, 27);
            panelDeskripsi.TabIndex = 5;
            // 
            // lbDeskripsi
            // 
            lbDeskripsi.AutoSize = true;
            lbDeskripsi.Location = new Point(15, 3);
            lbDeskripsi.Name = "lbDeskripsi";
            lbDeskripsi.Size = new Size(69, 20);
            lbDeskripsi.TabIndex = 0;
            lbDeskripsi.Text = "Deskripsi";
            // 
            // panelAlamat
            // 
            panelAlamat.BackColor = SystemColors.Window;
            panelAlamat.Controls.Add(lbAlamat);
            panelAlamat.Location = new Point(374, 125);
            panelAlamat.Name = "panelAlamat";
            panelAlamat.Size = new Size(850, 27);
            panelAlamat.TabIndex = 4;
            // 
            // lbAlamat
            // 
            lbAlamat.AutoSize = true;
            lbAlamat.Location = new Point(15, 3);
            lbAlamat.Name = "lbAlamat";
            lbAlamat.Size = new Size(57, 20);
            lbAlamat.TabIndex = 0;
            lbAlamat.Text = "Alamat";
            // 
            // panelNomor
            // 
            panelNomor.BackColor = SystemColors.Window;
            panelNomor.Controls.Add(lbNomor);
            panelNomor.Location = new Point(374, 80);
            panelNomor.Name = "panelNomor";
            panelNomor.Size = new Size(850, 27);
            panelNomor.TabIndex = 3;
            // 
            // lbNomor
            // 
            lbNomor.AutoSize = true;
            lbNomor.Location = new Point(15, 3);
            lbNomor.Name = "lbNomor";
            lbNomor.Size = new Size(86, 20);
            lbNomor.TabIndex = 0;
            lbNomor.Text = "No Telepon";
            // 
            // panelNama
            // 
            panelNama.BackColor = SystemColors.Window;
            panelNama.Controls.Add(lbNama);
            panelNama.Location = new Point(374, 35);
            panelNama.Name = "panelNama";
            panelNama.Size = new Size(850, 27);
            panelNama.TabIndex = 2;
            // 
            // lbNama
            // 
            lbNama.AutoSize = true;
            lbNama.Location = new Point(15, 3);
            lbNama.Name = "lbNama";
            lbNama.Size = new Size(115, 20);
            lbNama.TabIndex = 0;
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
