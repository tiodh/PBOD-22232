using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    public class TempatMakan
    {
        public int id_tempat_makan { get; set; }
        public string nama_tempat_makan { get; set; }
        public string lokasi_tempat_makan { get; set; }
        public string deskripsi_tempat_makan { get; set; }
        public string no_telepon_tempat_makan { get; set; }
        public int wisata_id { get; set; }
    }
}
