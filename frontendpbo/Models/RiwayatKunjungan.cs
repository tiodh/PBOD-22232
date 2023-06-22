using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    internal class RiwayatKunjungan
    {
        public int IdKunjungan { get; set; }
        public DateTime Tanggal_Kunjungan { get; set; }
        public int Jumlah_Tiket { get; set; }
        public int Tiket_ID { get; set; }
        public int Pengunjung_ID { get; set; }

    }
}
