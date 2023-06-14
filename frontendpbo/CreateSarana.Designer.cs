namespace frontendpbo
{
    partial class CreateSarana
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
            dataSarana = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            desk = new TextBox();
            nama = new TextBox();
            labeldeskripsi = new Label();
            labelnama = new Label();
            btnTambah = new Button();
            buttonMenuSarana = new Button();
            ((System.ComponentModel.ISupportInitialize)dataSarana).BeginInit();
            SuspendLayout();
            // 
            // dataSarana
            // 
            dataSarana.Anchor = AnchorStyles.None;
            dataSarana.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSarana.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataSarana.Location = new Point(517, 255);
            dataSarana.Name = "dataSarana";
            dataSarana.RowHeadersWidth = 51;
            dataSarana.RowTemplate.Height = 29;
            dataSarana.Size = new Size(521, 435);
            dataSarana.TabIndex = 44;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Column1.HeaderText = "Nama Sektor";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 124;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Deskripsi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // desk
            // 
            desk.Anchor = AnchorStyles.None;
            desk.Location = new Point(117, 384);
            desk.Name = "desk";
            desk.Size = new Size(329, 27);
            desk.TabIndex = 43;
            // 
            // nama
            // 
            nama.Anchor = AnchorStyles.None;
            nama.Location = new Point(117, 345);
            nama.Name = "nama";
            nama.Size = new Size(329, 27);
            nama.TabIndex = 42;
            // 
            // labeldeskripsi
            // 
            labeldeskripsi.Anchor = AnchorStyles.None;
            labeldeskripsi.AutoSize = true;
            labeldeskripsi.Location = new Point(1, 387);
            labeldeskripsi.Name = "labeldeskripsi";
            labeldeskripsi.Size = new Size(69, 20);
            labeldeskripsi.TabIndex = 41;
            labeldeskripsi.Text = "Deskripsi";
            // 
            // labelnama
            // 
            labelnama.Anchor = AnchorStyles.None;
            labelnama.AutoSize = true;
            labelnama.Location = new Point(1, 345);
            labelnama.Name = "labelnama";
            labelnama.Size = new Size(95, 20);
            labelnama.TabIndex = 40;
            labelnama.Text = "Nama Sektor";
            // 
            // btnTambah
            // 
            btnTambah.Anchor = AnchorStyles.None;
            btnTambah.Location = new Point(221, 445);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(139, 46);
            btnTambah.TabIndex = 39;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            // 
            // buttonMenuSarana
            // 
            buttonMenuSarana.Dock = DockStyle.Top;
            buttonMenuSarana.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMenuSarana.Location = new Point(0, 0);
            buttonMenuSarana.Name = "buttonMenuSarana";
            buttonMenuSarana.Size = new Size(1010, 72);
            buttonMenuSarana.TabIndex = 38;
            buttonMenuSarana.Text = "DATA SARANA DAN PRASARANA";
            buttonMenuSarana.UseVisualStyleBackColor = true;
            // 
            // CreateSarana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 671);
            Controls.Add(dataSarana);
            Controls.Add(desk);
            Controls.Add(nama);
            Controls.Add(labeldeskripsi);
            Controls.Add(labelnama);
            Controls.Add(btnTambah);
            Controls.Add(buttonMenuSarana);
            Name = "CreateSarana";
            Text = "CreateSarana";
            ((System.ComponentModel.ISupportInitialize)dataSarana).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataSarana;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox desk;
        private TextBox nama;
        private Label labeldeskripsi;
        private Label labelnama;
        private Button btnTambah;
        private Button buttonMenuSarana;
    }
}