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
    public partial class FormEditEvent : Form
    {
        public FormEditEvent()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Rio09rio:v;Database=DataEvent";
            string query = "SELECT * FROM eventacara";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    NpgsqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }
        private void FormEditEvent_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            int id_event = int.Parse(tbIdEvent.Text);
            DateOnly tanggal = DateOnly.Parse(dateTimePicker1.Value.ToShortDateString());
            int wisata = int.Parse(tbIdWisata.Text);
            Crud.CreateData(id_event, tbNamaEvent.Text, tbdeskripsi.Text, tanggal, wisata);
            LoadData();

        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            int id_event = int.Parse(tbIdEvent.Text);
            DateOnly tanggal = DateOnly.Parse(dateTimePicker1.Value.ToShortDateString());
            int wisata = int.Parse(tbIdWisata.Text);
            Crud.UpdateData(id_event, tbNamaEvent.Text, tbdeskripsi.Text, tanggal, wisata);
            LoadData();
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            int id_event = int.Parse(tbIdEvent.Text);
            Crud.DeleteData(id_event);
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    class Crud
    {
        public static void CreateData(int kode, string nama, string desk, DateOnly tgl, int wisata)
        {
            Connec koneksidb = new Connec();
            string querycreate = $"insert into eventacara (id_event, nama_event, deskripsi_Event, tanggal_pelaksana, wisata_id) values ('{kode}', '{nama}', '{desk}', '{tgl}', '{wisata}');";
            koneksidb.Run(querycreate);
        }

        public static void UpdateData(int kode, string nama, string desk, DateOnly tgl, int wisata)
        {
            Connec connectdb = new Connec();
            string queryupdate = $"update eventacara set nama_event = '{nama}', deskripsi_Event = '{desk}', tanggal_pelaksana = '{tgl}' where id_event = {kode}";
            connectdb.Run(queryupdate);
        }

        public static void DeleteData(int kode)
        {
            Connec connectdb = new Connec();
            string querydelete = $"delete from eventacara where id_event = {kode}::integer;;";
            connectdb.Run(querydelete);
        }


    }
    class Connec
    {
        public NpgsqlConnection connect;

        public Connec()
        {
            NpgsqlConnection connect = new NpgsqlConnection();
            connect.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Rio09rio:v;Database=DataEvent";
        }

        public DataTable Run(string sql)
        {
            NpgsqlConnection connect = new NpgsqlConnection();
            connect.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=Rio09rio:v;Database=DataEvent";

            DataTable dt = new DataTable();
            try
            {
                connect.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = sql;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                cmd.Dispose();
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return dt;
        }
    }
}
