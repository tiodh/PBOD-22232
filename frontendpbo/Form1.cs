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

        private void button4_Click(object sender, EventArgs e)
        {
        }
    }
}