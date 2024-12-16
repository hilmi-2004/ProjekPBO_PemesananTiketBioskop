using ProjekPBO_PemesananTiketBioskop.App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    public partial class V_E_TiketPelanggan : Form
    {
        public V_E_TiketPelanggan()
        {
            InitializeComponent();
            LoadTiketPelanggan();
        }

        // Method untuk mengambil data transaksi dan menampilkannya
        private void LoadTiketPelanggan()
        {
            try
            {
                // Query untuk mengambil data transaksi
                DataTable tiketData = C_RiwayatPemesanan.getTransaksi();

                if (tiketData.Rows.Count > 0)
                {
                    // Ambil data dari baris pertama (sesuai transaksi terakhir)
                    DataRow row = tiketData.Rows[0];

                    tbJudulFilmETiket.Text = $"Judul Film: {row["judul_film"]}";
                    tbRuanganETiket.Text = $"Ruangan: {row["nama_ruangan"]}";
                    tbKursiETiket.Text = $"Kursi: {row["nomor_kursi"]}";
                    tbWaktuTayang.Text = $"Waktu Tayang: {row["waktu_transaksi"]}";
                    tbTanggalTayang.Text = $"Tanggal Tayang: {row["tanggal_transaksi"]}";
                    tbMetodePembayaran.Text = $"Metode Pembayaran: {row["metode_pembayaran"]}";
                    tbTotalHarga.Text = $"Total Harga: Rp. {row["jumlah_pembayaran"]}";
                }
                else
                {
                    MessageBox.Show("Data transaksi tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
