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
            panel1 = new Panel();
            panel2 = new Panel();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            btClear = new Button();
            btHapus = new Button();
            btUpdate = new Button();
            btInsert = new Button();
            dataGridView1 = new DataGridView();
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(39, 34, 39, 34);
            panel1.Size = new Size(1084, 646);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(btClear);
            panel2.Controls.Add(btHapus);
            panel2.Controls.Add(btUpdate);
            panel2.Controls.Add(btInsert);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(39, 34);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 612);
            panel2.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(13, 397);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 31);
            textBox2.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(13, 323);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(254, 31);
            dateTimePicker1.TabIndex = 9;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(13, 248);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(254, 31);
            comboBox2.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 170);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(254, 31);
            comboBox1.TabIndex = 7;
            // 
            // btClear
            // 
            btClear.Location = new Point(435, 534);
            btClear.Name = "btClear";
            btClear.Size = new Size(125, 48);
            btClear.TabIndex = 6;
            btClear.Text = "Clear";
            btClear.UseVisualStyleBackColor = true;
            btClear.Click += btClear_Click;
            // 
            // btHapus
            // 
            btHapus.Location = new Point(285, 534);
            btHapus.Name = "btHapus";
            btHapus.Size = new Size(125, 48);
            btHapus.TabIndex = 5;
            btHapus.Text = "Hapus";
            btHapus.UseVisualStyleBackColor = true;
            btHapus.Click += btHapus_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new Point(142, 534);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(125, 48);
            btUpdate.TabIndex = 4;
            btUpdate.Text = "Edit";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // btInsert
            // 
            btInsert.Location = new Point(0, 534);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(125, 48);
            btInsert.TabIndex = 3;
            btInsert.Text = "Tambah";
            btInsert.UseVisualStyleBackColor = true;
            btInsert.Click += btInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(444, 62);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(562, 409);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.searchbg1;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(520, 8);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(2, 2, 9, 2);
            panel3.Size = new Size(483, 36);
            panel3.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(50, 7);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(323, 24);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Right;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(390, 2);
            label1.Name = "label1";
            label1.Size = new Size(84, 32);
            label1.TabIndex = 1;
            label1.Text = "Search";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // DetailRiwayatKunjungan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 646);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DetailRiwayatKunjungan";
            Text = "Edit_Riwayat_Kunjungan";
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
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button btClear;
        private Button btHapus;
        private Button btUpdate;
        private Button btInsert;
    }
}