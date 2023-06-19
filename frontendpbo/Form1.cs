using static System.TimeZoneInfo;

namespace frontendpbo
{
    public partial class Form1 : Form
    {
        //private Timer transitionTimer;
        //private int transitionStep;
        //private Color panelColor;


        public Form1()
        {
            InitializeComponent();
            mainside.Visible = false;
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
                mainside.Visible = true;
            }
            else
                mainside.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void panel3_Paint(object sender, PaintEventArgs e)
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
            pictureBox1.Location = new System.Drawing.Point(25, (panel3.Height - pictureBox1.Height) / 2);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rembangan_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private Form activeForm = null;

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
            openChildForm(new Pengunjung());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form3());
        }

        private void Login_Click(object sender, EventArgs e)
        {
            LoginAdmin formlog = new LoginAdmin();
            formlog.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}