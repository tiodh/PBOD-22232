namespace frontendpbo
{
    partial class CreateSarana
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNama = new Label();
            labelDeskripsi = new Label();
            tbxNama = new TextBox();
            tbxDeskripsi = new TextBox();
            simpan = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            btnJudul = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.Anchor = AnchorStyles.None;
            labelNama.AutoSize = true;
            labelNama.Location = new Point(60, 263);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(95, 20);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama Sektor";
            // 
            // labelDeskripsi
            // 
            labelDeskripsi.Anchor = AnchorStyles.None;
            labelDeskripsi.AutoSize = true;
            labelDeskripsi.Location = new Point(60, 313);
            labelDeskripsi.Name = "labelDeskripsi";
            labelDeskripsi.Size = new Size(69, 20);
            labelDeskripsi.TabIndex = 1;
            labelDeskripsi.Text = "Deskripsi";
            // 
            // tbxNama
            // 
            tbxNama.Anchor = AnchorStyles.None;
            tbxNama.Location = new Point(213, 270);
            tbxNama.Name = "tbxNama";
            tbxNama.Size = new Size(265, 27);
            tbxNama.TabIndex = 2;
            // 
            // tbxDeskripsi
            // 
            tbxDeskripsi.Anchor = AnchorStyles.None;
            tbxDeskripsi.Location = new Point(213, 325);
            tbxDeskripsi.Name = "tbxDeskripsi";
            tbxDeskripsi.Size = new Size(265, 27);
            tbxDeskripsi.TabIndex = 3;
            // 
            // simpan
            // 
            simpan.Anchor = AnchorStyles.None;
            simpan.Location = new Point(384, 407);
            simpan.Name = "simpan";
            simpan.Size = new Size(94, 29);
            simpan.TabIndex = 4;
            simpan.Text = "SIMPAN";
            simpan.UseVisualStyleBackColor = true;
            simpan.Click += simpan_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(521, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(644, 457);
            dataGridView1.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Nama Sektor";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Deskripsi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // btnJudul
            // 
            btnJudul.Dock = DockStyle.Top;
            btnJudul.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnJudul.Location = new Point(0, 0);
            btnJudul.Name = "btnJudul";
            btnJudul.Size = new Size(1195, 51);
            btnJudul.TabIndex = 6;
            btnJudul.Text = "DATA SARANA DAN PRASARANA";
            btnJudul.UseVisualStyleBackColor = true;
            // 
            // CreateSarana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 718);
            Controls.Add(btnJudul);
            Controls.Add(dataGridView1);
            Controls.Add(simpan);
            Controls.Add(tbxDeskripsi);
            Controls.Add(tbxNama);
            Controls.Add(labelDeskripsi);
            Controls.Add(labelNama);
            Name = "CreateSarana";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private Label labelDeskripsi;
        private TextBox tbxNama;
        private TextBox tbxDeskripsi;
        private Button simpan;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button btnJudul;
    }
}