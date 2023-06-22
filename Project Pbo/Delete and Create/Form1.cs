using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Delete_and_Create
{
    public partial class Form1 : Form
    {
        private string connectionString = "Host=localhost;Port=5432;Database=data_tempat_makan;Username=postgres;Password=060702";
        private NpgsqlConnection connection;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM rembangan";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
        }
        private void Create_Click(object sender, EventArgs e)
        {
            string Nama = nama.Text;
            string Lokasi = lokasi.Text;
            string Deskripsi = deskripsi.Text;
            string Telepon = telepon.Text;

            string query = "INSERT INTO rembangan (nama_tempat_makan, lokasi_tempat_makan, deskripsi_tempat_makan, no_telepon_tempat_makan) " +
                "VALUES (@nama_tempat_makan, @lokasi_tempat_makan, @deskripsi_tempat_makan, @no_telepon_tempat_makan)";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@nama_tempat_makan", Nama);
            command.Parameters.AddWithValue("@lokasi_tempat_makan", Lokasi);
            command.Parameters.AddWithValue("@deskripsi_tempat_makan", Deskripsi);
            command.Parameters.AddWithValue("@no_telepon_tempat_makan", Telepon);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Restaurant created successfully.");
                ClearFields();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Failed to create restaurant.");
            }
        }
            private void RefreshData()
            {
                string query = "SELECT * FROM rembangan";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        
        private void Delete_Click(object sender, EventArgs e)
        {
            int idTempatMakan = Convert.ToInt32(textBoxID.Text.Trim());

            if (idTempatMakan > 0)
            {
                string query = "DELETE FROM rembangan WHERE id_tempat_makan = @id_tempat_makan";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@id_tempat_makan", idTempatMakan);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Restaurant with ID '" + idTempatMakan + "' deleted successfully.");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete restaurant.");
                }
            }
            else
            {
                MessageBox.Show("Invalid ID format.");
            }
        }
        private void ClearFields()
        {
            nama.Text = "";
            lokasi.Text = "";
            deskripsi.Text = "";
            telepon.Text = "";
        }
    }
}

