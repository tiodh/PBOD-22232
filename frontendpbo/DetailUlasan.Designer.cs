namespace frontendpbo
{
    partial class DetailUlasan
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
            dataGridViewsShowUlasan = new DataGridView();
            labelCariBerdasarkan = new Label();
            textBoxCariBerdasarkan = new TextBox();
            buttonSearch = new Button();
            labelNamaPengguna = new Label();
            textBoxNamaPengguna = new TextBox();
            labelDeskripsiUlasan = new Label();
            textBoxDeskripsiUlasan = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewsShowUlasan).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewsShowUlasan
            // 
            dataGridViewsShowUlasan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewsShowUlasan.Location = new Point(43, 35);
            dataGridViewsShowUlasan.Margin = new Padding(2, 3, 2, 3);
            dataGridViewsShowUlasan.Name = "dataGridViewsShowUlasan";
            dataGridViewsShowUlasan.RowHeadersWidth = 62;
            dataGridViewsShowUlasan.RowTemplate.Height = 33;
            dataGridViewsShowUlasan.Size = new Size(1051, 323);
            dataGridViewsShowUlasan.TabIndex = 0;
            dataGridViewsShowUlasan.CellClick += dataGridViewsShowUlasan_CellClick;
            // 
            // labelCariBerdasarkan
            // 
            labelCariBerdasarkan.AutoSize = true;
            labelCariBerdasarkan.Location = new Point(43, 381);
            labelCariBerdasarkan.Margin = new Padding(2, 0, 2, 0);
            labelCariBerdasarkan.Name = "labelCariBerdasarkan";
            labelCariBerdasarkan.Size = new Size(120, 20);
            labelCariBerdasarkan.TabIndex = 1;
            labelCariBerdasarkan.Text = "Cari Berdasarkan";
            // 
            // textBoxCariBerdasarkan
            // 
            textBoxCariBerdasarkan.Location = new Point(174, 379);
            textBoxCariBerdasarkan.Margin = new Padding(2, 3, 2, 3);
            textBoxCariBerdasarkan.Name = "textBoxCariBerdasarkan";
            textBoxCariBerdasarkan.Size = new Size(244, 27);
            textBoxCariBerdasarkan.TabIndex = 2;
            textBoxCariBerdasarkan.TextChanged += textBoxCariBerdasarkan_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.DeepSkyBlue;
            buttonSearch.Location = new Point(449, 379);
            buttonSearch.Margin = new Padding(2, 3, 2, 3);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(89, 35);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "SEACRH";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // labelNamaPengguna
            // 
            labelNamaPengguna.AutoSize = true;
            labelNamaPengguna.Location = new Point(42, 435);
            labelNamaPengguna.Margin = new Padding(2, 0, 2, 0);
            labelNamaPengguna.Name = "labelNamaPengguna";
            labelNamaPengguna.Size = new Size(118, 20);
            labelNamaPengguna.TabIndex = 4;
            labelNamaPengguna.Text = "Nama Pengguna";
            // 
            // textBoxNamaPengguna
            // 
            textBoxNamaPengguna.Location = new Point(174, 435);
            textBoxNamaPengguna.Margin = new Padding(2, 3, 2, 3);
            textBoxNamaPengguna.Name = "textBoxNamaPengguna";
            textBoxNamaPengguna.Size = new Size(365, 27);
            textBoxNamaPengguna.TabIndex = 5;
            // 
            // labelDeskripsiUlasan
            // 
            labelDeskripsiUlasan.AutoSize = true;
            labelDeskripsiUlasan.Location = new Point(43, 499);
            labelDeskripsiUlasan.Margin = new Padding(2, 0, 2, 0);
            labelDeskripsiUlasan.Name = "labelDeskripsiUlasan";
            labelDeskripsiUlasan.Size = new Size(117, 20);
            labelDeskripsiUlasan.TabIndex = 6;
            labelDeskripsiUlasan.Text = "Deskripsi Ulasan";
            // 
            // textBoxDeskripsiUlasan
            // 
            textBoxDeskripsiUlasan.Location = new Point(174, 475);
            textBoxDeskripsiUlasan.Margin = new Padding(2, 3, 2, 3);
            textBoxDeskripsiUlasan.Multiline = true;
            textBoxDeskripsiUlasan.Name = "textBoxDeskripsiUlasan";
            textBoxDeskripsiUlasan.Size = new Size(603, 120);
            textBoxDeskripsiUlasan.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(797, 479);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 8;
            label1.Text = "Objek Wisata";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(899, 475);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 9;
            // 
            // DetailUlasan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 631);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBoxDeskripsiUlasan);
            Controls.Add(labelDeskripsiUlasan);
            Controls.Add(textBoxNamaPengguna);
            Controls.Add(labelNamaPengguna);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxCariBerdasarkan);
            Controls.Add(labelCariBerdasarkan);
            Controls.Add(dataGridViewsShowUlasan);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "DetailUlasan";
            Text = "FormShowUlasan";
            Load += FormShowUlasan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewsShowUlasan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewsShowUlasan;
        private Label labelCariBerdasarkan;
        private TextBox textBoxCariBerdasarkan;
        private Button buttonSearch;
        private Label labelNamaPengguna;
        private TextBox textBoxNamaPengguna;
        private Label labelDeskripsiUlasan;
        private TextBox textBoxDeskripsiUlasan;
        private Label label1;
        private ComboBox comboBox1;
    }
}