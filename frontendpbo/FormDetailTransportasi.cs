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

    public partial class FormDetailTransportasi : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = Alvio28; Database = PBO");
        public FormDetailTransportasi()
        {
            InitializeComponent();
        }
        private void FormDetailTransportasi_Load(object sender, EventArgs e)
        {
            showdata();
        }
        private void showdata()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from Transportasi where nama_transportasi like '%" + Tampil.Text + "'", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            Tampil.DataSource = dt;

            Tampil.Columns["id_transportasi"].Width = 100;
            Tampil.Columns["nama_transportasi"].Width = 110;
            Tampil.Columns["jenis_transportasi"].Width = 100;
            Tampil.Columns["deskripsi"].Width = 550;
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            try
            {
                string searchName = TampilkanDataTransportasi.Text;
                conn.Open();
                NpgsqlCommand cmd1 = new NpgsqlCommand("SELECT id_transportasi, nama_transportasi, jenis_transportasi, deskripsi FROM Transportasi WHERE nama_transportasi LIKE '%' || @searchName || '%'", conn);
                cmd1.Parameters.AddWithValue("@searchName", searchName);
                NpgsqlDataReader reader1 = cmd1.ExecuteReader();

                if (reader1.HasRows)
                {
                    if (reader1.Read())
                    {
                        IDTransportasi.Text = reader1["id_transportasi"].ToString();
                        NamaTransportasi.Text = reader1["nama_transportasi"].ToString();
                        JenisTransportasi.Text = reader1["jenis_transportasi"].ToString();
                        Deskripsi.Text = reader1["deskripsi"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Data Not Found");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private bool IsValidColumnName(string columnName)
        {
            string[] validColumnNames = { "nama_transportasi", "jenis_transportasi", "deskripsi" };

            return validColumnNames.Contains(columnName);
        }
    }
}