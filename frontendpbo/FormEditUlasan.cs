using frontendpbo.Models;
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
    public partial class FormEditUlasan : Form
    {
        private int id_ulasan;

        Contexts.ContextUlasan ulasanContext;
        public FormEditUlasan()
        {
            InitializeComponent();
            ulasanContext = new Contexts.ContextUlasan();

            ulasanContext.Read();
            dataGridViewEditUlasan.DataSource = ulasanContext.listUlasan;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string namaPengguna = textBoxNamaPenggunaE.Text;
                string deskripsiUlasan = textBoxDeskripsiUlasanE.Text;

                // Buat objek ulasan baru
                Ulasan ulasanBaru = new Ulasan();
                ulasanBaru.Nama_User = namaPengguna;
                ulasanBaru.Description = deskripsiUlasan;

                // Tambahkan objek ulasan baru ke dalam properti listUlasan di dalam ulasanContext
                ulasanContext.listUlasan.Add(ulasanBaru);

                // Refresh tampilan DataGridView dengan properti listUlasan yang diperbarui
                dataGridViewEditUlasan.DataSource = null;
                dataGridViewEditUlasan.DataSource = ulasanContext.listUlasan;

                // Kosongkan TextBox setelah data ditambahkan
                textBoxNamaPenggunaE.Text = "";
                textBoxDeskripsiUlasanE.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
