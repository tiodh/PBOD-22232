using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    public class Ulasan
    {
        public int id_ulasan { get; set; }
        public string nama_user { get; set; }
        public string deskripsi_ulasan { get; set; }
        public int wisata_id { get; set; }
    }
}
