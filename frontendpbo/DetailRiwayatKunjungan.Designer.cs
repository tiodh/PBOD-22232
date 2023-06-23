namespace frontendpbo
{
    partial class DetailRiwayatKunjungan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbJumlah = new TextBox();
            dtTanggal = new DateTimePicker();
            cbTiket = new ComboBox();
            cbPengunjung = new ComboBox();
            btClear = new Button();
            btUpdate = new Button();
            btInsert = new Button();
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(45, 45, 45, 45);
            panel1.Size = new Size(1239, 861);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbJumlah);
            panel2.Controls.Add(dtTanggal);
            panel2.Controls.Add(cbTiket);
            panel2.Controls.Add(cbPengunjung);
            panel2.Controls.Add(btClear);
            panel2.Controls.Add(btUpdate);
            panel2.Controls.Add(btInsert);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(25, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(1201, 816);
            panel2.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(15, 483);
            label5.Name = "label5";
            label5.Size = new Size(120, 28);
            label5.TabIndex = 14;
            label5.Text = "Jumlah Tiket";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 357);
            label4.Name = "label4";
            label4.Size = new Size(179, 28);
            label4.TabIndex = 13;
            label4.Text = "Tanggal Kunjungan";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 243);
            label3.Name = "label3";
            label3.Size = new Size(54, 28);
            label3.TabIndex = 12;
            label3.Text = "Tiket";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 127);
            label2.Name = "label2";
            label2.Size = new Size(116, 28);
            label2.TabIndex = 11;
            label2.Text = "Pengunjung";
            // 
            // tbJumlah
            // 
            tbJumlah.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tbJumlah.Location = new Point(15, 529);
            tbJumlah.Margin = new Padding(3, 4, 3, 4);
            tbJumlah.Name = "tbJumlah";
            tbJumlah.Size = new Size(398, 36);
            tbJumlah.TabIndex = 10;
            // 
            // dtTanggal
            // 
            dtTanggal.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dtTanggal.Location = new Point(15, 408);
            dtTanggal.Margin = new Padding(3, 4, 3, 4);
            dtTanggal.Name = "dtTanggal";
            dtTanggal.Size = new Size(398, 36);
            dtTanggal.TabIndex = 9;
            // 
            // cbTiket
            // 
            cbTiket.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbTiket.FormattingEnabled = true;
            cbTiket.Location = new Point(15, 291);
            cbTiket.Margin = new Padding(3, 4, 3, 4);
            cbTiket.Name = "cbTiket";
            cbTiket.Size = new Size(398, 38);
            cbTiket.TabIndex = 8;
            // 
            // cbPengunjung
            // 
            cbPengunjung.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            cbPengunjung.FormattingEnabled = true;
            cbPengunjung.Location = new Point(15, 175);
            cbPengunjung.Margin = new Padding(3, 4, 3, 4);
            cbPengunjung.Name = "cbPengunjung";
            cbPengunjung.Size = new Size(398, 38);
            cbPengunjung.TabIndex = 7;
            // 
            // btClear
            // 
            btClear.BackColor = Color.PaleGreen;
            btClear.Location = new Point(314, 584);
            btClear.Margin = new Padding(3, 4, 3, 4);
            btClear.Name = "btClear";
            btClear.Size = new Size(143, 64);
            btClear.TabIndex = 6;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = false;
            btClear.Click += btClear_Click;
            // 
            // btUpdate
            // 
            btUpdate.BackColor = Color.Gold;
            btUpdate.Location = new Point(165, 584);
            btUpdate.Margin = new Padding(3, 4, 3, 4);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(143, 64);
            btUpdate.TabIndex = 4;
            btUpdate.Text = "Edit";
            btUpdate.UseVisualStyleBackColor = false;
            btUpdate.Click += btUpdate_Click;
            // 
            // btInsert
            // 
            btInsert.BackColor = Color.LightSkyBlue;
            btInsert.Location = new Point(16, 584);
            btInsert.Margin = new Padding(3, 4, 3, 4);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(143, 64);
            btInsert.TabIndex = 3;
            btInsert.Text = "Tambah";
            btInsert.UseVisualStyleBackColor = false;
            btInsert.Click += btInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit });
            dataGridView1.Location = new Point(507, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(642, 545);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Edit.DefaultCellStyle = dataGridViewCellStyle1;
            Edit.HeaderText = "";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            Edit.Text = "Edit";
            Edit.ToolTipText = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 125;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.searchbg1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(594, 11);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(2, 3, 10, 3);
            panel3.Size = new Size(552, 48);
            panel3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(57, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 29);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Right;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(446, 3);
            label1.Name = "label1";
            label1.Size = new Size(96, 42);
            label1.TabIndex = 1;
            label1.Text = "Search";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DetailRiwayatKunjungan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 861);
            Controls.Add(panel1);
            Name = "DetailRiwayatKunjungan";
            Text = "Edit_Riwayat_Kunjungan";
            Load += DetailRiwayatKunjungan_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox textBox1;
        private TextBox tbJumlah;
        private DateTimePicker dtTanggal;
        private ComboBox cbTiket;
        private ComboBox cbPengunjung;
        private Button btClear;
        private Button btUpdate;
        private Button btInsert;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridViewButtonColumn Edit;
    }
}