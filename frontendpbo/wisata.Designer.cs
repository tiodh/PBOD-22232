namespace frontendpbo
{
    partial class wisata
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
            datagridcrudwisata1 = new DataGridView();
            btnclearwisata = new Button();
            btntambahwisata = new Button();
            btneditwisata = new Button();
            btnhapuswisata = new Button();
            label1_Nama_Wisata = new Label();
            textBox1_Nama_Wisata = new TextBox();
            textBox2_Deskripsi_Wisata = new TextBox();
            label2_Deskripsi_Wisata = new Label();
            textBox3_Lokasi_Wisata = new TextBox();
            label3_Lokasi_Wisata = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridcrudwisata1).BeginInit();
            SuspendLayout();
            // 
            // datagridcrudwisata1
            // 
            datagridcrudwisata1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridcrudwisata1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridcrudwisata1.Location = new Point(662, 122);
            datagridcrudwisata1.Name = "datagridcrudwisata1";
            datagridcrudwisata1.RowHeadersWidth = 51;
            datagridcrudwisata1.RowTemplate.Height = 29;
            datagridcrudwisata1.Size = new Size(743, 754);
            datagridcrudwisata1.TabIndex = 0;
            datagridcrudwisata1.CellContentClick += datagridwisata1_CellContentClick;
            // 
            // btnclearwisata
            // 
            btnclearwisata.BackColor = Color.Lime;
            btnclearwisata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnclearwisata.Location = new Point(38, 783);
            btnclearwisata.Name = "btnclearwisata";
            btnclearwisata.Size = new Size(129, 63);
            btnclearwisata.TabIndex = 1;
            btnclearwisata.Text = "Clear";
            btnclearwisata.UseVisualStyleBackColor = false;
            btnclearwisata.Click += btnclearwisata_Click;
            // 
            // btntambahwisata
            // 
            btntambahwisata.BackColor = Color.FromArgb(128, 128, 255);
            btntambahwisata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btntambahwisata.Location = new Point(178, 783);
            btntambahwisata.Name = "btntambahwisata";
            btntambahwisata.Size = new Size(129, 63);
            btntambahwisata.TabIndex = 2;
            btntambahwisata.Text = "Tambah";
            btntambahwisata.UseVisualStyleBackColor = false;
            btntambahwisata.Click += btntambahwisata_Click;
            // 
            // btneditwisata
            // 
            btneditwisata.BackColor = Color.Yellow;
            btneditwisata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btneditwisata.Location = new Point(320, 783);
            btneditwisata.Name = "btneditwisata";
            btneditwisata.Size = new Size(129, 63);
            btneditwisata.TabIndex = 3;
            btneditwisata.Text = "Edit";
            btneditwisata.UseVisualStyleBackColor = false;
            // 
            // btnhapuswisata
            // 
            btnhapuswisata.BackColor = Color.Red;
            btnhapuswisata.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnhapuswisata.Location = new Point(464, 783);
            btnhapuswisata.Name = "btnhapuswisata";
            btnhapuswisata.Size = new Size(129, 63);
            btnhapuswisata.TabIndex = 4;
            btnhapuswisata.Text = "Hapus";
            btnhapuswisata.UseVisualStyleBackColor = false;
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
            textBox1_Nama_Wisata.BackColor = SystemColors.Control;
            textBox1_Nama_Wisata.BorderStyle = BorderStyle.FixedSingle;
            textBox1_Nama_Wisata.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_Nama_Wisata.Location = new Point(38, 79);
            textBox1_Nama_Wisata.Multiline = true;
            textBox1_Nama_Wisata.Name = "textBox1_Nama_Wisata";
            textBox1_Nama_Wisata.Size = new Size(555, 27);
            textBox1_Nama_Wisata.TabIndex = 6;
            // 
            // textBox2_Deskripsi_Wisata
            // 
            textBox2_Deskripsi_Wisata.BackColor = SystemColors.Control;
            textBox2_Deskripsi_Wisata.BorderStyle = BorderStyle.FixedSingle;
            textBox2_Deskripsi_Wisata.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2_Deskripsi_Wisata.Location = new Point(38, 150);
            textBox2_Deskripsi_Wisata.Multiline = true;
            textBox2_Deskripsi_Wisata.Name = "textBox2_Deskripsi_Wisata";
            textBox2_Deskripsi_Wisata.Size = new Size(555, 482);
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
            textBox3_Lokasi_Wisata.BackColor = SystemColors.Control;
            textBox3_Lokasi_Wisata.BorderStyle = BorderStyle.FixedSingle;
            textBox3_Lokasi_Wisata.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3_Lokasi_Wisata.Location = new Point(38, 687);
            textBox3_Lokasi_Wisata.Multiline = true;
            textBox3_Lokasi_Wisata.Name = "textBox3_Lokasi_Wisata";
            textBox3_Lokasi_Wisata.Size = new Size(555, 50);
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
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(662, 79);
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
            label1.Location = new Point(662, 51);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 12;
            label1.Text = "Cari Data :";
            // 
            // wisata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1024);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label3_Lokasi_Wisata);
            Controls.Add(textBox3_Lokasi_Wisata);
            Controls.Add(label2_Deskripsi_Wisata);
            Controls.Add(textBox2_Deskripsi_Wisata);
            Controls.Add(textBox1_Nama_Wisata);
            Controls.Add(label1_Nama_Wisata);
            Controls.Add(btnhapuswisata);
            Controls.Add(btneditwisata);
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
        private Button btneditwisata;
        private Button btnhapuswisata;
        private Label label1_Nama_Wisata;
        private TextBox textBox1_Nama_Wisata;
        private TextBox textBox2_Deskripsi_Wisata;
        private Label label2_Deskripsi_Wisata;
        private TextBox textBox3_Lokasi_Wisata;
        private Label label3_Lokasi_Wisata;
        private TextBox textBox1;
        private Label label1;
    }
}