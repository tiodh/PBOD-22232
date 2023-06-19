﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace frontendpbo
{
    public class CRU_DataPengguna
    {
        public static void CreateData(string namaLengkap, string username, string email, string password)
        {
            ConnectDB connectData = new ConnectDB();
            string querycreate = $"insert into admin (nama_lengkap, username, email_admin, password) values ('{namaLengkap}', '{username}', '{email}', '{password}');";
            connectData.ExecuteSQL(querycreate);
        }
        public static DataTable ReadData()
        {
            ConnectDB connectData = new ConnectDB();
            DataTable dt = connectData.ExecuteSQL("select id_admin, nama_lengkap, username, email_admin from admin");

            return dt;
        }
    }
    class ConnectDB
    {
        public NpgsqlConnection connect;

        public ConnectDB()
        {
            connect = new NpgsqlConnection();
            string constr = "Server=localhost;Port=5432;User Id=hamzah;Password=adminpbo;Database=dataPengguna";
            connect.ConnectionString = constr;
        }

        public DataTable ExecuteSQL(string syntax)
        {

            DataTable dt = new DataTable();
            try
            {
                connect.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = syntax;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                cmd.Dispose();
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return dt;
        }
    }
}