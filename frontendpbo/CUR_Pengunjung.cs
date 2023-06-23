using System;
using System.Drawing;
using System.Windows.Forms;
using frontendpbo.Contexts;
using frontendpbo.Models;

namespace frontendpbo
{
    public partial class CUR_Pengunjung : Form
    {
        private ContextPengunjung context;
        private Color activeButtonColor = Color.Green; // Warna tombol aktif
        private Color defaultButtonColor = SystemColors.Control; // Warna tombol default

        public CUR_Pengunjung()
        {
            InitializeComponent();
            context = new ContextPengunjung();
            LoadData();
        }

        private void LoadData()
        {
            // Memuat data dari database dan menampilkan dalam gridView_Data
            gridView_Data.DataSource = context.Read();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            string keyword = textbox_Nama.Text;
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                // Mencari data pengunjung berdasarkan nama
                gridView_Data.DataSource = context.Search(keyword);
            }
            else
            {
                MessageBox.Show("Masukkan nama pengunjung untuk melakukan pencarian.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            int idPengunjung;
            if (int.TryParse(textbox_idPengunjung.Text, out idPengunjung))
            {
                string nama = textbox_Nama.Text;
                string asal = textbox_asal.Text;
                int idWisata;
                if (int.TryParse(textbox_idWisata.Text, out idWisata))
                {
                    // Membuat objek Pengunjung berdasarkan data yang diinputkan
                    Pengunjung pengunjung = new Pengunjung
                    {
                        Id = idPengunjung,
                        Name = nama,
                        Asal = asal,
                        Wisata_ID = idWisata
                    };

                    // Melakukan update data pengunjung
                    context.Update(pengunjung);

                    // Memuat ulang data setelah update
                    LoadData();
                }
                else
                {
                    MessageBox.Show("ID Wisata harus berupa angka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ID Pengunjung harus berupa angka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            string nama = textbox_Nama.Text;
            string asal = textbox_asal.Text;
            int idWisata;
            if (int.TryParse(textbox_idWisata.Text, out idWisata))
            {
                // Membuat objek Pengunjung berdasarkan data yang diinputkan
                Pengunjung pengunjung = new Pengunjung
                {
                    Name = nama,
                    Asal = asal,
                    Wisata_ID = idWisata
                };

                // Melakukan penambahan data pengunjung
                context.Create(pengunjung);

                // Memuat ulang data setelah penambahan
                LoadData();
            }
            else
            {
                MessageBox.Show("ID Wisata harus berupa angka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Search_MouseDown(object sender, MouseEventArgs e)
        {
            // Mengubah warna tombol Search ketika ditekan
            button_Search.BackColor = activeButtonColor;
        }

        private void button_Search_MouseUp(object sender, MouseEventArgs e)
        {
            // Mengembalikan warna tombol Search ke warna default setelah dilepas
            button_Search.BackColor = defaultButtonColor;
        }

        private void button_Update_MouseDown(object sender, MouseEventArgs e)
        {
            // Mengubah warna tombol Update ketika ditekan
            button_Update.BackColor = activeButtonColor;
        }

        private void button_Update_MouseUp(object sender, MouseEventArgs e)
        {
            // Mengembalikan warna tombol Update ke warna default setelah dilepas
            button_Update.BackColor = defaultButtonColor;
        }

        private void button_Create_MouseDown(object sender, MouseEventArgs e)
        {
            // Mengubah warna tombol Create ketika ditekan
            button_Create.BackColor = activeButtonColor;
        }

        private void button_Create_MouseUp(object sender, MouseEventArgs e)
        {
            // Mengembalikan warna tombol Create ke warna default setelah dilepas
            button_Create.BackColor = defaultButtonColor;
        }

        private void gridView_Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
