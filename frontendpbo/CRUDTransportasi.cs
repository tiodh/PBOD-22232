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
using System;

namespace frontendpbo
{
    public partial class CRUDTransportasi : Form
    {
        private string id = "";
        private int intRow = 0;

        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5433; User Id = postgres; Password = 12345678; Database = data_transportasi");
        NpgsqlCommand cmd = default(NpgsqlCommand);
        string sql = string.Empty;
        public CRUDTransportasi()
        {
            InitializeComponent();
            resetMe();
        }
        private void addParameters(string str)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("id_transportasi", int.Parse(IDTransportasi.Text.Trim()));
            cmd.Parameters.AddWithValue("nama_transportasi", NamaTransportasi.Text.Trim());
            cmd.Parameters.AddWithValue("jenis_transportasi", JenisTransportasi.Text.Trim());
            cmd.Parameters.AddWithValue("deskripsi", DeskripsiTransportasi.Text.Trim());

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
        private void CRUDTrasnportasi_Load(object sender, EventArgs e)
        {
            showdata();
        }
        public void resetMe()
        {
            this.id = string.Empty;

            IDTransportasi.Text = "";
            NamaTransportasi.Text = "";
            JenisTransportasi.Text = "";
            DeskripsiTransportasi.Text = "";

            CreateTransportasi.Text = "Tambah Data";
            UpdateTransportasi.Text = "Update () ";
            DeleteTransportasi.Text = "Delete () ";
        }

        private void loadData(string keyword)
        {
            DataTable dataTable = null;
            try
            {
                sql = "SELECT id_transportasi, nama_transportasi, jenis_transportasi, deskripsi FROM Transportasi";
                string strKeyword = string.Format("%{0}%", keyword);

                cmd = new NpgsqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("keyword", strKeyword);
                DataTable dt = new DataTable();
                int rowCount = dt.Rows.Count;
                if (rowCount > 0)
                {
                    TampilData.MultiSelect = false;
                    TampilData.AutoGenerateColumns = true;
                    TampilData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    TampilData.DataSource = dt;
                }
                else
                {
                    TampilData.DataSource = null;
                }

                string searchText = TampilanData.Text.Trim();

                if (!string.IsNullOrEmpty(searchText))
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5433;User Id=postgres;Password=12345678;Database=data_transportasi;"))
                    {
                        string sql = "SELECT * FROM transportasi WHERE nama_transportasi ILIKE '%' || @searchText || '%' " +
                        "OR jenis_transportasi ILIKE '%' || @searchText || '%' ";
                        using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                        {
                            command.Parameters.AddWithValue("@searchText", searchText);

                            using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                            {
                                if (dataTable == null)
                                    dataTable = new DataTable();

                                adapter.Fill(dataTable);
                                TampilData.DataSource = dataTable;
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
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from Transportasi where nama_transportasi like '%" + TampilData.Text + "'", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            TampilData.DataSource = dt;

            TampilData.Columns["id_transportasi"].Width = 120;
            TampilData.Columns["nama_transportasi"].Width = 150;
            TampilData.Columns["jenis_transportasi"].Width = 150;
            TampilData.Columns["deskripsi"].Width = 805;
        }

        private void CreateTransportasi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDTransportasi.Text.Trim()) || string.IsNullOrEmpty(NamaTransportasi.Text.Trim()) || string.IsNullOrEmpty(JenisTransportasi.Text.Trim()) || string.IsNullOrEmpty(DeskripsiTransportasi.Text.Trim()))
            {
                MessageBox.Show("Harap Masukkan Data Kembali", "Data Masih Kosong",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            sql = $"insert into transportasi (id_transportasi, nama_transportasi, jenis_transportasi, deskripsi) values ('{IDTransportasi.Text}', '{NamaTransportasi.Text}', '{JenisTransportasi.Text}', '{DeskripsiTransportasi.Text}')";
            execute(sql, "TAMBAH DATA");
            MessageBox.Show("Data Telah Berhasil Dimasukkan.", "Terima Kasih",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");
            resetMe();
            showdata();
        }

        private void UpdateTransportasi_Click(object sender, EventArgs e)
        {
            if (TampilData.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(IDTransportasi.Text.Trim()) || string.IsNullOrEmpty(NamaTransportasi.Text.Trim()) || string.IsNullOrEmpty(JenisTransportasi.Text.Trim()) || string.IsNullOrEmpty(DeskripsiTransportasi.Text.Trim()))
            {
                MessageBox.Show("Please input Id Barang and Name.", "Please Input Data",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            sql = "UPDATE transportasi SET id_transportasi = @id_transportasi, nama_transportasi = @nama_transportasi, jenis_transportasi = @jenis_transportasi, deskripsi = @deskripsi WHERE id_transportasi = @id_transportasi";
            execute(sql, "UPDATE");
            MessageBox.Show("The record has been updated.", "Update Data",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData("");
            resetMe();
            showdata();
        }

        private void TampilData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TampilData.Rows.Count)
            {
                DataGridViewRow row = TampilData.Rows[e.RowIndex];
                this.id = Convert.ToString(row.Cells["id_transportasi"].Value);
                UpdateTransportasi.Text = "Update (" + this.id + ")";
                DeleteTransportasi.Text = "Delete (" + this.id + ")";

                IDTransportasi.Text = Convert.ToString(row.Cells["id_transportasi"].Value);
                NamaTransportasi.Text = Convert.ToString(row.Cells["nama_transportasi"].Value);
                JenisTransportasi.Text = Convert.ToString(row.Cells["jenis_transportasi"].Value);
                DeskripsiTransportasi.Text = Convert.ToString(row.Cells["deskripsi"].Value);
            }
        }

        private void DeleteTransportasi_Click(object sender, EventArgs e)
        {
            if (TampilData.Rows.Count == 0)
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
                sql = "DELETE FROM transportasi WHERE id_transportasi = @id_transportasi";
                execute(sql, "Delete");

                MessageBox.Show("The record has been deleted.", "Delete Data",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");
                resetMe();
                showdata();

                UpdateTransportasi.Text = "Update ()";
                DeleteTransportasi.Text = "Delete ()";
            }
        }

        private void TampilanData_TextChanged(object sender, EventArgs e)
        {
            string keyword = TampilanData.Text.Trim();
            loadData(keyword);
        }
    }
}


//Yang bisa jalan