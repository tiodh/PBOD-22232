using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    internal class UMKM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Pemilik_UMKM { get; set; }
        public string No_Telepon_UMKM { get; set; }
        public int Wisata_ID { get; set; }  
    }
}
