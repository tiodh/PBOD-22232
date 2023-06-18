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
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditUlasan).BeginInit();
            SuspendLayout();
            // 
            // labelNamaPenggunaE
            // 
            labelNamaPenggunaE.AutoSize = true;
            labelNamaPenggunaE.Location = new Point(79, 153);
            labelNamaPenggunaE.Name = "labelNamaPenggunaE";
            labelNamaPenggunaE.Size = new Size(143, 25);
            labelNamaPenggunaE.TabIndex = 1;
            labelNamaPenggunaE.Text = "Nama Pengguna";
            // 
            // textBoxNamaPenggunaE
            // 
            textBoxNamaPenggunaE.Location = new Point(79, 200);
            textBoxNamaPenggunaE.Name = "textBoxNamaPenggunaE";
            textBoxNamaPenggunaE.Size = new Size(443, 31);
            textBoxNamaPenggunaE.TabIndex = 2;
            // 
            // labelDeskripsiUlasanE
            // 
            labelDeskripsiUlasanE.AutoSize = true;
            labelDeskripsiUlasanE.Location = new Point(88, 260);
            labelDeskripsiUlasanE.Name = "labelDeskripsiUlasanE";
            labelDeskripsiUlasanE.Size = new Size(141, 25);
            labelDeskripsiUlasanE.TabIndex = 3;
            labelDeskripsiUlasanE.Text = "Deskripsi Ulasan";
            // 
            // textBoxDeskripsiUlasanE
            // 
            textBoxDeskripsiUlasanE.Location = new Point(79, 303);
            textBoxDeskripsiUlasanE.Multiline = true;
            textBoxDeskripsiUlasanE.Name = "textBoxDeskripsiUlasanE";
            textBoxDeskripsiUlasanE.Size = new Size(443, 283);
            textBoxDeskripsiUlasanE.TabIndex = 4;
            // 
            // dataGridViewEditUlasan
            // 
            dataGridViewEditUlasan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditUlasan.Location = new Point(611, 163);
            dataGridViewEditUlasan.Name = "dataGridViewEditUlasan";
            dataGridViewEditUlasan.RowHeadersWidth = 62;
            dataGridViewEditUlasan.RowTemplate.Height = 33;
            dataGridViewEditUlasan.Size = new Size(817, 614);
            dataGridViewEditUlasan.TabIndex = 5;
            
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.Green;
            buttonCreate.Location = new Point(110, 640);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(173, 70);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "CREATE";
            buttonCreate.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Red;
            buttonDelete.Location = new Point(330, 640);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(161, 70);
            buttonDelete.TabIndex = 7;
            buttonDelete.Text = "DELETE";
            buttonDelete.UseVisualStyleBackColor = false;
           
            // 
            // labelCariBerdasarkanE
            // 
            labelCariBerdasarkanE.AutoSize = true;
            labelCariBerdasarkanE.Location = new Point(88, 787);
            labelCariBerdasarkanE.Name = "labelCariBerdasarkanE";
            labelCariBerdasarkanE.Size = new Size(143, 25);
            labelCariBerdasarkanE.TabIndex = 8;
            labelCariBerdasarkanE.Text = "Cari Berdasarkan";
            // 
            // textBoxCariBerdasarkanE
            // 
            textBoxCariBerdasarkanE.Location = new Point(79, 840);
            textBoxCariBerdasarkanE.Name = "textBoxCariBerdasarkanE";
            textBoxCariBerdasarkanE.Size = new Size(417, 31);
            textBoxCariBerdasarkanE.TabIndex = 9;
            // 
            // buttonSearchE
            // 
            buttonSearchE.BackColor = Color.DeepSkyBlue;
            buttonSearchE.Location = new Point(208, 909);
            buttonSearchE.Name = "buttonSearchE";
            buttonSearchE.Size = new Size(173, 70);
            buttonSearchE.TabIndex = 10;
            buttonSearchE.Text = "SEARCH";
            buttonSearchE.UseVisualStyleBackColor = false;
            // 
            // FormEditUlasan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1024);
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
            Name = "FormEditUlasan";
            Text = "FormEditUlasan";
            
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
    }
}