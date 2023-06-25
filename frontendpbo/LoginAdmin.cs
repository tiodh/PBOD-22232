using frontendpbo.Contexts;
using frontendpbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frontendpbo
{
    public partial class LoginAdmin : Form
    {
        ContextAdmin contextAdmin;
        Pengguna admin = new Pengguna();
        public LoginAdmin()
        {
            InitializeComponent();
            contextAdmin = new ContextAdmin();
            this.Size = new System.Drawing.Size(1200, 800);
            //this.WindowState = FormWindowState.Maximized;
        }

        private Models.Pengguna GetData()
        {

            admin.Username = tbx_user.Text;
            admin.Password = tbx_pasw.Text;

            return admin;
        }

        private void LoginAdmin_Load(object sender, EventArgs e)
        {
            panel1.Location = new System.Drawing.Point(
                (ClientSize.Width - panel1.Width) / 2,
                (ClientSize.Height - panel1.Height) / 2);
            panel2.Location = new System.Drawing.Point(
                (panel1.Width - panel2.Width) / 2,
                (panel1.Height - panel2.Height) / 2);
            button1.Location = new System.Drawing.Point((panel2.Width - button1.Width) / 2, (panel2.Height - button1.Height));
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            tbx_user.Select();
            if (tbx_pasw.TextLength == 0)
            {
                label2.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            tbx_pasw.Select();
            if (tbx_user.TextLength == 0)
            {
                label1.Visible = true;
            }
        }

        private void tbx_user_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (tbx_pasw.TextLength == 0)
            {
                label2.Visible = true;
            }
        }

        private void tbx_pasw_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (tbx_user.TextLength == 0)
            {
                label1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.Pengguna pengguna = this.GetData();
            bool loginSuccess = contextAdmin.Login(pengguna);

            if (loginSuccess)
            {

                Form2 form2 = new Form2("Admin");
                form2.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username atau password salah. Silakan coba lagi.", "Error Message");
            }
        }
    }
}
