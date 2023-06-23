using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontendpbo.Models
{
    public class Riwayat
    {
        public int Id { get; set; }
        public string nama { get; set; }
        public DateOnly Tanggal_Kunjungan { get; set; }
        public int Jumlah_Tiket { get; set; }
        public string nama_tiket { get; set; }
        public int Tiket_ID { get; set; }
        public int Pengunjung_ID { get; set; }



    }
}
