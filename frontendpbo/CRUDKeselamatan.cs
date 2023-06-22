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
                Keamanan = new ContextKeamanan();
                Keamanan.edit(textBox_nama_lembaga_dataKeamanan.Text, textBoxdeskripsi_dataKeamanan.Text, textBoxalamat_dataKeamanan.Text, textBoxnoHp_dataKeamanan.Text, id_);
                textBox_nama_lembaga_dataKeamanan.Text = "";
                textBoxnoHp_dataKeamanan.Text = "";
                textBoxalamat_dataKeamanan.Text = "";
                textBoxdeskripsi_dataKeamanan.Text = "";
                LoadData();
            }
        }

        private void Tambah_Keselamatan_Click(object sender, EventArgs e)
        {
            Keamanan = new ContextKeamanan();
            Keamanan.create(textBox_nama_lembaga_dataKeamanan.Text, textBoxnoHp_dataKeamanan.Text, textBoxalamat_dataKeamanan.Text, textBoxdeskripsi_dataKeamanan.Text);
            textBox_nama_lembaga_dataKeamanan.Text = "";
            textBoxnoHp_dataKeamanan.Text = "";
            textBoxalamat_dataKeamanan.Text = "";
            textBoxdeskripsi_dataKeamanan.Text = "";
            LoadData();
            //using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=peta_jember;user id=postgres;password=123"))
            //{
            //    connection.Open();
            //    NpgsqlCommand command = connection.CreateCommand();
            //    command.Connection = connection;
            //    command.CommandText = "insert into data_keamanan(nama_keamanan, deskripsi_keamanan, alamat_keamanan, no_tlp) values(@nama_keamanan, @deskripsi_keamanan, @alamat_keamanan, @no_tlp)";
            //    command.Parameters.Add(new NpgsqlParameter("@nama_keamanan", textBox_nama_lembaga_dataKeamanan.Text));
            //    command.Parameters.Add(new NpgsqlParameter("@no_tlp", textBoxnoHp_dataKeamanan.Text));
            //    command.Parameters.Add(new NpgsqlParameter("@alamat_keamanan", textBoxalamat_dataKeamanan.Text));
            //    command.Parameters.Add(new NpgsqlParameter("@deskripsi_keamanan", textBoxdeskripsi_dataKeamanan.Text));

            //textBox_nama_lembaga_dataKeamanan.Text = "";
            //textBoxnoHp_dataKeamanan.Text = "";
            //textBoxalamat_dataKeamanan.Text = "";
            //textBoxdeskripsi_dataKeamanan.Text = "";
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //    MessageBox.Show("Data berhasil diinput");
            //    //RefreshUlasanTerakhir();
            //    //RefreshRatingTerakhir();
            //}
        }
    }
}







