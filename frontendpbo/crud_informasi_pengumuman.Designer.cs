namespace frontendpbo
{
    partial class crud_informasi_pengumuman
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
            label_namainformasi = new Label();
            textBox_namainformasi = new TextBox();
            textBox_deskripsiinformasi = new TextBox();
            label_deskripsiinformasi = new Label();
            textBox_tanggalinformasi = new TextBox();
            label_tanggalinformasi = new Label();
            create_informasipengumuman = new Button();
            delete_informasipengumuman = new Button();
            update_informasipengumuman = new Button();
            Clear_informasipengumuman = new Button();
            dataGridView_informasipengumuman = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView_informasipengumuman).BeginInit();
            SuspendLayout();
            // 
            // label_namainformasi
            // 
            label_namainformasi.Anchor = AnchorStyles.Left;
            label_namainformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_namainformasi.Location = new Point(64, 134);
            label_namainformasi.Name = "label_namainformasi";
            label_namainformasi.Size = new Size(158, 30);
            label_namainformasi.TabIndex = 0;
            label_namainformasi.Text = "Nama Informasi";
            // 
            // textBox_namainformasi
            // 
            textBox_namainformasi.BorderStyle = BorderStyle.None;
            textBox_namainformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_namainformasi.Location = new Point(64, 167);
            textBox_namainformasi.Name = "textBox_namainformasi";
            textBox_namainformasi.Size = new Size(592, 23);
            textBox_namainformasi.TabIndex = 1;
            textBox_namainformasi.TextChanged += textBox_namainformasi_TextChanged;
            // 
            // textBox_deskripsiinformasi
            // 
            textBox_deskripsiinformasi.BorderStyle = BorderStyle.None;
            textBox_deskripsiinformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_deskripsiinformasi.Location = new Point(64, 286);
            textBox_deskripsiinformasi.Multiline = true;
            textBox_deskripsiinformasi.Name = "textBox_deskripsiinformasi";
            textBox_deskripsiinformasi.Size = new Size(592, 205);
            textBox_deskripsiinformasi.TabIndex = 3;
            textBox_deskripsiinformasi.TextChanged += textBox_deskripsiinformasi_TextChanged;
            // 
            // label_deskripsiinformasi
            // 
            label_deskripsiinformasi.Anchor = AnchorStyles.Left;
            label_deskripsiinformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_deskripsiinformasi.Location = new Point(64, 253);
            label_deskripsiinformasi.Name = "label_deskripsiinformasi";
            label_deskripsiinformasi.Size = new Size(222, 30);
            label_deskripsiinformasi.TabIndex = 2;
            label_deskripsiinformasi.Text = "Deskripsi Informasi";
            // 
            // textBox_tanggalinformasi
            // 
            textBox_tanggalinformasi.BorderStyle = BorderStyle.None;
            textBox_tanggalinformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_tanggalinformasi.Location = new Point(64, 558);
            textBox_tanggalinformasi.Name = "textBox_tanggalinformasi";
            textBox_tanggalinformasi.Size = new Size(592, 23);
            textBox_tanggalinformasi.TabIndex = 5;
            textBox_tanggalinformasi.TextChanged += textBox_tanggalinformasi_TextChanged;
            // 
            // label_tanggalinformasi
            // 
            label_tanggalinformasi.Anchor = AnchorStyles.Left;
            label_tanggalinformasi.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_tanggalinformasi.Location = new Point(64, 525);
            label_tanggalinformasi.Name = "label_tanggalinformasi";
            label_tanggalinformasi.Size = new Size(222, 30);
            label_tanggalinformasi.TabIndex = 4;
            label_tanggalinformasi.Text = "Tanggal Informasi";
            // 
            // create_informasipengumuman
            // 
            create_informasipengumuman.BackColor = Color.FromArgb(192, 255, 192);
            create_informasipengumuman.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            create_informasipengumuman.Location = new Point(211, 746);
            create_informasipengumuman.Name = "create_informasipengumuman";
            create_informasipengumuman.Size = new Size(129, 63);
            create_informasipengumuman.TabIndex = 6;
            create_informasipengumuman.Text = "Create";
            create_informasipengumuman.UseVisualStyleBackColor = false;
            create_informasipengumuman.Click += create_informasipengumuman_Click;
            // 
            // delete_informasipengumuman
            // 
            delete_informasipengumuman.BackColor = Color.Red;
            delete_informasipengumuman.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            delete_informasipengumuman.Location = new Point(543, 746);
            delete_informasipengumuman.Name = "delete_informasipengumuman";
            delete_informasipengumuman.Size = new Size(129, 63);
            delete_informasipengumuman.TabIndex = 9;
            delete_informasipengumuman.Text = "Delete";
            delete_informasipengumuman.UseVisualStyleBackColor = false;
            delete_informasipengumuman.Click += delete_informasipengumuman_Click;
            // 
            // update_informasipengumuman
            // 
            update_informasipengumuman.BackColor = Color.Yellow;
            update_informasipengumuman.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            update_informasipengumuman.Location = new Point(378, 746);
            update_informasipengumuman.Name = "update_informasipengumuman";
            update_informasipengumuman.Size = new Size(129, 63);
            update_informasipengumuman.TabIndex = 8;
            update_informasipengumuman.Text = "Update";
            update_informasipengumuman.UseVisualStyleBackColor = false;
            update_informasipengumuman.Click += update_informasipengumuman_Click;
            // 
            // Clear_informasipengumuman
            // 
            Clear_informasipengumuman.BackColor = Color.Lime;
            Clear_informasipengumuman.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Clear_informasipengumuman.Location = new Point(43, 746);
            Clear_informasipengumuman.Name = "Clear_informasipengumuman";
            Clear_informasipengumuman.Size = new Size(129, 63);
            Clear_informasipengumuman.TabIndex = 10;
            Clear_informasipengumuman.Text = "Clear";
            Clear_informasipengumuman.UseVisualStyleBackColor = false;
            Clear_informasipengumuman.Click += Clear_informasipengumuman_Click;
            // 
            // dataGridView_informasipengumuman
            // 
            dataGridView_informasipengumuman.BorderStyle = BorderStyle.None;
            dataGridView_informasipengumuman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_informasipengumuman.ImeMode = ImeMode.NoControl;
            dataGridView_informasipengumuman.Location = new Point(708, 134);
            dataGridView_informasipengumuman.Name = "dataGridView_informasipengumuman";
            dataGridView_informasipengumuman.RowHeadersWidth = 51;
            dataGridView_informasipengumuman.RowTemplate.Height = 29;
            dataGridView_informasipengumuman.Size = new Size(658, 675);
            dataGridView_informasipengumuman.TabIndex = 11;
            dataGridView_informasipengumuman.CellContentClick += dataGridView_informasipengumuman_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(1110, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 20);
            textBox1.TabIndex = 12;
            // 
            // crud_informasi_pengumuman
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 977);
            Controls.Add(textBox1);
            Controls.Add(dataGridView_informasipengumuman);
            Controls.Add(Clear_informasipengumuman);
            Controls.Add(delete_informasipengumuman);
            Controls.Add(update_informasipengumuman);
            Controls.Add(create_informasipengumuman);
            Controls.Add(textBox_tanggalinformasi);
            Controls.Add(label_tanggalinformasi);
            Controls.Add(textBox_deskripsiinformasi);
            Controls.Add(label_deskripsiinformasi);
            Controls.Add(textBox_namainformasi);
            Controls.Add(label_namainformasi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "crud_informasi_pengumuman";
            Text = "crud_informasi_pengumuman";
            Load += crud_informasi_pengumuman_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_informasipengumuman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_namainformasi;
        private TextBox textBox_namainformasi;
        private TextBox textBox_deskripsiinformasi;
        private Label label_deskripsiinformasi;
        private TextBox textBox_tanggalinformasi;
        private Label label_tanggalinformasi;
        private Button create_informasipengumuman;
        private Button delete_informasipengumuman;
        private Button update_informasipengumuman;
        private Button Clear_informasipengumuman;
        private DataGridView dataGridView_informasipengumuman;
        private TextBox textBox1;
    }
}