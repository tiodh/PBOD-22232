namespace frontendpbo
{
    partial class Data_Penngunjungcs
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
            Header = new Label();
            panel_ReadData = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Bulan = new ComboBox();
            Tahun = new ComboBox();
            Kategori = new ComboBox();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel_ReadData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Header);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1440, 68);
            panel1.TabIndex = 0;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Header.Location = new Point(588, 15);
            Header.Name = "Header";
            Header.Size = new Size(212, 29);
            Header.TabIndex = 1;
            Header.Text = "Data Pengunjung";
            // 
            // panel_ReadData
            // 
            panel_ReadData.Anchor = AnchorStyles.None;
            panel_ReadData.AutoSize = true;
            panel_ReadData.Controls.Add(button1);
            panel_ReadData.Controls.Add(label3);
            panel_ReadData.Controls.Add(label2);
            panel_ReadData.Controls.Add(label1);
            panel_ReadData.Controls.Add(Bulan);
            panel_ReadData.Controls.Add(Tahun);
            panel_ReadData.Controls.Add(Kategori);
            panel_ReadData.Controls.Add(dataGridView1);
            panel_ReadData.Location = new Point(12, 74);
            panel_ReadData.Name = "panel_ReadData";
            panel_ReadData.Size = new Size(1416, 494);
            panel_ReadData.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(1153, 342);
            button1.Name = "button1";
            button1.Size = new Size(197, 76);
            button1.TabIndex = 6;
            button1.Text = "Terapkan";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(900, 210);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 5;
            label3.Text = "Rentang Bulan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(900, 125);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 4;
            label2.Text = "Rentang Tahun";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(900, 46);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 2;
            label1.Text = "Kategori";
            // 
            // Bulan
            // 
            Bulan.FormattingEnabled = true;
            Bulan.Location = new Point(900, 233);
            Bulan.Name = "Bulan";
            Bulan.Size = new Size(151, 28);
            Bulan.TabIndex = 3;
            // 
            // Tahun
            // 
            Tahun.FormattingEnabled = true;
            Tahun.Location = new Point(900, 148);
            Tahun.Name = "Tahun";
            Tahun.Size = new Size(151, 28);
            Tahun.TabIndex = 2;
            // 
            // Kategori
            // 
            Kategori.FormattingEnabled = true;
            Kategori.Location = new Point(900, 69);
            Kategori.Name = "Kategori";
            Kategori.Size = new Size(151, 28);
            Kategori.TabIndex = 1;
            Kategori.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ButtonHighlight;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(855, 487);
            dataGridView1.TabIndex = 0;
            // 
            // Data_Penngunjungcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 1024);
            Controls.Add(panel_ReadData);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Data_Penngunjungcs";
            Text = "Data_Penngunjungcs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_ReadData.ResumeLayout(false);
            panel_ReadData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Header;
        private Panel panel_ReadData;
        private DataGridView dataGridView1;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox Bulan;
        private ComboBox Tahun;
        private ComboBox Kategori;
    }
}