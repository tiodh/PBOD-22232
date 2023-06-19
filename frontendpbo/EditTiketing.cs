using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CUD_DataTiket
{
    public partial class EditTiketing : Form
    {
        private int idtiket;
        public EditTiketing()
        {
            InitializeComponent();
        }
        void loadgrid()
        {
            DataGridViewEditTiket.DataSource = CUDEditTiket.BacaTiket();
            //DataGridViewEditTiket.Column(0).Visible = false;
        }

        private void btnTambahTiket_Click(object sender, EventArgs e)
        {
            CUDEditTiket.BuatTIket(txtNamaTiket.Text, txtDeskTiket.Text, Convert.ToInt32(txtHargaTiket.Text), Convert.ToInt32(txtIDTIket.Text));
            loadgrid();

            txtIDTIket.Text = "";
            txtNamaTiket.Text = "";
            txtDeskTiket.Text = "";
            txtHargaTiket.Text = "";
        }

        private void PanelReadDataTiket_Paint(object sender, PaintEventArgs e)
        {
            loadgrid();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (idtiket == 0)
            {
                MessageBox.Show("Pilih data yang mau di update", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                CUDEditTiket.UpdateTiket(txtNamaTiket.Text, Convert.ToInt32(txtHargaTiket.Text), txtDeskTiket.Text, Convert.ToInt32(txtIDTIket.Text), idtiket);
                loadgrid();
                txtIDTIket.Text = "";
                txtNamaTiket.Text = "";
                txtDeskTiket.Text = "";
                txtHargaTiket.Text = "";
                DataGridViewEditTiket.CurrentRow.Selected = false;
            }
        }

        private void DataGridViewEditTiket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClearIsi_Click(object sender, EventArgs e)
        {
            txtIDTIket.Text = "";
            txtNamaTiket.Text = "";
            txtDeskTiket.Text = "";
            txtHargaTiket.Text = "";

        }

        private void txtIDTiket_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamaTiket_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeskTiket_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHargaTiket_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridViewEditTiket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewEditTiket.CurrentRow.Selected = true;
            idtiket = Convert.ToInt32(DataGridViewEditTiket.Rows[e.RowIndex].Cells[0].Value);
            txtIDTIket.Text = DataGridViewEditTiket.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNamaTiket.Text = DataGridViewEditTiket.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDeskTiket.Text = DataGridViewEditTiket.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHargaTiket.Text = DataGridViewEditTiket.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void NamaKolom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClearDataTket_Click(object sender, EventArgs e)
        {


        }

        public void CariTiket_TextChanged(object sender, EventArgs e)
        {
            CUDEditTiket.konek koneksidb = new CUDEditTiket.konek();
            if ((string)NamaKolom.SelectedItem == "Nama")
            {
                string searchTextNama = CariTiket.Text.Trim();
                string namatiket = $"SELECT * FROM public.tiket  WHERE nama_tiket ILIKE '%{searchTextNama}%'";
                DataGridViewEditTiket.DataSource = koneksidb.Eksekusi(namatiket);
            }
            if (NamaKolom.SelectedItem == "ID Tiket")
            {
                string searchTextID = CariTiket.Text.Trim();
                string iDDtiket = $"SELECT * FROM public.tiket  WHERE id_tiket = {searchTextID}";
                DataGridViewEditTiket.DataSource = koneksidb.Eksekusi(iDDtiket);
            }
            if ((string)NamaKolom.SelectedItem == "Deskripsi")
            {
                string searchTextDesk = CariTiket.Text.Trim();
                string deskripsitiket = $"SELECT * FROM public.tiket  WHERE deskripsi_tiket ILIKE '%{searchTextDesk}%'";
                DataGridViewEditTiket.DataSource = koneksidb.Eksekusi(deskripsitiket);

            }
            if ((string)NamaKolom.SelectedItem == "Harga")
            {
                string searchharga = CariTiket.Text.Trim();
                string hargatiket = $"SELECT * FROM public.tiket  WHERE harga_tiket = {searchharga}";
                DataGridViewEditTiket.DataSource = koneksidb.Eksekusi(hargatiket);
            }
            if (CariTiket.Text == "")
            {
                loadgrid();
            }
        }

        private void NamaKolom_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void NamaKolom_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void JudulDataTiketRead_Click(object sender, EventArgs e)
        {

        }

        private void IDTiketlabel6_Click(object sender, EventArgs e)
        {

        }

        private void btnPopUpInfo_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void btnClearDataTket_Click_1(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panelDetailTiket_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}