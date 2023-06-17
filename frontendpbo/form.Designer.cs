namespace frontendpbo
{
    partial class form
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panel2 = new Panel();
            label3 = new Label();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel1 = new Panel();
            panelChildForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            panelChildForm.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Black;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView2.Location = new Point(306, 77);
            dataGridView2.Margin = new Padding(3, 4, 3, 4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(98, 24);
            dataGridView2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(271, 77);
            label4.Name = "label4";
            label4.Size = new Size(32, 23);
            label4.TabIndex = 15;
            label4.Text = "RP";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.Black;
            radioButton2.Location = new Point(39, 103);
            radioButton2.Margin = new Padding(3, 4, 3, 4);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(99, 27);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "Roda 4";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.Black;
            radioButton1.Location = new Point(39, 47);
            radioButton1.Margin = new Padding(3, 4, 3, 4);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(99, 27);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "Roda 2";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(radioButton1);
            panel2.Location = new Point(25, 511);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(618, 163);
            panel2.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(18, 0);
            label3.Name = "label3";
            label3.Size = new Size(212, 40);
            label3.TabIndex = 11;
            label3.Text = "Tiket Parkir :";
            // 
            // Column5
            // 
            Column5.HeaderText = "Harga";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Deskripsi";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Wisata";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id _tiket";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(43, 16);
            label1.Name = "label1";
            label1.Size = new Size(164, 44);
            label1.TabIndex = 10;
            label1.Text = "Search :";
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(227, 32);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(376, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(25, 84);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(618, 388);
            dataGridView1.TabIndex = 9;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Tiket";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(327, 41);
            label2.Name = "label2";
            label2.Size = new Size(536, 46);
            label2.TabIndex = 11;
            label2.Text = "DETAIL DATA TRANSASKI  TIKET";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(242, 124);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(664, 692);
            panel1.TabIndex = 10;
            // 
            // panelChildForm
            // 
            panelChildForm.Controls.Add(label2);
            panelChildForm.Controls.Add(panel1);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(0, 0);
            panelChildForm.Margin = new Padding(3, 4, 3, 4);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1073, 834);
            panelChildForm.TabIndex = 1;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1073, 834);
            Controls.Add(panelChildForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form";
            Text = "form";
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView2;
        private Label label4;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Panel panel2;
        private Label label3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column1;
        private Label label1;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column2;
        private Label label2;
        private Panel panel1;
        private Panel panelChildForm;
    }
}