using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    internal class Pengguna
    {
        public int Id_Admin { get; set; }
        public string Email { get; set; }
        public string Nama_Lengkap { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
