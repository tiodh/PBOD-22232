namespace tampil_data_umkm
{
    partial class jenis_umkm
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
            components = new System.ComponentModel.Container();
            headerumkm1 = new Label();
            umkm1 = new PictureBox();
            umkm2 = new PictureBox();
            umkm3 = new PictureBox();
            umkm4 = new PictureBox();
            umkm8 = new PictureBox();
            umkm7 = new PictureBox();
            umkm6 = new PictureBox();
            umkm5 = new PictureBox();
            bdetailumkm = new Button();
            sidebar = new Panel();
            Carib = new Button();
            opsiumkmk = new ComboBox();
            menub = new RadioButton();
            sidebartimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)umkm1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umkm2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umkm3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umkm4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umkm8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umkm7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umkm6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)umkm5).BeginInit();
            sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // headerumkm1
            // 
            headerumkm1.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            headerumkm1.ForeColor = SystemColors.ButtonHighlight;
            headerumkm1.Location = new Point(301, 9);
            headerumkm1.Name = "headerumkm1";
            headerumkm1.Size = new Size(542, 52);
            headerumkm1.TabIndex = 2;
            headerumkm1.Text = "Jenis-Jenis UMKM";
            headerumkm1.TextAlign = ContentAlignment.TopCenter;
            // 
            // umkm1
            // 
            umkm1.BackColor = SystemColors.ActiveBorder;
            umkm1.Location = new Point(252, 106);
            umkm1.Name = "umkm1";
            umkm1.Size = new Size(207, 143);
            umkm1.TabIndex = 3;
            umkm1.TabStop = false;
            umkm1.Click += umkm1_Click;
            // 
            // umkm2
            // 
            umkm2.BackColor = SystemColors.ActiveBorder;
            umkm2.Location = new Point(536, 106);
            umkm2.Name = "umkm2";
            umkm2.Size = new Size(207, 143);
            umkm2.TabIndex = 4;
            umkm2.TabStop = false;
            umkm2.Click += umkm2_Click;
            // 
            // umkm3
            // 
            umkm3.BackColor = SystemColors.ActiveBorder;
            umkm3.Location = new Point(813, 106);
            umkm3.Name = "umkm3";
            umkm3.Size = new Size(207, 143);
            umkm3.TabIndex = 5;
            umkm3.TabStop = false;
            umkm3.Click += pictureBox3_Click;
            // 
            // umkm4
            // 
            umkm4.BackColor = SystemColors.ActiveBorder;
            umkm4.Location = new Point(1100, 106);
            umkm4.Name = "umkm4";
            umkm4.Size = new Size(207, 143);
            umkm4.TabIndex = 6;
            umkm4.TabStop = false;
            umkm4.Click += pictureBox4_Click;
            // 
            // umkm8
            // 
            umkm8.BackColor = SystemColors.ActiveBorder;
            umkm8.Location = new Point(1100, 333);
            umkm8.Name = "umkm8";
            umkm8.Size = new Size(207, 143);
            umkm8.TabIndex = 10;
            umkm8.TabStop = false;
            // 
            // umkm7
            // 
            umkm7.BackColor = SystemColors.ActiveBorder;
            umkm7.Location = new Point(813, 333);
            umkm7.Name = "umkm7";
            umkm7.Size = new Size(207, 143);
            umkm7.TabIndex = 9;
            umkm7.TabStop = false;
            // 
            // umkm6
            // 
            umkm6.BackColor = SystemColors.ActiveBorder;
            umkm6.Location = new Point(536, 333);
            umkm6.Name = "umkm6";
            umkm6.Size = new Size(207, 143);
            umkm6.TabIndex = 8;
            umkm6.TabStop = false;
            // 
            // umkm5
            // 
            umkm5.BackColor = SystemColors.ActiveBorder;
            umkm5.Location = new Point(252, 333);
            umkm5.Name = "umkm5";
            umkm5.Size = new Size(207, 143);
            umkm5.TabIndex = 7;
            umkm5.TabStop = false;
            // 
            // bdetailumkm
            // 
            bdetailumkm.BackColor = SystemColors.ButtonHighlight;
            bdetailumkm.Location = new Point(12, 208);
            bdetailumkm.Name = "bdetailumkm";
            bdetailumkm.Size = new Size(97, 29);
            bdetailumkm.TabIndex = 11;
            bdetailumkm.Text = "Detail Umkm";
            bdetailumkm.UseVisualStyleBackColor = false;
            bdetailumkm.Click += button1_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ActiveCaptionText;
            sidebar.Controls.Add(Carib);
            sidebar.Controls.Add(opsiumkmk);
            sidebar.Controls.Add(menub);
            sidebar.Controls.Add(bdetailumkm);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(190, 552);
            sidebar.TabIndex = 12;
            sidebar.Paint += sidebar_Paint;
            // 
            // Carib
            // 
            Carib.Location = new Point(12, 136);
            Carib.Name = "Carib";
            Carib.Size = new Size(75, 23);
            Carib.TabIndex = 14;
            Carib.Text = "Cari UMKM";
            Carib.UseVisualStyleBackColor = true;
            // 
            // opsiumkmk
            // 
            opsiumkmk.FormattingEnabled = true;
            opsiumkmk.Location = new Point(12, 106);
            opsiumkmk.Name = "opsiumkmk";
            opsiumkmk.Size = new Size(175, 24);
            opsiumkmk.TabIndex = 13;
            // 
            // menub
            // 
            menub.AutoSize = true;
            menub.ForeColor = SystemColors.ButtonHighlight;
            menub.Location = new Point(12, 25);
            menub.Name = "menub";
            menub.Size = new Size(49, 20);
            menub.TabIndex = 12;
            menub.TabStop = true;
            menub.Text = "Menu";
            menub.UseVisualStyleBackColor = true;
            // 
            // sidebartimer
            // 
            sidebartimer.Tick += sidebartick;
            // 
            // jenis_umkm
            // 
            AutoScaleDimensions = new SizeF(6F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.DarkViolet;
            ClientSize = new Size(1197, 552);
            Controls.Add(sidebar);
            Controls.Add(umkm8);
            Controls.Add(umkm7);
            Controls.Add(umkm6);
            Controls.Add(umkm5);
            Controls.Add(umkm4);
            Controls.Add(umkm3);
            Controls.Add(umkm2);
            Controls.Add(umkm1);
            Controls.Add(headerumkm1);
            Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "jenis_umkm";
            Text = "Form2";
            Load += first_Load;
            ((System.ComponentModel.ISupportInitialize)umkm1).EndInit();
            ((System.ComponentModel.ISupportInitialize)umkm2).EndInit();
            ((System.ComponentModel.ISupportInitialize)umkm3).EndInit();
            ((System.ComponentModel.ISupportInitialize)umkm4).EndInit();
            ((System.ComponentModel.ISupportInitialize)umkm8).EndInit();
            ((System.ComponentModel.ISupportInitialize)umkm7).EndInit();
            ((System.ComponentModel.ISupportInitialize)umkm6).EndInit();
            ((System.ComponentModel.ISupportInitialize)umkm5).EndInit();
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label headerumkm1;
        private PictureBox umkm1;
        private PictureBox umkm2;
        private PictureBox umkm3;
        private PictureBox umkm4;
        private PictureBox umkm8;
        private PictureBox umkm7;
        private PictureBox umkm6;
        private PictureBox umkm5;
        private Button bdetailumkm;
        private Button Carib;
        private ComboBox opsiumkmk;
        private RadioButton menub;
        private System.Windows.Forms.Timer sidebartimer;
        private Panel sidebar;
    }
}