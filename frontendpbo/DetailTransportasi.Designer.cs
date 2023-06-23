namespace frontendpbo
{
    partial class DetailTransportasi
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
            panel7 = new Panel();
            TampilkanDataTransportasi = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            GambarTransportasi = new PictureBox();
            Deskripsi = new TextBox();
            JenisTransportasi = new TextBox();
            NamaTransportasi = new TextBox();
            IDTransportasi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            TampilData = new DataGridView();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GambarTransportasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TampilData).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(111, 106, 248);
            panel7.Controls.Add(TampilkanDataTransportasi);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(TampilData);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(20, 20);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(930, 708);
            panel7.TabIndex = 3;
            // 
            // TampilkanDataTransportasi
            // 
            TampilkanDataTransportasi.Location = new Point(423, 311);
            TampilkanDataTransportasi.Margin = new Padding(3, 4, 3, 4);
            TampilkanDataTransportasi.Name = "TampilkanDataTransportasi";
            TampilkanDataTransportasi.Size = new Size(532, 27);
            TampilkanDataTransportasi.TabIndex = 4;
            TampilkanDataTransportasi.TextChanged += TampilkanDataTransportasi_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(9, 310);
            label4.Name = "label4";
            label4.Size = new Size(408, 28);
            label4.TabIndex = 3;
            label4.Text = "TAMPILKAN DATA BERDASARKAN NAMA";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.White;
            panel3.Controls.Add(GambarTransportasi);
            panel3.Controls.Add(Deskripsi);
            panel3.Controls.Add(JenisTransportasi);
            panel3.Controls.Add(NamaTransportasi);
            panel3.Controls.Add(IDTransportasi);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(12, 345);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(903, 225);
            panel3.TabIndex = 2;
            // 
            // GambarTransportasi
            // 
            GambarTransportasi.Image = Properties.Resources.Kendaraan_ICon;
            GambarTransportasi.Location = new Point(14, 14);
            GambarTransportasi.Margin = new Padding(3, 4, 3, 4);
            GambarTransportasi.Name = "GambarTransportasi";
            GambarTransportasi.Size = new Size(239, 198);
            GambarTransportasi.SizeMode = PictureBoxSizeMode.StretchImage;
            GambarTransportasi.TabIndex = 8;
            GambarTransportasi.TabStop = false;
            // 
            // Deskripsi
            // 
            Deskripsi.Location = new Point(477, 135);
            Deskripsi.Margin = new Padding(3, 4, 3, 4);
            Deskripsi.Multiline = true;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Size = new Size(437, 77);
            Deskripsi.TabIndex = 7;
            // 
            // JenisTransportasi
            // 
            JenisTransportasi.Location = new Point(477, 92);
            JenisTransportasi.Margin = new Padding(3, 4, 3, 4);
            JenisTransportasi.Name = "JenisTransportasi";
            JenisTransportasi.Size = new Size(437, 27);
            JenisTransportasi.TabIndex = 6;
            // 
            // NamaTransportasi
            // 
            NamaTransportasi.Location = new Point(477, 54);
            NamaTransportasi.Margin = new Padding(3, 4, 3, 4);
            NamaTransportasi.Name = "NamaTransportasi";
            NamaTransportasi.Size = new Size(437, 27);
            NamaTransportasi.TabIndex = 5;
            // 
            // IDTransportasi
            // 
            IDTransportasi.Location = new Point(477, 16);
            IDTransportasi.Margin = new Padding(3, 4, 3, 4);
            IDTransportasi.Name = "IDTransportasi";
            IDTransportasi.Size = new Size(437, 27);
            IDTransportasi.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(278, 143);
            label8.Name = "label8";
            label8.Size = new Size(194, 23);
            label8.TabIndex = 3;
            label8.Text = "DESKRIPSI                    :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(275, 93);
            label7.Name = "label7";
            label7.Size = new Size(201, 23);
            label7.TabIndex = 2;
            label7.Text = "JENIS TRANSPORTASI    :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(275, 54);
            label6.Name = "label6";
            label6.Size = new Size(202, 23);
            label6.TabIndex = 1;
            label6.Text = "NAMA TRANSPORTASI   :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(278, 16);
            label5.Name = "label5";
            label5.Size = new Size(200, 23);
            label5.TabIndex = 0;
            label5.Text = "ID TRANSPORTASI         :";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 1;
            label3.Text = "DATA";
            // 
            // TampilData
            // 
            TampilData.AllowUserToAddRows = false;
            TampilData.AllowUserToDeleteRows = false;
            TampilData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TampilData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TampilData.BackgroundColor = Color.White;
            TampilData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TampilData.Location = new Point(12, 41);
            TampilData.Margin = new Padding(3, 4, 3, 4);
            TampilData.Name = "TampilData";
            TampilData.ReadOnly = true;
            TampilData.RowHeadersWidth = 51;
            TampilData.RowTemplate.Height = 25;
            TampilData.Size = new Size(905, 241);
            TampilData.TabIndex = 0;
            // 
            // DetailTransportasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 708);
            Controls.Add(panel7);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DetailTransportasi";
            Padding = new Padding(20);
            Text = "DetailTransportasi";
            Load += DetailTransportasi_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GambarTransportasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)TampilData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel7;
        private TextBox TampilkanDataTransportasi;
        private Label label4;
        private Panel panel3;
        private TextBox Deskripsi;
        private TextBox JenisTransportasi;
        private TextBox NamaTransportasi;
        private TextBox IDTransportasi;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private DataGridView TampilData;
        private PictureBox GambarTransportasi;
    }
}