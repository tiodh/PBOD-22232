﻿using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontendpbo.Contexts
{
    internal class ContextKeamanan
    {
        public List<Keamanan> keamananList = new List<Keamanan>();

        public bool create(Keamanan newKeamanan)
        {
            bool isSucces = false;
            using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=peta_jember;user id=postgres;password=123"))
            {
                connection.Open();
                NpgsqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "insert into data_keamanan(nama_lembaga, alamat_keamanan, no_tlp, deskripsi_keamanan) values(@nama_keamanan, @alamat_keamanan, @no_tlp, @deskripsi_keamanan)";
                command.Parameters.Add(new NpgsqlParameter("@nama_keamanan", newKeamanan.Name));
                command.Parameters.Add(new NpgsqlParameter("@deskripsi_keamanan", newKeamanan.Description));
                command.Parameters.Add(new NpgsqlParameter("@alamat_keamanan", newKeamanan.Alamat));
                command.Parameters.Add(new NpgsqlParameter("@no_tlp", newKeamanan.No_Tlp));

                command.CommandType = System.Data.CommandType.Text;
                int jmlDataBaru = command.ExecuteNonQuery();
                if(jmlDataBaru > 0)
                {
                    isSucces = true;
                    keamananList.Add(newKeamanan);
                }
                //connection.Close();
                MessageBox.Show("Data berhasil diinput");
            }
            return isSucces;
        }

        public void edit(string nama, string deskripsi, string alamat, string nomtelp, int ID)
        {
            
            using (NpgsqlConnection connection = new NpgsqlConnection("Host = localhost; Port = 5432; Database = peta_jember; Username = postgres; Password = 123"))
            {
                try
                {
                    connection.Open();
                    string queryupdate = $"update data_keamanan set nama_lembaga = @DataA, deskripsi_keamanan = @DataB, alamat_keamanan = @DataC, no_tlp = @DataD where id_keamanan = @ID";
                    using (NpgsqlCommand command = new NpgsqlCommand(queryupdate, connection))
                    {
                        command.Parameters.AddWithValue("@DataA", nama);
                        command.Parameters.AddWithValue("@DataB", deskripsi);
                        command.Parameters.AddWithValue("@DataC", alamat);
                        command.Parameters.AddWithValue("@DataD", nomtelp);
                        command.Parameters.AddWithValue("@ID", ID);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }
    }
}