using frontendpbo.Contexts;
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
    public partial class CreateSarana : Form
    {
        ContextSarana Sarana;
        private int id_;
        private int id_w;
        public CreateSarana()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Host = localhost; Port = 5432; Database = peta_jember; Username = postgres; Password = 123"))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM sarana_prasarana ORDER BY id_sarana ASC";

                    // Membuat objek perintah dan menentukan koneksi
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        // Membaca data dari database ke dalam DataSet
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "TabelData");

                        // Menampilkan data dalam DataGridView
                        dataGridView1.DataSource = dataSet.Tables["TabelData"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }
        private void simpan_Click(object sender, EventArgs e)
        {

            Sarana = new ContextSarana();
            Sarana.create(tbxNama.Text, tbxDeskripsi.Text);

            tbxNama.Text = "";
            tbxDeskripsi.Text = "";
            LoadData();
            //using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=peta_jember;user id=postgres;password=12345678"))
            //{
            //    connection.Open();
            //    NpgsqlCommand command = connection.CreateCommand();
            //    command.Connection = connection;
            //    command.CommandText = "insert into sarana_prasarana(nama_sarana,deskripsi_sarana) values(@nama_sarana,@deskripsi_sarana)";
            //    command.Parameters.Add(new NpgsqlParameter("@nama_sarana", tbxNama.Text));
            //    command.Parameters.Add(new NpgsqlParameter("@deskripsi_sarana", tbxDeskripsi.Text));

            //    tbxNama.Text = "";
            //    tbxDeskripsi.Text = "";
            //    command.ExecuteNonQuery();
            //    connection.Close();
            //    MessageBox.Show("Data berhasil diinput");
            //    //RefreshUlasanTerakhir();
            //    //RefreshRatingTerakhir();
            //}
            //string nama_sektor = tbxNama.Text;
            //string deskripsi = tbxDeskripsi.Text;

            //dataGridView1.Rows.Add(nama_sektor, deskripsi);
            //this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            id_ = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            tbxNama.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxDeskripsi.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            id_w = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
        }

        private void CreateSarana_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
