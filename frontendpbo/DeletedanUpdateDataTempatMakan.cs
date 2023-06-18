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
    public partial class DeletedanUpdateDataTempatMakan : Form
    {
        private int id_tempat_makan;
        public DeletedanUpdateDataTempatMakan()
        {
            InitializeComponent();
        }

        void loaddata()
        {
            Read();
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
                CreatePenginapan.Create(NamaTempatMakantextBox1.Text, LokasiTempatMakantextBox2.Text, DeskripsiTempatMakantextBox3.Text, NoTeleponTempatMakantextBox4.Text);
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

        public bool Read()
        {
            bool isSuccess = false;
            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Data Tempat Makan;";

            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                string sql =
                    @"SELECT id_tempat_makan, nama_tempat_makan, lokasi_tempat_makan, deskripsi_tempat_makan, no_telepon_tempat_makan
                  FROM rembangan";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    CRUDTempatMakandataGridView1.DataSource = dt;

                }
            }
            return isSuccess;
        }

        private void EditTempatMakanbutton3_Click(object sender, EventArgs e)
        {

        }

        private void HapusTempatMakanbutton4_Click(object sender, EventArgs e)
        {
            if (id_tempat_makan == 0)
            {
                MessageBox.Show("Baris nya tolong dipilih dulu ya", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                delete.contohDelete(id_tempat_makan);
                loaddata();

                NamaTempatMakantextBox1.Text = "";
                LokasiTempatMakantextBox2.Text = "";
                DeskripsiTempatMakantextBox3.Text = "";
                NoTeleponTempatMakantextBox4.Text = "";

                CRUDTempatMakandataGridView1.CurrentRow.Selected = false;
            }
        }

        private void ClearTempatMakanbutton1_Click(object sender, EventArgs e)
        {
            NamaTempatMakantextBox1.Text = "";
            LokasiTempatMakantextBox2.Text = "";
            DeskripsiTempatMakantextBox3.Text = "";
            NoTeleponTempatMakantextBox4.Text = "";
        }
    }
    class CreatePenginapan
    {
        static public void Create(string nama_tempat_makan, string lokasi_tempat_makan, string deskripsi_tempat_makan, string no_telepon_tempat_makan)
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

    class delete
    {
        static public DataTable contohDelete(int id_tempat_makan)
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
                string StrSql = $"delete from rembangan where id_tempat_makan = '{id_tempat_makan}'::integer;;";
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

            return dt;
        }
    }

}
