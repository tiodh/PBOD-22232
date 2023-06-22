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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace frontendpbo
{
    public partial class DeletedanUpdateDataTempatMakan : Form
    {
        private int id_tempat_makan;

        ContextTempatMakan contexttempatmakan;
        private List<TempatMakan> listtempatmakan;

        public Models.TempatMakan GetTempatMakan()
        {
            Models.TempatMakan tmpt = new Models.TempatMakan();
            tmpt.id_tempat_makan = id_tempat_makan;
            tmpt.lokasi_tempat_makan = LokasiTempatMakantextBox2.Text;
            tmpt.nama_tempat_makan = NamaTempatMakantextBox1.Text;
            tmpt.deskripsi_tempat_makan = DeskripsiTempatMakantextBox3.Text;
            tmpt.no_telepon_tempat_makan = NoTeleponTempatMakantextBox4.Text;
            return tmpt;
        }

        public DeletedanUpdateDataTempatMakan()
        {
            InitializeComponent();
            contexttempatmakan = new ContextTempatMakan();

            loaddata();
            CRUDTempatMakandataGridView1.DataSource = contexttempatmakan.GetListtempatmakan();
        }

        void loaddata()
        {
            contexttempatmakan.ReadTempatMakan();
            CRUDTempatMakandataGridView1.DataSource = contexttempatmakan.GetListtempatmakan();
        }


        private void DeskripsiTempatMakanlabel3_Click(object sender, EventArgs e)
        {

        }

        private void NamaTempatMakanlabel1_Click(object sender, EventArgs e)
        {

        }

        private void NoTeleponTempatMakanlabel4_Click(object sender, EventArgs e)
        {

        }

        private void LokasiTempatMakanlabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CRUDTempatMakandataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TambahTempatMakanbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                TempatMakan tempatMakan = new TempatMakan
                {
                    nama_tempat_makan = NamaTempatMakantextBox1.Text,
                    lokasi_tempat_makan = LokasiTempatMakantextBox2.Text,
                    deskripsi_tempat_makan = DeskripsiTempatMakantextBox3.Text,
                    no_telepon_tempat_makan = NoTeleponTempatMakantextBox4.Text
                };

                contexttempatmakan.CreateTempatMakan(tempatMakan);
                loaddata();

                NamaTempatMakantextBox1.Text = "";
                LokasiTempatMakantextBox2.Text = "";
                DeskripsiTempatMakantextBox3.Text = "";
                NoTeleponTempatMakantextBox4.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void NamaTempatMakantextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LokasiTempatMakantextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void HapusTempatMakanbutton4_Click(object sender, EventArgs e)
        {
           
          
        }

        private void ClearTempatMakanbutton1_Click(object sender, EventArgs e)
        {
            NamaTempatMakantextBox1.Text = "";
            LokasiTempatMakantextBox2.Text = "";
            DeskripsiTempatMakantextBox3.Text = "";
            NoTeleponTempatMakantextBox4.Text = "";
        }


        private void DeletedanUpdateDataTempatMakan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void CRUDTempatMakandataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUDTempatMakandataGridView1.CurrentRow.Selected = true;
            id_tempat_makan = Convert.ToInt32(CRUDTempatMakandataGridView1.Rows[e.RowIndex].Cells[0].Value);
            NamaTempatMakantextBox1.Text = CRUDTempatMakandataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LokasiTempatMakantextBox2.Text = CRUDTempatMakandataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            DeskripsiTempatMakantextBox3.Text = CRUDTempatMakandataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            NoTeleponTempatMakantextBox4.Text = CRUDTempatMakandataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        } 

        private void EditTempatMakanbutton3_Click(object sender, EventArgs e)
        {
            if (id_tempat_makan == 0)
            {
                MessageBox.Show("Baris nya tolong dipilih dulu ya", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TempatMakan tempatMakan = GetTempatMakan();
                contexttempatmakan.UpdateTempatMakan(tempatMakan);
                loaddata();

                NamaTempatMakantextBox1.Text = "";
                LokasiTempatMakantextBox2.Text = "";
                DeskripsiTempatMakantextBox3.Text = "";
                NoTeleponTempatMakantextBox4.Text = "";
                id_tempat_makan = 0;
            }
        }

        private void HapusTempatMakanbutton4_Click_1(object sender, EventArgs e)
        {
           
        }

        private void ClearTempatMakanbutton1_Click_1(object sender, EventArgs e)
        {
            NamaTempatMakantextBox1.Text = "";
            LokasiTempatMakantextBox2.Text = "";
            DeskripsiTempatMakantextBox3.Text = "";
            NoTeleponTempatMakantextBox4.Text = "";
        }
    }

    

}
