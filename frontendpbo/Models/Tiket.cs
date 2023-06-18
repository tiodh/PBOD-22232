using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    internal class Tiket
    {
        public int Id_Tiket { get; set; }
        public string Nama_Tiket { get; set; }
        public string Deskripsi { get; set; }
        public int Harga { get; set; }
        public int Wisata_ID { get; set; }
    }
}
