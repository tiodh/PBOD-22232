namespace frontendpbo
{
    partial class FormDetailDataTiket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailDataTiket));
            PanelReadDataTiket = new Panel();
            panelJudulReadData = new Panel();
            JudulDataTiketRead = new Label();
            BGJudulTampilanTiket = new PictureBox();
            panelDetailTiket = new Panel();
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
            panelInfoTiket = new Panel();
            pictureBoxKendaraan = new PictureBox();
            textBoxTiketParkir = new TextBox();
            labelHarga = new Label();
            radioButtonRoda4 = new RadioButton();
            radioButtonRoda2 = new RadioButton();
            labelInfoTiketParkir = new Label();
            imageListKendaraan = new ImageList(components);
            imageListDetailTiket = new ImageList(components);
            PanelReadDataTiket.SuspendLayout();
            panelJudulReadData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BGJudulTampilanTiket).BeginInit();
            panelDetailTiket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTiket).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNamaTiket).BeginInit();
            panelInfoTiket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKendaraan).BeginInit();
            SuspendLayout();
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
            PanelReadDataTiket.Size = new Size(1030, 768);
            PanelReadDataTiket.TabIndex = 3;
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
            panelJudulReadData.Size = new Size(1030, 68);
            panelJudulReadData.TabIndex = 13;
            // 
            // JudulDataTiketRead
            // 
            JudulDataTiketRead.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JudulDataTiketRead.AutoSize = true;
            JudulDataTiketRead.BackColor = Color.FromArgb(111, 106, 248);
            JudulDataTiketRead.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            JudulDataTiketRead.ForeColor = Color.White;
            JudulDataTiketRead.Location = new Point(324, 22);
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
            BGJudulTampilanTiket.Size = new Size(1010, 68);
            BGJudulTampilanTiket.SizeMode = PictureBoxSizeMode.Zoom;
            BGJudulTampilanTiket.TabIndex = 4;
            BGJudulTampilanTiket.TabStop = false;
            // 
            // panelDetailTiket
            // 
            panelDetailTiket.BackColor = Color.White;
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
            panelDetailTiket.Size = new Size(964, 468);
            panelDetailTiket.TabIndex = 11;
            // 
            // btnClearTket
            // 
            btnClearTket.Location = new Point(866, 61);
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
            label3.Location = new Point(26, 64);
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
            SearchTiket.Location = new Point(369, 61);
            SearchTiket.Name = "SearchTiket";
            SearchTiket.Size = new Size(485, 23);
            SearchTiket.TabIndex = 16;
            SearchTiket.TextChanged += SearchTiket_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 64);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 15;
            label2.Text = "Cari :";
            // 
            // KolomTiket
            // 
            KolomTiket.FormattingEnabled = true;
            KolomTiket.Items.AddRange(new object[] { "ID Tiket", "Nama", "Deskripsi", "Harga" });
            KolomTiket.Location = new Point(103, 61);
            KolomTiket.Name = "KolomTiket";
            KolomTiket.Size = new Size(204, 23);
            KolomTiket.TabIndex = 4;
            // 
            // HargaTiket
            // 
            HargaTiket.BackColor = SystemColors.InactiveCaption;
            HargaTiket.BorderStyle = BorderStyle.FixedSingle;
            HargaTiket.Location = new Point(540, 422);
            HargaTiket.Name = "HargaTiket";
            HargaTiket.Size = new Size(401, 23);
            HargaTiket.TabIndex = 14;
            // 
            // DataGridViewTiket
            // 
            DataGridViewTiket.AllowUserToAddRows = false;
            DataGridViewTiket.AllowUserToDeleteRows = false;
            DataGridViewTiket.AllowUserToResizeColumns = false;
            DataGridViewTiket.AllowUserToResizeRows = false;
            DataGridViewTiket.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DataGridViewTiket.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewTiket.BackgroundColor = SystemColors.ButtonHighlight;
            DataGridViewTiket.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewTiket.Location = new Point(26, 95);
            DataGridViewTiket.Name = "DataGridViewTiket";
            DataGridViewTiket.ReadOnly = true;
            DataGridViewTiket.RowTemplate.Height = 25;
            DataGridViewTiket.Size = new Size(915, 158);
            DataGridViewTiket.TabIndex = 5;
            DataGridViewTiket.CellContentClick += DataGridViewTiket_CellContentClick;
            // 
            // DeskTiket
            // 
            DeskTiket.BackColor = SystemColors.InactiveCaption;
            DeskTiket.BorderStyle = BorderStyle.FixedSingle;
            DeskTiket.Location = new Point(540, 338);
            DeskTiket.Multiline = true;
            DeskTiket.Name = "DeskTiket";
            DeskTiket.Size = new Size(401, 71);
            DeskTiket.TabIndex = 13;
            // 
            // NamaTiket
            // 
            NamaTiket.BackColor = SystemColors.InactiveCaption;
            NamaTiket.BorderStyle = BorderStyle.FixedSingle;
            NamaTiket.Location = new Point(540, 272);
            NamaTiket.Multiline = true;
            NamaTiket.Name = "NamaTiket";
            NamaTiket.Size = new Size(401, 53);
            NamaTiket.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(446, 424);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 11;
            label9.Text = "Harga Tiket      :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(446, 340);
            label8.Name = "label8";
            label8.Size = new Size(88, 15);
            label8.TabIndex = 10;
            label8.Text = "Deskripsi Tiket :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 272);
            label7.Name = "label7";
            label7.Size = new Size(88, 15);
            label7.TabIndex = 9;
            label7.Text = "Nama Tiket      :";
            // 
            // pictureBoxNamaTiket
            // 
            pictureBoxNamaTiket.Location = new Point(26, 272);
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
            // panelInfoTiket
            // 
            panelInfoTiket.BackColor = Color.White;
            panelInfoTiket.Controls.Add(pictureBoxKendaraan);
            panelInfoTiket.Controls.Add(textBoxTiketParkir);
            panelInfoTiket.Controls.Add(labelHarga);
            panelInfoTiket.Controls.Add(radioButtonRoda4);
            panelInfoTiket.Controls.Add(radioButtonRoda2);
            panelInfoTiket.Controls.Add(labelInfoTiketParkir);
            panelInfoTiket.Location = new Point(35, 572);
            panelInfoTiket.Name = "panelInfoTiket";
            panelInfoTiket.Size = new Size(964, 179);
            panelInfoTiket.TabIndex = 2;
            // 
            // pictureBoxKendaraan
            // 
            pictureBoxKendaraan.Location = new Point(250, 9);
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
            textBoxTiketParkir.Location = new Point(591, 87);
            textBoxTiketParkir.Name = "textBoxTiketParkir";
            textBoxTiketParkir.Size = new Size(122, 23);
            textBoxTiketParkir.TabIndex = 11;
            // 
            // labelHarga
            // 
            labelHarga.AutoSize = true;
            labelHarga.Location = new Point(527, 90);
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
            radioButtonRoda4.Location = new Point(26, 106);
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
            radioButtonRoda2.Location = new Point(26, 68);
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
            labelInfoTiketParkir.Location = new Point(20, 15);
            labelInfoTiketParkir.Name = "labelInfoTiketParkir";
            labelInfoTiketParkir.Size = new Size(174, 22);
            labelInfoTiketParkir.TabIndex = 1;
            labelInfoTiketParkir.Text = "Informasi Tiket Parkir";
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
            // FormDetailDataTiket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1030, 768);
            ControlBox = false;
            Controls.Add(PanelReadDataTiket);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDetailDataTiket";
            WindowState = FormWindowState.Maximized;
            Load += FormDetailDataTiket_Load;
            PanelReadDataTiket.ResumeLayout(false);
            panelJudulReadData.ResumeLayout(false);
            panelJudulReadData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BGJudulTampilanTiket).EndInit();
            panelDetailTiket.ResumeLayout(false);
            panelDetailTiket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewTiket).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNamaTiket).EndInit();
            panelInfoTiket.ResumeLayout(false);
            panelInfoTiket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKendaraan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelReadDataTiket;
        private Panel panelJudulReadData;
        private Label JudulDataTiketRead;
        private PictureBox BGJudulTampilanTiket;
        private Panel panelDetailTiket;
        private TextBox SearchTiket;
        private Label label2;
        private TextBox HargaTiket;
        private TextBox DeskTiket;
        private TextBox NamaTiket;
        private Label label9;
        private Label label8;
        private Label label7;
        private PictureBox pictureBoxNamaTiket;
        private Label labelDetailtiketRembangan;
        private DataGridView DataGridViewTiket;
        private ComboBox KolomTiket;
        private Panel panelInfoTiket;
        private PictureBox pictureBoxKendaraan;
        private TextBox textBoxTiketParkir;
        private Label labelHarga;
        private RadioButton radioButtonRoda4;
        private RadioButton radioButtonRoda2;
        private Label labelInfoTiketParkir;
        private ImageList imageListKendaraan;
        private ImageList imageListDetailTiket;
        private Label label3;
        private Label label1;
        private Button btnClearTket;
    }
}