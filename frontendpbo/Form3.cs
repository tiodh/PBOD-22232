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
            if (bounds.Height < 1000)
            {

                panel3.Size = new System.Drawing.Size(736, 460);
                label1.Location = new System.Drawing.Point(177, 182);
                textBox1.Location = new System.Drawing.Point(177, 182);
                textBox1.Width = 392;
                label2.Location = new System.Drawing.Point(177, 281);
                textBox2.Location = new System.Drawing.Point(177, 281);
                textBox2.Width = 392;
            }
            else
            {
                panel3.Height = 610;
            }

            panel3.Location = new System.Drawing.Point(587 - ((1920 - bounds.Width) / 2), 224 - ((1080 - bounds.Height) / 2));

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
