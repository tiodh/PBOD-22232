namespace frontendpbo
{
    partial class FormEditUlasan
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
            labelNamaPenggunaE = new Label();
            textBoxNamaPenggunaE = new TextBox();
            labelDeskripsiUlasanE = new Label();
            textBoxDeskripsiUlasanE = new TextBox();
            dataGridViewEditUlasan = new DataGridView();
            buttonCreate = new Button();
            buttonDelete = new Button();
            labelCariBerdasarkanE = new Label();
            textBoxCariBerdasarkanE = new TextBox();
            buttonSearchE = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditUlasan).BeginInit();
            SuspendLayout();
            // 
            // labelNamaPenggunaE
            // 
            labelNamaPenggunaE.AutoSize = true;
            labelNamaPenggunaE.Location = new Point(63, 122);
            labelNamaPenggunaE.Margin = new Padding(2, 0, 2, 0);
            labelNamaPenggunaE.Name = "labelNamaPenggunaE";
            labelNamaPenggunaE.Size = new Size(118, 20);
            labelNamaPenggunaE.TabIndex = 1;
            labelNamaPenggunaE.Text = "Nama Pengguna";
            // 
            // textBoxNamaPenggunaE
            // 
            textBoxNamaPenggunaE.Location = new Point(63, 150);
            textBoxNamaPenggunaE.Margin = new Padding(2);
            textBoxNamaPenggunaE.Name = "textBoxNamaPenggunaE";
            textBoxNamaPenggunaE.Size = new Size(355, 27);
            textBoxNamaPenggunaE.TabIndex = 2;
            // 
            // labelDeskripsiUlasanE
            // 
            labelDeskripsiUlasanE.AutoSize = true;
            labelDeskripsiUlasanE.Location = new Point(61, 271);
            labelDeskripsiUlasanE.Margin = new Padding(2, 0, 2, 0);
            labelDeskripsiUlasanE.Name = "labelDeskripsiUlasanE";
            labelDeskripsiUlasanE.Size = new Size(117, 20);
            labelDeskripsiUlasanE.TabIndex = 3;
            labelDeskripsiUlasanE.Text = "Deskripsi Ulasan";
            // 
            // textBoxDeskripsiUlasanE
            // 
            textBoxDeskripsiUlasanE.Location = new Point(63, 297);
            textBoxDeskripsiUlasanE.Margin = new Padding(2);
            textBoxDeskripsiUlasanE.Multiline = true;
            textBoxDeskripsiUlasanE.Name = "textBoxDeskripsiUlasanE";
            textBoxDeskripsiUlasanE.Size = new Size(355, 228);
            textBoxDeskripsiUlasanE.TabIndex = 4;
            // 
            // dataGridViewEditUlasan
            // 
            dataGridViewEditUlasan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewEditUlasan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditUlasan.Location = new Point(469, 130);
            dataGridViewEditUlasan.Margin = new Padding(2);
            dataGridViewEditUlasan.Name = "dataGridViewEditUlasan";
            dataGridViewEditUlasan.RowHeadersWidth = 62;
            dataGridViewEditUlasan.RowTemplate.Height = 33;
            dataGridViewEditUlasan.Size = new Size(654, 491);
            dataGridViewEditUlasan.TabIndex = 5;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.Green;
            buttonCreate.Location = new Point(88, 556);
            buttonCreate.Margin = new Padding(2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(138, 56);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "CREATE";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Location = new Point(264, 556);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(129, 56);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // labelCariBerdasarkanE
            // 
            labelCariBerdasarkanE.AutoSize = true;
            labelCariBerdasarkanE.Location = new Point(70, 630);
            labelCariBerdasarkanE.Margin = new Padding(2, 0, 2, 0);
            labelCariBerdasarkanE.Name = "labelCariBerdasarkanE";
            labelCariBerdasarkanE.Size = new Size(120, 20);
            labelCariBerdasarkanE.TabIndex = 8;
            labelCariBerdasarkanE.Text = "Cari Berdasarkan";
            // 
            // textBoxCariBerdasarkanE
            // 
            textBoxCariBerdasarkanE.Location = new Point(63, 672);
            textBoxCariBerdasarkanE.Margin = new Padding(2);
            textBoxCariBerdasarkanE.Name = "textBoxCariBerdasarkanE";
            textBoxCariBerdasarkanE.Size = new Size(334, 27);
            textBoxCariBerdasarkanE.TabIndex = 9;
            // 
            // buttonSearchE
            // 
            buttonSearchE.BackColor = Color.DeepSkyBlue;
            buttonSearchE.Location = new Point(166, 727);
            buttonSearchE.Margin = new Padding(2);
            buttonSearchE.Name = "buttonSearchE";
            buttonSearchE.Size = new Size(138, 56);
            buttonSearchE.TabIndex = 10;
            buttonSearchE.Text = "SEARCH";
            buttonSearchE.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 221);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(355, 28);
            comboBox1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 194);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 12;
            label1.Text = "Wisata";
            // 
            // FormEditUlasan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 819);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(buttonSearchE);
            Controls.Add(textBoxCariBerdasarkanE);
            Controls.Add(labelCariBerdasarkanE);
            Controls.Add(buttonDelete);
            Controls.Add(buttonCreate);
            Controls.Add(dataGridViewEditUlasan);
            Controls.Add(textBoxDeskripsiUlasanE);
            Controls.Add(labelDeskripsiUlasanE);
            Controls.Add(textBoxNamaPenggunaE);
            Controls.Add(labelNamaPenggunaE);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "FormEditUlasan";
            Text = "FormEditUlasan";
            Load += FormEditUlasan_Load;
            Click += FormEditUlasan_Click;
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditUlasan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNamaPenggunaE;
        private TextBox textBoxNamaPenggunaE;
        private Label labelDeskripsiUlasanE;
        private TextBox textBoxDeskripsiUlasanE;
        private DataGridView dataGridViewEditUlasan;
        private Button buttonCreate;
        private Button buttonDelete;
        private Label labelCariBerdasarkanE;
        private TextBox textBoxCariBerdasarkanE;
        private Button buttonSearchE;
        private ComboBox comboBox1;
        private Label label1;
    }
}