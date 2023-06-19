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
    }
}
