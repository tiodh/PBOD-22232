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
            panel4 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            CreateTransportasi = new Button();
            IDTransportasi = new TextBox();
            label2 = new Label();
            NamaTransportasi = new TextBox();
            DeskripsiTransportasi = new TextBox();
            JenisTransportasi = new TextBox();
            SearchTransportasi = new Button();
            TampilanData = new TextBox();
            label6 = new Label();
            DeleteTransportasi = new Button();
            UpdateTransportasi = new Button();
            panel3 = new Panel();
            TampilData = new DataGridView();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TampilData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 106, 248);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(20, 20);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 709);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 305);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(20);
            panel4.Size = new Size(1330, 376);
            panel4.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(SearchTransportasi);
            panel2.Controls.Add(TampilanData);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(DeleteTransportasi);
            panel2.Controls.Add(UpdateTransportasi);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(20, 20);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1290, 336);
            panel2.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(CreateTransportasi);
            panel5.Controls.Add(IDTransportasi);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(NamaTransportasi);
            panel5.Controls.Add(DeskripsiTransportasi);
            panel5.Controls.Add(JenisTransportasi);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(584, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(706, 336);
            panel5.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(21, 15);
            label1.Name = "label1";
            label1.Size = new Size(221, 23);
            label1.TabIndex = 0;
            label1.Text = "ID TRANSPORTASI             :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 160);
            label4.Name = "label4";
            label4.Size = new Size(224, 23);
            label4.TabIndex = 3;
            label4.Text = "DESKRIPSI TRANSPORTASI :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 109);
            label3.Name = "label3";
            label3.Size = new Size(222, 23);
            label3.TabIndex = 2;
            label3.Text = "JENIS TRANSPORTASI        :";
            // 
            // CreateTransportasi
            // 
            CreateTransportasi.BackColor = Color.Green;
            CreateTransportasi.Location = new Point(21, 225);
            CreateTransportasi.Margin = new Padding(3, 4, 3, 4);
            CreateTransportasi.Name = "CreateTransportasi";
            CreateTransportasi.Size = new Size(142, 45);
            CreateTransportasi.TabIndex = 10;
            CreateTransportasi.Text = "CREATE DATA";
            CreateTransportasi.UseVisualStyleBackColor = false;
            CreateTransportasi.Click += CreateTransportasi_Click;
            // 
            // IDTransportasi
            // 
            IDTransportasi.Location = new Point(237, 11);
            IDTransportasi.Margin = new Padding(3, 4, 3, 4);
            IDTransportasi.Name = "IDTransportasi";
            IDTransportasi.Size = new Size(414, 27);
            IDTransportasi.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 60);
            label2.Name = "label2";
            label2.Size = new Size(220, 23);
            label2.TabIndex = 1;
            label2.Text = "NAMA TRANSPORTASI      :";
            // 
            // NamaTransportasi
            // 
            NamaTransportasi.Location = new Point(237, 58);
            NamaTransportasi.Margin = new Padding(3, 4, 3, 4);
            NamaTransportasi.Name = "NamaTransportasi";
            NamaTransportasi.Size = new Size(414, 27);
            NamaTransportasi.TabIndex = 7;
            // 
            // DeskripsiTransportasi
            // 
            DeskripsiTransportasi.Location = new Point(237, 158);
            DeskripsiTransportasi.Margin = new Padding(3, 4, 3, 4);
            DeskripsiTransportasi.Multiline = true;
            DeskripsiTransportasi.Name = "DeskripsiTransportasi";
            DeskripsiTransportasi.Size = new Size(414, 112);
            DeskripsiTransportasi.TabIndex = 9;
            // 
            // JenisTransportasi
            // 
            JenisTransportasi.Location = new Point(237, 109);
            JenisTransportasi.Margin = new Padding(3, 4, 3, 4);
            JenisTransportasi.Name = "JenisTransportasi";
            JenisTransportasi.Size = new Size(414, 27);
            JenisTransportasi.TabIndex = 8;
            // 
            // SearchTransportasi
            // 
            SearchTransportasi.Location = new Point(414, 81);
            SearchTransportasi.Margin = new Padding(3, 4, 3, 4);
            SearchTransportasi.Name = "SearchTransportasi";
            SearchTransportasi.Size = new Size(86, 29);
            SearchTransportasi.TabIndex = 15;
            SearchTransportasi.Text = "SEARCH";
            SearchTransportasi.UseVisualStyleBackColor = true;
            // 
            // TampilanData
            // 
            TampilanData.Location = new Point(33, 83);
            TampilanData.Margin = new Padding(3, 4, 3, 4);
            TampilanData.Name = "TampilanData";
            TampilanData.Size = new Size(351, 27);
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
            // DeleteTransportasi
            // 
            DeleteTransportasi.BackColor = Color.Red;
            DeleteTransportasi.Location = new Point(242, 225);
            DeleteTransportasi.Margin = new Padding(3, 4, 3, 4);
            DeleteTransportasi.Name = "DeleteTransportasi";
            DeleteTransportasi.Size = new Size(142, 45);
            DeleteTransportasi.TabIndex = 12;
            DeleteTransportasi.Text = "DELETE DATA";
            DeleteTransportasi.UseVisualStyleBackColor = false;
            // 
            // UpdateTransportasi
            // 
            UpdateTransportasi.BackColor = Color.Yellow;
            UpdateTransportasi.Location = new Point(30, 225);
            UpdateTransportasi.Margin = new Padding(3, 4, 3, 4);
            UpdateTransportasi.Name = "UpdateTransportasi";
            UpdateTransportasi.Size = new Size(142, 45);
            UpdateTransportasi.TabIndex = 11;
            UpdateTransportasi.Text = "UPDATE DATA";
            UpdateTransportasi.UseVisualStyleBackColor = false;
            UpdateTransportasi.Click += UpdateTransportasi_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(TampilData);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(20);
            panel3.Size = new Size(1330, 305);
            panel3.TabIndex = 16;
            // 
            // TampilData
            // 
            TampilData.AllowUserToAddRows = false;
            TampilData.AllowUserToDeleteRows = false;
            TampilData.BackgroundColor = Color.White;
            TampilData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            TampilData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TampilData.Dock = DockStyle.Fill;
            TampilData.GridColor = Color.White;
            TampilData.Location = new Point(20, 20);
            TampilData.Margin = new Padding(3, 4, 3, 4);
            TampilData.Name = "TampilData";
            TampilData.ReadOnly = true;
            TampilData.RowHeadersWidth = 62;
            TampilData.RowTemplate.Height = 25;
            TampilData.Size = new Size(1290, 265);
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
            Padding = new Padding(20);
            Text = "Form4";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TampilData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView TampilData;
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
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}