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
using frontendpbo.Models;

namespace frontendpbo
{
    public partial class CRUDTransportasi : Form
    {
        private Contexts.ContextTransportasi transportasiContext;

        public CRUDTransportasi()
        {
            InitializeComponent();
            transportasiContext = new Contexts.ContextTransportasi();
            LoadTransportasiData();
        }

        private void LoadTransportasiData()
        {
            List<Transportasi> transportasiList = transportasiContext.GetTransportasiList();
            TampilData.DataSource = transportasiList;

            TampilData.Columns["Id_transportasi"].Width = 100;
            TampilData.Columns["Nama_transportasi"].Width = 200;
            TampilData.Columns["Jenis_transportasi"].Width = 150;
            TampilData.Columns["Deskripsi_transportasi"].Width = 300;
        }

        private void SearchTransportasi_Click(object sender, EventArgs e)
        {
            string namaTransportasi = TampilanData.Text.Trim();
            string jenisTransportasi = TampilanData.Text.Trim();

           /* List<Transportasi> searchResults = transportasiContext.SearchTransportasi(namaTransportasi, jenisTransportasi);
            TampilData.DataSource = searchResults;*/
        }

        private void CreateTransportasi_Click(object sender, EventArgs e)
        {
            int idTransportasi = Convert.ToInt32(IDTransportasi.Text.Trim());
            string namaTransportasi = NamaTransportasi.Text.Trim();
            string jenisTransportasi = JenisTransportasi.Text.Trim();
            string deskripsiTransportasi = DeskripsiTransportasi.Text.Trim();

            Transportasi transportasi = new Transportasi()
            {
                Id_transportasi = idTransportasi,
                Nama_transportasi = namaTransportasi,
                Jenis_transportasi = jenisTransportasi,
                Deskripsi_transportasi = deskripsiTransportasi
            };

            bool success = transportasiContext.InsertTransportasi(transportasi);

            if (success)
            {
                MessageBox.Show("Data has been inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTransportasiData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Failed to insert data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTransportasi_Click(object sender, EventArgs e)
        {
            int idTransportasi = Convert.ToInt32(IDTransportasi.Text.Trim());
            string namaTransportasi = NamaTransportasi.Text.Trim();
            string jenisTransportasi = JenisTransportasi.Text.Trim();
            string deskripsiTransportasi = DeskripsiTransportasi.Text.Trim();

            Transportasi transportasi = new Transportasi()
            {
                Id_transportasi = idTransportasi,
                Nama_transportasi = namaTransportasi,
                Jenis_transportasi = jenisTransportasi,
                Deskripsi_transportasi = deskripsiTransportasi
            };

            bool success = transportasiContext.UpdateTransportasi(transportasi);

            if (success)
            {
                MessageBox.Show("Data has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTransportasiData();
                ResetForm();
            }
            else
            {
                MessageBox.Show("Failed to update data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetForm()
        {
            IDTransportasi.Text = "";
            NamaTransportasi.Text = "";
            JenisTransportasi.Text = "";
            DeskripsiTransportasi.Text = "";
        }
    }
}