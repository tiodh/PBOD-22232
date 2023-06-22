using Npgsql;
using System.Data;
using frontendpbo.Contexts;

namespace frontendpbo
{
    public partial class Pengunjung : Form
    {
        private DataTable? dataTable;
        public Pengunjung()
        {
            InitializeComponent();
            ShowData();
        }

        public void ShowData()
        {
            DataTable dt = new DataTable();
            dt = Contexts.ContextPengunjung.Read();
            dataGridView1.DataSource = dt;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void loaddata()
        {
            string searchText = textBox3.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=132435;Database=peta_jember;"))
                {

                    string sql = "SELECT * FROM pengunjung WHERE nama_pengunjung ILIKE '%' || @searchText || '%' " +
                    "OR asal_pengunjung ILIKE '%' || @searchText || '%' ";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@searchText", searchText);

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            else
            {
                dataGridView1.DataSource = ContextPengunjung.Read();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchingtextBox3_TextChanged(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_Main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
