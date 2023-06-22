using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    public class Tiket
    {
        public int id_tiket { get; set; }
        public string nama_tiket { get; set; }
        public string deskripsi_tiket { get; set; }
        public int harga_tiket { get; set; }
        public int wisata_id { get; set; }
    }
}
