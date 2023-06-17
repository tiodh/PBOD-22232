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
    public partial class CRUDTrasnportasi : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = postgres; Password = Alvio28; Database = PBO");
        public CRUDTrasnportasi()
        {
            InitializeComponent();
        }
        private void CRUDTrasnportasi_Load(object sender, EventArgs e)
        {
            showdata();
        }
        private void showdata()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("Select * from Transportasi where nama_kendaraan like '%" + TampilData.Text + "'", conn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            TampilData.DataSource = dt;

            TampilData.Columns["id_transportasi"].Width = 100;
            TampilData.Columns["nama_transportasi"].Width = 110;
            TampilData.Columns["jenis_transportasi"].Width = 100;
            TampilData.Columns["deskripsi"].Width = 550;
        }
    }
}