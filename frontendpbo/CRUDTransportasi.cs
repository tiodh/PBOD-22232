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
    public partial class CRUDTransportasi : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = @unsiyah23; Database = DataTransportasi");
        NpgsqlCommand cmd = default(NpgsqlCommand);
        string sql = string.Empty;
        public CRUDTransportasi()
        {
            InitializeComponent();
        }
        private void addParameters(string str)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("id_transportasi", IDTransportasi.Text.Trim());
            cmd.Parameters.AddWithValue("nama_transportasi", NamaTransportasi.Text.Trim());
            cmd.Parameters.AddWithValue("jenis_transportasi", JenisTransportasi.Text.Trim());
            cmd.Parameters.AddWithValue("deskripsi", DeskripsiTransportasi.Text.Trim());
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
            //this.id = string.Empty;

            IDTransportasi.Text = "";
            NamaTransportasi.Text = "";
            JenisTransportasi.Text = "";
            DeskripsiTransportasi.Text = "";

            CreateTransportasi.Text = "Tambah Data";
        }

        private void loadData(string keyword)
        {
            sql = "SELECT id_transportasi, nama_transportasi, jenis_transportasi, deskripsi FROM Transportasi";
            string strKeyword = string.Format("%{0}%", keyword);

            cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("keyword", strKeyword);
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
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            TampilData.DataSource = dt;

            TampilData.Columns["id_transportasi"].Width = 100;
            TampilData.Columns["nama_transportasi"].Width = 110;
            TampilData.Columns["jenis_transportasi"].Width = 100;
            TampilData.Columns["deskripsi"].Width = 550;
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
    }
}