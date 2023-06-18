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
            btnCreateDataPengguna = new Button();
            btnUpdateDataPengguna = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVdataPengguna).BeginInit();
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
            // DGVdataPengguna
            // 
            DGVdataPengguna.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DGVdataPengguna.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGVdataPengguna.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DGVdataPengguna.BackgroundColor = SystemColors.ActiveBorder;
            DGVdataPengguna.BorderStyle = BorderStyle.None;
            DGVdataPengguna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVdataPengguna.Location = new Point(63, 107);
            DGVdataPengguna.Name = "DGVdataPengguna";
            DGVdataPengguna.RowHeadersWidth = 51;
            DGVdataPengguna.RowTemplate.Height = 25;
            DGVdataPengguna.Size = new Size(781, 494);
            DGVdataPengguna.TabIndex = 1;
            DGVdataPengguna.CellClick += DGVdataPengguna_CellClick;
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
            // tbSearchDataPengguna
            // 
            tbSearchDataPengguna.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbSearchDataPengguna.BackColor = SystemColors.ActiveBorder;
            tbSearchDataPengguna.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbSearchDataPengguna.Location = new Point(606, 66);
            tbSearchDataPengguna.Multiline = true;
            tbSearchDataPengguna.Name = "tbSearchDataPengguna";
            tbSearchDataPengguna.Size = new Size(238, 24);
            tbSearchDataPengguna.TabIndex = 10;
            tbSearchDataPengguna.Text = "Search Pengguna";
            tbSearchDataPengguna.Click += tbSearchDataPengguna_Click;
            tbSearchDataPengguna.TextChanged += tbSearchDataPengguna_TextChanged;
            // 
            // btnCreateDataPengguna
            // 
            btnCreateDataPengguna.Anchor = AnchorStyles.Right;
            btnCreateDataPengguna.BackColor = Color.LimeGreen;
            btnCreateDataPengguna.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateDataPengguna.Location = new Point(944, 556);
            btnCreateDataPengguna.Name = "btnCreateDataPengguna";
            btnCreateDataPengguna.Size = new Size(128, 45);
            btnCreateDataPengguna.TabIndex = 11;
            btnCreateDataPengguna.Text = "Create";
            btnCreateDataPengguna.UseVisualStyleBackColor = false;
            btnCreateDataPengguna.Click += btnCreateDataPengguna_Click;
            // 
            // btnUpdateDataPengguna
            // 
            btnUpdateDataPengguna.Anchor = AnchorStyles.Right;
            btnUpdateDataPengguna.BackColor = Color.Orange;
            btnUpdateDataPengguna.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateDataPengguna.Location = new Point(1128, 556);
            btnUpdateDataPengguna.Name = "btnUpdateDataPengguna";
            btnUpdateDataPengguna.Size = new Size(128, 45);
            btnUpdateDataPengguna.TabIndex = 12;
            btnUpdateDataPengguna.Text = "Update";
            btnUpdateDataPengguna.UseVisualStyleBackColor = false;
            btnUpdateDataPengguna.Click += btnUpdateDataPengguna_Click;
            // 
            // DataPengguna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 650);
            Controls.Add(btnUpdateDataPengguna);
            Controls.Add(btnCreateDataPengguna);
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
        private Button btnCreateDataPengguna;
        private Button btnUpdateDataPengguna;
    }
}