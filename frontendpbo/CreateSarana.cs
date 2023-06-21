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
    public partial class CreateSarana : Form
    {
        public CreateSarana()
        {
            InitializeComponent();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=peta_jember;user id=postgres;password=12345678"))
            {
                connection.Open();
                NpgsqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "insert into sarana_prasarana(nama_sarana,deskripsi_sarana) values(@nama_sarana,@deskripsi_sarana)";
                command.Parameters.Add(new NpgsqlParameter("@nama_sarana", tbxNama.Text));
                command.Parameters.Add(new NpgsqlParameter("@deskripsi_sarana", tbxDeskripsi.Text));

                tbxNama.Text = "";
                tbxDeskripsi.Text = "";
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data berhasil diinput");
                //RefreshUlasanTerakhir();
                //RefreshRatingTerakhir();
            }

            dataGridView1.Rows.Add(nama_sektor, deskripsi);
            this.DialogResult = DialogResult.OK;
        }
    }
}
