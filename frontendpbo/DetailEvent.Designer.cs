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
            dataGridView1 = new DataGridView();
            panelsearch = new Panel();
            labelid = new Label();
            labelnama = new Label();
            labeltanggal = new Label();
            labeldeskripsi = new Label();
            labelobjek = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonJudul
            // 
            buttonJudul.BackColor = Color.Thistle;
            buttonJudul.Dock = DockStyle.Top;
            buttonJudul.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJudul.ForeColor = SystemColors.Desktop;
            buttonJudul.Location = new Point(0, 0);
            buttonJudul.Name = "buttonJudul";
            buttonJudul.Size = new Size(1778, 86);
            buttonJudul.TabIndex = 0;
            buttonJudul.Text = "EVENT ACARA";
            buttonJudul.UseVisualStyleBackColor = false;
            // 
            // panelmenu
            // 
            panelmenu.Controls.Add(dataGridView1);
            panelmenu.Controls.Add(panelsearch);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 86);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(696, 1020);
            panelmenu.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 150);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(696, 870);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panelsearch
            // 
            panelsearch.Dock = DockStyle.Top;
            panelsearch.Location = new Point(0, 0);
            panelsearch.Name = "panelsearch";
            panelsearch.Size = new Size(696, 150);
            panelsearch.TabIndex = 0;
            // 
            // labelid
            // 
            labelid.Anchor = AnchorStyles.None;
            labelid.AutoSize = true;
            labelid.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelid.Location = new Point(970, 300);
            labelid.Name = "labelid";
            labelid.Size = new Size(100, 30);
            labelid.TabIndex = 2;
            labelid.Text = "ID Event";
            // 
            // labelnama
            // 
            labelnama.Anchor = AnchorStyles.None;
            labelnama.AutoSize = true;
            labelnama.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelnama.Location = new Point(970, 377);
            labelnama.Name = "labelnama";
            labelnama.Size = new Size(138, 30);
            labelnama.TabIndex = 3;
            labelnama.Text = "Nama Event";
            // 
            // labeltanggal
            // 
            labeltanggal.Anchor = AnchorStyles.None;
            labeltanggal.AutoSize = true;
            labeltanggal.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labeltanggal.Location = new Point(970, 467);
            labeltanggal.Name = "labeltanggal";
            labeltanggal.Size = new Size(203, 30);
            labeltanggal.TabIndex = 4;
            labeltanggal.Text = "Tanggal Pelaksana";
            // 
            // labeldeskripsi
            // 
            labeldeskripsi.Anchor = AnchorStyles.None;
            labeldeskripsi.AutoSize = true;
            labeldeskripsi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labeldeskripsi.Location = new Point(970, 549);
            labeldeskripsi.Name = "labeldeskripsi";
            labeldeskripsi.Size = new Size(108, 30);
            labeldeskripsi.TabIndex = 5;
            labeldeskripsi.Text = "Deskripsi";
            // 
            // labelobjek
            // 
            labelobjek.Anchor = AnchorStyles.None;
            labelobjek.AutoSize = true;
            labelobjek.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelobjek.Location = new Point(970, 641);
            labelobjek.Name = "labelobjek";
            labelobjek.Size = new Size(151, 30);
            labelobjek.TabIndex = 6;
            labelobjek.Text = "Objek Wisata";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1255, 299);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1255, 376);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(386, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1255, 466);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(208, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1255, 548);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(480, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1255, 640);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 31);
            textBox5.TabIndex = 11;
            // 
            // DetailEvent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 1106);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelobjek);
            Controls.Add(labeldeskripsi);
            Controls.Add(labeltanggal);
            Controls.Add(labelnama);
            Controls.Add(labelid);
            Controls.Add(panelmenu);
            Controls.Add(buttonJudul);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetailEvent";
            Text = "DetailEvent";
            panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonJudul;
        private Panel panelmenu;
        private DataGridView dataGridView1;
        private Panel panelsearch;
        private Label labelid;
        private Label labelnama;
        private Label labeltanggal;
        private Label labeldeskripsi;
        private Label labelobjek;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}