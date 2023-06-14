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
    public partial class CreateSarana : Form
    {
        public CreateSarana()
        {
            InitializeComponent();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            string nama_sektor = tbxNama.Text;
            string deskripsi = tbxDeskripsi.Text;

            dataGridView1.Rows.Add(nama_sektor, deskripsi);
            this.DialogResult = DialogResult.OK;
        }
    }
}
