using frontendpbo.DatabaseHelpers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace frontendpbo
{
    public partial class CRUDDataPenginapan : Form
    {
        DatabaseHelpers.DatabaseHelpers db;
        private int id_penginapan;
        public CRUDDataPenginapan()
        {
            InitializeComponent();
        }

        void CRUDDataPenginapan_Load(object sender, EventArgs e)
        {
            db = new DatabaseHelpers.DatabaseHelpers();
            loaddata();
        }
        private void loaddata()
        {
        }


        private void NamaPenginapantextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeskripsiPenginapantextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Editbutton3_Click(object sender, EventArgs e)
        {

        }

        private void Deletebutton4_Click(object sender, EventArgs e)
        {

        }

        private void DataPenginapandataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataPenginapandataGridView1.CurrentRow.Selected = true;
            id_penginapan = Convert.ToInt32(DataPenginapandataGridView1.Rows[e.RowIndex].Cells[0].Value);
            NamaPenginapantextBox1.Text = DataPenginapandataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            NamaPenginapantextBox1.Text = DataPenginapandataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void DataPenginapandataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void Tambahbutton2_Click(object sender, EventArgs e)
        {
            string sql = $"INSERT INTO penginapan(nama_penginapan, deskripsi_penginapan) VALUES ('{NamaPenginapantextBox1.Text}','{DeskripsiPenginapantextBox2.Text}')";
            DialogResult dialogResult = MessageBox.Show("APAKAH ANDA YAKIN?", "INSERT PENGINAPAN", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Berhasil!");
                db.exc(sql);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Gagal!");
            }
        }
    }

}
