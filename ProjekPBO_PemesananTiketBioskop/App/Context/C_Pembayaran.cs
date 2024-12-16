using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;
using Npgsql;
using ProjekPBO_PemesananTiketBioskop.App.Core;
using ProjekPBO_PemesananTiketBioskop.App.Model;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_Pembayaran : DatabaseWrapper
    {
        public static DataTable GetNomorKursi()
        {
            string query = @"SELECT kursi_id.idKursi, nomor_kursi.nomorkursi FROM kursi WHERE kursi_id = @kursi ";
            DataTable NomorKursi = queryExecutor(query);
            return NomorKursi;

        }

        public static DataTable getdataTransaksi()
        {
            if (userSession.CurrentUser == null)
            {
                throw new InvalidOperationException("User session is not available. The user must be logged in.");
            }

            string query = @"
        SELECT 
            akun.username,
            film.judul_film,
            ruangan.nama_ruangan,
            transaksi.waktu_transaksi,
            transaksi.tanggal_transaksi,
            kursi.nomor_kursi,
            transaksi.jumlah_pembayaran
        FROM 
            transaksi
        JOIN 
            detail_kursi ON transaksi.detailkursi_id = detail_kursi.detailkursi_id
        JOIN 
            kursi ON detail_kursi.kursi_id = kursi.kursi_id
        JOIN 
            detail_film ON detail_kursi.detailfilm_id = detail_film.detailfilm_id
        JOIN 
            film ON detail_film.film_id = film.film_id
        JOIN 
            ruangan ON detail_film.ruangan_id = ruangan.ruangan_id
        WHERE
            akun_id = @akun_id;
        ";

            DataTable dataFilm = queryExecutor(query);
            return dataFilm;
        }

        public static void AddPembayaran(M_Pembayaran pembayaran)
        {
            string query = @"
            INSERT INTO transaksi 
                (akun_id, waktu_transaksi, tanggal_transaksi,jumlah_pembayaran, detailkursi_id, metode_id)
            VALUES 
                (@akun_id, @waktu_transaksi::time, @tanggal_transaksi, @jumlah_pembayaran, @detailkursi_id, @metode_id)";

            var parameters = new NpgsqlParameter[]
            {
            new NpgsqlParameter("@akun_id", pembayaran.akun_id),
            new NpgsqlParameter("@waktu_transaksi", pembayaran.waktu_transaksi),
            new NpgsqlParameter("@tanggal_transaksi", pembayaran.tanggal_transaksi),
            new NpgsqlParameter("@jumlah_pembayaran", pembayaran.JumlahUang),
            new NpgsqlParameter("@detailkursi_id", pembayaran.Kursi),
            new NpgsqlParameter("@metode_id", pembayaran.MetodeId)
            };

            try
            {
                DatabaseWrapper.commandExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception($"Gagal menambahkan pembayaran: {ex.Message}");
            }
        }
    }
}
