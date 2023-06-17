using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    internal class Pengumuman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Tanggal_Informasi { get; set; }
        public int Wisata_ID { get; set; }

    }
}
