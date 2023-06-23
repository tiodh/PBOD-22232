using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.TimeZoneInfo;

namespace frontendpbo
{
    public partial class Form1 : Form
    {
        private Form activeForm = null;


        public Form1()
        {
            InitializeComponent();
            mainside.Visible = true;
        }


        private void hidemainside()
        {
            if (mainside.Visible == true)
                mainside.Visible = false;

        }

        private void showmainside()
        {
            if (mainside.Visible == false)
            {
                hidemainside();
                //pictureBox3.Size = new System.Drawing.Size(1871 - mainside.Width, 478);
                //pictureBox3.Location = new System.Drawing.Point(53 + mainside.Width, 94);
                mainside.Visible = true;
            }
            else
            {
                //pictureBox3.Size = new System.Drawing.Size(1871, 478);
                //pictureBox3.Location = new System.Drawing.Point(53, 94);
                mainside.Visible = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            showmainside();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click_1(object sender, EventArgs e)
        {
            showmainside();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new System.Drawing.Point(
                30,
                (panel3.Height - pictureBox1.Height) / 2);
            int taskbarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            this.Height -= taskbarHeight;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) // Jika Form di-minimize
            {
                // Kode untuk menyesuaikan tampilan saat di-minimize
                // Misalnya, Anda dapat menyembunyikan elemen-elemen tertentu atau mengubah tata letak

            }
            else if (this.WindowState == FormWindowState.Maximized) // Jika Form di-maximize
            {
                // Kode untuk menyesuaikan tampilan saat di-maximize
                // Misalnya, Anda dapat memperbarui tata letak elemen-elemen atau menampilkan elemen-elemen tambahan

            }

        }


        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //openChildForm(new CPengunjung());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int cornerRadius = 60;
            int width = panel3.Width;
            int height = panel3.Height;

            path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(width - cornerRadius, height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(0, height - cornerRadius, cornerRadius, cornerRadius, 90, 90);

            path.CloseFigure();

            panel3.Region = new Region(path);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginAdmin form = new LoginAdmin();
            form.ShowDialog();
        }
    }
}