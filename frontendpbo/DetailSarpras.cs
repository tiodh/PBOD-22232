﻿using frontendpbo.Contexts;
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
    public partial class DetailSarpras : Form
    {
        private ContextSarana contextSarana;
        public DetailSarpras()
        {
            InitializeComponent();
            contextSarana = new ContextSarana();
            showDataKolam();
            showDataCamp();
            showDataHotel();
            showDataWisata();
        }

        private void showDataHotel()
        {
            DataTable dataTable = contextSarana.ReadAll();

            // Menghapus semua kolom dan baris yang ada pada DataGridView
            dGV_Hotel.Rows.Clear();
            dGV_Hotel.Columns.Clear();

            // Menambahkan kolom-kolom yang ingin ditampilkan
            dGV_Hotel.Columns.Add("deskripsi_sarana", "Deskripsi Sarana");

            // Memeriksa apakah ada baris dalam DataTable
            if (dataTable.Rows.Count > 0)
            {
                DataRow firstRow = dataTable.Rows[0];
                string deskripsiSarana = firstRow["deskripsi_sarana"].ToString();

                // Menambahkan baris pertama ke dalam DataGridView
                dGV_Hotel.Rows.Add(deskripsiSarana);
            }

        }

        private void showDataKolam()
        {
            DataTable dataTable = contextSarana.ReadAll();

            // Menghapus semua kolom dan baris yang ada pada DataGridView
            dGV_kolam.Rows.Clear();
            dGV_kolam.Columns.Clear();

            // Menambahkan kolom-kolom yang ingin ditampilkan
            dGV_kolam.Columns.Add("deskripsi_sarana", "Deskripsi Sarana");

            // Memeriksa apakah ada baris dalam DataTable
            if (dataTable.Rows.Count >= 2)
            {
                DataRow firstRow = dataTable.Rows[1];
                string deskripsiSarana = firstRow["deskripsi_sarana"].ToString();

                // Menambahkan baris pertama ke dalam DataGridView
                dGV_kolam.Rows.Add(deskripsiSarana);
            }

        }

        private void showDataCamp()
        {
            DataTable dataTable = contextSarana.ReadAll();

            // Menghapus semua kolom dan baris yang ada pada DataGridView
            dGV_kolam.Rows.Clear();
            dGV_kolam.Columns.Clear();

            // Menambahkan kolom-kolom yang ingin ditampilkan
            dGV_kolam.Columns.Add("deskripsi_sarana", "Deskripsi Sarana");

            // Memeriksa apakah ada baris dalam DataTable
            if (dataTable.Rows.Count >= 3)
            {
                DataRow firstRow = dataTable.Rows[2];
                string deskripsiSarana = firstRow["deskripsi_sarana"].ToString();

                // Menambahkan baris pertama ke dalam DataGridView
                dGV_kolam.Rows.Add(deskripsiSarana);
            }

        }


        private void showDataWisata()
        {
            DataTable dataTable = contextSarana.ReadAll();

            // Menghapus semua kolom dan baris yang ada pada DataGridView
            dGV_kolam.Rows.Clear();
            dGV_kolam.Columns.Clear();

            // Menambahkan kolom-kolom yang ingin ditampilkan
            dGV_kolam.Columns.Add("deskripsi_sarana", "Deskripsi Sarana");

            // Memeriksa apakah ada baris dalam DataTable
            if (dataTable.Rows.Count >= 3)
            {
                DataRow firstRow = dataTable.Rows[2];
                string deskripsiSarana = firstRow["deskripsi_sarana"].ToString();

                // Menambahkan baris pertama ke dalam DataGridView
                dGV_kolam.Rows.Add(deskripsiSarana);
            }

        }
    }
}