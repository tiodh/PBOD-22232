namespace CUD_DataTiket
{
    partial class EditTiketing
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
            PanelReadDataTiket = new Panel();
            JudulDataTiketRead = new Label();
            pictureBox1 = new PictureBox();
            panelDetailTiket = new Panel();
            btnPopUpInfo = new Button();
            button4UpdateTIket = new Button();
            button2 = new Button();
            btnClearIsi = new Button();
            btnTambahTiket = new Button();
            label5 = new Label();
            btnClearDataTket = new Button();
            label3 = new Label();
            label1 = new Label();
            CariTiket = new TextBox();
            label2 = new Label();
            NamaKolom = new ComboBox();
            txtHargaTiket = new TextBox();
            txtDeskTiket = new TextBox();
            txtNamaTiket = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label4 = new Label();
            DataGridViewEditTiket = new DataGridView();
            txtIDTIket = new TextBox();
            IDTiketlabel6 = new Label();
            PanelReadDataTiket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelDetailTiket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEditTiket).BeginInit();
            SuspendLayout();
            // 
            // PanelReadDataTiket
            // 
            PanelReadDataTiket.AutoScroll = true;
            PanelReadDataTiket.AutoSize = true;
            PanelReadDataTiket.BackColor = Color.FromArgb(111, 106, 248);
            PanelReadDataTiket.Controls.Add(JudulDataTiketRead);
            PanelReadDataTiket.Controls.Add(pictureBox1);
            PanelReadDataTiket.Controls.Add(panelDetailTiket);
            PanelReadDataTiket.Location = new Point(8, 8);
            PanelReadDataTiket.Name = "PanelReadDataTiket";
            PanelReadDataTiket.Size = new Size(1030, 768);
            PanelReadDataTiket.TabIndex = 4;
            PanelReadDataTiket.Paint += PanelReadDataTiket_Paint;
            // 
            // JudulDataTiketRead
            // 
            JudulDataTiketRead.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JudulDataTiketRead.AutoSize = true;
            JudulDataTiketRead.BackColor = Color.FromArgb(111, 106, 248);
            JudulDataTiketRead.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            JudulDataTiketRead.ForeColor = Color.White;
            JudulDataTiketRead.Location = new Point(267, 25);
            JudulDataTiketRead.Name = "JudulDataTiketRead";
            JudulDataTiketRead.Size = new Size(429, 24);
            JudulDataTiketRead.TabIndex = 12;
            JudulDataTiketRead.Text = "TAMPILAN ADMIN EDIT DATA TIKET REMBANGAN";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(-5, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1026, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelDetailTiket
            // 
            panelDetailTiket.BackColor = Color.White;
            panelDetailTiket.Controls.Add(txtIDTIket);
            panelDetailTiket.Controls.Add(IDTiketlabel6);
            panelDetailTiket.Controls.Add(btnPopUpInfo);
            panelDetailTiket.Controls.Add(button4UpdateTIket);
            panelDetailTiket.Controls.Add(button2);
            panelDetailTiket.Controls.Add(btnClearIsi);
            panelDetailTiket.Controls.Add(btnTambahTiket);
            panelDetailTiket.Controls.Add(label5);
            panelDetailTiket.Controls.Add(btnClearDataTket);
            panelDetailTiket.Controls.Add(label3);
            panelDetailTiket.Controls.Add(label1);
            panelDetailTiket.Controls.Add(CariTiket);
            panelDetailTiket.Controls.Add(label2);
            panelDetailTiket.Controls.Add(NamaKolom);
            panelDetailTiket.Controls.Add(txtHargaTiket);
            panelDetailTiket.Controls.Add(txtDeskTiket);
            panelDetailTiket.Controls.Add(txtNamaTiket);
            panelDetailTiket.Controls.Add(label9);
            panelDetailTiket.Controls.Add(label8);
            panelDetailTiket.Controls.Add(label7);
            panelDetailTiket.Controls.Add(label4);
            panelDetailTiket.Controls.Add(DataGridViewEditTiket);
            panelDetailTiket.Location = new Point(28, 110);
            panelDetailTiket.Name = "panelDetailTiket";
            panelDetailTiket.Padding = new Padding(5);
            panelDetailTiket.Size = new Size(964, 638);
            panelDetailTiket.TabIndex = 11;
            // 
            // btnPopUpInfo
            // 
            btnPopUpInfo.Location = new Point(828, 284);
            btnPopUpInfo.Name = "btnPopUpInfo";
            btnPopUpInfo.Size = new Size(113, 23);
            btnPopUpInfo.TabIndex = 28;
            btnPopUpInfo.Text = "Help";
            btnPopUpInfo.UseVisualStyleBackColor = true;
            // 
            // button4UpdateTIket
            // 
            button4UpdateTIket.BackColor = Color.DeepSkyBlue;
            button4UpdateTIket.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4UpdateTIket.Location = new Point(774, 485);
            button4UpdateTIket.Name = "button4UpdateTIket";
            button4UpdateTIket.Size = new Size(167, 58);
            button4UpdateTIket.TabIndex = 27;
            button4UpdateTIket.Text = "Perbarui Data";
            button4UpdateTIket.UseVisualStyleBackColor = false;
            button4UpdateTIket.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(241, 85, 63);
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(597, 549);
            button2.Name = "button2";
            button2.Size = new Size(344, 58);
            button2.TabIndex = 25;
            button2.Text = "Hapus Data";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnClearIsi
            // 
            btnClearIsi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearIsi.Location = new Point(597, 360);
            btnClearIsi.Name = "btnClearIsi";
            btnClearIsi.Size = new Size(344, 58);
            btnClearIsi.TabIndex = 24;
            btnClearIsi.Text = "Clear";
            btnClearIsi.UseVisualStyleBackColor = true;
            btnClearIsi.Click += btnClearIsi_Click;
            // 
            // btnTambahTiket
            // 
            btnTambahTiket.BackColor = Color.FromArgb(128, 255, 128);
            btnTambahTiket.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnTambahTiket.Location = new Point(597, 485);
            btnTambahTiket.Name = "btnTambahTiket";
            btnTambahTiket.Size = new Size(167, 58);
            btnTambahTiket.TabIndex = 23;
            btnTambahTiket.Text = "Tambah Data";
            btnTambahTiket.UseVisualStyleBackColor = false;
            btnTambahTiket.Click += btnTambahTiket_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label5.Location = new Point(25, 323);
            label5.Name = "label5";
            label5.Size = new Size(249, 22);
            label5.TabIndex = 20;
            label5.Text = "Masukkan dan Ubah Data Disini!";
            // 
            // btnClearDataTket
            // 
            btnClearDataTket.Location = new Point(866, 61);
            btnClearDataTket.Name = "btnClearDataTket";
            btnClearDataTket.Size = new Size(75, 23);
            btnClearDataTket.TabIndex = 19;
            btnClearDataTket.Text = "Clear";
            btnClearDataTket.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(26, 65);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 18;
            label3.Text = "Berdasarkan :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 218);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // CariTiket
            // 
            CariTiket.BackColor = SystemColors.ControlLightLight;
            CariTiket.BorderStyle = BorderStyle.FixedSingle;
            CariTiket.ForeColor = SystemColors.WindowText;
            CariTiket.Location = new Point(369, 61);
            CariTiket.Name = "CariTiket";
            CariTiket.Size = new Size(485, 23);
            CariTiket.TabIndex = 16;
            CariTiket.TextChanged += CariTiket_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 65);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 15;
            label2.Text = "Cari :";
            // 
            // NamaKolom
            // 
            NamaKolom.FormattingEnabled = true;
            NamaKolom.Items.AddRange(new object[] { "ID Tiket", "Nama", "Deskripsi", "Harga" });
            NamaKolom.Location = new Point(103, 61);
            NamaKolom.Name = "NamaKolom";
            NamaKolom.Size = new Size(204, 23);
            NamaKolom.TabIndex = 4;
            NamaKolom.SelectedIndexChanged += NamaKolom_SelectedIndexChanged_1;
            NamaKolom.SelectedValueChanged += NamaKolom_SelectedValueChanged;
            // 
            // txtHargaTiket
            // 
            txtHargaTiket.BackColor = SystemColors.Window;
            txtHargaTiket.BorderStyle = BorderStyle.FixedSingle;
            txtHargaTiket.Location = new Point(140, 584);
            txtHargaTiket.Name = "txtHargaTiket";
            txtHargaTiket.Size = new Size(432, 23);
            txtHargaTiket.TabIndex = 14;
            txtHargaTiket.TextChanged += txtHargaTiket_TextChanged;
            // 
            // txtDeskTiket
            // 
            txtDeskTiket.BackColor = SystemColors.Window;
            txtDeskTiket.BorderStyle = BorderStyle.FixedSingle;
            txtDeskTiket.Location = new Point(131, 483);
            txtDeskTiket.Multiline = true;
            txtDeskTiket.Name = "txtDeskTiket";
            txtDeskTiket.Size = new Size(440, 84);
            txtDeskTiket.TabIndex = 13;
            txtDeskTiket.TextChanged += txtDeskTiket_TextChanged;
            // 
            // txtNamaTiket
            // 
            txtNamaTiket.BackColor = SystemColors.Window;
            txtNamaTiket.BorderStyle = BorderStyle.FixedSingle;
            txtNamaTiket.Location = new Point(131, 407);
            txtNamaTiket.Multiline = true;
            txtNamaTiket.Name = "txtNamaTiket";
            txtNamaTiket.Size = new Size(440, 53);
            txtNamaTiket.TabIndex = 12;
            txtNamaTiket.TextChanged += txtNamaTiket_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(26, 588);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 11;
            label9.Text = "Harga Tiket      :  Rp";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 483);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 10;
            label8.Text = "Deskripsi Tiket :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 407);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 9;
            label7.Text = "Nama Tiket      :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(25, 20);
            label4.Name = "label4";
            label4.Size = new Size(213, 22);
            label4.TabIndex = 4;
            label4.Text = "Edit Data Tiket Rembangan";
            // 
            // DataGridViewEditTiket
            // 
            DataGridViewEditTiket.AllowUserToAddRows = false;
            DataGridViewEditTiket.AllowUserToDeleteRows = false;
            DataGridViewEditTiket.AllowUserToResizeColumns = false;
            DataGridViewEditTiket.AllowUserToResizeRows = false;
            DataGridViewEditTiket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewEditTiket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewEditTiket.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewEditTiket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewEditTiket.Location = new Point(26, 94);
            DataGridViewEditTiket.Name = "DataGridViewEditTiket";
            DataGridViewEditTiket.ReadOnly = true;
            DataGridViewEditTiket.RowTemplate.Height = 25;
            DataGridViewEditTiket.Size = new Size(915, 184);
            DataGridViewEditTiket.TabIndex = 5;
            DataGridViewEditTiket.CellClick += DataGridViewEditTiket_CellClick;
            DataGridViewEditTiket.CellContentClick += DataGridViewEditTiket_CellContentClick;
            // 
            // txtIDTIket
            // 
            txtIDTIket.BackColor = SystemColors.Window;
            txtIDTIket.BorderStyle = BorderStyle.FixedSingle;
            txtIDTIket.Location = new Point(139, 360);
            txtIDTIket.Name = "txtIDTIket";
            txtIDTIket.Size = new Size(432, 23);
            txtIDTIket.TabIndex = 30;
            txtIDTIket.TextChanged += textBox1_TextChanged;
            // 
            // IDTiketlabel6
            // 
            IDTiketlabel6.AutoSize = true;
            IDTiketlabel6.Location = new Point(25, 364);
            IDTiketlabel6.Name = "IDTiketlabel6";
            IDTiketlabel6.Size = new Size(91, 15);
            IDTiketlabel6.TabIndex = 29;
            IDTiketlabel6.Text = "ID Tiket            :  ";
            // 
            // EditTiketing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 768);
            Controls.Add(PanelReadDataTiket);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditTiketing";
            PanelReadDataTiket.ResumeLayout(false);
            PanelReadDataTiket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelDetailTiket.ResumeLayout(false);
            panelDetailTiket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewEditTiket).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelReadDataTiket;
        private Label JudulDataTiketRead;
        private PictureBox pictureBox1;
        private Panel panelDetailTiket;
        private Button button4UpdateTIket;
        private Button button2;
        private Button btnClearIsi;
        private Button btnTambahTiket;
        private Label label5;
        private Button btnClearDataTket;
        private Label label3;
        private Label label1;
        private TextBox CariTiket;
        private Label label2;
        private ComboBox NamaKolom;
        private TextBox txtHargaTiket;
        private TextBox txtDeskTiket;
        private TextBox txtNamaTiket;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label4;
        private DataGridView DataGridViewEditTiket;
        private Button btnPopUpInfo;
        private TextBox txtIDTIket;
        private Label IDTiketlabel6;
    }
}