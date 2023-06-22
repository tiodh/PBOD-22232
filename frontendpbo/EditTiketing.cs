using frontendpbo.Contexts;
using frontendpbo.Models;
using OxyPlot;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CUD_DataTiket
{
    public partial class EditTiketing : Form
    {
        private int IdTiket;
        ContextTiket contextTiket;
        private List<Tiket> listTiket;
        private List<Tiket> searchResults;

        public frontendpbo.Models.Tiket GetTiket()
        {
            frontendpbo.Models.Tiket tkt = new frontendpbo.Models.Tiket();
            tkt.nama_tiket = txtNamaTiket.Text;
            tkt.deskripsi_tiket = txtDeskTiket.Text;
            tkt.harga_tiket = Convert.ToInt32(txtHargaTiket.Text);
            return tkt;
        }
        public EditTiketing()
        {
            InitializeComponent();
            contextTiket = new ContextTiket();
            loadgrid();
            DataGridViewEditTiket.DataSource = contextTiket.GetListTiket();
        }
        void loadgrid()
        {
            contextTiket.Read();
            DataGridViewEditTiket.DataSource = contextTiket.listTiket;
            //DataGridViewEditTiket.Column(0).Visible = false;
        }

        private void btnTambahTiket_Click(object sender, EventArgs e)
        {
            frontendpbo.Models.Tiket nambah = new Tiket();
            contextTiket.Insert(nambah);
            loadgrid();
            txtNamaTiket.Text = "";
            txtDeskTiket.Text = "";
            txtHargaTiket.Text = "";
        }

        private void btnClearIsi_Click(object sender, EventArgs e)
        {
            txtNamaTiket.Text = "";
            txtDeskTiket.Text = "";
            txtHargaTiket.Text = "";
            txtIDWisataEditTiket.Text = "";
        }
        private void DataGridViewEditTiket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewEditTiket.CurrentRow.Selected = true;
            IdTiket = Convert.ToInt32(DataGridViewEditTiket.Rows[e.RowIndex].Cells[0].Value);
            txtNamaTiket.Text = DataGridViewEditTiket.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDeskTiket.Text = DataGridViewEditTiket.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtHargaTiket.Text = DataGridViewEditTiket.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtIDWisataEditTiket.Text = DataGridViewEditTiket.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void NamaKolom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClearDataTket_Click(object sender, EventArgs e)
        {


        }

        public void CariTiket_TextChanged(object sender, EventArgs e)
        {

            if ((string)NamaKolom.SelectedItem == "Nama")
            {
                List<Tiket> cari = contextTiket.Search(CariTiket.Text, "nama_tiket");
                DataGridViewEditTiket.DataSource = cari;
            }
            if (NamaKolom.SelectedItem == "ID Tiket")
            {
                List<Tiket> cari = contextTiket.Search(CariTiket.Text, "id_tiket");
                DataGridViewEditTiket.DataSource = cari;
            }
            if ((string)NamaKolom.SelectedItem == "Deskripsi")
            {
                List<Tiket> cari = contextTiket.Search(CariTiket.Text, "deskripsi_tiket");
                DataGridViewEditTiket.DataSource = cari;
            }
            if ((string)NamaKolom.SelectedItem == "Harga")
            {
                List<Tiket> cari = contextTiket.Search(CariTiket.Text, "harga_tiket");
                DataGridViewEditTiket.DataSource = cari;
            }
            if (CariTiket.Text == "")
            {
                loadgrid();
            }
        }

        private void btnClearDataTket_Click_1(object sender, EventArgs e)
        {
            CariTiket.Text = " ";
            NamaKolom.Text = " ";
        }

        private void button4UpdateTIket_Click_1(object sender, EventArgs e)
        {
            frontendpbo.Models.Tiket ubah = new Tiket();
            contextTiket.Update(ubah);
            loadgrid();
            txtNamaTiket.Text = "";
            txtDeskTiket.Text = "";
            txtHargaTiket.Text = "";
            txtIDWisataEditTiket.Text = "";

        }

        private void EditTiketing_Load(object sender, EventArgs e)
        {

            PanelReadDataTiket.Dock = DockStyle.Fill;
            loadgrid();
            DataGridViewEditTiket.DataSource = contextTiket.GetListTiket();
        }
    }
}