namespace frontendpbo
{
    partial class FormDetailTransportasi
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
            Enter = new Button();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
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
            Tampil = new DataGridView();
            panel7.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GambarTransportasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Tampil).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(111, 106, 248);
            panel7.Controls.Add(Enter);
            panel7.Controls.Add(panel2);
            panel7.Controls.Add(TampilkanDataTransportasi);
            panel7.Controls.Add(label4);
            panel7.Controls.Add(panel3);
            panel7.Controls.Add(label3);
            panel7.Controls.Add(Tampil);
            panel7.Location = new Point(-5, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1021, 732);
            panel7.TabIndex = 3;
            // 
            // Enter
            // 
            Enter.Location = new Point(749, 399);
            Enter.Name = "Enter";
            Enter.Size = new Size(75, 23);
            Enter.TabIndex = 7;
            Enter.Text = "ENTER";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(8, 0, 8, 0);
            panel2.Size = new Size(1021, 68);
            panel2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(111, 106, 248);
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(223, 15);
            label2.Name = "label2";
            label2.Size = new Size(546, 37);
            label2.TabIndex = 5;
            label2.Text = "TAMPILAN ADMIN DATA TRANSPORTASI";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Rectangle_28__1_;
            pictureBox1.Location = new Point(8, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1005, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // TampilkanDataTransportasi
            // 
            TampilkanDataTransportasi.Location = new Point(396, 399);
            TampilkanDataTransportasi.Name = "TampilkanDataTransportasi";
            TampilkanDataTransportasi.Size = new Size(347, 23);
            TampilkanDataTransportasi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(59, 399);
            label4.Name = "label4";
            label4.Size = new Size(316, 21);
            label4.TabIndex = 3;
            label4.Text = "TAMPILKAN DATA BERDASARKAN NAMA";
            // 
            // panel3
            // 
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
            panel3.Location = new Point(59, 464);
            panel3.Name = "panel3";
            panel3.Size = new Size(906, 215);
            panel3.TabIndex = 2;
            // 
            // GambarTransportasi
            // 
            GambarTransportasi.Image = Properties.Resources.Kendaraan_ICon;
            GambarTransportasi.Location = new Point(39, 29);
            GambarTransportasi.Name = "GambarTransportasi";
            GambarTransportasi.Size = new Size(218, 158);
            GambarTransportasi.SizeMode = PictureBoxSizeMode.StretchImage;
            GambarTransportasi.TabIndex = 8;
            GambarTransportasi.TabStop = false;
            // 
            // Deskripsi
            // 
            Deskripsi.Location = new Point(475, 124);
            Deskripsi.Multiline = true;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Size = new Size(383, 59);
            Deskripsi.TabIndex = 7;
            // 
            // JenisTransportasi
            // 
            JenisTransportasi.Location = new Point(475, 90);
            JenisTransportasi.Name = "JenisTransportasi";
            JenisTransportasi.Size = new Size(383, 23);
            JenisTransportasi.TabIndex = 6;
            // 
            // NamaTransportasi
            // 
            NamaTransportasi.Location = new Point(475, 57);
            NamaTransportasi.Name = "NamaTransportasi";
            NamaTransportasi.Size = new Size(383, 23);
            NamaTransportasi.TabIndex = 5;
            // 
            // IDTransportasi
            // 
            IDTransportasi.Location = new Point(475, 25);
            IDTransportasi.Name = "IDTransportasi";
            IDTransportasi.Size = new Size(383, 23);
            IDTransportasi.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(301, 130);
            label8.Name = "label8";
            label8.Size = new Size(154, 17);
            label8.TabIndex = 3;
            label8.Text = "DESKRIPSI                    :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(298, 91);
            label7.Name = "label7";
            label7.Size = new Size(158, 17);
            label7.TabIndex = 2;
            label7.Text = "JENIS TRANSPORTASI    :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(298, 57);
            label6.Name = "label6";
            label6.Size = new Size(160, 17);
            label6.TabIndex = 1;
            label6.Text = "NAMA TRANSPORTASI   :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(301, 25);
            label5.Name = "label5";
            label5.Size = new Size(159, 17);
            label5.TabIndex = 0;
            label5.Text = "ID TRANSPORTASI         :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(59, 106);
            label3.Name = "label3";
            label3.Size = new Size(147, 21);
            label3.TabIndex = 1;
            label3.Text = "TAMPILKAN DATA";
            // 
            // Tampil
            // 
            Tampil.AllowUserToAddRows = false;
            Tampil.AllowUserToDeleteRows = false;
            Tampil.BackgroundColor = Color.White;
            Tampil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Tampil.Location = new Point(59, 134);
            Tampil.Name = "Tampil";
            Tampil.ReadOnly = true;
            Tampil.RowTemplate.Height = 25;
            Tampil.Size = new Size(906, 228);
            Tampil.TabIndex = 0;
            // 
            // FormDetailTransportasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 729);
            Controls.Add(panel7);
            Name = "FormDetailTransportasi";
            Text = "FormDetailTransportasi";
            Load += FormDetailTransportasi_Load;
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GambarTransportasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)Tampil).EndInit();
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
        private DataGridView Tampil;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox GambarTransportasi;
        private Button Enter;
    }
}