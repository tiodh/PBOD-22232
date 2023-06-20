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
    public partial class Edit_Riwayat_Kunjungan : Form
    {
        string pilihan;
        string perintah;
        public Edit_Riwayat_Kunjungan()
        {
            InitializeComponent();
        }

        private void Edit_Riwayat_Kunjungan_Load(object sender, EventArgs e)
        {
            panel3.Location = new System.Drawing.Point((panel1.Width - panel3.Width) / 2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Nama Wisata")
            {
                pilihan = comboBox1.SelectedItem.ToString();
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Rembangan");
                comboBox1.Items.Add("Watu Ulo");
                comboBox1.Items.Add("Patemon");
                comboBox1.Items.Add("Kebon Agung");
                comboBox1.Items.Add("back");
            }
            else if (comboBox1.SelectedItem.ToString() == "Jumlah Tiket")
            {
                pilihan = comboBox1.SelectedItem.ToString();
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Terkecil");
                comboBox1.Items.Add("Terbanyak");
                comboBox1.Items.Add("back");
            }
            else if (comboBox1.SelectedItem.ToString() == "back")
            {
                dataGridView1.DataSource = null;
                comboBox1.Items.Clear();
                comboBox1.Items.Add("ID Wisata");
                comboBox1.Items.Add("Tanggal Kunjungan");
                comboBox1.Items.Add("Jumlah Tiket");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (pilihan == "Nama Wisata")
                {
                    if (comboBox1.SelectedItem == "Rembangan")
                    {
                        perintah = $"where id_wisata = 1";
                    }
                    else if (comboBox1.SelectedItem == "Watu Ulo")
                    {
                        perintah = $"where id_wisata = 2";
                    }
                    else if (comboBox1.SelectedItem == "Patemon")
                    {
                        perintah = $"where id_wisata = 3";
                    }
                    else if (comboBox1.SelectedItem == "Kebon Agung")
                    {
                        perintah = $"where id_wisata = 4";
                    }
                    else
                    {
                        MessageBox.Show("Silakan pilih nilai ID Wisata dari combobox.");
                    }
                }



                else if (pilihan == "Tanggal Kunjungan")
                {
                    //Masih Belum Karena bingung
                }



                else if (pilihan == "Jumlah Tiket")
                {
                    if (comboBox1.SelectedItem == "Terkecil")
                    {
                        perintah = $"ORDER BY jumlah_tiket ASC";
                    }
                    else if (comboBox1.SelectedItem == "Terbanyak")
                    {
                        perintah = $"ORDER BY jumlah_tiket Desc";
                    }
                    else
                    {
                        MessageBox.Show("Silakan pilih Jenis Sorting dari combobox.");
                    }
                }


                if (perintah != null)
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection("Host = localhost; Port = 5432; Database = peta_jember; Username = postgres; Password = 010504"))
                    {
                        try
                        {
                            string query = $"SELECT * FROM riwayat_kunjungan {perintah}";

                            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                            {
                                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                                DataSet dataSet = new DataSet();
                                adapter.Fill(dataSet, "TabelData");

                                dataGridView1.DataSource = dataSet.Tables["TabelData"];
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                        }
                    }
                }

            }

            else
            {
                MessageBox.Show("Silakan pilih nilai dari combobox.");
            }
        }
    }
}
