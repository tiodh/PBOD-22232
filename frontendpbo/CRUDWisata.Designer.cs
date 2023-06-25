namespace frontendpbo
{
    partial class CRUDWisata
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            datagridcrudwisata1 = new DataGridView();
            Id_Wisata = new DataGridViewTextBoxColumn();
            Nama_Wisata = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Lokasi = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            btnclearwisata = new Button();
            btntambahwisata = new Button();
            label1_Nama_Wisata = new Label();
            textBox1_Nama_Wisata = new TextBox();
            textBox2_Deskripsi_Wisata = new TextBox();
            label2_Deskripsi_Wisata = new Label();
            textBox3_Lokasi_Wisata = new TextBox();
            label3_Lokasi_Wisata = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridcrudwisata1).BeginInit();
            SuspendLayout();
            // 
            // datagridcrudwisata1
            // 
            datagridcrudwisata1.AllowUserToAddRows = false;
            datagridcrudwisata1.AllowUserToDeleteRows = false;
            datagridcrudwisata1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridcrudwisata1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            datagridcrudwisata1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            datagridcrudwisata1.ColumnHeadersHeight = 29;
            datagridcrudwisata1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            datagridcrudwisata1.Columns.AddRange(new DataGridViewColumn[] { Id_Wisata, Nama_Wisata, Description, Lokasi, Edit });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            datagridcrudwisata1.DefaultCellStyle = dataGridViewCellStyle3;
            datagridcrudwisata1.Location = new Point(549, 150);
            datagridcrudwisata1.Name = "datagridcrudwisata1";
            datagridcrudwisata1.ReadOnly = true;
            datagridcrudwisata1.RowHeadersWidth = 51;
            datagridcrudwisata1.RowTemplate.Height = 29;
            datagridcrudwisata1.Size = new Size(856, 691);
            datagridcrudwisata1.TabIndex = 0;
            datagridcrudwisata1.CellContentClick += datagridwisata1_CellContentClick;
            // 
            // Id_Wisata
            // 
            Id_Wisata.DataPropertyName = "Id_Wisata";
            Id_Wisata.HeaderText = "ID WISATA";
            Id_Wisata.MinimumWidth = 6;
            Id_Wisata.Name = "Id_Wisata";
            Id_Wisata.ReadOnly = true;
            // 
            // Nama_Wisata
            // 
            Nama_Wisata.DataPropertyName = "Nama_Wisata";
            Nama_Wisata.HeaderText = "NAMA WISATA";
            Nama_Wisata.MinimumWidth = 6;
            Nama_Wisata.Name = "Nama_Wisata";
            Nama_Wisata.ReadOnly = true;
            // 
            // Description
            // 
            Description.DataPropertyName = "Deskripsi";
            Description.HeaderText = "DESKRIPSI";
            Description.MinimumWidth = 6;
            Description.Name = "Description";
            Description.ReadOnly = true;
            // 
            // Lokasi
            // 
            Lokasi.DataPropertyName = "Lokasi";
            Lokasi.HeaderText = "LOKASI";
            Lokasi.MinimumWidth = 6;
            Lokasi.Name = "Lokasi";
            Lokasi.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Lime;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            Edit.DefaultCellStyle = dataGridViewCellStyle2;
            Edit.FlatStyle = FlatStyle.Flat;
            Edit.HeaderText = "";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            // 
            // btnclearwisata
            // 
            btnclearwisata.BackColor = Color.Lime;
            btnclearwisata.FlatStyle = FlatStyle.Flat;
            btnclearwisata.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnclearwisata.Location = new Point(363, 778);
            btnclearwisata.Name = "btnclearwisata";
            btnclearwisata.Size = new Size(145, 63);
            btnclearwisata.TabIndex = 1;
            btnclearwisata.Text = "CLEAR";
            btnclearwisata.UseVisualStyleBackColor = false;
            btnclearwisata.Click += btnclearwisata_Click;
            // 
            // btntambahwisata
            // 
            btntambahwisata.BackColor = Color.FromArgb(128, 128, 255);
            btntambahwisata.FlatStyle = FlatStyle.Flat;
            btntambahwisata.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btntambahwisata.Location = new Point(38, 778);
            btntambahwisata.Name = "btntambahwisata";
            btntambahwisata.Size = new Size(319, 63);
            btntambahwisata.TabIndex = 2;
            btntambahwisata.Text = "SUBMIT";
            btntambahwisata.UseVisualStyleBackColor = false;
            btntambahwisata.Click += btntambahwisata_Click;
            // 
            // label1_Nama_Wisata
            // 
            label1_Nama_Wisata.AutoSize = true;
            label1_Nama_Wisata.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1_Nama_Wisata.Location = new Point(38, 51);
            label1_Nama_Wisata.Name = "label1_Nama_Wisata";
            label1_Nama_Wisata.Size = new Size(141, 25);
            label1_Nama_Wisata.TabIndex = 5;
            label1_Nama_Wisata.Text = "Nama Wisata :";
            // 
            // textBox1_Nama_Wisata
            // 
            textBox1_Nama_Wisata.BackColor = SystemColors.ButtonHighlight;
            textBox1_Nama_Wisata.BorderStyle = BorderStyle.FixedSingle;
            textBox1_Nama_Wisata.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_Nama_Wisata.Location = new Point(38, 79);
            textBox1_Nama_Wisata.Multiline = true;
            textBox1_Nama_Wisata.Name = "textBox1_Nama_Wisata";
            textBox1_Nama_Wisata.Size = new Size(470, 27);
            textBox1_Nama_Wisata.TabIndex = 6;
            // 
            // textBox2_Deskripsi_Wisata
            // 
            textBox2_Deskripsi_Wisata.BackColor = SystemColors.ButtonHighlight;
            textBox2_Deskripsi_Wisata.BorderStyle = BorderStyle.FixedSingle;
            textBox2_Deskripsi_Wisata.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2_Deskripsi_Wisata.Location = new Point(38, 150);
            textBox2_Deskripsi_Wisata.Multiline = true;
            textBox2_Deskripsi_Wisata.Name = "textBox2_Deskripsi_Wisata";
            textBox2_Deskripsi_Wisata.Size = new Size(470, 482);
            textBox2_Deskripsi_Wisata.TabIndex = 7;
            // 
            // label2_Deskripsi_Wisata
            // 
            label2_Deskripsi_Wisata.AutoSize = true;
            label2_Deskripsi_Wisata.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2_Deskripsi_Wisata.Location = new Point(38, 122);
            label2_Deskripsi_Wisata.Name = "label2_Deskripsi_Wisata";
            label2_Deskripsi_Wisata.Size = new Size(103, 25);
            label2_Deskripsi_Wisata.TabIndex = 9;
            label2_Deskripsi_Wisata.Text = "Deskripsi :";
            label2_Deskripsi_Wisata.Click += label2_Deskripsi_Click;
            // 
            // textBox3_Lokasi_Wisata
            // 
            textBox3_Lokasi_Wisata.BackColor = SystemColors.ButtonHighlight;
            textBox3_Lokasi_Wisata.BorderStyle = BorderStyle.FixedSingle;
            textBox3_Lokasi_Wisata.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3_Lokasi_Wisata.Location = new Point(38, 687);
            textBox3_Lokasi_Wisata.Multiline = true;
            textBox3_Lokasi_Wisata.Name = "textBox3_Lokasi_Wisata";
            textBox3_Lokasi_Wisata.Size = new Size(470, 50);
            textBox3_Lokasi_Wisata.TabIndex = 10;
            // 
            // label3_Lokasi_Wisata
            // 
            label3_Lokasi_Wisata.AutoSize = true;
            label3_Lokasi_Wisata.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3_Lokasi_Wisata.Location = new Point(38, 659);
            label3_Lokasi_Wisata.Name = "label3_Lokasi_Wisata";
            label3_Lokasi_Wisata.Size = new Size(80, 25);
            label3_Lokasi_Wisata.TabIndex = 11;
            label3_Lokasi_Wisata.Text = "Lokasi :";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(549, 80);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(743, 27);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(549, 51);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 12;
            label1.Text = "Cari Data :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(549, 122);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 14;
            label2.Text = "Data : ";
            // 
            // wisata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1024);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label3_Lokasi_Wisata);
            Controls.Add(textBox3_Lokasi_Wisata);
            Controls.Add(label2_Deskripsi_Wisata);
            Controls.Add(textBox2_Deskripsi_Wisata);
            Controls.Add(textBox1_Nama_Wisata);
            Controls.Add(label1_Nama_Wisata);
            Controls.Add(btntambahwisata);
            Controls.Add(btnclearwisata);
            Controls.Add(datagridcrudwisata1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "wisata";
            Text = "wisata";
            Load += wisata_Load;
            ((System.ComponentModel.ISupportInitialize)datagridcrudwisata1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView datagridcrudwisata1;
        private Button btnclearwisata;
        private Button btntambahwisata;
        private Label label1_Nama_Wisata;
        private TextBox textBox1_Nama_Wisata;
        private TextBox textBox2_Deskripsi_Wisata;
        private Label label2_Deskripsi_Wisata;
        private TextBox textBox3_Lokasi_Wisata;
        private Label label3_Lokasi_Wisata;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn Id_Wisata;
        private DataGridViewTextBoxColumn Nama_Wisata;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewTextBoxColumn Lokasi;
        private DataGridViewButtonColumn Edit;
    }
}