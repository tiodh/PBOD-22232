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
        public bool Login(Admin admin)
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=1;Database=PETAJEMBER;";

            using (var conn = new NpgsqlConnection(conStr))
            {
                conn.Open();

                string sql = "SELECT COUNT(*) FROM admin WHERE username = @username AND password = @password";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@username", NpgsqlTypes.NpgsqlDbType.Text, admin.Username);
                    cmd.Parameters.AddWithValue("@password", NpgsqlTypes.NpgsqlDbType.Text, admin.Password);

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
