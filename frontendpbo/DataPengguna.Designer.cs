namespace frontendpbo
{
    partial class DataPengguna
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            tbNama = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            textBox5 = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(111, 106, 248);
            label1.Location = new Point(63, 26);
            label1.Name = "label1";
            label1.Size = new Size(253, 37);
            label1.TabIndex = 0;
            label1.Text = "Data Pengguna";
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(63, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(781, 494);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(879, 107);
            label2.Name = "label2";
            label2.Size = new Size(231, 24);
            label2.TabIndex = 2;
            label2.Text = "Nama Lengkap Pengguna";
            // 
            // tbNama
            // 
            tbNama.Anchor = AnchorStyles.Right;
            tbNama.BackColor = Color.FromArgb(111, 106, 248);
            tbNama.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNama.ForeColor = SystemColors.Window;
            tbNama.Location = new Point(879, 147);
            tbNama.Multiline = true;
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(426, 34);
            tbNama.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(879, 224);
            label3.Name = "label3";
            label3.Size = new Size(150, 24);
            label3.TabIndex = 4;
            label3.Text = "Email Pengguna";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(879, 337);
            label4.Name = "label4";
            label4.Size = new Size(97, 24);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(884, 449);
            label5.Name = "label5";
            label5.Size = new Size(92, 24);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Right;
            tbEmail.BackColor = Color.FromArgb(111, 106, 248);
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.ForeColor = SystemColors.Window;
            tbEmail.Location = new Point(879, 262);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(426, 33);
            tbEmail.TabIndex = 7;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Right;
            tbUsername.BackColor = Color.FromArgb(111, 106, 248);
            tbUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.ForeColor = SystemColors.Window;
            tbUsername.Location = new Point(879, 374);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(426, 31);
            tbUsername.TabIndex = 8;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Right;
            tbPassword.BackColor = Color.FromArgb(111, 106, 248);
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = SystemColors.Window;
            tbPassword.Location = new Point(879, 485);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(426, 30);
            tbPassword.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox5.BackColor = SystemColors.ActiveBorder;
            textBox5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(606, 66);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(238, 24);
            textBox5.TabIndex = 10;
            textBox5.Text = "Search Pengguna";
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Right;
            btnCreate.BackColor = Color.LimeGreen;
            btnCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(944, 556);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(128, 45);
            btnCreate.TabIndex = 11;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Right;
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(1128, 556);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(128, 45);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // DataPengguna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 650);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(textBox5);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbNama);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DataPengguna";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private TextBox tbNama;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox textBox5;
        private Button btnCreate;
        private Button btnUpdate;
    }
}