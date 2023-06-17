namespace frontendpbo
{
    partial class CRUDTrasnportasi
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
            panel2 = new Panel();
            Search = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Create = new Button();
            Delete = new Button();
            label3 = new Label();
            label4 = new Label();
            Update = new Button();
            panel3 = new Panel();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            TampilData = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TampilData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 106, 248);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(TampilData);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1203, 565);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(Search);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Create);
            panel2.Controls.Add(Delete);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(Update);
            panel2.Location = new Point(32, 294);
            panel2.Name = "panel2";
            panel2.Size = new Size(1126, 257);
            panel2.TabIndex = 15;
            // 
            // Search
            // 
            Search.Location = new Point(254, 60);
            Search.Name = "Search";
            Search.Size = new Size(75, 23);
            Search.TabIndex = 15;
            Search.Text = "SEARCH";
            Search.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(29, 61);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(204, 23);
            textBox5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 27);
            label6.Name = "label6";
            label6.Size = new Size(212, 17);
            label6.TabIndex = 13;
            label6.Text = "TAMPILKAN DATA BERDASARKAN";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(702, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(363, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(702, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(363, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(702, 99);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(363, 23);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(702, 137);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(363, 85);
            textBox4.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(520, 27);
            label1.Name = "label1";
            label1.Size = new Size(165, 17);
            label1.TabIndex = 0;
            label1.Text = "ID TRANSPORTASI           :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(519, 62);
            label2.Name = "label2";
            label2.Size = new Size(164, 17);
            label2.TabIndex = 1;
            label2.Text = "NAMA TRANSPORTASI    :";
            // 
            // Create
            // 
            Create.BackColor = Color.Green;
            Create.Location = new Point(520, 175);
            Create.Name = "Create";
            Create.Size = new Size(124, 65);
            Create.TabIndex = 10;
            Create.Text = "CREATE DATA";
            Create.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Red;
            Delete.Location = new Point(194, 175);
            Delete.Name = "Delete";
            Delete.Size = new Size(124, 65);
            Delete.TabIndex = 12;
            Delete.Text = "DELETE DATA";
            Delete.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(519, 99);
            label3.Name = "label3";
            label3.Size = new Size(165, 17);
            label3.TabIndex = 2;
            label3.Text = "JENIS TRANSPORTASI      :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(519, 138);
            label4.Name = "label4";
            label4.Size = new Size(165, 17);
            label4.TabIndex = 3;
            label4.Text = "DESKRIPSI                       :";
            // 
            // Update
            // 
            Update.BackColor = Color.Yellow;
            Update.Location = new Point(18, 175);
            Update.Name = "Update";
            Update.Size = new Size(124, 65);
            Update.TabIndex = 11;
            Update.Text = "UPDATE DATA";
            Update.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(8, 0, 8, 0);
            panel3.Size = new Size(1203, 68);
            panel3.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(111, 106, 248);
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(231, 15);
            label7.Name = "label7";
            label7.Size = new Size(546, 37);
            label7.TabIndex = 5;
            label7.Text = "TAMPILAN ADMIN DATA TRANSPORTASI";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Rectangle_28__1_;
            pictureBox1.Location = new Point(8, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1187, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // TampilData
            // 
            TampilData.AllowUserToAddRows = false;
            TampilData.AllowUserToDeleteRows = false;
            TampilData.BackgroundColor = Color.White;
            TampilData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            TampilData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TampilData.GridColor = Color.White;
            TampilData.Location = new Point(32, 81);
            TampilData.Name = "TampilData";
            TampilData.ReadOnly = true;
            TampilData.RowTemplate.Height = 25;
            TampilData.Size = new Size(1126, 203);
            TampilData.TabIndex = 5;
            // 
            // CRUDTrasnportasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 562);
            Controls.Add(panel1);
            Name = "CRUDTrasnportasi";
            Text = "Form4";
            Load += CRUDTrasnportasi_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)TampilData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView TampilData;
        private Panel panel3;
        private Label label7;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button Search;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Button Create;
        private Button Delete;
        private Label label3;
        private Label label4;
        private Button Update;
    }
}