using ProjekPBO_PemesananTiketBioskop.App.Context;
using ProjekPBO_PemesananTiketBioskop.App.Core;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    public partial class V_Pembayaran : Form
    {
        private int detailfilmID;
        private int filmId;
        private string nomorKursi;
        private int idDetailKursi;
        private int selectedMetodeId = 0;

        public V_Pembayaran(int detailfilmID, string nomorKursi, int filmId)
        {
            InitializeComponent();
            this.detailfilmID = detailfilmID;
            this.nomorKursi = nomorKursi;
            this.filmId = filmId;

            // Set Tag untuk setiap tombol
            btMandiri.Tag = 1;
            btBCA.Tag = 2;
            btBRI.Tag = 3;
            btJATIM.Tag = 4;
            btOVO.Tag = 5;
            btDANA.Tag = 6;

            // Daftarkan event handler untuk semua tombol
            btMandiri.Click += MetodePembayaran_Click;
            btBCA.Click += MetodePembayaran_Click;
            btBRI.Click += MetodePembayaran_Click;
            btJATIM.Click += MetodePembayaran_Click;
            btOVO.Click += MetodePembayaran_Click;
            btDANA.Click += MetodePembayaran_Click;

            // Pesan kursi dan simpan id_detail_kursi
            this.idDetailKursi = C_KursiPelanggan.PesanKursi(detailfilmID, nomorKursi);

            // Muat detail film untuk tampilan pembayaran
            LoadFilmDetail();
        }

        private void MetodePembayaran_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                selectedMetodeId = (int)button.Tag; // Ambil ID dari Tag
                HighlightSelectedButton(button); // Panggil metode untuk menyoroti tombol yang dipilih
            }
        }

        private void HighlightSelectedButton(Button selectedButton)
        {
            // Reset semua tombol ke warna default
            foreach (Control control in this.Controls)
            {
                if (control is Button button && button.Name.StartsWith("bt"))
                {
                    button.BackColor = SystemColors.Control; // Warna default
                }
            }
        }

        private void LoadFilmDetail()
        {
            try
            {
                // Ambil data film dan ruangan berdasarkan ID film
                var (film, ruangan, detailfilmId) = C_film.GetDataFilmAndRuangan(filmId);

                if (film != null)
                {
                    // Menampilkan detail film ke elemen UI
                    tbJudulFilm.Text = film.judul_film;
                    tbRuangan.Text = ruangan.nama_ruangan;
                    tbKursi.Text = nomorKursi;
                    tbTotalHarga.Text = $"Rp.{film.harga.ToString("N0")}";
                    tbJumblahUang.Text = "0";
                }
                else
                {
                    MessageBox.Show("Film tidak ditemukan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Tutup form jika film tidak ditemukan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data film: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBayarPembayaran_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedMetodeId == 0)
                {
                    MessageBox.Show("Pilih metode pembayaran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal jumlahUang;
                if (!decimal.TryParse(tbJumblahUang.Text, out jumlahUang))
                {
                    MessageBox.Show("Jumlah uang yang dimasukkan tidak valid!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal totalHarga = decimal.Parse(tbTotalHarga.Text.Replace("Rp.", "").Replace(",", "")); // Hilangkan format "Rp." dan koma

                if (jumlahUang < totalHarga)
                {
                    MessageBox.Show("Jumlah uang tidak cukup!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                M_Pembayaran pembayaran = new M_Pembayaran
                {
                    akun_id = userSession.CurrentUser.akun_id,
                    MetodeId = selectedMetodeId,
                    TotalHarga = totalHarga,
                    JumlahUang = jumlahUang,
                    Kursi = this.idDetailKursi,
                    waktu_transaksi = DateTime.Now,
                    tanggal_transaksi = DateTime.Now
                };

                MessageBox.Show($"Mencoba menyimpan pembayaran:\nMetode: {pembayaran.MetodeId}\nTotal: {pembayaran.TotalHarga}\nUang: {pembayaran.JumlahUang}");

                C_Pembayaran.AddPembayaran(pembayaran);

                MessageBox.Show($"Pembayaran selesai. Kursi {nomorKursi} berhasil dipesan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                V_E_TiketPelanggan HalTiket = new V_E_TiketPelanggan();
                this.Hide();
                HalTiket.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat menyelesaikan pembayaran: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKembaliPembayaran_Click(object sender, EventArgs e)
        {
            V_HalPelanggan HalPelanggan = new V_HalPelanggan();
            this.Hide();
            HalPelanggan.Show();
        }
    }
}

