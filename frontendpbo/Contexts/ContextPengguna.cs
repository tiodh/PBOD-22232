using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextPengguna
    {
        public int CurrentIdAdmin;
        public List<Pengguna> listPengguna = new List<Pengguna>() { };
        public bool Create(Pengguna pengguna)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=hamzah;Password=adminpbo;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql =
                    "INSERT INTO admin(email_admin, nama_lengkap, username, password) values (:email_admin,:nama_lengkap,:username,:password)";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":email_admin", pengguna.Email));
                    cmd.Parameters.Add(new NpgsqlParameter(":nama_lengkap", pengguna.Nama_Lengkap));
                    cmd.Parameters.Add(new NpgsqlParameter(":username", pengguna.Username));
                    cmd.Parameters.Add(new NpgsqlParameter(":password", pengguna.Password));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int newdata = cmd.ExecuteNonQuery();
                    if (newdata > 0)
                    {
                        isSuccess = true;
                        this.listPengguna.Add(pengguna);
                    }
                }
            }
            return isSuccess;
        }

        public bool Read()
        {
            bool isSuccess = false;

            string conStr = "Server=localhost ;Port=5432; User Id=hamzah; Password=adminpbo; Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = "SELECT id_admin, email_admin, nama_lengkap, username, password FROM admin ORDER BY id_admin;";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    listPengguna.Clear();
                    while (reader.Read())
                    {
                        Pengguna pengguna = new Pengguna();
                        pengguna.Id_Admin = (int)reader["id_admin"];
                        pengguna.Email = (string)reader["email_admin"];
                        pengguna.Nama_Lengkap = (string)reader["nama_lengkap"];
                        pengguna.Username = (string)reader["username"];
                        pengguna.Password = (string)reader["password"];

                        listPengguna.Add(pengguna);
                    }
                }
            }
            return isSuccess;
        }

        public bool Update(Pengguna pengguna)
        {
            bool isSuccess = false;

            string conStr = "Server=localhost; Port=5432; User Id=hamzah; Password=adminpbo; Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = 
                    "UPDATE admin SET email_admin=:email_admin, nama_lengkap=:nama_lengkap, username=:username, password=:password WHERE id_admin=:id_admin;";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    CurrentIdAdmin = pengguna.Id_Admin;
                    cmd.Parameters.Add(new NpgsqlParameter(":id_admin", CurrentIdAdmin));
                    cmd.Parameters.Add(new NpgsqlParameter(":email_admin", pengguna.Email));
                    cmd.Parameters.Add(new NpgsqlParameter(":nama_lengkap", pengguna.Nama_Lengkap));
                    cmd.Parameters.Add(new NpgsqlParameter(":username", pengguna.Username));
                    cmd.Parameters.Add(new NpgsqlParameter(":password", pengguna.Password));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int newData = cmd.ExecuteNonQuery();
                    if (newData > 0)
                    {
                        isSuccess = true;
                        this.listPengguna.Add(pengguna);
                    }
                }
            }

            return isSuccess;
        }
    }
}
