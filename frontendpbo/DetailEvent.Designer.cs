namespace frontendpbo
{
    partial class DetailEvent
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
            buttonJudul = new Button();
            panelmenu = new Panel();
            dataGridView1Search = new DataGridView();
            panelsearch = new Panel();
            label1 = new Label();
            textBox6Search = new TextBox();
            labelid = new Label();
            labelnama = new Label();
            labeltanggal = new Label();
            labeldeskripsi = new Label();
            labelobjek = new Label();
            textBox1IDEvent = new TextBox();
            textBox2NamaEvent = new TextBox();
            textBox3TanggalPelaksana = new TextBox();
            textBox4Deskripsi = new TextBox();
            textBox5ObjekWisata = new TextBox();
            panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1Search).BeginInit();
            panelsearch.SuspendLayout();
            SuspendLayout();
            // 
            // buttonJudul
            // 
            buttonJudul.BackColor = Color.Thistle;
            buttonJudul.Dock = DockStyle.Top;
            buttonJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJudul.ForeColor = SystemColors.Desktop;
            buttonJudul.Location = new Point(0, 0);
            buttonJudul.Margin = new Padding(2);
            buttonJudul.Name = "buttonJudul";
            buttonJudul.Size = new Size(1422, 69);
            buttonJudul.TabIndex = 0;
            buttonJudul.Text = "EVENT ACARA";
            buttonJudul.UseVisualStyleBackColor = false;
            // 
            // panelmenu
            // 
            panelmenu.Controls.Add(dataGridView1Search);
            panelmenu.Controls.Add(panelsearch);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 69);
            panelmenu.Margin = new Padding(2);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(557, 813);
            panelmenu.TabIndex = 1;
            // 
            // dataGridView1Search
            // 
            dataGridView1Search.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1Search.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1Search.Dock = DockStyle.Fill;
            dataGridView1Search.Location = new Point(0, 120);
            dataGridView1Search.Margin = new Padding(2);
            dataGridView1Search.Name = "dataGridView1Search";
            dataGridView1Search.RowHeadersWidth = 62;
            dataGridView1Search.RowTemplate.Height = 33;
            dataGridView1Search.Size = new Size(557, 693);
            dataGridView1Search.TabIndex = 1;
            dataGridView1Search.CellClick += dataGridView1_CellClick;
            dataGridView1Search.CellContentClick += dataGridView1Search_CellContentClick;
            // 
            // panelsearch
            // 
            panelsearch.Controls.Add(label1);
            panelsearch.Controls.Add(textBox6Search);
            panelsearch.Dock = DockStyle.Top;
            panelsearch.Location = new Point(0, 0);
            panelsearch.Margin = new Padding(2);
            panelsearch.Name = "panelsearch";
            panelsearch.Size = new Size(557, 120);
            panelsearch.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 61);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 1;
            label1.Text = "Search";
            label1.Click += label1_Click;
            // 
            // textBox6Search
            // 
            textBox6Search.Location = new Point(102, 54);
            textBox6Search.Name = "textBox6Search";
            textBox6Search.Size = new Size(195, 27);
            textBox6Search.TabIndex = 0;
            textBox6Search.TextChanged += textBox6Search_TextChanged;
            // 
            // labelid
            // 
            labelid.Anchor = AnchorStyles.None;
            labelid.AutoSize = true;
            labelid.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelid.Location = new Point(776, 240);
            labelid.Margin = new Padding(2, 0, 2, 0);
            labelid.Name = "labelid";
            labelid.Size = new Size(86, 25);
            labelid.TabIndex = 2;
            labelid.Text = "ID Event";
            // 
            // labelnama
            // 
            labelnama.Anchor = AnchorStyles.None;
            labelnama.AutoSize = true;
            labelnama.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelnama.Location = new Point(776, 302);
            labelnama.Margin = new Padding(2, 0, 2, 0);
            labelnama.Name = "labelnama";
            labelnama.Size = new Size(118, 25);
            labelnama.TabIndex = 3;
            labelnama.Text = "Nama Event";
            // 
            // labeltanggal
            // 
            labeltanggal.Anchor = AnchorStyles.None;
            labeltanggal.AutoSize = true;
            labeltanggal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labeltanggal.Location = new Point(776, 374);
            labeltanggal.Margin = new Padding(2, 0, 2, 0);
            labeltanggal.Name = "labeltanggal";
            labeltanggal.Size = new Size(136, 25);
            labeltanggal.TabIndex = 4;
            labeltanggal.Text = "Tanggal Event";
            labeltanggal.Click += labeltanggal_Click;
            // 
            // labeldeskripsi
            // 
            labeldeskripsi.Anchor = AnchorStyles.None;
            labeldeskripsi.AutoSize = true;
            labeldeskripsi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labeldeskripsi.Location = new Point(776, 439);
            labeldeskripsi.Margin = new Padding(2, 0, 2, 0);
            labeldeskripsi.Name = "labeldeskripsi";
            labeldeskripsi.Size = new Size(93, 25);
            labeldeskripsi.TabIndex = 5;
            labeldeskripsi.Text = "Deskripsi";
            // 
            // labelobjek
            // 
            labelobjek.Anchor = AnchorStyles.None;
            labelobjek.AutoSize = true;
            labelobjek.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelobjek.Location = new Point(776, 513);
            labelobjek.Margin = new Padding(2, 0, 2, 0);
            labelobjek.Name = "labelobjek";
            labelobjek.Size = new Size(128, 25);
            labelobjek.TabIndex = 6;
            labelobjek.Text = "Objek Wisata";
            // 
            // textBox1IDEvent
            // 
            textBox1IDEvent.Location = new Point(1004, 239);
            textBox1IDEvent.Margin = new Padding(2);
            textBox1IDEvent.Name = "textBox1IDEvent";
            textBox1IDEvent.Size = new Size(158, 27);
            textBox1IDEvent.TabIndex = 7;
            // 
            // textBox2NamaEvent
            // 
            textBox2NamaEvent.Location = new Point(1004, 301);
            textBox2NamaEvent.Margin = new Padding(2);
            textBox2NamaEvent.Name = "textBox2NamaEvent";
            textBox2NamaEvent.Size = new Size(310, 27);
            textBox2NamaEvent.TabIndex = 8;
            // 
            // textBox3TanggalPelaksana
            // 
            textBox3TanggalPelaksana.Location = new Point(1004, 373);
            textBox3TanggalPelaksana.Margin = new Padding(2);
            textBox3TanggalPelaksana.Name = "textBox3TanggalPelaksana";
            textBox3TanggalPelaksana.Size = new Size(167, 27);
            textBox3TanggalPelaksana.TabIndex = 9;
            // 
            // textBox4Deskripsi
            // 
            textBox4Deskripsi.Location = new Point(1004, 438);
            textBox4Deskripsi.Margin = new Padding(2);
            textBox4Deskripsi.Name = "textBox4Deskripsi";
            textBox4Deskripsi.Size = new Size(385, 27);
            textBox4Deskripsi.TabIndex = 10;
            // 
            // textBox5ObjekWisata
            // 
            textBox5ObjekWisata.Location = new Point(1004, 512);
            textBox5ObjekWisata.Margin = new Padding(2);
            textBox5ObjekWisata.Name = "textBox5ObjekWisata";
            textBox5ObjekWisata.Size = new Size(241, 27);
            textBox5ObjekWisata.TabIndex = 11;
            // 
            // DetailEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 882);
            Controls.Add(textBox5ObjekWisata);
            Controls.Add(textBox4Deskripsi);
            Controls.Add(textBox3TanggalPelaksana);
            Controls.Add(textBox2NamaEvent);
            Controls.Add(textBox1IDEvent);
            Controls.Add(labelobjek);
            Controls.Add(labeldeskripsi);
            Controls.Add(labeltanggal);
            Controls.Add(labelnama);
            Controls.Add(labelid);
            Controls.Add(panelmenu);
            Controls.Add(buttonJudul);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "DetailEvent";
            Text = "DetailEvent";
            panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1Search).EndInit();
            panelsearch.ResumeLayout(false);
            panelsearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonJudul;
        private Panel panelmenu;
        private DataGridView dataGridView1Search;
        private Panel panelsearch;
        private Label labelid;
        private Label labelnama;
        private Label labeltanggal;
        private Label labeldeskripsi;
        private Label labelobjek;
        private TextBox textBox1IDEvent;
        private TextBox textBox2NamaEvent;
        private TextBox textBox3TanggalPelaksana;
        private TextBox textBox4Deskripsi;
        private TextBox textBox5ObjekWisata;
        private TextBox textBox6Search;
        private Label label1;
    }
}