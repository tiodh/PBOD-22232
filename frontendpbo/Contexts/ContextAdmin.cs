using frontendpbo.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Contexts
{
    internal class ContextAdmin
    {

        public bool Login(Pengguna pengguna)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=123;Database=peta_jember;";

            using (var conn = new NpgsqlConnection(conStr))
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter("@username", pengguna.Username));
                    cmd.Parameters.Add(new NpgsqlParameter("@password", pengguna.Password));

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        isSuccess = true;
                    }
                }
            }

            return isSuccess;
        }

    }
}
