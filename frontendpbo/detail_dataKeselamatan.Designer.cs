namespace frontendpbo
{
    partial class detail_dataKeselamatan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelDetail = new Panel();
            lbDeskripsi = new Label();
            lbAlamat = new Label();
            lbNomor = new Label();
            lbNama = new Label();
            pbIcon = new PictureBox();
            panel1 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoScrollMinSize = new Size(898, 1688);
            flowLayoutPanel1.Controls.Add(panelDetail);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(84, 113);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1281, 985);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panelDetail
            // 
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
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1422, 977);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // detail_dataKeselamatan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "detail_dataKeselamatan";
            Text = "detail_dataKeselamatan";
            Load += detail_dataKeselamatan_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panelDetail.ResumeLayout(false);
            panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbIcon).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panelDetail;
        private PictureBox pbIcon;
        private Label lbDeskripsi;
        private Label lbAlamat;
        private Label lbNomor;
        private Label lbNama;
    }
}