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
    public partial class crud_umkm : Form
    {
        private int id_umkm;
        public crud_umkm()
        {
            InitializeComponent();
        }
        void loadgrid()
        {
            dataGridView1_umkm.DataSource = Class_crud_umkm.read();
        }
        private void textBox1_nama_umkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void crud_umkm_Load(object sender, EventArgs e)
        {
            loadgrid();
        }

        private void textBox2_desk_umkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_pemilik_umkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_telepon_umkm_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_umkm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_clear_umkm_Click(object sender, EventArgs e)
        {

        }

        private void button4_read_umkm_Click(object sender, EventArgs e)
        {

        }

        private void button5_edit_umkm_Click(object sender, EventArgs e)
        {
            if (id_umkm == 0)
            {
                MessageBox.Show("Pilih baris dahulu", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int id = 0;
                if (int.TryParse(textBox5_id_umkm.Text, out id))
                {

                    EditTempatMakan.Edit(textBox1_nama_umkm.Text, textBox2_desk_umkm.Text, textBox3_pemilik_umkm.Text, textBox4_telepon_umkm.Text, id);
                    loadgrid();

                    textBox1_nama_umkm.Text = "";
                    textBox2_desk_umkm.Text = "";
                    textBox3_pemilik_umkm.Text = "";
                    textBox4_telepon_umkm.Text = "";
                    textBox5_id_umkm.Text = "";

                    dataGridView1_umkm.CurrentRow.Selected = false;
                }
                else 
                {
                    MessageBox.Show("id harus berupa angka", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_add_umkm_Click(object sender, EventArgs e)
        {
            Class_crud_umkm.made(Convert.ToInt32(textBox5_id_umkm.Text), textBox1_nama_umkm.Text, textBox2_desk_umkm.Text, textBox3_pemilik_umkm.Text, textBox4_telepon_umkm.Text);
            loadgrid();
            textBox5_id_umkm.Text = "";
            textBox1_nama_umkm.Text = "";
            textBox2_desk_umkm.Text = "";
            textBox3_pemilik_umkm.Text = "";
            textBox4_telepon_umkm.Text = "";
        }

        private void dataGridView1_umkm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_umkm.CurrentRow.Selected = true;
            id_umkm = Convert.ToInt32(dataGridView1_umkm.Rows[e.RowIndex].Cells[0].Value);
            textBox1_nama_umkm.Text = dataGridView1_umkm.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2_desk_umkm.Text = dataGridView1_umkm.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3_pemilik_umkm.Text = dataGridView1_umkm.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4_telepon_umkm.Text = dataGridView1_umkm.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_id_umkm_TextChanged(object sender, EventArgs e)
        {

        }
    }

    class EditUmkm
    {
        static public void Edit(string nama_umkm, string deskripsi_umkm, string pemilik_umkm, string no_telepon_umkm, int id_umkm)
        {
            NpgsqlConnection connection = new NpgsqlConnection();

            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=aini123;Database=DataUmkm;";
            connection.ConnectionString = constr;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                string StrSql = $"Update public.DataUmkm set nama_umkm = '{nama_umkm}', deskripsi_umkm = '{deskripsi_umkm}', pemilik_umkm = '{pemilik_umkm}', no_telepon_umkm = '{no_telepon_umkm}' where id_umkm = '{id_umkm}'";
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
