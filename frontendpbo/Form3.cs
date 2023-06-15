using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontendpbo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            this.Size = new System.Drawing.Size(bounds.Width, bounds.Height);
            if (bounds.Width == 1920 && bounds.Height == 1080)
            {
                label1.Location = new System.Drawing.Point(702, 425);
                label2.Location = new System.Drawing.Point(702, 556);
                textBox1.Location = new System.Drawing.Point(708, 422);
                textBox2.Location = new System.Drawing.Point(708, 553);
                button1.Location = new System.Drawing.Point(823, 780);
            }
            else
            {
                if (bounds.Height < 1000)
                {
                    textBox1.Width = 524;
                    textBox2.Width = 524;
                    button1.Size = new System.Drawing.Size(275, 63);
                    textBox1.Location = new System.Drawing.Point(708 - ((1920 - bounds.Width) / 2), 427 - ((1080 - bounds.Height) / 2));
                    textBox2.Location = new System.Drawing.Point(708 - ((1920 - bounds.Width) / 2), 560 - ((1080 - bounds.Height) / 2));
                    label1.Location = new System.Drawing.Point(702 - ((1920 - bounds.Width) / 2), 430 - ((1080 - bounds.Height) / 2));
                    label2.Location = new System.Drawing.Point(702 - ((1920 - bounds.Width) / 2), 561 - ((1080 - bounds.Height) / 2));
                    button1.Location = new System.Drawing.Point(823 - ((1920 - bounds.Width) / 2), 780 - ((1080 - bounds.Height) / 2));
                }
                else
                {
                    textBox1.Location = new System.Drawing.Point(708 - ((1920 - bounds.Width) / 2), 422 - ((1080 - bounds.Height) / 2));
                    textBox2.Location = new System.Drawing.Point(708 - ((1920 - bounds.Width) / 2), 553 - ((1080 - bounds.Height) / 2));
                    label1.Location = new System.Drawing.Point(702 - ((1920 - bounds.Width) / 2), 425 - ((1080 - bounds.Height) / 2));
                    label2.Location = new System.Drawing.Point(702 - ((1920 - bounds.Width) / 2), 556 - ((1080 - bounds.Height) / 2));
                    button1.Location = new System.Drawing.Point(823 - ((1920 - bounds.Width) / 2), 780 - ((1080 - bounds.Height) / 2));
                }
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Select();
            if (textBox2.TextLength == 0)
            {
                label2.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            textBox2.Select();
            if (textBox1.TextLength == 0)
            {
                label1.Visible = true;
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox2.TextLength == 0)
            {
                label2.Visible = true;
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (textBox1.TextLength == 0)
            {
                label1.Visible = true;
            }
        }
    }
}
