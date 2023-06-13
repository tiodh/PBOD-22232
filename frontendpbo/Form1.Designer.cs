namespace frontendpbo
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
            side = new Panel();
            menu = new PictureBox();
            panel5 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            mainside = new Panel();
            dashboard = new Button();
            button6 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button4 = new Button();
            label1 = new Label();
            side.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            mainside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // side
            // 
            side.BackColor = SystemColors.ActiveCaption;
            side.BackgroundImage = Properties.Resources.sidebar;
            side.Controls.Add(menu);
            side.Dock = DockStyle.Left;
            side.Location = new Point(0, 0);
            side.Margin = new Padding(2);
            side.Name = "side";
            side.Size = new Size(53, 786);
            side.TabIndex = 0;
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.Image = Properties.Resources.garis3;
            menu.Location = new Point(8, 20);
            menu.Margin = new Padding(2);
            menu.Name = "menu";
            menu.Size = new Size(37, 55);
            menu.SizeMode = PictureBoxSizeMode.Zoom;
            menu.TabIndex = 0;
            menu.TabStop = false;
            menu.Click += menu_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.AppWorkspace;
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(285, 91);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Size = new Size(1639, 695);
            panel5.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(9, 9);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(4);
            panel3.Size = new Size(1621, 82);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Rectangle_28__1_;
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1613, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(285, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 0, 9, 0);
            panel2.Size = new Size(1639, 91);
            panel2.TabIndex = 1;
            // 
            // mainside
            // 
            mainside.BackColor = Color.Transparent;
            mainside.BackgroundImage = Properties.Resources.sidebar;
            mainside.Controls.Add(dashboard);
            mainside.Controls.Add(button6);
            mainside.Controls.Add(button3);
            mainside.Controls.Add(pictureBox2);
            mainside.Controls.Add(button1);
            mainside.Controls.Add(button4);
            mainside.Dock = DockStyle.Left;
            mainside.Location = new Point(53, 0);
            mainside.Margin = new Padding(2);
            mainside.Name = "mainside";
            mainside.Size = new Size(232, 786);
            mainside.TabIndex = 0;
            // 
            // dashboard
            // 
            dashboard.BackColor = Color.Transparent;
            dashboard.FlatAppearance.BorderSize = 0;
            dashboard.FlatStyle = FlatStyle.Flat;
            dashboard.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dashboard.ForeColor = Color.Black;
            dashboard.Location = new Point(-43, 116);
            dashboard.Name = "dashboard";
            dashboard.Size = new Size(275, 63);
            dashboard.TabIndex = 10;
            dashboard.Text = "Dashboard";
            dashboard.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Black;
            button6.Location = new Point(-45, 208);
            button6.Name = "button6";
            button6.Size = new Size(275, 63);
            button6.TabIndex = 9;
            button6.Text = "Kebon Agung";
            button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(-45, 307);
            button3.Name = "button3";
            button3.Size = new Size(275, 63);
            button3.TabIndex = 8;
            button3.Text = "Patemon";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(-45, 257);
            button1.Name = "button1";
            button1.Size = new Size(275, 63);
            button1.TabIndex = 7;
            button1.Text = "Watu Ulo";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(-44, 161);
            button4.Name = "button4";
            button4.Size = new Size(275, 63);
            button4.TabIndex = 3;
            button4.Text = "Rembangan";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 254);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 786);
            Controls.Add(label1);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(mainside);
            Controls.Add(side);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            side.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            mainside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel side;
        private Panel panel5;
        private PictureBox menu;
        private Panel mainside;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Button button4;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button1;
        private Button button6;
        private Button dashboard;
    }
}