using Npgsql;
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
    public partial class Pengunjung : Form
    {
        private DataTable? dataTable;
        public Pengunjung()
        {
            InitializeComponent();
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
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=garudart10rw02;Database=data_pengunjung;"))
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
                dataGridView1.DataSource = read.contohSelect();
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

        private void label5_Click(object sender, EventArgs e)
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
    }
    class read
    {
        static public DataTable contohSelect()
        {

            NpgsqlConnection connection = new NpgsqlConnection();


            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=garudart10rw02;Database=data_pengunjung;";
            connection.ConnectionString = constr;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                string StrSql = "select * from Pengunjung";
                cmd.CommandText = StrSql;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return dt;
        }
    }
}
