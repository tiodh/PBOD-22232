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
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Diagnostics.CodeAnalysis;


namespace frontendpbo
{
    public partial class FormDetailDataTiket : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port=5432;User Id = postgres; Password=12345;Database=postgres");

        public FormDetailDataTiket()
        {
            InitializeComponent();
        }
        private void FormDetailDataTiket_Load(object sender, EventArgs e)
        {
            menampilkan_datagrid();
            pictureBoxKendaraan.Image = imageListKendaraan.Images[0];
            pictureBoxNamaTiket.Image = imageListDetailTiket.Images[0];
        }
        private void menampilkan_datagrid()
        {
            NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from Tiket where nama_tiket <> 'Parkir'", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataGridViewTiket.DataSource = dt;
        }

        private void radioButtonRoda2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxKendaraan.Image = imageListKendaraan.Images[1];

            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select harga_tiket from Tiket where deskripsi_tiket like 'Kendaraan Roda 2'", conn);
            cmd.Parameters.AddWithValue("harga_tiket", radioButtonRoda2.Checked == true);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxTiketParkir.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void radioButtonRoda4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxKendaraan.Image = imageListKendaraan.Images[2];

            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("Select harga_tiket from Tiket where deskripsi_tiket like 'Kendaraan Roda 4'", conn);
            cmd.Parameters.AddWithValue("harga_tiket", radioButtonRoda4.Checked == true);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                textBoxTiketParkir.Text = dr.GetValue(0).ToString();
            }
            conn.Close();
        }

        private void SearchTiket_TextChanged(object sender, EventArgs e)
        {
            if (KolomTiket.Text == "ID Tiket")
            {
                conn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from Tiket where nama_tiket <> 'Parkir' and CAST(id_tiket AS VARCHAR) ilike '%" + SearchTiket.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridViewTiket.DataSource = dt;
                conn.Close();
            }
            else if (KolomTiket.Text == "Nama")
            {
                conn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from Tiket where nama_tiket <> 'Parkir' and nama_tiket ilike '%" + SearchTiket.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridViewTiket.DataSource = dt;
                conn.Close();
            }
            else if (KolomTiket.Text == "Deskripsi")
            {
                conn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from Tiket where nama_tiket <> 'Parkir' and deskripsi_tiket ilike '%" + SearchTiket.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridViewTiket.DataSource = dt;
                conn.Close();
            }
            else if (KolomTiket.Text == "Harga")
            {
                conn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter("Select * from Tiket where nama_tiket <> 'Parkir' and CAST(harga_tiket AS VARCHAR) ilike '%" + SearchTiket.Text + "%'", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridViewTiket.DataSource = dt;
                conn.Close();
            }
        }

        private void DataGridViewTiket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv1 = DataGridViewTiket;

                NamaTiket.Text = Convert.ToString(dgv1.CurrentRow.Cells[1].Value);
                DeskTiket.Text = Convert.ToString(dgv1.CurrentRow.Cells[2].Value);
                HargaTiket.Text = Convert.ToString(dgv1.CurrentRow.Cells[3].Value);
            }
        }

        private void btnClearTket_Click(object sender, EventArgs e)
        {
            menampilkan_datagrid();
            SearchTiket.Text = "";
            KolomTiket.Text = "";
        }
    }
}
