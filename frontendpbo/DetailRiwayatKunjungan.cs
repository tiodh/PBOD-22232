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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frontendpbo
{
    public partial class DetailRiwayatKunjungan : Form
    {
        ContextRiwayatKunjungan contextRiwayat = new ContextRiwayatKunjungan();
        ContextRiwayatPengunjung contextPengunjung = new ContextRiwayatPengunjung();
        ContextTiket contextTiket = new ContextTiket();

        public List<Riwayat> listRiwayats = new List<Riwayat>();

        public int CurrentId;
        string pilihan;
        string perintah;

        public DetailRiwayatKunjungan()
        {
            InitializeComponent();
            ReadDataRiwayatKunjungan();
            btUpdate.Enabled = false;
        }

        private void setDataGridview()
        {
            dataGridView1.Columns["nama"].HeaderText = "Nama_Pengunjung";
            dataGridView1.Columns["Tanggal_kunjungan"].HeaderText = "Tanggal_kunjungan";
            dataGridView1.Columns["Jumlah_Tiket"].HeaderText = "Jumlah_Tiket";
            dataGridView1.Columns["nama_tiket"].HeaderText = "Nama_Tiket";
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Pengunjung_ID"].Visible = false;
            dataGridView1.Columns["Tiket_ID"].Visible = false;
        }

        private void ReadDataRiwayatKunjungan()
        {
            contextRiwayat.ListRiwayat = listRiwayats;
            contextRiwayat.Read();
            dataGridView1.DataSource = contextRiwayat.ListRiwayat;
            setDataGridview();
            loadComboBoxPengunjung();
            loadComboBoxTiket();
        }

        private Riwayat GetDataRiwayatKunjungan()
        {
            Riwayat riwayatKunjungan = new Riwayat();

            
            riwayatKunjungan.Tanggal_Kunjungan = DateOnly.Parse(dtTanggal.Value.ToShortDateString());
            riwayatKunjungan.Jumlah_Tiket = int.Parse(tbJumlah.Text);
            riwayatKunjungan.Tiket_ID = ((Tiket)cbTiket.SelectedItem).id_tiket;
            riwayatKunjungan.nama_tiket = ((Tiket)cbTiket.SelectedItem).nama_tiket;
            riwayatKunjungan.Pengunjung_ID = ((PengunjungWisata)cbPengunjung.SelectedItem).Id;
            riwayatKunjungan.nama = ((PengunjungWisata)cbPengunjung.SelectedItem).Name;

            riwayatKunjungan.Id = CurrentId;

            return riwayatKunjungan;
        }

        

        private void Edit_Riwayat_Kunjungan_Load(object sender, EventArgs e)
        {
            panel3.Location = new System.Drawing.Point((panel1.Width - panel3.Width) / 2);
        }



        private void loadComboBoxPengunjung()
        {
            List<PengunjungWisata> pengunjungList = contextPengunjung.Read();

            cbPengunjung.DataSource = pengunjungList;
            cbPengunjung.ValueMember = "Id";
            cbPengunjung.DisplayMember = "Name";
        }

        private void loadComboBoxTiket()
        {
            List<Tiket> tiketList =  contextTiket.ReadtoCard();

            cbTiket.DataSource = tiketList;
            cbTiket.ValueMember = "id_tiket";
            cbTiket.DisplayMember = "nama_tiket";
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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                /*tbNIM.Enabled = false;
                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;*/
                Riwayat riwayat = listRiwayats[e.RowIndex];
                CurrentId = riwayat.Id;
                cbPengunjung.SelectedValue = riwayat.Pengunjung_ID;
                cbTiket.SelectedValue = riwayat.Tiket_ID;
                tbJumlah.Text = riwayat.Jumlah_Tiket.ToString();
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            Riwayat riwayatinsert = this.GetDataRiwayatKunjungan();
            contextRiwayat.Insert(riwayatinsert);
            dataGridView1.DataSource = null;
            ReadDataRiwayatKunjungan();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            Riwayat riwayatupdate = this.GetDataRiwayatKunjungan();
            contextRiwayat.Update(riwayatupdate);
            dataGridView1.DataSource = null;
            ReadDataRiwayatKunjungan();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                /*tbNIM.Enabled = false;
                btnInsert.Enabled = false;
                btnUpdate.Enabled = true;*/
                Riwayat riwayat = listRiwayats[e.RowIndex];
                CurrentId = riwayat.Id;
                cbPengunjung.SelectedValue = riwayat.Pengunjung_ID;
                cbTiket.SelectedValue = riwayat.Tiket_ID;
                tbJumlah.Text = riwayat.Jumlah_Tiket.ToString();
            }

            btUpdate.Enabled = true;
            btInsert.Enabled = false;
        }

        private void DetailRiwayatKunjungan_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            btUpdate.Enabled = false;
            btInsert.Enabled = true;
            tbJumlah.Text = "";
            cbPengunjung.SelectedValue = "";
            cbTiket.SelectedValue = "";
        }
    }
}
