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

namespace frontendpbo
{
    public partial class CRUDDataPenginapan : Form
    {
        private int id_penginapan;
        public CRUDDataPenginapan()
        {
            InitializeComponent();
        }

        void loaddata()
        {
        }

        private void CRUDDataPenginapan_Load(object sender, EventArgs e)
        {
            loaddata();
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
    }

}
