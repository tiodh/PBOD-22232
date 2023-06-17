using frontendpbo.Helpers;
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
    public partial class search_data_sarpras : Form
    {
        DatabaseHelper db;
        public search_data_sarpras()
        {
            InitializeComponent();
            ShowDataSarpras();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var db = new DatabaseHelper();
            var reader = db.Select($"SELECT * FROM sarana_prasarana WHERE nama_sarana LIKE '%{textBox1.Text}%'");
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add((int)reader["id_sarana"], (string)reader["nama_sarana"], (string)reader["deskripsi_saranat"], (int)reader["wisata_idt"]);
            }
            reader.Close();
        }

        private void ShowDataSarpras()
        {
            var db = new DatabaseHelper();
            var reader = db.Select("SELECT id_sarana,nama_sarana,deskripsi_sarana,wisata_id FROM public.sarana_prasarana;");
            dataGridView1.Rows.Clear();


            while (reader.Read())
            {
                dataGridView1.Rows.Add((int)reader["id_sarana"], (string)reader["nama_sarana"], (string)reader["deskripsi_saranat"], (int)reader["wisata_idt"]);
            }

            reader.Close();

        }
    }
}
