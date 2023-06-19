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
            labelNamaPenggunaE=new Label();
            textBoxNamaPenggunaE=new TextBox();
            labelDeskripsiUlasanE=new Label();
            textBoxDeskripsiUlasanE=new TextBox();
            dataGridViewEditUlasan=new DataGridView();
            buttonCreate=new Button();
            buttonDelete=new Button();
            labelCariBerdasarkanE=new Label();
            textBoxCariBerdasarkanE=new TextBox();
            buttonSearchE=new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEditUlasan).BeginInit();
            SuspendLayout();
            // 
            // labelNamaPenggunaE
            // 
            labelNamaPenggunaE.AutoSize=true;
            labelNamaPenggunaE.Location=new Point(55, 92);
            labelNamaPenggunaE.Margin=new Padding(2, 0, 2, 0);
            labelNamaPenggunaE.Name="labelNamaPenggunaE";
            labelNamaPenggunaE.Size=new Size(96, 15);
            labelNamaPenggunaE.TabIndex=1;
            labelNamaPenggunaE.Text="Nama Pengguna";
            // 
            // textBoxNamaPenggunaE
            // 
            textBoxNamaPenggunaE.Location=new Point(55, 120);
            textBoxNamaPenggunaE.Margin=new Padding(2, 2, 2, 2);
            textBoxNamaPenggunaE.Name="textBoxNamaPenggunaE";
            textBoxNamaPenggunaE.Size=new Size(311, 23);
            textBoxNamaPenggunaE.TabIndex=2;
            // 
            // labelDeskripsiUlasanE
            // 
            labelDeskripsiUlasanE.AutoSize=true;
            labelDeskripsiUlasanE.Location=new Point(62, 156);
            labelDeskripsiUlasanE.Margin=new Padding(2, 0, 2, 0);
            labelDeskripsiUlasanE.Name="labelDeskripsiUlasanE";
            labelDeskripsiUlasanE.Size=new Size(92, 15);
            labelDeskripsiUlasanE.TabIndex=3;
            labelDeskripsiUlasanE.Text="Deskripsi Ulasan";
            // 
            // textBoxDeskripsiUlasanE
            // 
            textBoxDeskripsiUlasanE.Location=new Point(55, 182);
            textBoxDeskripsiUlasanE.Margin=new Padding(2, 2, 2, 2);
            textBoxDeskripsiUlasanE.Multiline=true;
            textBoxDeskripsiUlasanE.Name="textBoxDeskripsiUlasanE";
            textBoxDeskripsiUlasanE.Size=new Size(311, 171);
            textBoxDeskripsiUlasanE.TabIndex=4;
            // 
            // dataGridViewEditUlasan
            // 
            dataGridViewEditUlasan.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEditUlasan.Location=new Point(428, 98);
            dataGridViewEditUlasan.Margin=new Padding(2, 2, 2, 2);
            dataGridViewEditUlasan.Name="dataGridViewEditUlasan";
            dataGridViewEditUlasan.RowHeadersWidth=62;
            dataGridViewEditUlasan.RowTemplate.Height=33;
            dataGridViewEditUlasan.Size=new Size(572, 368);
            dataGridViewEditUlasan.TabIndex=5;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor=Color.Green;
            buttonCreate.Location=new Point(77, 384);
            buttonCreate.Margin=new Padding(2, 2, 2, 2);
            buttonCreate.Name="buttonCreate";
            buttonCreate.Size=new Size(121, 42);
            buttonCreate.TabIndex=6;
            buttonCreate.Text="CREATE";
            buttonCreate.UseVisualStyleBackColor=false;
            buttonCreate.Click+=buttonCreate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor=Color.Red;
            buttonDelete.Location=new Point(231, 384);
            buttonDelete.Margin=new Padding(2, 2, 2, 2);
            buttonDelete.Name="buttonDelete";
            buttonDelete.Size=new Size(113, 42);
            buttonDelete.TabIndex=7;
            buttonDelete.Text="DELETE";
            buttonDelete.UseVisualStyleBackColor=false;
            // 
            // labelCariBerdasarkanE
            // 
            labelCariBerdasarkanE.AutoSize=true;
            labelCariBerdasarkanE.Location=new Point(62, 472);
            labelCariBerdasarkanE.Margin=new Padding(2, 0, 2, 0);
            labelCariBerdasarkanE.Name="labelCariBerdasarkanE";
            labelCariBerdasarkanE.Size=new Size(95, 15);
            labelCariBerdasarkanE.TabIndex=8;
            labelCariBerdasarkanE.Text="Cari Berdasarkan";
            // 
            // textBoxCariBerdasarkanE
            // 
            textBoxCariBerdasarkanE.Location=new Point(55, 504);
            textBoxCariBerdasarkanE.Margin=new Padding(2, 2, 2, 2);
            textBoxCariBerdasarkanE.Name="textBoxCariBerdasarkanE";
            textBoxCariBerdasarkanE.Size=new Size(293, 23);
            textBoxCariBerdasarkanE.TabIndex=9;
            // 
            // buttonSearchE
            // 
            buttonSearchE.BackColor=Color.DeepSkyBlue;
            buttonSearchE.Location=new Point(146, 545);
            buttonSearchE.Margin=new Padding(2, 2, 2, 2);
            buttonSearchE.Name="buttonSearchE";
            buttonSearchE.Size=new Size(121, 42);
            buttonSearchE.TabIndex=10;
            buttonSearchE.Text="SEARCH";
            buttonSearchE.UseVisualStyleBackColor=false;
            // 
            // FormEditUlasan
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(970, 473);
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
            FormBorderStyle=FormBorderStyle.None;
            Margin=new Padding(2, 2, 2, 2);
            Name="FormEditUlasan";
            Text="FormEditUlasan";
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