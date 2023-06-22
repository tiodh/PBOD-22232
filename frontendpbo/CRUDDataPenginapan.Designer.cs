namespace frontendpbo
{
    partial class CRUDDataPenginapan
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
            NamaPenginapan = new Label();
            DeskripsiPenginapan = new Label();
            NamaPenginapantextBox1 = new TextBox();
            DeskripsiPenginapantextBox2 = new TextBox();
            DataPenginapandataGridView1 = new DataGridView();
            Clearbutton1 = new Button();
            Tambahbutton2 = new Button();
            Editbutton3 = new Button();
            Deletebutton4 = new Button();
            txt_search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataPenginapandataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NamaPenginapan
            // 
            NamaPenginapan.AutoSize = true;
            NamaPenginapan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NamaPenginapan.Location = new Point(65, 73);
            NamaPenginapan.Name = "NamaPenginapan";
            NamaPenginapan.Size = new Size(174, 25);
            NamaPenginapan.TabIndex = 1;
            NamaPenginapan.Text = "Nama Penginapan";
            // 
            // DeskripsiPenginapan
            // 
            DeskripsiPenginapan.AutoSize = true;
            DeskripsiPenginapan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeskripsiPenginapan.Location = new Point(65, 237);
            DeskripsiPenginapan.Name = "DeskripsiPenginapan";
            DeskripsiPenginapan.Size = new Size(202, 25);
            DeskripsiPenginapan.TabIndex = 2;
            DeskripsiPenginapan.Text = "Deskripsi Penginapan";
            // 
            // NamaPenginapantextBox1
            // 
            NamaPenginapantextBox1.Location = new Point(65, 149);
            NamaPenginapantextBox1.Name = "NamaPenginapantextBox1";
            NamaPenginapantextBox1.Size = new Size(404, 27);
            NamaPenginapantextBox1.TabIndex = 3;
            NamaPenginapantextBox1.TextChanged += NamaPenginapantextBox1_TextChanged;
            // 
            // DeskripsiPenginapantextBox2
            // 
            DeskripsiPenginapantextBox2.Location = new Point(65, 313);
            DeskripsiPenginapantextBox2.Multiline = true;
            DeskripsiPenginapantextBox2.Name = "DeskripsiPenginapantextBox2";
            DeskripsiPenginapantextBox2.Size = new Size(404, 288);
            DeskripsiPenginapantextBox2.TabIndex = 4;
            DeskripsiPenginapantextBox2.TextChanged += DeskripsiPenginapantextBox2_TextChanged;
            // 
            // DataPenginapandataGridView1
            // 
            DataPenginapandataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataPenginapandataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataPenginapandataGridView1.Location = new Point(548, 57);
            DataPenginapandataGridView1.Name = "DataPenginapandataGridView1";
            DataPenginapandataGridView1.RowHeadersWidth = 51;
            DataPenginapandataGridView1.RowTemplate.Height = 29;
            DataPenginapandataGridView1.Size = new Size(823, 590);
            DataPenginapandataGridView1.TabIndex = 5;
            DataPenginapandataGridView1.CellClick += DataPenginapandataGridView1_CellClick;
            DataPenginapandataGridView1.CellContentClick += DataPenginapandataGridView1_CellContentClick;
            // 
            // Clearbutton1
            // 
            Clearbutton1.BackColor = Color.Lime;
            Clearbutton1.Location = new Point(590, 675);
            Clearbutton1.Name = "Clearbutton1";
            Clearbutton1.Size = new Size(123, 49);
            Clearbutton1.TabIndex = 6;
            Clearbutton1.Text = "Clear";
            Clearbutton1.UseVisualStyleBackColor = false;
            // 
            // Tambahbutton2
            // 
            Tambahbutton2.BackColor = Color.FromArgb(128, 128, 255);
            Tambahbutton2.Location = new Point(807, 675);
            Tambahbutton2.Name = "Tambahbutton2";
            Tambahbutton2.Size = new Size(123, 49);
            Tambahbutton2.TabIndex = 7;
            Tambahbutton2.Text = "Tambah";
            Tambahbutton2.UseVisualStyleBackColor = false;
            Tambahbutton2.Click += Tambahbutton2_Click;
            // 
            // Editbutton3
            // 
            Editbutton3.BackColor = Color.Gold;
            Editbutton3.Location = new Point(1008, 675);
            Editbutton3.Name = "Editbutton3";
            Editbutton3.Size = new Size(123, 49);
            Editbutton3.TabIndex = 8;
            Editbutton3.Text = "Edit";
            Editbutton3.UseVisualStyleBackColor = false;
            Editbutton3.Click += Editbutton3_Click;
            // 
            // Deletebutton4
            // 
            Deletebutton4.BackColor = Color.Red;
            Deletebutton4.Location = new Point(1205, 675);
            Deletebutton4.Name = "Deletebutton4";
            Deletebutton4.Size = new Size(123, 49);
            Deletebutton4.TabIndex = 9;
            Deletebutton4.Text = "Hapus";
            Deletebutton4.UseVisualStyleBackColor = false;
            Deletebutton4.Click += Deletebutton4_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(548, 24);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(468, 27);
            txt_search.TabIndex = 10;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // CRUDDataPenginapan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(txt_search);
            Controls.Add(Deletebutton4);
            Controls.Add(Editbutton3);
            Controls.Add(Tambahbutton2);
            Controls.Add(Clearbutton1);
            Controls.Add(DataPenginapandataGridView1);
            Controls.Add(DeskripsiPenginapantextBox2);
            Controls.Add(NamaPenginapantextBox1);
            Controls.Add(DeskripsiPenginapan);
            Controls.Add(NamaPenginapan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CRUDDataPenginapan";
            Text = "Form4";
            Load += CRUDDataPenginapan_Load;
            ((System.ComponentModel.ISupportInitialize)DataPenginapandataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NamaPenginapan;
        private Label DeskripsiPenginapan;
        private TextBox NamaPenginapantextBox1;
        private TextBox DeskripsiPenginapantextBox2;
        private DataGridView DataPenginapandataGridView1;
        private Button Clearbutton1;
        private Button Tambahbutton2;
        private Button Editbutton3;
        private Button Deletebutton4;
        private TextBox txt_search;
    }
}