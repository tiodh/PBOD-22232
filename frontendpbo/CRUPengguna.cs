using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace frontendpbo
{
    public class CRUPengguna
    {
        public static void Create_Data_Pengguna(string nama_Lengkap, string username, string email, string password)
        {
            ConnectDB connectData = new ConnectDB();
            string querycreate = $"INSERT INTO admin (nama_lengkap, username, email_admin, password) values ('{nama_Lengkap}', '{username}', '{email}', '{password}');";
            connectData.ExecuteSQL(querycreate);
        }
        public static DataTable ReadData()
        {
            ConnectDB connectData = new ConnectDB();
            DataTable dt = connectData.ExecuteSQL("select * from admin");

            return dt;
        }
        public static void UpdateData(string email, string namaLengkap, string username, string password, int idadmin)
        {
            ConnectDB connectData = new ConnectDB();
            string update = $"update admin set nama_lengkap = '{namaLengkap}', username = '{username}', email_admin = '{email}', password = '{password}' \nwhere id_admin = {idadmin}  ;";
            connectData.ExecuteSQL(update);

        }
    }
    class ConnectDB
    {
        public NpgsqlConnection connect;

        public ConnectDB()
        {
            connect = new NpgsqlConnection();
            string constr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember";
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
