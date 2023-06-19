﻿namespace frontendpbo
{
    partial class crud_informasi_pengumuman
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
            label_namainformasi = new Label();
            NamaInformasi = new TextBox();
            DeskripsiInformasi = new TextBox();
            label_deskripsiinformasi = new Label();
            TanggalInformasi = new TextBox();
            label_tanggalinformasi = new Label();
            CreateInformasiPengumuman = new Button();
            DeleteInformasiPengumuman = new Button();
            UpdateInformasiPengumuman = new Button();
            Exit_informasipengumuman = new Button();
            TampilInformasi = new DataGridView();
            SearchingInformasitextBox1 = new TextBox();
            IDWisata = new TextBox();
            label_id = new Label();
            ((System.ComponentModel.ISupportInitialize)TampilInformasi).BeginInit();
            SuspendLayout();
            // 
            // label_namainformasi
            // 
            label_namainformasi.Anchor = AnchorStyles.Left;
            label_namainformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_namainformasi.Location = new Point(64, 170);
            label_namainformasi.Name = "label_namainformasi";
            label_namainformasi.Size = new Size(158, 30);
            label_namainformasi.TabIndex = 0;
            label_namainformasi.Text = "Nama Informasi";
            label_namainformasi.Click += label_namainformasi_Click;
            // 
            // NamaInformasi
            // 
            NamaInformasi.BorderStyle = BorderStyle.None;
            NamaInformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NamaInformasi.Location = new Point(64, 204);
            NamaInformasi.Name = "NamaInformasi";
            NamaInformasi.Size = new Size(592, 23);
            NamaInformasi.TabIndex = 1;
            NamaInformasi.TextChanged += textBox_namainformasi_TextChanged;
            // 
            // DeskripsiInformasi
            // 
            DeskripsiInformasi.BorderStyle = BorderStyle.None;
            DeskripsiInformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeskripsiInformasi.Location = new Point(64, 286);
            DeskripsiInformasi.Multiline = true;
            DeskripsiInformasi.Name = "DeskripsiInformasi";
            DeskripsiInformasi.Size = new Size(592, 205);
            DeskripsiInformasi.TabIndex = 3;
            DeskripsiInformasi.TextChanged += textBox_deskripsiinformasi_TextChanged;
            // 
            // label_deskripsiinformasi
            // 
            label_deskripsiinformasi.Anchor = AnchorStyles.Left;
            label_deskripsiinformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_deskripsiinformasi.Location = new Point(64, 253);
            label_deskripsiinformasi.Name = "label_deskripsiinformasi";
            label_deskripsiinformasi.Size = new Size(222, 30);
            label_deskripsiinformasi.TabIndex = 2;
            label_deskripsiinformasi.Text = "Deskripsi Informasi";
            // 
            // TanggalInformasi
            // 
            TanggalInformasi.BorderStyle = BorderStyle.None;
            TanggalInformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TanggalInformasi.Location = new Point(64, 558);
            TanggalInformasi.Name = "TanggalInformasi";
            TanggalInformasi.Size = new Size(592, 23);
            TanggalInformasi.TabIndex = 5;
            TanggalInformasi.TextChanged += textBox_tanggalinformasi_TextChanged;
            // 
            // label_tanggalinformasi
            // 
            label_tanggalinformasi.Anchor = AnchorStyles.Left;
            label_tanggalinformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_tanggalinformasi.Location = new Point(64, 525);
            label_tanggalinformasi.Name = "label_tanggalinformasi";
            label_tanggalinformasi.Size = new Size(222, 30);
            label_tanggalinformasi.TabIndex = 4;
            label_tanggalinformasi.Text = "Tanggal Informasi";
            // 
            // CreateInformasiPengumuman
            // 
            CreateInformasiPengumuman.BackColor = Color.FromArgb(192, 255, 192);
            CreateInformasiPengumuman.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateInformasiPengumuman.Location = new Point(211, 746);
            CreateInformasiPengumuman.Name = "CreateInformasiPengumuman";
            CreateInformasiPengumuman.Size = new Size(129, 63);
            CreateInformasiPengumuman.TabIndex = 6;
            CreateInformasiPengumuman.Text = "Create";
            CreateInformasiPengumuman.UseVisualStyleBackColor = false;
            CreateInformasiPengumuman.Click += create_informasipengumuman_Click;
            // 
            // DeleteInformasiPengumuman
            // 
            DeleteInformasiPengumuman.BackColor = Color.Red;
            DeleteInformasiPengumuman.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteInformasiPengumuman.Location = new Point(543, 746);
            DeleteInformasiPengumuman.Name = "DeleteInformasiPengumuman";
            DeleteInformasiPengumuman.Size = new Size(129, 63);
            DeleteInformasiPengumuman.TabIndex = 9;
            DeleteInformasiPengumuman.Text = "Delete";
            DeleteInformasiPengumuman.UseVisualStyleBackColor = false;
            DeleteInformasiPengumuman.Click += delete_informasipengumuman_Click;
            // 
            // UpdateInformasiPengumuman
            // 
            UpdateInformasiPengumuman.BackColor = Color.Yellow;
            UpdateInformasiPengumuman.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateInformasiPengumuman.Location = new Point(378, 746);
            UpdateInformasiPengumuman.Name = "UpdateInformasiPengumuman";
            UpdateInformasiPengumuman.Size = new Size(129, 63);
            UpdateInformasiPengumuman.TabIndex = 8;
            UpdateInformasiPengumuman.Text = "Update";
            UpdateInformasiPengumuman.UseVisualStyleBackColor = false;
            UpdateInformasiPengumuman.Click += update_informasipengumuman_Click;
            // 
            // Exit_informasipengumuman
            // 
            Exit_informasipengumuman.BackColor = Color.Lime;
            Exit_informasipengumuman.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Exit_informasipengumuman.Location = new Point(43, 746);
            Exit_informasipengumuman.Name = "Exit_informasipengumuman";
            Exit_informasipengumuman.Size = new Size(129, 63);
            Exit_informasipengumuman.TabIndex = 10;
            Exit_informasipengumuman.Text = "Exit";
            Exit_informasipengumuman.UseVisualStyleBackColor = false;
            Exit_informasipengumuman.Click += Clear_informasipengumuman_Click;
            // 
            // TampilInformasi
            // 
            TampilInformasi.AllowUserToAddRows = false;
            TampilInformasi.AllowUserToDeleteRows = false;
            TampilInformasi.BorderStyle = BorderStyle.None;
            TampilInformasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TampilInformasi.ImeMode = ImeMode.NoControl;
            TampilInformasi.Location = new Point(708, 134);
            TampilInformasi.Name = "TampilInformasi";
            TampilInformasi.ReadOnly = true;
            TampilInformasi.RowHeadersWidth = 51;
            TampilInformasi.RowTemplate.Height = 29;
            TampilInformasi.Size = new Size(658, 675);
            TampilInformasi.TabIndex = 11;
            TampilInformasi.CellContentClick += dataGridView_informasipengumuman_CellContentClick;
            // 
            // SearchingInformasitextBox1
            // 
            SearchingInformasitextBox1.BackColor = SystemColors.ScrollBar;
            SearchingInformasitextBox1.BorderStyle = BorderStyle.None;
            SearchingInformasitextBox1.Location = new Point(1110, 62);
            SearchingInformasitextBox1.Name = "SearchingInformasitextBox1";
            SearchingInformasitextBox1.Size = new Size(256, 20);
            SearchingInformasitextBox1.TabIndex = 12;
            SearchingInformasitextBox1.TextChanged += SearchingPengumumantextBox1_TextChanged;
            // 
            // IDWisata
            // 
            IDWisata.Location = new Point(64, 134);
            IDWisata.Margin = new Padding(2);
            IDWisata.Name = "IDWisata";
            IDWisata.Size = new Size(121, 27);
            IDWisata.TabIndex = 13;
            // 
            // label_id
            // 
            label_id.Anchor = AnchorStyles.Left;
            label_id.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_id.Location = new Point(64, 102);
            label_id.Name = "label_id";
            label_id.Size = new Size(158, 30);
            label_id.TabIndex = 14;
            label_id.Text = "ID";
            // 
            // crud_informasi_pengumuman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 882);
            Controls.Add(label_id);
            Controls.Add(IDWisata);
            Controls.Add(SearchingInformasitextBox1);
            Controls.Add(TampilInformasi);
            Controls.Add(Exit_informasipengumuman);
            Controls.Add(DeleteInformasiPengumuman);
            Controls.Add(UpdateInformasiPengumuman);
            Controls.Add(CreateInformasiPengumuman);
            Controls.Add(TanggalInformasi);
            Controls.Add(label_tanggalinformasi);
            Controls.Add(DeskripsiInformasi);
            Controls.Add(label_deskripsiinformasi);
            Controls.Add(NamaInformasi);
            Controls.Add(label_namainformasi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "crud_informasi_pengumuman";
            Text = "crud_informasi_pengumuman";
            Load += crud_informasi_pengumuman_Load;
            ((System.ComponentModel.ISupportInitialize)TampilInformasi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_namainformasi;
        private TextBox NamaInformasi;
        private TextBox DeskripsiInformasi;
        private Label label_deskripsiinformasi;
        private TextBox TanggalInformasi;
        private Label label_tanggalinformasi;
        private Button CreateInformasiPengumuman;
        private Button DeleteInformasiPengumuman;
        private Button UpdateInformasiPengumuman;
        private Button Exit_informasipengumuman;
        private DataGridView TampilInformasi;
        private TextBox SearchingInformasitextBox1;
        private TextBox IDWisata;
        private Label label_id;
    }
}