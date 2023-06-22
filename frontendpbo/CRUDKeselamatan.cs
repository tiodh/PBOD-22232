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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace frontendpbo
{
    public partial class CRUD_Data_Keselamatan : Form
    {
        private int id_;

        ContextKeamanan Keamanan;
        ReadKeselamatanContext readKeselamatanContext;
        public CRUD_Data_Keselamatan()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //ContextKeamanan keamanan = new ContextKeamanan();
            ReadKeselamatanContext readKeselamatanContext = new ReadKeselamatanContext();
            Keamanan = new ContextKeamanan();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            id_ = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            textBox_nama_lembaga_dataKeamanan.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxnoHp_dataKeamanan.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxalamat_dataKeamanan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxdeskripsi_dataKeamanan.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void Data_Keselamatan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            readKeselamatanContext = new ReadKeselamatanContext();
            readKeselamatanContext.Read();
            dataGridView1.DataSource = readKeselamatanContext.readKeselamatanList;
        }

        private void Edit_Keamanan_Click(object sender, EventArgs e)
        {
            if (id_ == 0)
            {
                MessageBox.Show("Pilih baris dahulu", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Keamanan data = new Keamanan();
                data.Name = textBox_nama_lembaga_dataKeamanan.Text;
                data.Description = textBoxdeskripsi_dataKeamanan.Text;
                data.Alamat = textBoxalamat_dataKeamanan.Text;
                data.No_Tlp = textBoxnoHp_dataKeamanan.Text;
                data.Id = id_;

                Keamanan = new ContextKeamanan();
                Keamanan.edit(data.Name, data.Description, data.Alamat, data.No_Tlp , data.Id);
                textBox_nama_lembaga_dataKeamanan.Text = "";
                textBoxnoHp_dataKeamanan.Text = "";
                textBoxalamat_dataKeamanan.Text = "";
                textBoxdeskripsi_dataKeamanan.Text = "";
                LoadData();
            }
        }

        private void Tambah_Keselamatan_Click(object sender, EventArgs e)
        {
            string Name = textBox_nama_lembaga_dataKeamanan.Text;
            string Description = textBoxdeskripsi_dataKeamanan.Text;
            string Alamat = textBoxalamat_dataKeamanan.Text;
            string No_Tlp = textBoxnoHp_dataKeamanan.Text;

            Keamanan newKeamanan = new Keamanan()
            {
                Name = Name,
                Description = Description,
                Alamat = Alamat,
                No_Tlp = No_Tlp
            };
            bool isSucces = Keamanan.create(newKeamanan);
            if (isSucces)
            {
                MessageBox.Show("input sukses");
            }
            else
            {
                MessageBox.Show("input gagal");
            }
            //ol isSuccess = ContextKeamanan
            //Keamanan = new ContextKeamanan();
            //Keamanan.create(textBox_nama_lembaga_dataKeamanan.Text, textBoxnoHp_dataKeamanan.Text, textBoxalamat_dataKeamanan.Text, textBoxdeskripsi_dataKeamanan.Text);
            //textBox_nama_lembaga_dataKeamanan.Text = "";
            //textBoxnoHp_dataKeamanan.Text = "";
            //textBoxalamat_dataKeamanan.Text = "";
            //textBoxdeskripsi_dataKeamanan.Text = "";
            //LoadData();

        }

        private void textBox_nama_lembaga_dataKeamanan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}







