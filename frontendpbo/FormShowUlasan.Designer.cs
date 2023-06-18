namespace frontendpbo
{
    partial class FormShowUlasan
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewsShowUlasan).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewsShowUlasan
            // 
            dataGridViewsShowUlasan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewsShowUlasan.Location = new Point(55, 43);
            dataGridViewsShowUlasan.Name = "dataGridViewsShowUlasan";
            dataGridViewsShowUlasan.RowHeadersWidth = 62;
            dataGridViewsShowUlasan.RowTemplate.Height = 33;
            dataGridViewsShowUlasan.Size = new Size(1314, 403);
            dataGridViewsShowUlasan.TabIndex = 0;
            // 
            // labelCariBerdasarkan
            // 
            labelCariBerdasarkan.AutoSize = true;
            labelCariBerdasarkan.Location = new Point(55, 477);
            labelCariBerdasarkan.Name = "labelCariBerdasarkan";
            labelCariBerdasarkan.Size = new Size(143, 25);
            labelCariBerdasarkan.TabIndex = 1;
            labelCariBerdasarkan.Text = "Cari Berdasarkan";
            // 
            // textBoxCariBerdasarkan
            // 
            textBoxCariBerdasarkan.Location = new Point(217, 474);
            textBoxCariBerdasarkan.Name = "textBoxCariBerdasarkan";
            textBoxCariBerdasarkan.Size = new Size(304, 31);
            textBoxCariBerdasarkan.TabIndex = 2;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.DeepSkyBlue;
            buttonSearch.Location = new Point(562, 474);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(112, 34);
            buttonSearch.TabIndex = 3;
            buttonSearch.Text = "SEACRH";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // labelNamaPengguna
            // 
            labelNamaPengguna.AutoSize = true;
            labelNamaPengguna.Location = new Point(53, 544);
            labelNamaPengguna.Name = "labelNamaPengguna";
            labelNamaPengguna.Size = new Size(143, 25);
            labelNamaPengguna.TabIndex = 4;
            labelNamaPengguna.Text = "Nama Pengguna";
            // 
            // textBoxNamaPengguna
            // 
            textBoxNamaPengguna.Location = new Point(217, 544);
            textBoxNamaPengguna.Name = "textBoxNamaPengguna";
            textBoxNamaPengguna.Size = new Size(456, 31);
            textBoxNamaPengguna.TabIndex = 5;
            // 
            // labelDeskripsiUlasan
            // 
            labelDeskripsiUlasan.AutoSize = true;
            labelDeskripsiUlasan.Location = new Point(55, 623);
            labelDeskripsiUlasan.Name = "labelDeskripsiUlasan";
            labelDeskripsiUlasan.Size = new Size(141, 25);
            labelDeskripsiUlasan.TabIndex = 6;
            labelDeskripsiUlasan.Text = "Deskripsi Ulasan";
            // 
            // textBoxDeskripsiUlasan
            // 
            textBoxDeskripsiUlasan.Location = new Point(217, 594);
            textBoxDeskripsiUlasan.Multiline = true;
            textBoxDeskripsiUlasan.Name = "textBoxDeskripsiUlasan";
            textBoxDeskripsiUlasan.Size = new Size(752, 249);
            textBoxDeskripsiUlasan.TabIndex = 7;
            // 
            // FormShowUlasan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1409, 864);
            Controls.Add(textBoxDeskripsiUlasan);
            Controls.Add(labelDeskripsiUlasan);
            Controls.Add(textBoxNamaPengguna);
            Controls.Add(labelNamaPengguna);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxCariBerdasarkan);
            Controls.Add(labelCariBerdasarkan);
            Controls.Add(dataGridViewsShowUlasan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormShowUlasan";
            Text = "FormShowUlasan";
            
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
    }
}