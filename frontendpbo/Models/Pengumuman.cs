using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    internal class Pengumuman
    {
        public int id_wisata { get; set; }
        public string nama_informasi { get; set; } = string.Empty;
        public string deskripsi_informasi { get; set; } = string.Empty;
        public DateTime tanggal_informasi { get; set; }


    }
}