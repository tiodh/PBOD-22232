namespace frontendpbo
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Brown;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1348, 876);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1348, 876);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gainsboro;
            label2.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(679, 543);
            label2.Name = "label2";
            label2.Size = new Size(215, 50);
            label2.TabIndex = 4;
            label2.Text = "PASSWORD";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(679, 412);
            label1.Name = "label1";
            label1.Size = new Size(212, 50);
            label1.TabIndex = 2;
            label1.Text = "USERNAME";
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(679, 543);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(525, 49);
            textBox2.TabIndex = 3;
            textBox2.Click += textBox2_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(679, 412);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(525, 49);
            textBox1.TabIndex = 1;
            textBox1.Click += textBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Log_In_admin__8_;
            pictureBox2.Location = new Point(814, 715);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(255, 47);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 876);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}