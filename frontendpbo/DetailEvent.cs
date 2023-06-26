using frontendpbo.Models;
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
    public partial class DetailEvent : Form
    {
        Contexts.ContextDataEvent eventContext;
        List<Event> eventList;
        DataTable? dataTable;
        public DetailEvent()
        {
            {
                InitializeComponent();
                eventContext = new Contexts.ContextDataEvent();
                eventList = new List<Event>();

                eventContext.Readdata();
                dataGridView1Search.DataSource = eventContext.listDataEvent;
                //LoadData();

            }
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
                        dataGridView1Search.DataSource = dt;
                    }
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1Search_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6Search_TextChanged(object sender, EventArgs e)
        {
            List<Event> cari = eventContext.Search(textBox6Search.Text);
            dataGridView1Search.DataSource = cari;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6Search_Click(object sender, EventArgs e)
        {
            textBox6Search.Text = null;
        }
    }

}



