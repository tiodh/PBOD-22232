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
    public partial class DeletedanUpdateDataTempatMakan : Form
    {
        public DeletedanUpdateDataTempatMakan()
        {
            InitializeComponent();
        }

        void loaddata()
        {

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

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TambahTempatMakanbutton2_Click(object sender, EventArgs e)
        {
            try
            {
                Create.contohCreate(NamaTempatMakantextBox1.Text, LokasiTempatMakantextBox2.Text, DeskripsiTempatMakantextBox3.Text, NoTeleponTempatMakantextBox4.Text);
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

        private void DeletedanUpdateDataTempatMakan_Load(object sender, EventArgs e)
        {

        }

        private void CRUDTempatMakandataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CRUDTempatMakandataGridView1.CurrentRow.Selected = true;
            NamaTempatMakantextBox1.Text = CRUDTempatMakandataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            LokasiTempatMakantextBox2.Text = CRUDTempatMakandataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            DeskripsiTempatMakantextBox3.Text = CRUDTempatMakandataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            NoTeleponTempatMakantextBox4.Text = CRUDTempatMakandataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        public bool Read()
        {
            bool isSuccess = false;
            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Data Tempat Makan;";

            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                string sql =
                    @"SELECT nama_tempat_makan, lokasi_tempat_makan, deskripsi_tempat_makan, no_telepon_tempat_makan
                  FROM rembangan";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                }
            }
            return isSuccess;
        }

        private void EditTempatMakanbutton3_Click(object sender, EventArgs e)
        {

        }
    }
    class Create
    {
        static public void contohCreate(string nama_tempat_makan, string lokasi_tempat_makan, string deskripsi_tempat_makan, string no_telepon_tempat_makan)
        {

            NpgsqlConnection connection = new NpgsqlConnection();

            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Data Tempat Makan;";
            connection.ConnectionString = constr;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                string StrSql = $"insert into rembangan (nama_tempat_makan, lokasi_tempat_makan, deskripsi_tempat_makan, no_telepon_tempat_makan) values ('{nama_tempat_makan}', '{lokasi_tempat_makan}', '{deskripsi_tempat_makan}', '{no_telepon_tempat_makan}');";
                cmd.CommandText = StrSql;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                cmd.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }


}
