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
        public List<Pengguna> listPengguna = new List<Pengguna>() { };
        Pengguna pengguna = new Pengguna();
        public bool Create(Pengguna pengguna)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql =
                    "INSERT INTO pengguna(nama_lengkap, email, username, password) values (:nama_lengkap,:email,:username,:password)";
                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":nama_lengkap", pengguna.Nama_Lengkap));
                    cmd.Parameters.Add(new NpgsqlParameter(":email", pengguna.Email));
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
    }
}
