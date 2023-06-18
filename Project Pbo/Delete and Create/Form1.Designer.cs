namespace Delete_and_Create
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Delete = new Button();
            Create = new Button();
            Read = new Button();
            nama = new TextBox();
            lokasi = new TextBox();
            telepon = new TextBox();
            deskripsi = new TextBox();
            textBoxID = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 155);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(532, 211);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 43);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 104);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Lokasi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(463, 46);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Deskripsi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(469, 112);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 4;
            label4.Text = "Telepon";
            // 
            // Delete
            // 
            Delete.BackColor = Color.FromArgb(255, 128, 128);
            Delete.Location = new Point(91, 390);
            Delete.Name = "Delete";
            Delete.Size = new Size(111, 23);
            Delete.TabIndex = 5;
            Delete.Text = "Hapus Data";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Create
            // 
            Create.BackColor = Color.FromArgb(128, 255, 128);
            Create.Location = new Point(295, 390);
            Create.Name = "Create";
            Create.Size = new Size(111, 23);
            Create.TabIndex = 6;
            Create.Text = "Tambah Data";
            Create.UseVisualStyleBackColor = false;
            Create.Click += Create_Click;
            // 
            // Read
            // 
            Read.BackColor = Color.FromArgb(128, 255, 255);
            Read.Location = new Point(512, 390);
            Read.Name = "Read";
            Read.Size = new Size(111, 23);
            Read.TabIndex = 7;
            Read.Text = "Tampilkan Data";
            Read.UseVisualStyleBackColor = false;
            Read.Click += Read_Click;
            // 
            // nama
            // 
            nama.Location = new Point(137, 43);
            nama.Name = "nama";
            nama.Size = new Size(100, 23);
            nama.TabIndex = 8;
            // 
            // lokasi
            // 
            lokasi.Location = new Point(137, 101);
            lokasi.Name = "lokasi";
            lokasi.Size = new Size(100, 23);
            lokasi.TabIndex = 9;
            // 
            // telepon
            // 
            telepon.Location = new Point(523, 104);
            telepon.Name = "telepon";
            telepon.Size = new Size(100, 23);
            telepon.TabIndex = 10;
            // 
            // deskripsi
            // 
            deskripsi.Location = new Point(523, 46);
            deskripsi.Name = "deskripsi";
            deskripsi.Size = new Size(100, 23);
            deskripsi.TabIndex = 11;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(306, 43);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(100, 23);
            textBoxID.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(279, 49);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 13;
            label5.Text = "ID ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(textBoxID);
            Controls.Add(deskripsi);
            Controls.Add(telepon);
            Controls.Add(lokasi);
            Controls.Add(nama);
            Controls.Add(Read);
            Controls.Add(Create);
            Controls.Add(Delete);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button Delete;
        private Button Create;
        private Button Read;
        private TextBox nama;
        private TextBox lokasi;
        private TextBox telepon;
        private TextBox deskripsi;
        private TextBox textBoxID;
        private Label label5;
    }
}