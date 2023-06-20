namespace frontendpbo
{
    partial class Pengunjung
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
            label1 = new Label();
            panel_Main = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            Cari_pengunjung = new Button();
            textBox3 = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            panel_Main.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 25);
            label1.Name = "label1";
            label1.Size = new Size(292, 32);
            label1.TabIndex = 0;
            label1.Text = "DATA PENGUNJUNG";
            label1.Click += label1_Click;
            // 
            // panel_Main
            // 
            panel_Main.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel_Main.Controls.Add(button1);
            panel_Main.Controls.Add(panel3);
            panel_Main.Controls.Add(panel2);
            panel_Main.Controls.Add(label3);
            panel_Main.Controls.Add(label2);
            panel_Main.Location = new Point(32, 81);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1384, 443);
            panel_Main.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1116, 332);
            button1.Name = "button1";
            button1.Size = new Size(186, 68);
            button1.TabIndex = 6;
            button1.Text = "Simpan";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(textBox2);
            panel3.Location = new Point(32, 199);
            panel3.Name = "panel3";
            panel3.Size = new Size(1081, 78);
            panel3.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 20);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1025, 42);
            textBox2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(32, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(1081, 78);
            panel2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 17);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1025, 42);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 168);
            label3.Name = "label3";
            label3.Size = new Size(224, 28);
            label3.TabIndex = 3;
            label3.Text = "Asal Daerah Pengunjung";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 27);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 2;
            label2.Text = "Data Pengunjung";
            label2.Click += label2_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(32, 554);
            panel4.Name = "panel4";
            panel4.Size = new Size(1384, 458);
            panel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(920, 373);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(Cari_pengunjung);
            panel6.Controls.Add(textBox3);
            panel6.Location = new Point(335, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(617, 61);
            panel6.TabIndex = 2;
            // 
            // Cari_pengunjung
            // 
            Cari_pengunjung.BackColor = SystemColors.ActiveCaption;
            Cari_pengunjung.Location = new Point(478, 16);
            Cari_pengunjung.Name = "Cari_pengunjung";
            Cari_pengunjung.Size = new Size(94, 29);
            Cari_pengunjung.TabIndex = 3;
            Cari_pengunjung.Text = "Cari";
            Cari_pengunjung.UseVisualStyleBackColor = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(15, 16);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(419, 27);
            textBox3.TabIndex = 0;
            textBox3.TextChanged += SearchingtextBox3_TextChanged;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label4);
            panel5.Location = new Point(32, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(286, 61);
            panel5.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 19);
            label4.Name = "label4";
            label4.Size = new Size(245, 20);
            label4.TabIndex = 0;
            label4.Text = "Pengunjung [Tanggal Sekarang]";
            label4.Click += label4_Click;
            // 
            // Pengunjung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1024);
            ControlBox = false;
            Controls.Add(panel4);
            Controls.Add(panel_Main);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Pengunjung";
            WindowState = FormWindowState.Maximized;
            Load += Form4_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_Main.ResumeLayout(false);
            panel_Main.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel_Main;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button button1;
        private Panel panel3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Panel panel6;
        private DataGridView dataGridView1;
        private Button Cari_pengunjung;
        private TextBox textBox3;
    }
}