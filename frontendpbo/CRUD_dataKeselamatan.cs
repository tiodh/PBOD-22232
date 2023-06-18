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
    public partial class CRUD_Data_Keselamatan : Form
    {
        public CRUD_Data_Keselamatan()
        {
            InitializeComponent();
        }

        private void Data_Keselamatan_Load(object sender, EventArgs e)
        {

        }

        private void ReadData()
        {

        }

        private void Tambah_Keselamatan_Click(object sender, EventArgs e)
        {
                using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=DummyDatabase;user id=postgres;password=220305"))
                {
                    connection.Open();
                    NpgsqlCommand command = connection.CreateCommand();
                    command.Connection = connection;
                    command.CommandText = "insert into Keamanan(nama_keamanan, deskripsi_keamanan, alamat_keamanan, no_tlp) values(@nama_keamanan, @deskripsi_keamanan, @alamat_keamanan, @no_tlp)";
                    command.Parameters.Add(new NpgsqlParameter("@nama_keamanan", textBox_nama_lembaga_dataKeamanan.Text));
                    command.Parameters.Add(new NpgsqlParameter("@no_tlp", textBoxnoHp_dataKeamanan.Text));
                    command.Parameters.Add(new NpgsqlParameter("@alamat_keamanan", textBoxalamat_dataKeamanan.Text));
                    command.Parameters.Add(new NpgsqlParameter("@deskripsi_keamanan", textBoxdeskripsi_dataKeamanan.Text));

                    textBox_nama_lembaga_dataKeamanan.Text = "";
                    textBoxnoHp_dataKeamanan.Text = "";
                    textBoxalamat_dataKeamanan.Text = "";
                    textBoxdeskripsi_dataKeamanan.Text = "";
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Data berhasil diinput");
                    //RefreshUlasanTerakhir();
                    //RefreshRatingTerakhir();
                }
        }
    }
}
