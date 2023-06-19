using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontendpbo
{
    public partial class Data_Penngunjungcs : Form
    {
        public string ErrorCheck;
        private string? connectionString;

        public Data_Penngunjungcs()
        {
            InitializeComponent();
            // Mendapatkan daftar nama bulan dalam bahasa Inggris
            string[] namaBulan = CultureInfo.CurrentCulture.DateTimeFormat.MonthNames;

            Tahun.Items.Add("All Years");
            Bulan.Items.Add("All Month");

            Kategori.Items.Add("All Category");
            Kategori.Items.Add("Anak Anak");
            Kategori.Items.Add("Dewasa");
            Kategori.Items.Add("Jenis Tiket");
            connectionString = "Host=localhost;Username=postgres;Password=132435;Database=PETAJEMBER";
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Kueri untuk mendapatkan tahun awal dari tabel riwayat_kunjungan
                    string query = "SELECT MIN(EXTRACT(YEAR FROM tanggal_kunjungan)) FROM riwayat_kunjungan";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        // Mendapatkan tahun awal dari hasil kueri
                        int tahunAwal = Convert.ToInt32(command.ExecuteScalar());

                        // Mendapatkan tahun saat ini
                        int tahunSaatIni = DateTime.Now.Year;

                        // Menambahkan tahun ke ComboBox Tahun
                        for (int tahun = tahunAwal; tahun <= tahunSaatIni; tahun++)
                        {
                            Tahun.Items.Add(tahun.ToString());
                        }
                    }
                }

                // Menambahkan nama bulan ke ComboBox Bulan
                foreach (string bulan in namaBulan)
                {
                    if (!string.IsNullOrEmpty(bulan))
                    {
                        Bulan.Items.Add(bulan);
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorCheck = ex.Message;
                status_Database.Text = "Database : Error";
                // Tindakan lain yang perlu dilakukan jika terjadi kesalahan
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kode yang akan dieksekusi ketika perubahan terjadi pada ComboBox Kategori
        }

        private void panel_ReadData_Paint(object sender, PaintEventArgs e)
        {

        }

        private void status_Database_Click(object sender, EventArgs e)
        {
            if (status_Database.Text == "Database : Error")
            {
                MessageBox.Show("Terjadi kesalahan saat membuka database: " + ErrorCheck);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bulan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedTahun = Tahun.SelectedItem.ToString();
            string selectedBulan = Bulan.SelectedItem.ToString();
            string selectedKategori = Kategori.SelectedItem.ToString();

            // Menggunakan StringBuilder untuk membangun query
            StringBuilder queryBuilder = new StringBuilder();
            queryBuilder.Append("SELECT * FROM riwayat_kunjungan WHERE ");

            // Menambahkan kondisi berdasarkan pilihan pengguna di ComboBox
            if (selectedTahun != "All Years")
            {
                queryBuilder.Append("EXTRACT(YEAR FROM tanggal_kunjungan) = ");
                queryBuilder.Append(selectedTahun);
            }

            if (selectedBulan != "All Month")
            {
                if (selectedTahun != "All Years")
                {
                    queryBuilder.Append(" AND ");
                }

                queryBuilder.Append("EXTRACT(MONTH FROM tanggal_kunjungan) = ");
                queryBuilder.Append(Array.IndexOf(CultureInfo.CurrentCulture.DateTimeFormat.MonthNames, selectedBulan) + 1);
            }

            if (selectedKategori != "All Category")
            {
                if (selectedTahun != "All Years" || selectedBulan != "All Month")
                {
                    queryBuilder.Append(" AND ");
                }

                if (selectedKategori == "Jenis Tiket")
                {
                    queryBuilder.Append("tiket_id IN (2, 3, 4)");
                }
                else
                {
                    queryBuilder.Append("kategori = '");
                    queryBuilder.Append(selectedKategori);
                    queryBuilder.Append("'");
                }
            }

            string query = queryBuilder.ToString();

            // Eksekusi query dan tampilkan hasilnya di DataGridView
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        DataGrid_Utama.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorCheck = ex.Message;
                MessageBox.Show("Terjadi kesalahan saat mengambil data: " + ErrorCheck);
            }
        }
    }
}


namespace NpgSqlCRUD
{
    public static class DatabaseManager
    {
        private static string connectionString = "Host=localhost;Username=postgres;Password=132435;Database=PETAJEMBER";

        public static DataTable ExecuteQuery(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or throw it further
                throw new Exception("Error executing query: " + ex.Message);
            }
        }

        public static int ExecuteNonQuery(string query)
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or throw it further
                throw new Exception("Error executing non-query: " + ex.Message);
            }
        }
    }
}
