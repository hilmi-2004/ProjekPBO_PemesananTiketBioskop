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
    public partial class V_RiwayatPemesanan : Form
    {
        public V_RiwayatPemesanan()
        {
            InitializeComponent();
            LoadDataTransaksi();
        }

        public void LoadDataTransaksi()
        {
            try
            {
                // Ambil data transaksi dari database
                DataTable dataTransaksi = C_RiwayatPemesanan.getTransaksi();

                // Set hasil data ke DataGridView
                dgvRiwayatPesanan.DataSource = dataTransaksi;

                // Konfigurasi DataGridView
                dgvRiwayatPesanan.AllowUserToAddRows = false;
                dgvRiwayatPesanan.RowHeadersVisible = false;

                // Set header text
                dgvRiwayatPesanan.Columns["Akun"].HeaderText = "Akun";
                dgvRiwayatPesanan.Columns["judul_film"].HeaderText = "Judul Film";
                dgvRiwayatPesanan.Columns["nama_ruangan"].HeaderText = "Ruangan";
                dgvRiwayatPesanan.Columns["nomor_kursi"].HeaderText = "Nomor Kursi";
                dgvRiwayatPesanan.Columns["jumlah_pembayaran"].HeaderText = "Total Harga";
                dgvRiwayatPesanan.Columns["waktu_transaksi"].HeaderText = "Waktu Transaksi";
                dgvRiwayatPesanan.Columns["tanggal_transaksi"].HeaderText = "Tanggal Transaksi";
                dgvRiwayatPesanan.Columns["id_metode"].HeaderText = "metode_id";

                // Gaya tampilan header
                dgvRiwayatPesanan.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
                dgvRiwayatPesanan.ColumnHeadersHeight = 30;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data transaksi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKembaliRiwayat_Click(object sender, EventArgs e)
        {
            V_HalPelanggan HalPelanggan = new V_HalPelanggan();
            this.Hide();
            HalPelanggan.Show();
        }
    }
}
