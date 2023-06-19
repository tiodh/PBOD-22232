using frontendpbo.Models;
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
    public partial class crud_informasi_pengumuman : Form
    {
        private string id = "";
        private int intRow = 0;

        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = 1; Database = Data Informasi Pengumuman");
        NpgsqlCommand cmd = default(NpgsqlCommand);
        string sql = string.Empty;

        public crud_informasi_pengumuman()
        {
            InitializeComponent();
            resetMe();
        }

        private void addParameters(string str)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("id_wisata", int.Parse(IDWisata.Text.Trim()));
            cmd.Parameters.AddWithValue("nama_informasi", NamaInformasi.Text.Trim());
            cmd.Parameters.AddWithValue("deskripsi_informasi", DeskripsiInformasi.Text.Trim());
            cmd.Parameters.AddWithValue("tanggal_informasi", DateTime.Parse(TanggalInformasi.Text.Trim()));

            if (str == "Update" || str == "Delete" && string.IsNullOrEmpty(this.id))
            {

                cmd.Parameters.AddWithValue("id", this.id);

            }
        }

        public static DataTable PerformCRUD(NpgsqlCommand com)
        {
            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);

            DataTable dt = new DataTable();
            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terdapat ERROR: " + ex.Message, "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                dt = null;
            }

            return dt;
        }

        private void crud_informasi_pengumuman_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void resetMe()
        {
            this.id = string.Empty;

            IDWisata.Text = "";
            NamaInformasi.Text = "";
            DeskripsiInformasi.Text = "";
            TanggalInformasi.Text = "";

            CreateInformasiPengumuman.Text = "Tambah Data";
            UpdateInformasiPengumuman.Text = "Update () ";
            DeleteInformasiPengumuman.Text = "Delete () ";
        }

        private void loadData(string keyword)
        {
            DataTable dataTable = null;
            try
            {
                sql = "SELECT id_wisata, nama_informasi, deskripsi_informasi, tanggal_informasi FROM pengumuman";
                string strKeyword = string.Format("%{0}%", keyword);

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("keyword", strKeyword);
                DataTable dt = PerformCRUD(cmd);

                int rowCount = dt.Rows.Count;
                if (rowCount > 0)
                {
                    TampilInformasi.MultiSelect = false;
                    TampilInformasi.AutoGenerateColumns = true;
                    TampilInformasi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    TampilInformasi.DataSource = dt;
                }
                else
                {
                    TampilInformasi.DataSource = null;
                }
                string searchText = SearchingInformasitextBox1.Text.Trim();

                if (!string.IsNullOrEmpty(searchText))
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Data Informasi Pengumuman;"))
                    {
                        string sql = "SELECT * FROM pengumuman WHERE nama_informasi ILIKE '%' || @searchText || '%' " +
                        "OR deskripsi_informasi ILIKE '%' || @searchText || '%' " +
                        "OR tanggal_informasi::text ILIKE '%' || @searchText || '%'";
                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@searchText", searchText);

                            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                            {
                                if (dataTable == null)
                                    dataTable = new DataTable();

                                adapter.Fill(dataTable);
                                TampilInformasi.DataSource = dataTable;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Data Loading Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void execute(string mySQL, string param)
        {
            cmd = new NpgsqlCommand(mySQL, conn);
            addParameters(param);
            PerformCRUD(cmd);
        }
        private void showdata()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from pengumuman where nama_informasi like '%" + TampilInformasi.Text + "'", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            TampilInformasi.DataSource = dt;

            TampilInformasi.Columns["id_wisata"].Width = 120;
            TampilInformasi.Columns["nama_informasi"].Width = 300;
            TampilInformasi.Columns["deskripsi_informasi"].Width = 300;
            TampilInformasi.Columns["tanggal_informasi"].Width = 1000;
        }

        private void textBox_namainformasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_deskripsiinformasi_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox_tanggalinformasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_informasipengumuman_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void create_informasipengumuman_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDWisata.Text.Trim()) || string.IsNullOrEmpty(NamaInformasi.Text.Trim()) || string.IsNullOrEmpty(DeskripsiInformasi.Text.Trim()) || string.IsNullOrEmpty(TanggalInformasi.Text.Trim()))
            {
                MessageBox.Show("Harap Masukkan Data Kembali", "Data Masih Kosong",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            sql = $"insert into pengumuman (id_wisata, nama_informasi, deskripsi_informasi, tanggal_informasi) values ('{IDWisata.Text}', '{NamaInformasi.Text}', '{DeskripsiInformasi.Text}', '{TanggalInformasi.Text}')";
            execute(sql, "TAMBAH DATA");
            MessageBox.Show("Data Telah Berhasil Dimasukkan.", "Terima Kasih",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");
            resetMe();
            showdata();

        }

        private void update_informasipengumuman_Click(object sender, EventArgs e)
        {
            if (TampilInformasi.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(IDWisata.Text.Trim()) || string.IsNullOrEmpty(NamaInformasi.Text.Trim()) || string.IsNullOrEmpty(DeskripsiInformasi.Text.Trim()) || string.IsNullOrEmpty(TanggalInformasi.Text.Trim()))
            {
                MessageBox.Show("Please input Id Barang and Name.", "Please Input Data",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            sql = "UPDATE pengumuman SET id_wisata = @id_wisata, nama_informasi = @nama_informasi, deskripsi_informasi = @deskripsi_informasi, tanggal_informasi = @tanggal_informasi WHERE id_wisata = @id_wisata";
            execute(sql, "UPDATE");

            MessageBox.Show("The record has been updated.", "Update Data",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");
            resetMe();
            showdata();
        }

        private void delete_informasipengumuman_Click(object sender, EventArgs e)
        {
            if (TampilInformasi.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Please select an item from the list.", "Please Delete Data",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Do you want to delete the data permanently?", "Delete Data",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                sql = "DELETE FROM pengumuman WHERE id_wisata = @id_wisata";
                execute(sql, "Delete");

                MessageBox.Show("The record has been deleted.", "Delete Data",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");
                resetMe();
                showdata();

                UpdateInformasiPengumuman.Text = "Update ()";
                DeleteInformasiPengumuman.Text = "Delete ()";
            }
        }

        private void dataGridView_informasipengumuman_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TampilInformasi.Rows.Count)
            {
                DataGridViewRow row = TampilInformasi.Rows[e.RowIndex];
                this.id = Convert.ToString(row.Cells["id_wisata"].Value);
                UpdateInformasiPengumuman.Text = "Update (" + this.id + ")";
                DeleteInformasiPengumuman.Text = "Delete (" + this.id + ")";


                IDWisata.Text = Convert.ToString(row.Cells["id_wisata"].Value);
                NamaInformasi.Text = Convert.ToString(row.Cells["nama_informasi"].Value);
                DeskripsiInformasi.Text = Convert.ToString(row.Cells["deskripsi_informasi"].Value);
                TanggalInformasi.Text = Convert.ToString(row.Cells["tanggal_informasi"].Value);

            }
        }

        private void label_namainformasi_Click(object sender, EventArgs e)
        {

        }

        private void SearchingPengumumantextBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = SearchingInformasitextBox1.Text.Trim();
            loadData(keyword);
        }

        private void NamaInformasi_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class read
    {
        static public DataTable contohSelect()
        {
            NpgsqlConnection connection = new NpgsqlConnection();
            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Data Informasi Pengumuman;";
            connection.ConnectionString = constr;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                string StrSql = "SELECT * FROM pengumuman";
                cmd.CommandText = StrSql;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }


}
