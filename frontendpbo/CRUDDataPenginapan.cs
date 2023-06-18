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
    public partial class CRUDDataPenginapan : Form
    {
        private int id_penginapan;
        public CRUDDataPenginapan()
        {
            InitializeComponent();
        }

        void loaddata()
        {
            DataPenginapandataGridView1.DataSource = Read.contohSelect();
        }

        private void CRUDDataPenginapan_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void NamaPenginapantextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeskripsiPenginapantextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Editbutton3_Click(object sender, EventArgs e)
        {
            if (id_penginapan == 0)
            {
                MessageBox.Show("Pilih baris dahulu", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                update.contohUpdate(NamaPenginapantextBox1.Text, DeskripsiPenginapantextBox2.Text, id_penginapan);
                loaddata();

                NamaPenginapantextBox1.Text = "";
                DeskripsiPenginapantextBox2.Text = "";

                DataPenginapandataGridView1.CurrentRow.Selected = false;
            }
        }

        private void Deletebutton4_Click(object sender, EventArgs e)
        {
            if (id_penginapan == 0)
            {
                MessageBox.Show("Baris nya tolong dipilih dulu ya", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Delete.contohDelete(id_penginapan);
                loaddata();

                NamaPenginapantextBox1.Text = "";
                DeskripsiPenginapantextBox2.Text = "";

                DataPenginapandataGridView1.CurrentRow.Selected = false;
            }
        }

        private void DataPenginapandataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataPenginapandataGridView1.CurrentRow.Selected = true;
            id_penginapan = Convert.ToInt32(DataPenginapandataGridView1.Rows[e.RowIndex].Cells[0].Value);
            NamaPenginapantextBox1.Text = DataPenginapandataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            DeskripsiPenginapantextBox2.Text = DataPenginapandataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void DataPenginapandataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loaddata();
        }

        private void Tambahbutton2_Click(object sender, EventArgs e)
        {
            if (NamaPenginapantextBox1.Text == "" || DeskripsiPenginapantextBox2.Text == "")
            {
                MessageBox.Show("Nama atau deskripsi penginapan tidak boleh kosong", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
            Create.contohCreate(NamaPenginapantextBox1.Text, DeskripsiPenginapantextBox2.Text);
            loaddata();
            NamaPenginapantextBox1.Text = "";
            DeskripsiPenginapantextBox2.Text = "";
            }
        }
    }

    class Delete
    {
        static public DataTable contohDelete(int id_penginapan)
        {

            NpgsqlConnection connection = new NpgsqlConnection();


            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Data Penginapan;";
            connection.ConnectionString = constr;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                string StrSql = $"delete from penginapan where id_penginapan = {id_penginapan}::integer;;";
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
    class update
    {
        static public void contohUpdate(string nama_penginapan, string deskripsi_penginapan, int id_penginapan)
        {

            NpgsqlConnection connection = new NpgsqlConnection();


            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Data Penginapan;";
            connection.ConnectionString = constr;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                string StrSql = $"Update public.penginapan set nama_penginapan = '{nama_penginapan}', deskripsi_penginapan = '{deskripsi_penginapan}' where id_penginapan = '{id_penginapan}'";
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

    class Create
    {
        static public void contohCreate(string nama_penginapan, string deskripsi_penginapan)
        {

            NpgsqlConnection connection = new NpgsqlConnection();


            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Data Penginapan;";
            connection.ConnectionString = constr;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                string StrSql = $"INSERT INTO penginapan(nama_penginapan, deskripsi_penginapan) VALUES ('{nama_penginapan}','{deskripsi_penginapan}')"; ;
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

    class Read
    {
        static public DataTable contohSelect()
        {

            NpgsqlConnection connection = new NpgsqlConnection();


            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=Data Penginapan;";
            connection.ConnectionString = constr;
            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                string StrSql = "select * from penginapan";
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
