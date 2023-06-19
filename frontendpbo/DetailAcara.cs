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
    public partial class DetailAcara : Form
    {
        public DetailAcara()
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
        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEvent3_Click(object sender, EventArgs e)
        {

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
}
