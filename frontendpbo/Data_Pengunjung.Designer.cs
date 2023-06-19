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
            panel2 = new Panel();
            status_Database = new Label();
            DataGrid_Utama = new DataGridView();
            panel1.SuspendLayout();
            panel_ReadData.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Utama).BeginInit();
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
            panel1.Size = new Size(1422, 68);
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
            panel_ReadData.Controls.Add(DataGrid_Utama);
            panel_ReadData.Controls.Add(button1);
            panel_ReadData.Controls.Add(label3);
            panel_ReadData.Controls.Add(label2);
            panel_ReadData.Controls.Add(label1);
            panel_ReadData.Controls.Add(Bulan);
            panel_ReadData.Controls.Add(Tahun);
            panel_ReadData.Controls.Add(Kategori);
            panel_ReadData.Location = new Point(12, 74);
            panel_ReadData.Name = "panel_ReadData";
            panel_ReadData.Size = new Size(1416, 494);
            panel_ReadData.TabIndex = 1;
            panel_ReadData.Paint += panel_ReadData_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(1153, 342);
            button1.Name = "button1";
            button1.Size = new Size(197, 76);
            button1.TabIndex = 6;
            button1.Text = "Terapkan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            Bulan.Text = "All Month";
            Bulan.SelectedIndexChanged += Bulan_SelectedIndexChanged;
            // 
            // Tahun
            // 
            Tahun.FormattingEnabled = true;
            Tahun.Location = new Point(900, 148);
            Tahun.Name = "Tahun";
            Tahun.Size = new Size(151, 28);
            Tahun.TabIndex = 2;
            Tahun.Text = "All Years";
            // 
            // Kategori
            // 
            Kategori.FormattingEnabled = true;
            Kategori.Location = new Point(900, 69);
            Kategori.Name = "Kategori";
            Kategori.Size = new Size(151, 28);
            Kategori.TabIndex = 1;
            Kategori.Text = "All category";
            Kategori.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(status_Database);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 943);
            panel2.Name = "panel2";
            panel2.Size = new Size(1422, 34);
            panel2.TabIndex = 2;
            // 
            // status_Database
            // 
            status_Database.AutoSize = true;
            status_Database.Location = new Point(1228, 5);
            status_Database.Name = "status_Database";
            status_Database.Size = new Size(133, 20);
            status_Database.TabIndex = 3;
            status_Database.Text = "Database : Normal";
            status_Database.Click += status_Database_Click;
            // 
            // DataGrid_Utama
            // 
            DataGrid_Utama.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid_Utama.Location = new Point(3, 3);
            DataGrid_Utama.Name = "DataGrid_Utama";
            DataGrid_Utama.RowHeadersWidth = 51;
            DataGrid_Utama.RowTemplate.Height = 29;
            DataGrid_Utama.Size = new Size(835, 487);
            DataGrid_Utama.TabIndex = 7;
            // 
            // Data_Penngunjungcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(panel2);
            Controls.Add(panel_ReadData);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Data_Penngunjungcs";
            Text = "Data_Penngunjungcs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel_ReadData.ResumeLayout(false);
            panel_ReadData.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid_Utama).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Header;
        private Panel panel_ReadData;
        private Button button1;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox Bulan;
        private ComboBox Tahun;
        private ComboBox Kategori;
        private Panel panel2;
        private Label status_Database;
        private DataGridView DataGrid_Utama;
    }
}