namespace frontendpbo
{
    partial class DetailTiket
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailTiket));
            imageListKendaraan = new ImageList(components);
            imageListDetailTiket = new ImageList(components);
            panelInfoTiket = new Panel();
            pictureBoxKendaraan = new PictureBox();
            textBoxTiketParkir = new TextBox();
            labelHarga = new Label();
            radioButtonRoda4 = new RadioButton();
            radioButtonRoda2 = new RadioButton();
            labelInfoTiketParkir = new Label();
            panelDetailTiket = new Panel();
            InformationTiketPopUp = new Button();
            IDTiket = new TextBox();
            label4 = new Label();
            btnClearTket = new Button();
            label3 = new Label();
            label1 = new Label();
            SearchTiket = new TextBox();
            label2 = new Label();
            KolomTiket = new ComboBox();
            HargaTiket = new TextBox();
            DataGridViewTiket = new DataGridView();
            DeskTiket = new TextBox();
            NamaTiket = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pictureBoxNamaTiket = new PictureBox();
            labelDetailtiketRembangan = new Label();
            panelJudulReadData = new Panel();
            JudulDataTiketRead = new Label();
            BGJudulTampilanTiket = new PictureBox();
            PanelReadDataTiket = new Panel();
            panelInfoTiket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKendaraan).BeginInit();
            panelDetailTiket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNamaTiket).BeginInit();
            panelJudulReadData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BGJudulTampilanTiket).BeginInit();
            PanelReadDataTiket.SuspendLayout();
            SuspendLayout();
            // 
            // imageListKendaraan
            // 
            imageListKendaraan.ColorDepth = ColorDepth.Depth8Bit;
            imageListKendaraan.ImageStream = (ImageListStreamer)resources.GetObject("imageListKendaraan.ImageStream");
            imageListKendaraan.TransparentColor = Color.Transparent;
            imageListKendaraan.Images.SetKeyName(0, "Kendaraan Awal.png");
            imageListKendaraan.Images.SetKeyName(1, "Roda 2.png");
            imageListKendaraan.Images.SetKeyName(2, "Roda 4.png");
            // 
            // imageListDetailTiket
            // 
            imageListDetailTiket.ColorDepth = ColorDepth.Depth8Bit;
            imageListDetailTiket.ImageStream = (ImageListStreamer)resources.GetObject("imageListDetailTiket.ImageStream");
            imageListDetailTiket.TransparentColor = Color.Transparent;
            imageListDetailTiket.Images.SetKeyName(0, "Tiket Rembangan.png");
            // 
            // panelInfoTiket
            // 
            panelInfoTiket.BackColor = Color.White;
            panelInfoTiket.Controls.Add(pictureBoxKendaraan);
            panelInfoTiket.Controls.Add(textBoxTiketParkir);
            panelInfoTiket.Controls.Add(labelHarga);
            panelInfoTiket.Controls.Add(radioButtonRoda4);
            panelInfoTiket.Controls.Add(radioButtonRoda2);
            panelInfoTiket.Controls.Add(labelInfoTiketParkir);
            panelInfoTiket.Location = new Point(35, 760);
            panelInfoTiket.Name = "panelInfoTiket";
            panelInfoTiket.Size = new Size(1361, 234);
            panelInfoTiket.TabIndex = 2;
            // 
            // pictureBoxKendaraan
            // 
            pictureBoxKendaraan.Location = new Point(254, 40);
            pictureBoxKendaraan.Name = "pictureBoxKendaraan";
            pictureBoxKendaraan.Size = new Size(244, 161);
            pictureBoxKendaraan.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxKendaraan.TabIndex = 12;
            pictureBoxKendaraan.TabStop = false;
            // 
            // textBoxTiketParkir
            // 
            textBoxTiketParkir.BackColor = SystemColors.InactiveCaption;
            textBoxTiketParkir.BorderStyle = BorderStyle.FixedSingle;
            textBoxTiketParkir.Location = new Point(593, 110);
            textBoxTiketParkir.Name = "textBoxTiketParkir";
            textBoxTiketParkir.Size = new Size(122, 23);
            textBoxTiketParkir.TabIndex = 11;
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(529, 113);
            labelHarga.Name = "labelHarga";
            labelHarga.Size = new Size(65, 15);
            labelHarga.TabIndex = 10;
            labelHarga.Text = "Harga :  Rp";
            // 
            // radioButtonRoda4
            // 
            radioButtonRoda4.AutoSize = true;
            radioButtonRoda4.ForeColor = Color.Black;
            radioButtonRoda4.ImageAlign = ContentAlignment.BottomLeft;
            radioButtonRoda4.Location = new Point(28, 114);
            radioButtonRoda4.Name = "radioButtonRoda4";
            radioButtonRoda4.Size = new Size(120, 19);
            radioButtonRoda4.TabIndex = 3;
            radioButtonRoda4.Text = "Kendaraan Roda 4";
            radioButtonRoda4.UseVisualStyleBackColor = true;
            radioButtonRoda4.CheckedChanged += radioButtonRoda4_CheckedChanged;
            // 
            // radioButtonRoda2
            // 
            radioButtonRoda2.AutoSize = true;
            radioButtonRoda2.ForeColor = Color.Black;
            radioButtonRoda2.Location = new Point(28, 76);
            radioButtonRoda2.Name = "radioButtonRoda2";
            radioButtonRoda2.Size = new Size(120, 19);
            radioButtonRoda2.TabIndex = 2;
            radioButtonRoda2.Text = "Kendaraan Roda 2";
            radioButtonRoda2.UseVisualStyleBackColor = true;
            radioButtonRoda2.CheckedChanged += radioButtonRoda2_CheckedChanged;
            // 
            // labelInfoTiketParkir
            // 
            labelInfoTiketParkir.AutoSize = true;
            labelInfoTiketParkir.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelInfoTiketParkir.ForeColor = Color.Black;
            labelInfoTiketParkir.Location = new Point(22, 23);
            labelInfoTiketParkir.Name = "labelInfoTiketParkir";
            labelInfoTiketParkir.Size = new Size(174, 22);
            labelInfoTiketParkir.TabIndex = 1;
            labelInfoTiketParkir.Text = "Informasi Tiket Parkir";
            // 
            // panelDetailTiket
            // 
            panelDetailTiket.BackColor = Color.White;
            panelDetailTiket.Controls.Add(InformationTiketPopUp);
            panelDetailTiket.Controls.Add(IDTiket);
            panelDetailTiket.Controls.Add(label4);
            panelDetailTiket.Controls.Add(btnClearTket);
            panelDetailTiket.Controls.Add(label3);
            panelDetailTiket.Controls.Add(label1);
            panelDetailTiket.Controls.Add(SearchTiket);
            panelDetailTiket.Controls.Add(label2);
            panelDetailTiket.Controls.Add(KolomTiket);
            panelDetailTiket.Controls.Add(HargaTiket);
            panelDetailTiket.Controls.Add(DataGridViewTiket);
            panelDetailTiket.Controls.Add(DeskTiket);
            panelDetailTiket.Controls.Add(NamaTiket);
            panelDetailTiket.Controls.Add(label9);
            panelDetailTiket.Controls.Add(label8);
            panelDetailTiket.Controls.Add(label7);
            panelDetailTiket.Controls.Add(pictureBoxNamaTiket);
            panelDetailTiket.Controls.Add(labelDetailtiketRembangan);
            panelDetailTiket.Location = new Point(35, 87);
            panelDetailTiket.Name = "panelDetailTiket";
            panelDetailTiket.Padding = new Padding(5);
            panelDetailTiket.Size = new Size(1361, 630);
            panelDetailTiket.TabIndex = 11;
            // 
            // InformationTiketPopUp
            // 
            InformationTiketPopUp.Location = new Point(1226, 371);
            InformationTiketPopUp.Name = "InformationTiketPopUp";
            InformationTiketPopUp.Size = new Size(111, 23);
            InformationTiketPopUp.TabIndex = 22;
            InformationTiketPopUp.Text = "More Information";
            InformationTiketPopUp.UseVisualStyleBackColor = true;
            InformationTiketPopUp.Click += InformationTiketPopUp_Click;
            // 
            // IDTiket
            // 
            IDTiket.BackColor = SystemColors.InactiveCaption;
            IDTiket.BorderStyle = BorderStyle.FixedSingle;
            IDTiket.Location = new Point(529, 412);
            IDTiket.Name = "IDTiket";
            IDTiket.Size = new Size(808, 23);
            IDTiket.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 415);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 20;
            label4.Text = "ID Tiket             :";
            // 
            // btnClearTket
            // 
            btnClearTket.Location = new Point(1262, 56);
            btnClearTket.Name = "btnClearTket";
            btnClearTket.Size = new Size(75, 23);
            btnClearTket.TabIndex = 19;
            btnClearTket.Text = "Clear";
            btnClearTket.UseVisualStyleBackColor = true;
            btnClearTket.Click += btnClearTket_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(26, 59);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 18;
            label3.Text = "Berdasarkan :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 213);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // SearchTiket
            // 
            SearchTiket.BackColor = SystemColors.ControlLightLight;
            SearchTiket.BorderStyle = BorderStyle.FixedSingle;
            SearchTiket.ForeColor = SystemColors.WindowText;
            SearchTiket.Location = new Point(540, 56);
            SearchTiket.Name = "SearchTiket";
            SearchTiket.Size = new Size(716, 23);
            SearchTiket.TabIndex = 16;
            SearchTiket.TextChanged += SearchTiket_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(500, 59);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 15;
            label2.Text = "Cari :";
            // 
            // KolomTiket
            // 
            KolomTiket.FormattingEnabled = true;
            KolomTiket.Items.AddRange(new object[] { "id_tiket", "nama_tiket", "deskripsi_tiket", "harga_tiket", "wisata_id" });
            KolomTiket.Location = new Point(103, 56);
            KolomTiket.Name = "KolomTiket";
            KolomTiket.Size = new Size(362, 23);
            KolomTiket.TabIndex = 4;
            // 
            // HargaTiket
            // 
            HargaTiket.BackColor = SystemColors.InactiveCaption;
            HargaTiket.BorderStyle = BorderStyle.FixedSingle;
            HargaTiket.Location = new Point(529, 586);
            HargaTiket.Name = "HargaTiket";
            HargaTiket.Size = new Size(808, 23);
            HargaTiket.TabIndex = 14;
            // 
            // DataGridViewTiket
            // 
            DataGridViewTiket.AllowUserToAddRows = false;
            DataGridViewTiket.AllowUserToDeleteRows = false;
            DataGridViewTiket.AllowUserToResizeColumns = false;
            DataGridViewTiket.AllowUserToResizeRows = false;
            DataGridViewTiket.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewTiket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTiket.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewTiket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTiket.Location = new Point(20, 85);
            DataGridViewTiket.Name = "DataGridViewTiket";
            DataGridViewTiket.ReadOnly = true;
            DataGridViewTiket.RowTemplate.Height = 25;
            DataGridViewTiket.Size = new Size(1318, 280);
            DataGridViewTiket.TabIndex = 5;
            DataGridViewTiket.CellContentClick += DataGridViewTiket_CellContentClick;
            // 
            // DeskTiket
            // 
            DeskTiket.BackColor = SystemColors.InactiveCaption;
            DeskTiket.BorderStyle = BorderStyle.FixedSingle;
            DeskTiket.Location = new Point(529, 506);
            DeskTiket.Multiline = true;
            DeskTiket.Name = "DeskTiket";
            DeskTiket.Size = new Size(808, 71);
            DeskTiket.TabIndex = 13;
            // 
            // NamaTiket
            // 
            NamaTiket.BackColor = SystemColors.InactiveCaption;
            NamaTiket.BorderStyle = BorderStyle.FixedSingle;
            NamaTiket.Location = new Point(529, 444);
            NamaTiket.Multiline = true;
            NamaTiket.Name = "NamaTiket";
            NamaTiket.Size = new Size(808, 53);
            NamaTiket.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(435, 585);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 11;
            label9.Text = "Harga Tiket      :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(435, 508);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 10;
            label8.Text = "Deskripsi Tiket :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(435, 444);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 9;
            label7.Text = "Nama Tiket      :";
            // 
            // pictureBoxNamaTiket
            // 
            pictureBoxNamaTiket.Location = new Point(22, 420);
            pictureBoxNamaTiket.Name = "pictureBoxNamaTiket";
            pictureBoxNamaTiket.Size = new Size(384, 173);
            pictureBoxNamaTiket.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNamaTiket.TabIndex = 8;
            pictureBoxNamaTiket.TabStop = false;
            // 
            // labelDetailtiketRembangan
            // 
            labelDetailtiketRembangan.AutoSize = true;
            labelDetailtiketRembangan.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelDetailtiketRembangan.Location = new Point(20, 15);
            labelDetailtiketRembangan.Name = "labelDetailtiketRembangan";
            labelDetailtiketRembangan.Size = new Size(188, 22);
            labelDetailtiketRembangan.TabIndex = 4;
            labelDetailtiketRembangan.Text = "Detail Tiket Rembangan";
            // 
            // panelJudulReadData
            // 
            panelJudulReadData.BackColor = Color.White;
            panelJudulReadData.Controls.Add(JudulDataTiketRead);
            panelJudulReadData.Controls.Add(BGJudulTampilanTiket);
            panelJudulReadData.Dock = DockStyle.Top;
            panelJudulReadData.Location = new Point(0, 0);
            panelJudulReadData.Margin = new Padding(2);
            panelJudulReadData.Name = "panelJudulReadData";
            panelJudulReadData.Padding = new Padding(8, 0, 8, 0);
            panelJudulReadData.Size = new Size(1428, 68);
            panelJudulReadData.TabIndex = 13;
            // 
            // JudulDataTiketRead
            // 
            JudulDataTiketRead.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JudulDataTiketRead.AutoSize = true;
            JudulDataTiketRead.BackColor = Color.FromArgb(111, 106, 248);
            JudulDataTiketRead.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            JudulDataTiketRead.ForeColor = Color.White;
            JudulDataTiketRead.Location = new Point(531, 22);
            JudulDataTiketRead.Name = "JudulDataTiketRead";
            JudulDataTiketRead.Size = new Size(383, 24);
            JudulDataTiketRead.TabIndex = 2;
            JudulDataTiketRead.Text = "TAMPILAN ADMIN DATA TIKET REMBANGAN";
            // 
            // BGJudulTampilanTiket
            // 
            BGJudulTampilanTiket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BGJudulTampilanTiket.Image = Properties.Resources.Rectangle_28__1_;
            BGJudulTampilanTiket.Location = new Point(10, 0);
            BGJudulTampilanTiket.Margin = new Padding(2);
            BGJudulTampilanTiket.Name = "BGJudulTampilanTiket";
            BGJudulTampilanTiket.Size = new Size(1408, 68);
            BGJudulTampilanTiket.SizeMode = PictureBoxSizeMode.Zoom;
            BGJudulTampilanTiket.TabIndex = 4;
            BGJudulTampilanTiket.TabStop = false;
            // 
            // PanelReadDataTiket
            // 
            PanelReadDataTiket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelReadDataTiket.AutoScroll = true;
            PanelReadDataTiket.AutoSize = true;
            PanelReadDataTiket.BackColor = Color.FromArgb(111, 106, 248);
            PanelReadDataTiket.Controls.Add(panelJudulReadData);
            PanelReadDataTiket.Controls.Add(panelDetailTiket);
            PanelReadDataTiket.Controls.Add(panelInfoTiket);
            PanelReadDataTiket.Location = new Point(0, 0);
            PanelReadDataTiket.Name = "PanelReadDataTiket";
            PanelReadDataTiket.Size = new Size(1428, 1043);
            PanelReadDataTiket.TabIndex = 3;
            // 
            // DetailTiket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(1440, 1024);
            ControlBox = false;
            Controls.Add(PanelReadDataTiket);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetailTiket";
            WindowState = FormWindowState.Maximized;
            Load += FormDetailDataTiket_Load;
            panelInfoTiket.ResumeLayout(false);
            panelInfoTiket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKendaraan).EndInit();
            panelDetailTiket.ResumeLayout(false);
            panelDetailTiket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNamaTiket).EndInit();
            panelJudulReadData.ResumeLayout(false);
            panelJudulReadData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BGJudulTampilanTiket).EndInit();
            PanelReadDataTiket.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ImageList imageListKendaraan;
        private ImageList imageListDetailTiket;
        private Panel panelInfoTiket;
        private PictureBox pictureBoxKendaraan;
        private TextBox textBoxTiketParkir;
        private Label labelHarga;
        private RadioButton radioButtonRoda4;
        private RadioButton radioButtonRoda2;
        private Label labelInfoTiketParkir;
        private Panel panelDetailTiket;
        private Button btnClearTket;
        private Label label3;
        private Label label1;
        private TextBox SearchTiket;
        private Label label2;
        private ComboBox KolomTiket;
        private TextBox HargaTiket;
        private DataGridView DataGridViewTiket;
        private TextBox DeskTiket;
        private TextBox NamaTiket;
        private Label label9;
        private Label label8;
        private Label label7;
        private PictureBox pictureBoxNamaTiket;
        private Label labelDetailtiketRembangan;
        private Panel panelJudulReadData;
        private Label JudulDataTiketRead;
        private PictureBox BGJudulTampilanTiket;
        private Panel PanelReadDataTiket;
        private Button InformationTiketPopUp;
        private TextBox IDTiket;
        private Label label4;
    }
}