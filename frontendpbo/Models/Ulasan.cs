using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    internal class Ulasan
    {
        public int ID { get; set; }
        public string Nama_User { get; set; }
        public string Description { get; set; }
        public int Wisata_ID { get; set; }
    }
}
