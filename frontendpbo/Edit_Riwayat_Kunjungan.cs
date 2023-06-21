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
    public partial class Edit_Riwayat_Kunjungan : Form
    {
        ContextRiwayatKunjungan contextRiwayat;
        string pilihan;
        string perintah;
        public Edit_Riwayat_Kunjungan()
        {
            InitializeComponent();
        }

        private void Edit_Riwayat_Kunjungan_Load(object sender, EventArgs e)
        {
            panel3.Location = new System.Drawing.Point((panel1.Width - panel3.Width) / 2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            contextRiwayat = new ContextRiwayatKunjungan();
            List<Riwayat> ListRiwayat = contextRiwayat.ListRiwayat;
            contextRiwayat.search(textBox1.Text);
            dataGridView1.DataSource = ListRiwayat;
            

        }
    }
}
