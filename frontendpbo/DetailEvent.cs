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
    public partial class DetailEvent : Form
    {
        DataTable? dataTable;
        public DetailEvent()
        {
            InitializeComponent();
            LoadData();
        }
        private void SearchData()
        {
            string searchText = textBox6Search.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;"))
                {

                    string sql = "SELECT * FROM event_acara WHERE nama_event ILIKE '%' || @searchText || '%' " +
                    "OR deskripsi_event ILIKE '%' || @searchText || '%' " +
                    "OR tanggal_event::text ILIKE '%' || @searchText || '%' ";
                    using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                    {

                        command.Parameters.AddWithValue("@searchText", searchText);

                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {
                            dataTable = new DataTable();

                            adapter.Fill(dataTable);

                            dataGridView1Search.DataSource = dataTable;
                        }
                    }
                }
            }
            else
            {
                LoadData();
            }
        }
        private void LoadData()
        {

            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";
            string query = "SELECT * FROM event_acara";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1Search.DataSource = dt;
                    }
                }
            }
        }
        class Connec
        {
            public NpgsqlConnection connect;

            public Connec()
            {
                NpgsqlConnection connect = new NpgsqlConnection();
                connect.ConnectionString = "Server=localhost;Port=5433;User Id=postgres;Password=123;Database=peta_jember";
            }

            public DataTable Run(string sql)
            {
                NpgsqlConnection connect = new NpgsqlConnection();
                connect.ConnectionString = "Server=localhost;Port=5433;User Id=postgres;Password=123;Database=peta_jember";

                DataTable dt = new DataTable();
                try
                {
                    connect.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connect;
                    cmd.CommandText = sql;
                    cmd.CommandType = CommandType.Text;
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    da.Fill(dt);
                    cmd.Dispose();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                }
                return dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1Search.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1Search.CurrentRow.Selected = true;
                textBox1IDEvent.Text = dataGridView1Search.Rows[e.RowIndex].Cells["id_Event"].FormattedValue.ToString();
                textBox2NamaEvent.Text = dataGridView1Search.Rows[e.RowIndex].Cells["nama_Event"].FormattedValue.ToString();
                textBox3TanggalPelaksana.Text = dataGridView1Search.Rows[e.RowIndex].Cells["tanggal_event"].FormattedValue.ToString();
                textBox4Deskripsi.Text = dataGridView1Search.Rows[e.RowIndex].Cells["deskripsi_Event"].FormattedValue.ToString();
                textBox5ObjekWisata.Text = dataGridView1Search.Rows[e.RowIndex].Cells["wisata_id"].FormattedValue.ToString();
            }
        }

        private void dataGridView1Search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1Seacrh_Click(object sender, EventArgs e)
        {

        }

        private void labeltanggal_Click(object sender, EventArgs e)
        {

        }

        private void textBox6Search_TextChanged(object sender, EventArgs e)
        {
            SearchData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}



