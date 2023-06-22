namespace frontendpbo
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
            panel1.Location = new Point(-1, -3);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1375, 755);
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
            panel2.Location = new Point(37, 392);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1287, 341);
            panel2.TabIndex = 15;
            // 
            // SearchTransportasi
            // 
            SearchTransportasi.Location = new Point(290, 80);
            SearchTransportasi.Margin = new Padding(3, 4, 3, 4);
            SearchTransportasi.Name = "SearchTransportasi";
            SearchTransportasi.Size = new Size(86, 29);
            SearchTransportasi.TabIndex = 15;
            SearchTransportasi.Text = "SEARCH";
            SearchTransportasi.UseVisualStyleBackColor = true;
            SearchTransportasi.Click += SearchTransportasi_Click;
            // 
            // TampilanData
            // 
            TampilanData.Location = new Point(33, 83);
            TampilanData.Margin = new Padding(3, 4, 3, 4);
            TampilanData.Name = "TampilanData";
            TampilanData.Size = new Size(233, 27);
            TampilanData.TabIndex = 14;

            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(30, 36);
            label6.Name = "label6";
            label6.Size = new Size(271, 23);
            label6.TabIndex = 13;
            label6.Text = "TAMPILKAN DATA BERDASARKAN";
            // 
            // IDTransportasi
            // 
            IDTransportasi.Location = new Point(802, 34);
            IDTransportasi.Margin = new Padding(3, 4, 3, 4);
            IDTransportasi.Name = "IDTransportasi";
            IDTransportasi.Size = new Size(414, 27);
            IDTransportasi.TabIndex = 6;
            // 
            // NamaTransportasi
            // 
            NamaTransportasi.Location = new Point(802, 81);
            NamaTransportasi.Margin = new Padding(3, 4, 3, 4);
            NamaTransportasi.Name = "NamaTransportasi";
            NamaTransportasi.Size = new Size(414, 27);
            NamaTransportasi.TabIndex = 7;
            // 
            // JenisTransportasi
            // 
            JenisTransportasi.Location = new Point(802, 132);
            JenisTransportasi.Margin = new Padding(3, 4, 3, 4);
            JenisTransportasi.Name = "JenisTransportasi";
            JenisTransportasi.Size = new Size(414, 27);
            JenisTransportasi.TabIndex = 8;
            // 
            // DeskripsiTransportasi
            // 
            DeskripsiTransportasi.Location = new Point(802, 181);
            DeskripsiTransportasi.Margin = new Padding(3, 4, 3, 4);
            DeskripsiTransportasi.Multiline = true;
            DeskripsiTransportasi.Name = "DeskripsiTransportasi";
            DeskripsiTransportasi.Size = new Size(414, 112);
            DeskripsiTransportasi.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(586, 38);
            label1.Name = "label1";
            label1.Size = new Size(221, 23);
            label1.TabIndex = 0;
            label1.Text = "ID TRANSPORTASI             :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(586, 83);
            label2.Name = "label2";
            label2.Size = new Size(220, 23);
            label2.TabIndex = 1;
            label2.Text = "NAMA TRANSPORTASI      :";
            // 
            // CreateTransportasi
            // 
            CreateTransportasi.BackColor = Color.Green;
            CreateTransportasi.Location = new Point(594, 235);
            CreateTransportasi.Margin = new Padding(3, 4, 3, 4);
            CreateTransportasi.Name = "CreateTransportasi";
            CreateTransportasi.Size = new Size(142, 85);
            CreateTransportasi.TabIndex = 10;
            CreateTransportasi.Text = "CREATE DATA";
            CreateTransportasi.UseVisualStyleBackColor = false;
            CreateTransportasi.Click += CreateTransportasi_Click;
            // 
            // DeleteTransportasi
            // 
            DeleteTransportasi.BackColor = Color.Red;
            DeleteTransportasi.Location = new Point(222, 235);
            DeleteTransportasi.Margin = new Padding(3, 4, 3, 4);
            DeleteTransportasi.Name = "DeleteTransportasi";
            DeleteTransportasi.Size = new Size(142, 85);
            DeleteTransportasi.TabIndex = 12;
            DeleteTransportasi.Text = "DELETE DATA";
            DeleteTransportasi.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(583, 132);
            label3.Name = "label3";
            label3.Size = new Size(222, 23);
            label3.TabIndex = 2;
            label3.Text = "JENIS TRANSPORTASI        :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(581, 183);
            label4.Name = "label4";
            label4.Size = new Size(224, 23);
            label4.TabIndex = 3;
            label4.Text = "DESKRIPSI TRANSPORTASI :";
            // 
            // UpdateTransportasi
            // 
            UpdateTransportasi.BackColor = Color.Yellow;
            UpdateTransportasi.Location = new Point(21, 235);
            UpdateTransportasi.Margin = new Padding(3, 4, 3, 4);
            UpdateTransportasi.Name = "UpdateTransportasi";
            UpdateTransportasi.Size = new Size(142, 85);
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
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(9, 0, 9, 0);
            panel3.Size = new Size(1375, 91);
            panel3.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(111, 106, 248);
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(264, 20);
            label7.Name = "label7";
            label7.Size = new Size(686, 46);
            label7.TabIndex = 5;
            label7.Text = "TAMPILAN ADMIN DATA TRANSPORTASI";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Rectangle_28__1_;
            pictureBox1.Location = new Point(9, 0);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1357, 91);
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
            TampilData.Location = new Point(37, 108);
            TampilData.Margin = new Padding(3, 4, 3, 4);
            TampilData.Name = "TampilData";
            TampilData.ReadOnly = true;
            TampilData.RowHeadersWidth = 62;
            TampilData.RowTemplate.Height = 25;
            TampilData.Size = new Size(1287, 269);
            TampilData.TabIndex = 5;

            // 
            // CRUDTransportasi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CRUDTransportasi";
            Text = "Form4";

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