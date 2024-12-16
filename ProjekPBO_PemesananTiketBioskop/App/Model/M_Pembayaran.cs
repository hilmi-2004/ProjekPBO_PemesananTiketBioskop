using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Model
{
    public class M_Pembayaran
    {
        public int akun_id { get; set; }
        public DateTime waktu_transaksi { get; set; } = DateTime.Now;
        public DateTime tanggal_transaksi { get; set; } = DateTime.Now.Date;
        public int MetodeId { get; set; }
        public decimal TotalHarga { get; set; }
        public decimal JumlahUang { get; set; }
        public int Kursi { get; set; }
    }
}
