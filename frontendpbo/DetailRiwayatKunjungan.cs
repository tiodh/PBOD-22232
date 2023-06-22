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
    public partial class DetailRiwayatKunjungan : Form
    {
        ContextRiwayatKunjungan contextRiwayat = new ContextRiwayatKunjungan();
        ContextPengunjung contextPengunjung = new ContextPengunjung();
        ContextWisata contextWisata = new ContextWisata();

        public List<Riwayat> listRiwayats = new List<Riwayat>();
        
        string pilihan;
        string perintah;

        public DetailRiwayatKunjungan()
        {
            InitializeComponent();
            ReadDataRiwayatKunjungan();
        }

        private void setDataGridview()
        {
            dataGridView1.Columns["nama"].HeaderText = "Nama_Pengunjung";
            dataGridView1.Columns["Tanggal_kunjungan"].HeaderText = "Tanggal_kunjungan";
            dataGridView1.Columns["Jumlah_Tiket"].HeaderText = "Jumlah_Tiket";
            dataGridView1.Columns["nama_tiket"].HeaderText = "Nama_Tiket"; 
        }

        private void ReadDataRiwayatKunjungan()
        {
            contextRiwayat.ListRiwayat = listRiwayats;
            contextRiwayat.Read();
            dataGridView1.DataSource = contextRiwayat.ListRiwayat;
            setDataGridview();
        }

        private void GetDataRiwayatKunjungan()
        {

        }

        

        private void Edit_Riwayat_Kunjungan_Load(object sender, EventArgs e)
        {
            panel3.Location = new System.Drawing.Point((panel1.Width - panel3.Width) / 2);
        }



        private void laodComboBoxPengunjung()
        {

        }

        private void loadComboBoxTiket()
        {

        } 

        private void btInsert_Click(object sender, EventArgs e)
        {

        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btHapus_Click(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            contextRiwayat = new ContextRiwayatKunjungan();
            List<Riwayat> ListRiwayat = contextRiwayat.ListRiwayat;
            contextRiwayat.search(textBox1.Text);
            dataGridView1.DataSource = ListRiwayat;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
