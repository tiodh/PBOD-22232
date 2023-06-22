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
            label6 = new Label();
            panel9 = new Panel();
            wisata_id = new TextBox();
            label5 = new Label();
            panel7 = new Panel();
            ID_wisata = new TextBox();
            button1 = new Button();
            panel3 = new Panel();
            Daerah = new TextBox();
            panel2 = new Panel();
            Nama = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel6 = new Panel();
            Cari_pengunjung = new Button();
            textBox3 = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            panel8 = new Panel();
            radioButton_Update = new RadioButton();
            radioButton_Cread = new RadioButton();
            panel1.SuspendLayout();
            panel_Main.SuspendLayout();
            panel9.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
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
            panel_Main.AutoSize = true;
            panel_Main.Controls.Add(label6);
            panel_Main.Controls.Add(panel9);
            panel_Main.Controls.Add(label5);
            panel_Main.Controls.Add(panel7);
            panel_Main.Controls.Add(button1);
            panel_Main.Controls.Add(panel3);
            panel_Main.Controls.Add(panel2);
            panel_Main.Controls.Add(label3);
            panel_Main.Controls.Add(label2);
            panel_Main.Location = new Point(32, 81);
            panel_Main.Name = "panel_Main";
            panel_Main.Size = new Size(1384, 443);
            panel_Main.TabIndex = 1;
            panel_Main.Paint += panel_Main_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(783, 27);
            label6.Name = "label6";
            label6.Size = new Size(138, 28);
            label6.TabIndex = 8;
            label6.Text = "Id Pengunjung";
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.ActiveBorder;
            panel9.BorderStyle = BorderStyle.FixedSingle;
            panel9.Controls.Add(wisata_id);
            panel9.Location = new Point(783, 58);
            panel9.Name = "panel9";
            panel9.Size = new Size(330, 78);
            panel9.TabIndex = 5;
            // 
            // wisata_id
            // 
            wisata_id.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            wisata_id.Location = new Point(12, 17);
            wisata_id.Multiline = true;
            wisata_id.Name = "wisata_id";
            wisata_id.Size = new Size(265, 42);
            wisata_id.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 301);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 7;
            label5.Text = "ID Wisata";
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.ActiveBorder;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(ID_wisata);
            panel7.Location = new Point(29, 332);
            panel7.Name = "panel7";
            panel7.Size = new Size(1081, 78);
            panel7.TabIndex = 6;
            // 
            // ID_wisata
            // 
            ID_wisata.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            ID_wisata.Location = new Point(12, 20);
            ID_wisata.Multiline = true;
            ID_wisata.Name = "ID_wisata";
            ID_wisata.Size = new Size(1025, 42);
            ID_wisata.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1153, 342);
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
            panel3.Controls.Add(Daerah);
            panel3.Location = new Point(32, 189);
            panel3.Name = "panel3";
            panel3.Size = new Size(1081, 78);
            panel3.TabIndex = 5;
            // 
            // Daerah
            // 
            Daerah.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Daerah.Location = new Point(12, 20);
            Daerah.Multiline = true;
            Daerah.Name = "Daerah";
            Daerah.Size = new Size(1022, 42);
            Daerah.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(Nama);
            panel2.Location = new Point(32, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 78);
            panel2.TabIndex = 4;
            // 
            // Nama
            // 
            Nama.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Nama.Location = new Point(12, 17);
            Nama.Multiline = true;
            Nama.Name = "Nama";
            Nama.Size = new Size(679, 42);
            Nama.TabIndex = 0;
            Nama.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 158);
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
            label2.Size = new Size(173, 28);
            label2.TabIndex = 2;
            label2.Text = "Nama Pengunjung";
            label2.Click += label2_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.AutoSize = true;
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel8);
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
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Controls.Add(radioButton_Update);
            panel8.Controls.Add(radioButton_Cread);
            panel8.Location = new Point(1012, 82);
            panel8.Name = "panel8";
            panel8.Size = new Size(203, 125);
            panel8.TabIndex = 5;
            // 
            // radioButton_Update
            // 
            radioButton_Update.AutoSize = true;
            radioButton_Update.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_Update.Location = new Point(17, 57);
            radioButton_Update.Name = "radioButton_Update";
            radioButton_Update.Size = new Size(142, 29);
            radioButton_Update.TabIndex = 9;
            radioButton_Update.TabStop = true;
            radioButton_Update.Text = "Update Date";
            radioButton_Update.UseVisualStyleBackColor = true;
            // 
            // radioButton_Cread
            // 
            radioButton_Cread.AutoSize = true;
            radioButton_Cread.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_Cread.Location = new Point(17, 22);
            radioButton_Cread.Name = "radioButton_Cread";
            radioButton_Cread.Size = new Size(133, 29);
            radioButton_Cread.TabIndex = 8;
            radioButton_Cread.TabStop = true;
            radioButton_Cread.Text = "Cread Data";
            radioButton_Cread.UseVisualStyleBackColor = true;
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
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
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
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox Daerah;
        private TextBox Nama;
        private Panel panel4;
        private Panel panel5;
        private Label label4;
        private Panel panel6;
        private DataGridView dataGridView1;
        private Button Cari_pengunjung;
        private TextBox textBox3;
        private Label label5;
        private Panel panel7;
        private TextBox ID_wisata;
        private Panel panel8;
        private RadioButton radioButton_Update;
        private RadioButton radioButton_Cread;
        private Label label6;
        private Panel panel9;
        private TextBox wisata_id;
    }
}