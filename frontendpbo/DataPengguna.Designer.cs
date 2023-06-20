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
            DGVdataPengguna = new DataGridView();
            label2 = new Label();
            tbNama = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbEmail = new TextBox();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbSearchDataPengguna = new TextBox();
            btnCreate = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVdataPengguna).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(111, 106, 248);
            label1.Location = new Point(90, 43);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(373, 55);
            label1.TabIndex = 0;
            label1.Text = "Data Pengguna";
            // 
            // DGVdataPengguna
            // 
            DGVdataPengguna.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DGVdataPengguna.BackgroundColor = SystemColors.ActiveBorder;
            DGVdataPengguna.BorderStyle = BorderStyle.None;
            DGVdataPengguna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVdataPengguna.Location = new Point(90, 178);
            DGVdataPengguna.Margin = new Padding(4, 5, 4, 5);
            DGVdataPengguna.Name = "DGVdataPengguna";
            DGVdataPengguna.RowHeadersWidth = 51;
            DGVdataPengguna.RowTemplate.Height = 25;
            DGVdataPengguna.Size = new Size(1116, 823);
            DGVdataPengguna.TabIndex = 1;
            DGVdataPengguna.CellClick += DGVdataPengguna_CellClick;
            DGVdataPengguna.CellContentClick += DGVDataPengguna_CellContentClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(1256, 178);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(381, 36);
            label2.TabIndex = 2;
            label2.Text = "Nama Lengkap Pengguna";
            // 
            // tbNama
            // 
            tbNama.Anchor = AnchorStyles.Right;
            tbNama.BackColor = Color.FromArgb(111, 106, 248);
            tbNama.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbNama.ForeColor = SystemColors.Window;
            tbNama.Location = new Point(1256, 245);
            tbNama.Margin = new Padding(4, 5, 4, 5);
            tbNama.Multiline = true;
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(607, 54);
            tbNama.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(1256, 373);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(247, 36);
            label3.TabIndex = 4;
            label3.Text = "Email Pengguna";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(1256, 562);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(158, 36);
            label4.TabIndex = 5;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(1263, 748);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(155, 36);
            label5.TabIndex = 6;
            label5.Text = "Password";
            // 
            // tbEmail
            // 
            tbEmail.Anchor = AnchorStyles.Right;
            tbEmail.BackColor = Color.FromArgb(111, 106, 248);
            tbEmail.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.ForeColor = SystemColors.Window;
            tbEmail.Location = new Point(1256, 437);
            tbEmail.Margin = new Padding(4, 5, 4, 5);
            tbEmail.Multiline = true;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(607, 52);
            tbEmail.TabIndex = 7;
            // 
            // tbUsername
            // 
            tbUsername.Anchor = AnchorStyles.Right;
            tbUsername.BackColor = Color.FromArgb(111, 106, 248);
            tbUsername.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.ForeColor = SystemColors.Window;
            tbUsername.Location = new Point(1256, 623);
            tbUsername.Margin = new Padding(4, 5, 4, 5);
            tbUsername.Multiline = true;
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(607, 49);
            tbUsername.TabIndex = 8;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Right;
            tbPassword.BackColor = Color.FromArgb(111, 106, 248);
            tbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = SystemColors.Window;
            tbPassword.Location = new Point(1256, 808);
            tbPassword.Margin = new Padding(4, 5, 4, 5);
            tbPassword.Multiline = true;
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(607, 47);
            tbPassword.TabIndex = 9;
            // 
            // tbSearchDataPengguna
            // 
            tbSearchDataPengguna.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSearchDataPengguna.BackColor = SystemColors.ActiveBorder;
            tbSearchDataPengguna.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearchDataPengguna.Location = new Point(866, 110);
            tbSearchDataPengguna.Margin = new Padding(4, 5, 4, 5);
            tbSearchDataPengguna.Multiline = true;
            tbSearchDataPengguna.Name = "tbSearchDataPengguna";
            tbSearchDataPengguna.Size = new Size(338, 37);
            tbSearchDataPengguna.TabIndex = 10;
            tbSearchDataPengguna.Text = "Search Pengguna";
            tbSearchDataPengguna.Click += tbSearchDataPengguna_Click;
            tbSearchDataPengguna.TextChanged += tbSearchDataPengguna_TextChanged;
            // 
            // btnCreate
            // 
            btnCreate.Anchor = AnchorStyles.Right;
            btnCreate.BackColor = Color.LimeGreen;
            btnCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(1349, 927);
            btnCreate.Margin = new Padding(4, 5, 4, 5);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(183, 75);
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
            btnUpdate.Location = new Point(1611, 927);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(183, 75);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // DataPengguna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1929, 1083);
            Controls.Add(btnUpdate);
            Controls.Add(btnCreate);
            Controls.Add(tbSearchDataPengguna);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(tbEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbNama);
            Controls.Add(label2);
            Controls.Add(DGVdataPengguna);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "DataPengguna";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)DGVdataPengguna).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView DGVdataPengguna;
        private Label label2;
        private TextBox tbNama;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbEmail;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbSearchDataPengguna;
        private Button btnCreate;
        private Button btnUpdate;
    }
}