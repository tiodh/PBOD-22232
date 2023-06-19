﻿namespace frontendpbo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            side = new Panel();
            menu = new PictureBox();
            panel3 = new Panel();
            Login = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            mainside = new Panel();
            button5 = new Button();
            button2 = new Button();
            dashboard = new Button();
            button6 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            panelContent = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            mainside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // side
            // 
            side.BackColor = SystemColors.ActiveCaption;
            side.BackgroundImage = Properties.Resources.sidebar;
            side.Controls.Add(menu);
            side.Dock = DockStyle.Left;
            side.Location = new Point(0, 0);
            side.Margin = new Padding(2, 3, 2, 3);
            side.Name = "side";
            side.Size = new Size(53, 787);
            side.TabIndex = 0;
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.Image = Properties.Resources.garis3;
            menu.Location = new Point(8, 20);
            menu.Margin = new Padding(2, 3, 2, 3);
            menu.Name = "menu";
            menu.Size = new Size(37, 55);
            menu.SizeMode = PictureBoxSizeMode.Zoom;
            menu.TabIndex = 0;
            menu.TabStop = false;
            menu.Click += menu_Click_1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(111, 106, 248);
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(Login);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(21, 15);
            panel3.Margin = new Padding(2, 3, 2, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(1356, 74);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint_1;
            // 
            // Login
            // 
            Login.BackColor = Color.Transparent;
            Login.Dock = DockStyle.Right;
            Login.Font = new Font("Perpetua", 17F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ImageAlign = ContentAlignment.MiddleRight;
            Login.Location = new Point(1246, 0);
            Login.Name = "Login";
            Login.Size = new Size(110, 74);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.TextAlign = ContentAlignment.MiddleLeft;
            Login.Click += Login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(111, 106, 248);
            pictureBox1.Image = Properties.Resources.Dashboard;
            pictureBox1.Location = new Point(261, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 45);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(362, 0);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(21, 15, 21, 15);
            panel2.Size = new Size(1398, 104);
            panel2.TabIndex = 1;
            // 
            // mainside
            // 
            mainside.BackColor = Color.FromArgb(111, 106, 248);
            mainside.Controls.Add(button5);
            mainside.Controls.Add(button2);
            mainside.Controls.Add(dashboard);
            mainside.Controls.Add(button6);
            mainside.Controls.Add(button3);
            mainside.Controls.Add(pictureBox2);
            mainside.Dock = DockStyle.Left;
            mainside.Location = new Point(53, 0);
            mainside.Margin = new Padding(2, 3, 2, 3);
            mainside.Name = "mainside";
            mainside.Size = new Size(309, 787);
            mainside.TabIndex = 0;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Black;
            button5.Location = new Point(0, 312);
            button5.Name = "button5";
            button5.Size = new Size(309, 53);
            button5.TabIndex = 12;
            button5.Text = "Kebon Agung";
            button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, 259);
            button2.Name = "button2";
            button2.Size = new Size(309, 53);
            button2.TabIndex = 11;
            button2.Text = "Patemon";
            button2.UseVisualStyleBackColor = false;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.Transparent;
            dashboard.Dock = DockStyle.Top;
            dashboard.FlatAppearance.BorderSize = 0;
            dashboard.FlatStyle = FlatStyle.Flat;
            dashboard.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dashboard.ForeColor = Color.Black;
            dashboard.Location = new Point(0, 206);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(309, 53);
            dashboard.TabIndex = 10;
            dashboard.Text = "Watu Ulo";
            dashboard.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(0, 153);
            button6.Name = "button6";
            button6.Size = new Size(309, 53);
            button6.TabIndex = 9;
            button6.Text = "Rembangan";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Gainsboro;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(0, 100);
            button3.Name = "button3";
            button3.Size = new Size(309, 53);
            button3.TabIndex = 8;
            button3.Text = "Dashboard";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Padding = new Padding(21, 20, 0, 11);
            pictureBox2.Size = new Size(309, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panelContent
            // 
            panelContent.AutoScroll = true;
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(panel1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(362, 104);
            panelContent.Margin = new Padding(2, 3, 2, 3);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(23, 20, 23, 20);
            panelContent.Size = new Size(1398, 683);
            panelContent.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(23, 20);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 355);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 253);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1760, 787);
            Controls.Add(label1);
            Controls.Add(panelContent);
            Controls.Add(panel2);
            Controls.Add(mainside);
            Controls.Add(side);
            Margin = new Padding(2, 3, 2, 3);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            Resize += Form1_Resize;
            side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            mainside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel side;
        private PictureBox menu;
        private Panel mainside;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button6;
        private Button dashboard;
        private Label Login;
        private PictureBox pictureBox1;
        private Button button5;
        private Button button2;
        private Panel panelContent;
        private Panel panel1;
    }
}