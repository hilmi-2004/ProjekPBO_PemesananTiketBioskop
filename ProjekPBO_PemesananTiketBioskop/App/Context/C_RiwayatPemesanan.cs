using core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_RiwayatPemesanan : DatabaseWrapper
    {
        public static DataTable getTransaksi()
        {
            string query = @"
        SELECT 
            a.username,
            f.judul_film,
            r.nama_ruangan,
            t.waktu_transaksi,
            t.tanggal_transaksi,
            mp.nama_metode AS metode_pembayaran, -- Menampilkan nama metode pembayaran
            k.nomor_kursi,
            t.jumlah_pembayaran
        FROM 
            transaksi t
        JOIN 
            akun a ON t.akun_id = a.akun_id
        JOIN 
            detail_kursi dk ON t.detailkursi_id = dk.detailkursi_id
        JOIN 
            kursi k ON dk.kursi_id = k.kursi_id
        JOIN 
            detail_film df ON dk.detailfilm_id = df.detailfilm_id
        JOIN 
            film f ON df.film_id = f.film_id
        JOIN 
            ruangan r ON df.ruangan_id = r.ruangan_id
        JOIN
            metode_pembayaran mp ON t.metode_id = mp.metode_id
        ";

            DataTable dataFilm = queryExecutor(query);
            return dataFilm;
        }
    }
}
