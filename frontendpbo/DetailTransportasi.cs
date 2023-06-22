using frontendpbo.Contexts;
using frontendpbo.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace frontendpbo
{
    public partial class DetailTransportasi : Form
    {
        private ContextTransportasi contextTransportasi = new ContextTransportasi();

        public DetailTransportasi()
        {
            InitializeComponent();
        }

        private void DetailTransportasi_Load(object sender, EventArgs e)
        {
            LoadTransportasiData();
        }

        private void LoadTransportasiData()
        {
            List<Transportasi> transportasiList = contextTransportasi.GetTransportasiList();
            TampilData.DataSource = transportasiList;
        }

        private void TampilkanDataTransportasi_TextChanged(object sender, EventArgs e)
        {
            string searchText = TampilkanDataTransportasi.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                IDTransportasi.Text = "";
                NamaTransportasi.Text = "";
                JenisTransportasi.Text = "";
                Deskripsi.Text = "";
            }
            else
            {
                List<Transportasi> searchResults = contextTransportasi.SearchTransportasi(searchText);

                if (searchResults.Count > 0)
                {
                    Transportasi transportasi = searchResults[0]; 

                    IDTransportasi.Text = transportasi.Id_transportasi.ToString();
                    NamaTransportasi.Text = transportasi.Nama_transportasi;
                    JenisTransportasi.Text = transportasi.Jenis_transportasi;
                    Deskripsi.Text = transportasi.Deskripsi_transportasi;
                }
                else
                {
                    IDTransportasi.Text = "";
                    NamaTransportasi.Text = "";
                    JenisTransportasi.Text = "";
                    Deskripsi.Text = "";
                }
            }
        }
    }
}