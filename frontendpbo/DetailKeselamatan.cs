using frontendpbo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frontendpbo
{
    public partial class DetailKeselamatan : Form
    {
        ReadKeselamatanContext readKeselamatanContext;
        public DetailKeselamatan()
        {
            InitializeComponent();
            readKeselamatanContext = new ReadKeselamatanContext();
        }

        private void detail_dataKeselamatan_Load(object sender, EventArgs e)
        {
            ShowItems();
        }
        private void ShowItems()
        {
            readKeselamatanContext.Read();
            List<readKeselamatan> readKeselamatanList;
            readKeselamatanList = readKeselamatanContext.readKeselamatanList;

            flowLayoutPanel1.Controls.Clear();
            foreach (var readKeselamatan in readKeselamatanList)
            {
                string nama = readKeselamatan.nama;
                string noTlp = readKeselamatan.noTlp;
                string alamat = readKeselamatan.alamat;
                string deskripsi = readKeselamatan.deskripsi;
                Panel readKeselamatanItem = new ReadKeselamatanItem(nama, noTlp, alamat, deskripsi).CreateItem();
                flowLayoutPanel1.Controls.Add(readKeselamatanItem);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_tlpHospital_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_alamatHospital_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_deskripsiHospital_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
