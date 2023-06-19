﻿namespace frontendpbo
{
    partial class CRUDTransportasi
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
            panel1 = new Panel();
            panel2 = new Panel();
            SearchTransportasi = new Button();
            TampilanData = new TextBox();
            label6 = new Label();
            IDTransportasi = new TextBox();
            NamaTransportasi = new TextBox();
            JenisTransportasi = new TextBox();
            DeskripsiTransportasi = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CreateTransportasi = new Button();
            DeleteTransportasi = new Button();
            label3 = new Label();
            label4 = new Label();
            UpdateTransportasi = new Button();
            panel3 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            TampilData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TampilData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 106, 248);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(TampilData);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1203, 566);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(SearchTransportasi);
            panel2.Controls.Add(TampilanData);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(IDTransportasi);
            panel2.Controls.Add(NamaTransportasi);
            panel2.Controls.Add(JenisTransportasi);
            panel2.Controls.Add(DeskripsiTransportasi);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(CreateTransportasi);
            panel2.Controls.Add(DeleteTransportasi);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(UpdateTransportasi);
            panel2.Location = new Point(32, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(1126, 256);
            panel2.TabIndex = 15;
            // 
            // SearchTransportasi
            // 
            SearchTransportasi.Location = new Point(254, 60);
            SearchTransportasi.Name = "SearchTransportasi";
            SearchTransportasi.Size = new Size(75, 22);
            SearchTransportasi.TabIndex = 15;
            SearchTransportasi.Text = "SEARCH";
            SearchTransportasi.UseVisualStyleBackColor = true;
            // 
            // TampilanData
            // 
            TampilanData.Location = new Point(29, 62);
            TampilanData.Name = "TampilanData";
            TampilanData.Size = new Size(204, 23);
            TampilanData.TabIndex = 14;
            TampilanData.TextChanged += TampilanData_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 27);
            label6.Name = "label6";
            label6.Size = new Size(212, 17);
            label6.TabIndex = 13;
            label6.Text = "TAMPILKAN DATA BERDASARKAN";
            // 
            // IDTransportasi
            // 
            IDTransportasi.Location = new Point(702, 21);
            IDTransportasi.Name = "IDTransportasi";
            IDTransportasi.Size = new Size(363, 23);
            IDTransportasi.TabIndex = 6;
            // 
            // NamaTransportasi
            // 
            NamaTransportasi.Location = new Point(702, 56);
            NamaTransportasi.Name = "NamaTransportasi";
            NamaTransportasi.Size = new Size(363, 23);
            NamaTransportasi.TabIndex = 7;
            // 
            // JenisTransportasi
            // 
            JenisTransportasi.Location = new Point(702, 99);
            JenisTransportasi.Name = "JenisTransportasi";
            JenisTransportasi.Size = new Size(363, 23);
            JenisTransportasi.TabIndex = 8;
            // 
            // DeskripsiTransportasi
            // 
            DeskripsiTransportasi.Location = new Point(702, 136);
            DeskripsiTransportasi.Multiline = true;
            DeskripsiTransportasi.Name = "DeskripsiTransportasi";
            DeskripsiTransportasi.Size = new Size(363, 85);
            DeskripsiTransportasi.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(520, 27);
            label1.Name = "label1";
            label1.Size = new Size(165, 17);
            label1.TabIndex = 0;
            label1.Text = "ID TRANSPORTASI           :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(519, 62);
            label2.Name = "label2";
            label2.Size = new Size(164, 17);
            label2.TabIndex = 1;
            label2.Text = "NAMA TRANSPORTASI    :";
            // 
            // CreateTransportasi
            // 
            CreateTransportasi.BackColor = Color.Green;
            CreateTransportasi.Location = new Point(520, 176);
            CreateTransportasi.Name = "CreateTransportasi";
            CreateTransportasi.Size = new Size(124, 64);
            CreateTransportasi.TabIndex = 10;
            CreateTransportasi.Text = "CREATE DATA";
            CreateTransportasi.UseVisualStyleBackColor = false;
            CreateTransportasi.Click += CreateTransportasi_Click;
            // 
            // DeleteTransportasi
            // 
            DeleteTransportasi.BackColor = Color.Red;
            DeleteTransportasi.Location = new Point(194, 176);
            DeleteTransportasi.Name = "DeleteTransportasi";
            DeleteTransportasi.Size = new Size(124, 64);
            DeleteTransportasi.TabIndex = 12;
            DeleteTransportasi.Text = "DELETE DATA";
            DeleteTransportasi.UseVisualStyleBackColor = false;
            DeleteTransportasi.Click += DeleteTransportasi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(519, 99);
            label3.Name = "label3";
            label3.Size = new Size(165, 17);
            label3.TabIndex = 2;
            label3.Text = "JENIS TRANSPORTASI      :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(519, 138);
            label4.Name = "label4";
            label4.Size = new Size(165, 17);
            label4.TabIndex = 3;
            label4.Text = "DESKRIPSI                       :";
            // 
            // UpdateTransportasi
            // 
            UpdateTransportasi.BackColor = Color.Yellow;
            UpdateTransportasi.Location = new Point(18, 176);
            UpdateTransportasi.Name = "UpdateTransportasi";
            UpdateTransportasi.Size = new Size(124, 64);
            UpdateTransportasi.TabIndex = 11;
            UpdateTransportasi.Text = "UPDATE DATA";
            UpdateTransportasi.UseVisualStyleBackColor = false;
            UpdateTransportasi.Click += UpdateTransportasi_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(8, 0, 8, 0);
            panel3.Size = new Size(1203, 68);
            panel3.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(111, 106, 248);
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(231, 15);
            label7.Name = "label7";
            label7.Size = new Size(546, 37);
            label7.TabIndex = 5;
            label7.Text = "TAMPILAN ADMIN DATA TRANSPORTASI";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Rectangle_28__1_;
            pictureBox1.Location = new Point(8, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1187, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // TampilData
            // 
            TampilData.AllowUserToAddRows = false;
            TampilData.AllowUserToDeleteRows = false;
            TampilData.BackgroundColor = Color.White;
            TampilData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            TampilData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TampilData.GridColor = Color.White;
            TampilData.Location = new Point(32, 81);
            TampilData.Name = "TampilData";
            TampilData.ReadOnly = true;
            TampilData.RowHeadersWidth = 62;
            TampilData.RowTemplate.Height = 25;
            TampilData.Size = new Size(1126, 202);
            TampilData.TabIndex = 5;
            TampilData.CellContentClick += TampilData_CellContentClick;
            // 
            // CRUDTransportasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 562);
            Controls.Add(panel1);
            Name = "CRUDTransportasi";
            Text = "Form4";
            Load += CRUDTrasnportasi_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TampilData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView TampilData;
        private Panel panel3;
        private Label label7;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button SearchTransportasi;
        private TextBox TampilanData;
        private Label label6;
        private TextBox IDTransportasi;
        private TextBox NamaTransportasi;
        private TextBox JenisTransportasi;
        private TextBox DeskripsiTransportasi;
        private Label label1;
        private Label label2;
        private Button CreateTransportasi;
        private Button DeleteTransportasi;
        private Label label3;
        private Label label4;
        private Button UpdateTransportasi;
    }
}