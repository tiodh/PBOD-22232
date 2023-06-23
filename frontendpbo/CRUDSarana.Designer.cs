namespace frontendpbo
{
    partial class CRUDSarana
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
            textBox1 = new TextBox();
            panel1 = new Panel();
            Cari = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panelSARANA = new Panel();
            Update = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelSARANA.SuspendLayout();
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 79);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(644, 457);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(29, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(434, 34);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(Cari);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(492, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(703, 556);
            panel1.TabIndex = 8;
            // 
            // Cari
            // 
            Cari.Location = new Point(469, 33);
            Cari.Name = "Cari";
            Cari.Size = new Size(128, 38);
            Cari.TabIndex = 8;
            Cari.Text = "Cari";
            Cari.UseVisualStyleBackColor = true;
            Cari.Click += Cari_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1195, 72);
            panel2.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(448, 26);
            label1.Name = "label1";
            label1.Size = new Size(280, 28);
            label1.TabIndex = 0;
            label1.Text = "DATA SARANA PRASARANA";
            // 
            // panelSARANA
            // 
            panelSARANA.Controls.Add(Update);
            panelSARANA.Dock = DockStyle.Bottom;
            panelSARANA.Location = new Point(0, 78);
            panelSARANA.Name = "panelSARANA";
            panelSARANA.Size = new Size(1195, 640);
            panelSARANA.TabIndex = 10;
            // 
            // Update
            // 
            Update.Anchor = AnchorStyles.None;
            Update.Location = new Point(258, 329);
            Update.Name = "Update";
            Update.Size = new Size(94, 29);
            Update.TabIndex = 4;
            Update.Text = "EDIT";
            Update.UseVisualStyleBackColor = true;
            Update.Click += button1_Click;
            // 
            // CRUDSarana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 718);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(simpan);
            Controls.Add(tbxDeskripsi);
            Controls.Add(tbxNama);
            Controls.Add(labelDeskripsi);
            Controls.Add(labelNama);
            Controls.Add(panelSARANA);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CRUDSarana";
            Text = "Form1";
            Load += CreateSarana_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelSARANA.ResumeLayout(false);
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
        private TextBox textBox1;
        private Panel panel1;
        private Button Cari;
        private Panel panel2;
        private Label label1;
        private Panel panelSARANA;
        private Button Update;
    }
}