﻿using System;
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
        DatabaseHelper db;
        public DetailSarpras()
        {
            InitializeComponent();
            showDataKolam();
            showDataCamp();
            showDataHotel();
            showDataWisata();
        }

        private void showDataHotel()
        {
            db = new DatabaseHelper();
            var reader = db.Select("SELECT deskripsi_sarana FROM sarana_prasarana limit 1 ");
            dGV_Hotel.Columns.Clear();
            dGV_Hotel.Rows.Clear();

            // Menambahkan kolom deskripsi sarana
            dGV_Hotel.Columns.Add("Deskripsi Sarana", "Deskripsi Sarana");

            // Mengatur properti ColumnHeadersVisible menjadi false
            dGV_Hotel.ColumnHeadersVisible = false;
            dGV_Hotel.RowHeadersVisible = false;

            // Mengatur properti WrapMode menjadi True
            dGV_Hotel.Columns["Deskripsi Sarana"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Mengatur posisi teks pada sel "Deskripsi Sarana"
            dGV_Hotel.Columns["Deskripsi Sarana"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            // Mengatur AutoSizeRowsMode menjadi AllCells
            dGV_Hotel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Mengatur AutoSizeMode menjadi Fill
            dGV_Hotel.Columns["Deskripsi Sarana"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            while (reader.Read())
            {
                var deskripsiSarana = reader["deskripsi_sarana"];
                dGV_Hotel.Rows.Add(deskripsiSarana);
            }

            reader.Close();

        }

        private void showDataKolam()
        {
            db = new DatabaseHelper();
            var reader = db.Select("SELECT deskripsi_sarana FROM sarana_prasarana limit 1 offset 1");
            dGV_kolam.Columns.Clear();
            dGV_kolam.Rows.Clear();

            // Menambahkan kolom deskripsi sarana
            dGV_kolam.Columns.Add("Deskripsi Sarana", "Deskripsi Sarana");

            // Mengatur properti ColumnHeadersVisible menjadi false
            dGV_kolam.ColumnHeadersVisible = false;
            dGV_kolam.RowHeadersVisible = false;

            // Mengatur properti WrapMode menjadi True
            dGV_kolam.Columns["Deskripsi Sarana"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Mengatur posisi teks pada sel "Deskripsi Sarana"
            dGV_kolam.Columns["Deskripsi Sarana"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            // Mengatur AutoSizeRowsMode menjadi AllCells
            dGV_kolam.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Mengatur AutoSizeMode menjadi Fill
            dGV_kolam.Columns["Deskripsi Sarana"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            while (reader.Read())
            {
                var deskripsiSarana = reader["deskripsi_sarana"];
                dGV_kolam.Rows.Add(deskripsiSarana);
            }

            reader.Close();

        }

        private void showDataCamp()
        {
            db = new DatabaseHelper();
            var reader = db.Select("SELECT deskripsi_sarana FROM sarana_prasarana limit 1 offset 2");
            dGV_camp.Columns.Clear();
            dGV_camp.Rows.Clear();

            // Menambahkan kolom deskripsi sarana
            dGV_camp.Columns.Add("Deskripsi Sarana", "Deskripsi Sarana");

            // Mengatur properti ColumnHeadersVisible menjadi false
            dGV_camp.ColumnHeadersVisible = false;
            dGV_camp.RowHeadersVisible = false;

            // Mengatur properti WrapMode menjadi True
            dGV_camp.Columns["Deskripsi Sarana"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Mengatur posisi teks pada sel "Deskripsi Sarana"
            dGV_camp.Columns["Deskripsi Sarana"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            // Mengatur AutoSizeRowsMode menjadi AllCells
            dGV_camp.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Mengatur AutoSizeMode menjadi Fill
            dGV_camp.Columns["Deskripsi Sarana"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            while (reader.Read())
            {
                var deskripsiSarana = reader["deskripsi_sarana"];
                dGV_camp.Rows.Add(deskripsiSarana);
            }

            reader.Close();

        }


        private void showDataWisata()
        {
            db = new DatabaseHelper();
            var reader = db.Select("SELECT deskripsi_sarana FROM sarana_prasarana limit 1 offset 3");
            dGV_wisata.Columns.Clear();
            dGV_wisata.Rows.Clear();

            // Menambahkan kolom deskripsi sarana
            dGV_wisata.Columns.Add("Deskripsi Sarana", "Deskripsi Sarana");

            // Mengatur properti ColumnHeadersVisible menjadi false
            dGV_wisata.ColumnHeadersVisible = false;
            dGV_wisata.RowHeadersVisible = false;

            // Mengatur properti WrapMode menjadi True
            dGV_wisata.Columns["Deskripsi Sarana"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Mengatur posisi teks pada sel "Deskripsi Sarana"
            dGV_wisata.Columns["Deskripsi Sarana"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;

            // Mengatur AutoSizeRowsMode menjadi AllCells
            dGV_wisata.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Mengatur AutoSizeMode menjadi Fill
            dGV_wisata.Columns["Deskripsi Sarana"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            while (reader.Read())
            {
                var deskripsiSarana = reader["deskripsi_sarana"];
                dGV_wisata.Rows.Add(deskripsiSarana);
            }

            reader.Close();

        }
    }
}