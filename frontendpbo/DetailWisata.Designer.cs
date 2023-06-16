namespace frontendpbo
{
    partial class DetailWisata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailWisata));
            panel_detail_wisata = new Panel();
            dataGridView_detail_wisata = new DataGridView();
            pictureBox_gambar_rembangan = new PictureBox();
            Rembangan_detail_wisata = new Label();
            panel_detail_wisata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_detail_wisata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_gambar_rembangan).BeginInit();
            SuspendLayout();
            // 
            // panel_detail_wisata
            // 
            panel_detail_wisata.BackColor = SystemColors.AppWorkspace;
            panel_detail_wisata.Controls.Add(Rembangan_detail_wisata);
            panel_detail_wisata.Controls.Add(dataGridView_detail_wisata);
            panel_detail_wisata.Location = new Point(12, 273);
            panel_detail_wisata.Name = "panel_detail_wisata";
            panel_detail_wisata.Size = new Size(1388, 692);
            panel_detail_wisata.TabIndex = 0;
            // 
            // dataGridView_detail_wisata
            // 
            dataGridView_detail_wisata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_detail_wisata.Location = new Point(14, 55);
            dataGridView_detail_wisata.Name = "dataGridView_detail_wisata";
            dataGridView_detail_wisata.RowHeadersWidth = 51;
            dataGridView_detail_wisata.RowTemplate.Height = 29;
            dataGridView_detail_wisata.Size = new Size(1350, 612);
            dataGridView_detail_wisata.TabIndex = 0;
            // 
            // pictureBox_gambar_rembangan
            // 
            pictureBox_gambar_rembangan.Image = (Image)resources.GetObject("pictureBox_gambar_rembangan.Image");
            pictureBox_gambar_rembangan.Location = new Point(466, 12);
            pictureBox_gambar_rembangan.Name = "pictureBox_gambar_rembangan";
            pictureBox_gambar_rembangan.Size = new Size(500, 255);
            pictureBox_gambar_rembangan.TabIndex = 1;
            pictureBox_gambar_rembangan.TabStop = false;
            // 
            // Rembangan_detail_wisata
            // 
            Rembangan_detail_wisata.AutoSize = true;
            Rembangan_detail_wisata.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Rembangan_detail_wisata.Location = new Point(628, 12);
            Rembangan_detail_wisata.Name = "Rembangan_detail_wisata";
            Rembangan_detail_wisata.Size = new Size(153, 29);
            Rembangan_detail_wisata.TabIndex = 1;
            Rembangan_detail_wisata.Text = "Rembangan";
            Rembangan_detail_wisata.TextAlign = ContentAlignment.TopCenter;
            // 
            // DetailWisata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(pictureBox_gambar_rembangan);
            Controls.Add(panel_detail_wisata);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetailWisata";
            Text = "DetailWisata";
            panel_detail_wisata.ResumeLayout(false);
            panel_detail_wisata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_detail_wisata).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_gambar_rembangan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_detail_wisata;
        private DataGridView dataGridView_detail_wisata;
        private Label Rembangan_detail_wisata;
        private PictureBox pictureBox_gambar_rembangan;
    }
}