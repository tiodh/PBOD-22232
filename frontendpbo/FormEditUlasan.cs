using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using frontendpbo.Helpers;
using frontendpbo.Contexts;
using System.Runtime.InteropServices;
using frontendpbo.Models;
using Npgsql;

namespace frontendpbo
{

    public partial class FormEditUlasan : Form
    {

        Contexts.ContextUlasan ulasanContext;
        List<Ulasan> ulasanList;
        public FormEditUlasan()
        {
            InitializeComponent();
            ulasanContext = new Contexts.ContextUlasan();
            ulasanList = new List<Ulasan>();

            ulasanContext.Read();
            dataGridViewEditUlasan.DataSource = ulasanContext.listUlasan;

            LoadComboBox();
        }

        private Ulasan GetUlasan()
        {
            Ulasan ulasan = new Ulasan();
            ulasan.nama_user = textBoxNamaPenggunaE.Text;
            ulasan.deskripsi_ulasan = textBoxDeskripsiUlasanE.Text;
            ulasan.wisata_id = ((Wisata)comboBox1.SelectedItem).Id_Wisata;

            return ulasan;
        }

        private void LoadComboBox()
        {
            List<Wisata> namaWisataList = ulasanContext.GetNamaWisataList();

            comboBox1.DataSource = namaWisataList;
            comboBox1.ValueMember = "Id_Wisata";
            comboBox1.DisplayMember = "Nama_Wisata";
        }

        private void FormEditUlasan_Load(object sender, EventArgs e)
        {

        }

        private void FormEditUlasan_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Ulasan ulasan = this.GetUlasan();
            ulasanContext.Insert(ulasan);
            dataGridViewEditUlasan.DataSource = null;
            dataGridViewEditUlasan.DataSource = ulasanList;

            ulasanContext.Read();
            dataGridViewEditUlasan.DataSource = ulasanContext.listUlasan;
        }
    }
}
