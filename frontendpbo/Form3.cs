﻿using System;
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

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (textBox2.TextLength == 0)
            {
                label2.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
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