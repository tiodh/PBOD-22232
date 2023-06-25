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
using frontendpbo.Contexts;
using frontendpbo.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace frontendpbo
{
    public partial class CRUDTransportasi : Form
    {
        Contexts.ContextTransportasi contextTransportasi = new Contexts.ContextTransportasi();
        Contexts.ContextWisata contexTransportasi = new Contexts.ContextWisata();

        public string CurrentIdTransportasi;
        private List<Transportasi> listTransportasis = new List<Transportasi>();

        public CRUDTransportasi()
        {

            InitializeComponent();

            TampilData.AutoGenerateColumns = false;
            ReadDataTransportasi();
        }




        private void ReadDataTransportasi()
        {

            contextTransportasi.TransportasiList = listTransportasis;
            contextTransportasi.Read();
            TampilData.DataSource = contextTransportasi.TransportasiList;


        }

        private Models.Transportasi GetData()
        {
            Transportasi transportasi = new Models.Transportasi();

            transportasi.Id_transportasi = int.Parse(IDTransportasi.Text);
            transportasi.Nama_transportasi = NamaTransportasi.Text;
            transportasi.Jenis_transportasi = JenisTransportasi.Text;
            transportasi.Deskripsi_transportasi = DeskripsiTransportasi.Text;

            return transportasi;
        }


        private void TampilData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TampilData.Columns[e.ColumnIndex].Name == "Edit")
            {
                IDTransportasi.Enabled = false;
                CreateTransportasi.Enabled = false;
                UpdateTransportasi.Enabled = true;
                Transportasi transportasi = listTransportasis[e.RowIndex];
                IDTransportasi.Text = transportasi.Id_transportasi.ToString();
                NamaTransportasi.Text = transportasi.Nama_transportasi;
                JenisTransportasi.Text = transportasi.Jenis_transportasi;
                DeskripsiTransportasi.Text = transportasi.Deskripsi_transportasi;


            }
            else if (TampilData.Columns[e.ColumnIndex].Name == "Delete")
            {
                Transportasi transportasi = listTransportasis[e.RowIndex];
                CurrentIdTransportasi = transportasi.Id_transportasi.ToString();
                contextTransportasi.Delete(transportasi);
                TampilData.DataSource = null;
                ReadDataTransportasi();
            }
        }

        private void CRUDTransportasi_Load(object sender, EventArgs e)
        {

        }

        private void CreateTransportasi_Click(object sender, EventArgs e)
        {
            Models.Transportasi transportasi = this.GetData();
            contextTransportasi.Insert(transportasi);
            TampilData.DataSource = null;
            ReadDataTransportasi();
        }

        private void UpdateTransportasi_Click(object sender, EventArgs e)
        {
            Models.Transportasi transportasi = this.GetData();
            contextTransportasi.Update(transportasi);
            TampilData.DataSource = null;
            ReadDataTransportasi();
        }

        private void DeleteTransportasi_Click(object sender, EventArgs e)
        {
            IDTransportasi.Enabled = true;
            UpdateTransportasi.Enabled = false;
            CreateTransportasi.Enabled = true;
            IDTransportasi.Text = "";
            NamaTransportasi.Text = "";
            DeskripsiTransportasi.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

