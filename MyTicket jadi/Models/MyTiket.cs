using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace MyTicket_jadi.Models
{
    public class MyTiket
    {
        public string nama_wisata { get; set; }
        public string alamat_wisata { get; set; }
        public decimal harga_tiket { get; set; }
        public int kuantitas  { get; set; }

        public string deskripsi { get; set; }
        public decimal detailHarga { get; set; }
        public float rating { get; set; }  
        
    }
}
