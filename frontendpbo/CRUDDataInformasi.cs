using frontendpbo.Contexts;
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
    public partial class CRUDDataInformasi : Form
    {
        private ContextInformasiPengumuman db;
        private string id = "";
        Models.Pengumuman pengumuman = new Models.Pengumuman();

        public CRUDDataInformasi()
        {
            InitializeComponent();
            db = new ContextInformasiPengumuman();
            resetMe();



        }
        private void crud_informasi_pengumuman_Load(object sender, EventArgs e)
        {

            showdata();

        }
        private void resetMe()
        {
            this.id = string.Empty;
            IDWisata.Text = "";
            NamaInformasi.Text = "";
            DeskripsiInformasi.Text = "";
            TanggalInformasi.Text = "";

            CreateInformasiPengumuman.Text = "Tambah Data";
            UpdateInformasiPengumuman.Text = "Update ()";
            DeleteInformasiPengumuman.Text = "Delete ()";
        }

        private void loadData(string keyword)
        {

            IQueryable<Pengumuman> query = db.ListInformasiPengumuman.AsQueryable();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(p => p.nama_informasi.Contains(keyword) ||
                                         p.deskripsi_informasi.Contains(keyword) ||
                                         p.tanggal_informasi.ToString().Contains(keyword));
            }

            List<Pengumuman> pengumumanList = query.ToList();
            TampilInformasi.DataSource = pengumumanList;
        }

        private void showdata()
        {

            List<Pengumuman> pengumumanList = db.ListInformasiPengumuman.ToList();
            TampilInformasi.DataSource = pengumumanList;

            TampilInformasi.Columns["id_informasi"].Width = 120;
            TampilInformasi.Columns["nama_informasi"].Width = 200;
            TampilInformasi.Columns["deskripsi_informasi"].Width = 200;
            TampilInformasi.Columns["tanggal_informasi"].Width = 750;
        }

        private void execute(string sql, string param)
        {
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing SQL: " + ex.Message);

            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {

        }



        private void Exit_informasipengumuman_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TampilInformasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < TampilInformasi.Rows.Count)
            {
                DataGridViewRow row = TampilInformasi.Rows[e.RowIndex];
                this.id = Convert.ToString(row.Cells["id_informasi"].Value);
                UpdateInformasiPengumuman.Text = "Update (" + this.id + ")";
                DeleteInformasiPengumuman.Text = "Delete (" + this.id + ")";


                IDWisata.Text = Convert.ToString(row.Cells["id_informasi"].Value);
                NamaInformasi.Text = Convert.ToString(row.Cells["nama_informasi"].Value);
                DeskripsiInformasi.Text = Convert.ToString(row.Cells["deskripsi_informasi"].Value);
                TanggalInformasi.Text = Convert.ToString(row.Cells["tanggal_informasi"].Value);
            }
        }

        private void CreateInformasiPengumuman_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDWisata.Text.Trim()) || string.IsNullOrEmpty(NamaInformasi.Text.Trim()) || string.IsNullOrEmpty(DeskripsiInformasi.Text.Trim()) || string.IsNullOrEmpty(TanggalInformasi.Text.Trim()))
            {
                MessageBox.Show("Harap Masukkan Data Kembali", "Data Masih Kosong",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string sql = $"INSERT INTO informasi_pengumuman (id_informasi, nama_informasi, deskripsi_informasi, tanggal_informasi) VALUES ('{IDWisata.Text}', '{NamaInformasi.Text}', '{DeskripsiInformasi.Text}', '{TanggalInformasi.Text}')";
            execute(sql, "TAMBAH DATA");
            MessageBox.Show("Data Telah Berhasil Dimasukkan.", "Terima Kasih",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


            loadData("");
            resetMe();

        }

        private void UpdateInformasiPengumuman_Click(object sender, EventArgs e)
        {
            if (TampilInformasi.Rows.Count == 0)
            {
                return;
            }

            if (string.IsNullOrEmpty(IDWisata.Text.Trim()) || string.IsNullOrEmpty(NamaInformasi.Text.Trim()) || string.IsNullOrEmpty(DeskripsiInformasi.Text.Trim()) || string.IsNullOrEmpty(TanggalInformasi.Text.Trim()))
            {
                MessageBox.Show("Please input Id Wisata and Name.", "Please Input Data",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string sql = $"UPDATE informasi_pengumuman SET id_informasi = '{IDWisata.Text}', nama_informasi = '{NamaInformasi.Text}', deskripsi_informasi = '{DeskripsiInformasi.Text}', tanggal_informasi = '{TanggalInformasi.Text}' WHERE id_wisata = '{this.id}'";
            execute(sql, "UPDATE DATA");
            MessageBox.Show("Data Telah Berhasil Diupdate.", "Terima Kasih",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData("");
            resetMe();

        }

        private void DeleteInformasiPengumuman_Click(object sender, EventArgs e)
        {
            if (TampilInformasi.Rows.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = $"DELETE FROM informasi_pengumuman WHERE id_informasi = '{this.id}'";
                execute(sql, "DELETE DATA");
                MessageBox.Show("Data Telah Berhasil Dihapus.", "Terima Kasih",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData("");
                resetMe();


            }
        }

        private void NamaInformasi_TextChanged(object sender, EventArgs e)
        {
            string keyword = NamaInformasi.Text.Trim();
            loadData(keyword);
        }

        private void DeskripsiInformasi_TextChanged(object sender, EventArgs e)
        {
            string keyword = DeskripsiInformasi.Text.Trim();
            loadData(keyword);
        }

        private void TanggalInformasi_TextChanged(object sender, EventArgs e)
        {
            string keyword = TanggalInformasi.Text.Trim();
            loadData(keyword);
        }
    }
}