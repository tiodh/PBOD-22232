using frontendpbo.Contexts;
using frontendpbo.Models;
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
        ContextDataEvent contextDataEvent;
        List<Event> events = new List<Event>();
        public FormEditEvent()
        {
            InitializeComponent();
            contextDataEvent = new ContextDataEvent();
            contextDataEvent.Readdata();
            dataGridView1.DataSource = contextDataEvent.listDataEvent;

        }
        private Models.Event GetDataEvent()
        {
            Models.Event dataevent = new Models.Event();
            dataevent.Id = int.Parse(tbIdEvent.Text);
            dataevent.Nama = tbNamaEvent.Text;
            dataevent.Deskripsi = textBox1.Text;
            dataevent.Tanggal_Event = new DateOnly(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
            dataevent.Wisata_ID = int.Parse(tvIdWisata.Text);

            return dataevent;
        }

        private void FormEditEvent_Load(object sender, EventArgs e)
        {
            Models.Event dataEvent = this.GetDataEvent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contextDataEvent.listDataEvent;
            contextDataEvent.Readdata();
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
            Models.Event dataEvent = this.GetDataEvent();
            contextDataEvent.insert(dataEvent);
            dataGridView1.DataSource = null;
            List<Event> updatedData = contextDataEvent.GetListDataEvent();
            dataGridView1.DataSource = contextDataEvent.listDataEvent;
            contextDataEvent.Readdata();

        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            Models.Event dataEvent = this.GetDataEvent();
            contextDataEvent.Update(dataEvent);
            List<Event> updatedData = contextDataEvent.GetListDataEvent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contextDataEvent.listDataEvent;
            contextDataEvent.Readdata();
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {

            Models.Event dataEvent = this.GetDataEvent();
            contextDataEvent.deleted(dataEvent);
            List<Event> updatedData = contextDataEvent.GetListDataEvent();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contextDataEvent.listDataEvent;
            contextDataEvent.Readdata();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                using (FormEditEvent dataEvent = new FormEditEvent())
                {

                    dataEvent.Text = "FormEditEvent";


                    DialogResult dr = dataEvent.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        Models.Event newDataEvent = dataEvent.GetDataEvent();
                        contextDataEvent.Update(newDataEvent);
                    }


                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    tbIdEvent.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    tbNamaEvent.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    tvIdWisata.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                }

            }
            catch (Exception)
            {

            }
        }
    }




}
