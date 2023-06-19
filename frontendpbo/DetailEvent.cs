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
        public DetailEvent()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = "Server=localhost;Port=5433;User Id=postgres;Password=ilacantik123;Database=EventAcara";
            string query = "SELECT * FROM eventacara";

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
                        dataGridView1.DataSource = dt;
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
                connect.ConnectionString = "Server=localhost;Port=5433;User Id=postgres;Password=ilacantik123;Database=EventAcara";
            }

            public DataTable Run(string sql)
            {
                NpgsqlConnection connect = new NpgsqlConnection();
                connect.ConnectionString = "Server=localhost;Port=5433;User Id=postgres;Password=ilacantik123;Database=EventAcara";

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
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected= true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["id_Event"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["nama_Event"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["tanggal_pelaksana"].FormattedValue.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["deskripsi_Event"].FormattedValue.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["wisata_id"].FormattedValue.ToString();
            }
        }
    }
}
