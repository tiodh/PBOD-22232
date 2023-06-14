using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateSarana
{
    public partial class Sarana : Form
    {
        public Sarana()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string nama_sektor = nama.Text;
            string deskripsi = desk.Text;

            dataSarana.Rows.Add(nama_sektor, deskripsi);
            this.DialogResult = DialogResult.OK;
        }
    }
}
