using Npgsql;
using OxyPlot;
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

        private void FormEditEvent_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";
            string query = "SELECT * FROM event_acara";

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

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            int id_event = int.Parse(tbIdEvent.Text);
            DateOnly tanggal = DateOnly.Parse(dateTimePicker1.Value.ToShortDateString());
            int wisata = int.Parse(tvIdWisata.Text);
            Crud.CreateData(id_event, tbNamaEvent.Text, textBox1.Text, tanggal, wisata);
            LoadData();

        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            int id_event = int.Parse(tbIdEvent.Text);
            DateOnly tanggal = DateOnly.Parse(dateTimePicker1.Value.ToShortDateString());
            int wisata = int.Parse(tvIdWisata.Text);
            Crud.UpdateData(id_event, tbNamaEvent.Text, textBox1.Text, tanggal, wisata);
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
        public static void CreateData(int id_event, string nama_event, string deskripsi_event, DateOnly tanggal_event, int wisata_id)
        {
            Connec koneksidb = new Connec();
            string querycreate = $"insert into event_acara (id_event, nama_event, deskripsi_Event, tanggal_event, wisata_id) values ('{id_event}', '{nama_event}', '{deskripsi_event}', '{tanggal_event}', '{wisata_id}');";
            koneksidb.Run(querycreate);
        }

        public static void UpdateData(int id_event, string nama_event, string deskripsi_event, DateOnly tanggal_event, int wisata_id)
        {
            Connec connectdb = new Connec();
            string queryupdate = $"update event_acara set nama_event = '{nama_event}', deskripsi_event = '{deskripsi_event}', tanggal_event = '{tanggal_event}' where id_event = {id_event}";
            connectdb.Run(queryupdate);
        }

        public static void DeleteData(int id_event)
        {
            Connec connectdb = new Connec();
            string querydelete = $"delete from event_acara where id_event = {id_event}::integer;;";
            connectdb.Run(querydelete);
        }


    }

    class Connec
    {
        public NpgsqlConnection connect;

        public Connec()
        {
            NpgsqlConnection connect = new NpgsqlConnection();
            connect.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";
        }

        public DataTable Run(string sql)
        {
            NpgsqlConnection connect = new NpgsqlConnection();
            connect.ConnectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";

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
