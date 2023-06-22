namespace frontendpbo
{
    partial class CUR_Pengunjung
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            jdl_Header = new Label();
            Status_Database = new Label();
            textbox_Nama = new TextBox();
            label_namaPengunjung = new Label();
            label1 = new Label();
            textbox_asal = new TextBox();
            label_idWisata = new Label();
            textbox_idWisata = new TextBox();
            id_pengunjung = new Label();
            textbox_idPengunjung = new TextBox();
            gridView_Data = new DataGridView();
            button_Search = new Button();
            button_Update = new Button();
            button_Create = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridView_Data).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Status_Database);
            panel1.Controls.Add(jdl_Header);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1336, 61);
            panel1.TabIndex = 0;
            // 
            // jdl_Header
            // 
            jdl_Header.AutoSize = true;
            jdl_Header.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            jdl_Header.Location = new Point(12, 19);
            jdl_Header.Name = "jdl_Header";
            jdl_Header.Size = new Size(178, 25);
            jdl_Header.TabIndex = 0;
            jdl_Header.Text = "Data Pengunjung";
            // 
            // Status_Database
            // 
            Status_Database.AutoSize = true;
            Status_Database.Location = new Point(1178, 39);
            Status_Database.Name = "Status_Database";
            Status_Database.Size = new Size(153, 20);
            Status_Database.TabIndex = 1;
            Status_Database.Text = "peta_jember [normal]";
            // 
            // textbox_Nama
            // 
            textbox_Nama.Location = new Point(21, 127);
            textbox_Nama.Name = "textbox_Nama";
            textbox_Nama.Size = new Size(471, 27);
            textbox_Nama.TabIndex = 1;
            textbox_Nama.TextChanged += textbox_Nama_TextChanged;
            // 
            // label_namaPengunjung
            // 
            label_namaPengunjung.AutoSize = true;
            label_namaPengunjung.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_namaPengunjung.Location = new Point(16, 104);
            label_namaPengunjung.Name = "label_namaPengunjung";
            label_namaPengunjung.Size = new Size(145, 20);
            label_namaPengunjung.TabIndex = 2;
            label_namaPengunjung.Text = "Nama Pengunjung";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 207);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 4;
            label1.Text = "Asal Pengunjung";
            // 
            // textbox_asal
            // 
            textbox_asal.Location = new Point(21, 230);
            textbox_asal.Name = "textbox_asal";
            textbox_asal.Size = new Size(471, 27);
            textbox_asal.TabIndex = 3;
            textbox_asal.TextChanged += textbox_asal_TextChanged;
            // 
            // label_idWisata
            // 
            label_idWisata.AutoSize = true;
            label_idWisata.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_idWisata.Location = new Point(21, 311);
            label_idWisata.Name = "label_idWisata";
            label_idWisata.Size = new Size(83, 20);
            label_idWisata.TabIndex = 6;
            label_idWisata.Text = "ID Wisata";
            // 
            // textbox_idWisata
            // 
            textbox_idWisata.Location = new Point(21, 334);
            textbox_idWisata.Name = "textbox_idWisata";
            textbox_idWisata.Size = new Size(471, 27);
            textbox_idWisata.TabIndex = 5;
            textbox_idWisata.TextChanged += textbox_idWisata_TextChanged;
            // 
            // id_pengunjung
            // 
            id_pengunjung.AutoSize = true;
            id_pengunjung.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            id_pengunjung.Location = new Point(26, 416);
            id_pengunjung.Name = "id_pengunjung";
            id_pengunjung.Size = new Size(118, 20);
            id_pengunjung.TabIndex = 8;
            id_pengunjung.Text = "ID Pengunjung";
            id_pengunjung.Click += id_pengunjung_Click;
            // 
            // textbox_idPengunjung
            // 
            textbox_idPengunjung.Location = new Point(21, 439);
            textbox_idPengunjung.Name = "textbox_idPengunjung";
            textbox_idPengunjung.Size = new Size(471, 27);
            textbox_idPengunjung.TabIndex = 7;
            textbox_idPengunjung.TextChanged += textbox_idPengunjung_TextChanged;
            // 
            // gridView_Data
            // 
            gridView_Data.BackgroundColor = SystemColors.Control;
            gridView_Data.BorderStyle = BorderStyle.None;
            gridView_Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView_Data.Location = new Point(642, 95);
            gridView_Data.Name = "gridView_Data";
            gridView_Data.RowHeadersWidth = 51;
            gridView_Data.RowTemplate.Height = 29;
            gridView_Data.Size = new Size(697, 557);
            gridView_Data.TabIndex = 9;
            gridView_Data.CellContentClick += gridView_Data_CellContentClick;
            // 
            // button_Search
            // 
            button_Search.Location = new Point(26, 539);
            button_Search.Name = "button_Search";
            button_Search.Size = new Size(94, 29);
            button_Search.TabIndex = 10;
            button_Search.Text = "Search";
            button_Search.UseVisualStyleBackColor = true;
            button_Search.Click += button_Search_Click;
            // 
            // button_Update
            // 
            button_Update.Location = new Point(203, 539);
            button_Update.Name = "button_Update";
            button_Update.Size = new Size(94, 29);
            button_Update.TabIndex = 11;
            button_Update.Text = "Update";
            button_Update.UseVisualStyleBackColor = true;
            button_Update.Click += button_Update_Click;
            // 
            // button_Create
            // 
            button_Create.Location = new Point(398, 539);
            button_Create.Name = "button_Create";
            button_Create.Size = new Size(94, 29);
            button_Create.TabIndex = 12;
            button_Create.Text = "Create";
            button_Create.UseVisualStyleBackColor = true;
            button_Create.Click += button_Create_Click;
            // 
            // CUR_Pengunjung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_Create);
            Controls.Add(button_Update);
            Controls.Add(button_Search);
            Controls.Add(gridView_Data);
            Controls.Add(id_pengunjung);
            Controls.Add(textbox_idPengunjung);
            Controls.Add(label_idWisata);
            Controls.Add(textbox_idWisata);
            Controls.Add(label1);
            Controls.Add(textbox_asal);
            Controls.Add(label_namaPengunjung);
            Controls.Add(textbox_Nama);
            Controls.Add(panel1);
            Name = "CUR_Pengunjung";
            Size = new Size(1342, 655);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridView_Data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label Status_Database;
        private Label jdl_Header;
        private TextBox textbox_Nama;
        private Label label_namaPengunjung;
        private Label label1;
        private TextBox textbox_asal;
        private Label label_idWisata;
        private TextBox textbox_idWisata;
        private Label id_pengunjung;
        private TextBox textbox_idPengunjung;
        private DataGridView gridView_Data;
        private Button button_Search;
        private Button button_Update;
        private Button button_Create;
    }
}
