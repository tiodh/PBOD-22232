namespace frontendpbo
{
    partial class LoginAdmin
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
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            tbx_user = new TextBox();
            tbx_pasw = new TextBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = Properties.Resources.InputGround;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbx_user);
            panel2.Controls.Add(tbx_pasw);
            panel2.Location = new Point(146, 98);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(573, 491);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(93, 296);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 9;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(181, 453);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 3;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 191);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 6;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // tbx_user
            // 
            tbx_user.BackColor = Color.Gainsboro;
            tbx_user.BorderStyle = BorderStyle.None;
            tbx_user.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_user.Location = new Point(95, 191);
            tbx_user.Name = "tbx_user";
            tbx_user.Size = new Size(395, 32);
            tbx_user.TabIndex = 7;
            tbx_user.Click += tbx_user_Click;
            // 
            // tbx_pasw
            // 
            tbx_pasw.BackColor = Color.Gainsboro;
            tbx_pasw.BorderStyle = BorderStyle.None;
            tbx_pasw.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_pasw.Location = new Point(95, 297);
            tbx_pasw.Name = "tbx_pasw";
            tbx_pasw.Size = new Size(395, 32);
            tbx_pasw.TabIndex = 8;
            tbx_pasw.Click += tbx_pasw_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Group_12__1_;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(264, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(867, 680);
            panel1.TabIndex = 3;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(15, 16, 44);
            ClientSize = new Size(1513, 825);
            Controls.Add(panel1);
            Name = "LoginAdmin";
            Text = "LoginAdmin";
            Load += LoginAdmin_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox tbx_user;
        private TextBox tbx_pasw;
        private Panel panel1;
    }
}