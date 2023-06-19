namespace frontendpbo
{
    partial class DetailAcara
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
            panelJudul = new Panel();
            buttonJudul = new Button();
            buttonsearcheventacara = new Button();
            textBoxsearch1 = new TextBox();
            menudetail = new Panel();
            panelssearch = new Panel();
            dataGridView1 = new DataGridView();
            panelDeskripsi = new Panel();
            panelJudul.SuspendLayout();
            menudetail.SuspendLayout();
            panelssearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelJudul
            // 
            panelJudul.Controls.Add(buttonJudul);
            panelJudul.Dock = DockStyle.Top;
            panelJudul.Location = new Point(0, 0);
            panelJudul.Margin = new Padding(2);
            panelJudul.Name = "panelJudul";
            panelJudul.Size = new Size(1800, 144);
            panelJudul.TabIndex = 0;
            // 
            // buttonJudul
            // 
            buttonJudul.BackColor = Color.Gray;
            buttonJudul.Dock = DockStyle.Bottom;
            buttonJudul.Font = new Font("Franklin Gothic Heavy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonJudul.ForeColor = SystemColors.ButtonHighlight;
            buttonJudul.Location = new Point(0, 68);
            buttonJudul.Margin = new Padding(2);
            buttonJudul.Name = "buttonJudul";
            buttonJudul.Size = new Size(1800, 76);
            buttonJudul.TabIndex = 2;
            buttonJudul.Text = "EVENT ACARA";
            buttonJudul.UseVisualStyleBackColor = false;
            // 
            // buttonsearcheventacara
            // 
            buttonsearcheventacara.Anchor = AnchorStyles.None;
            buttonsearcheventacara.Location = new Point(328, 31);
            buttonsearcheventacara.Margin = new Padding(4);
            buttonsearcheventacara.Name = "buttonsearcheventacara";
            buttonsearcheventacara.Size = new Size(118, 36);
            buttonsearcheventacara.TabIndex = 13;
            buttonsearcheventacara.Text = "Search";
            buttonsearcheventacara.UseVisualStyleBackColor = true;
            // 
            // textBoxsearch1
            // 
            textBoxsearch1.Anchor = AnchorStyles.None;
            textBoxsearch1.Location = new Point(28, 34);
            textBoxsearch1.Margin = new Padding(4);
            textBoxsearch1.Name = "textBoxsearch1";
            textBoxsearch1.Size = new Size(256, 31);
            textBoxsearch1.TabIndex = 14;
            textBoxsearch1.Text = "Masukan Nama";
            textBoxsearch1.TextChanged += textBox1_TextChanged;
            // 
            // menudetail
            // 
            menudetail.Controls.Add(dataGridView1);
            menudetail.Controls.Add(panelssearch);
            menudetail.Dock = DockStyle.Left;
            menudetail.Location = new Point(0, 144);
            menudetail.Name = "menudetail";
            menudetail.Size = new Size(490, 962);
            menudetail.TabIndex = 1;
            // 
            // panelssearch
            // 
            panelssearch.Controls.Add(buttonsearcheventacara);
            panelssearch.Controls.Add(textBoxsearch1);
            panelssearch.Dock = DockStyle.Top;
            panelssearch.Location = new Point(0, 0);
            panelssearch.Name = "panelssearch";
            panelssearch.Size = new Size(490, 90);
            panelssearch.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(490, 872);
            dataGridView1.TabIndex = 1;
            // 
            // panelDeskripsi
            // 
            panelDeskripsi.Dock = DockStyle.Fill;
            panelDeskripsi.Location = new Point(490, 144);
            panelDeskripsi.Name = "panelDeskripsi";
            panelDeskripsi.Size = new Size(1310, 962);
            panelDeskripsi.TabIndex = 2;
            // 
            // DetailAcara
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1800, 1106);
            Controls.Add(panelDeskripsi);
            Controls.Add(menudetail);
            Controls.Add(panelJudul);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "DetailAcara";
            Text = "EVENT ACARA";
            panelJudul.ResumeLayout(false);
            menudetail.ResumeLayout(false);
            panelssearch.ResumeLayout(false);
            panelssearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelJudul;
        private Button buttonJudul;
        private Panel panelMenu;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button1;
        private Panel panelEvent1;
        private PictureBox pictureBox1;
        private Panel panelSearch;
        private Button buttonsearcheventacara;
        private TextBox textBoxsearch1;
        private Panel menudetail;
        private DataGridView dataGridView1;
        private Panel panelssearch;
        private Panel panelDeskripsi;
    }
}