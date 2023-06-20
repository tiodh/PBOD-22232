namespace frontendpbo
{
    partial class Edit_Riwayat_Kunjungan
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            panel3 = new Panel();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(45);
            panel1.Size = new Size(1675, 861);
            panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(45, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1585, 577);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(45, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(1585, 79);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.searchbg1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(441, 10);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(2, 2, 10, 2);
            panel3.Size = new Size(705, 48);
            panel3.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Gainsboro;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nama Wisata", "Tanggal Kunjungan", "Jumlah Tiket" });
            comboBox1.Location = new Point(16, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(578, 36);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Right;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("MS UI Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(599, 2);
            label1.Name = "label1";
            label1.Size = new Size(96, 44);
            label1.TabIndex = 1;
            label1.Text = "Search";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // Edit_Riwayat_Kunjungan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1675, 861);
            Controls.Add(panel1);
            Name = "Edit_Riwayat_Kunjungan";
            Text = "Edit_Riwayat_Kunjungan";
            Load += Edit_Riwayat_Kunjungan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private ComboBox comboBox1;
    }
}