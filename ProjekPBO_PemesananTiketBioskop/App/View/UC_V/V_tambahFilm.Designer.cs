﻿namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_tambahFilm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_tambahFilm));
            pbGambarFilm = new PictureBox();
            tbTambahJudul = new TextBox();
            tbTambahGenre = new TextBox();
            tbTambahSutradara = new TextBox();
            tbTambahProduksi = new TextBox();
            tbTambahAktor = new TextBox();
            tbTambahBatasUmur = new TextBox();
            btTambahSinopsis = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            dtTambahTanggalTayang = new DateTimePicker();
            tbTambahDurasi = new TextBox();
            tbTambahHarga = new TextBox();
            cbTambahStatus = new ComboBox();
            cbTambahRuangan = new ComboBox();
            btSimpanTambahFilm = new Button();
            cbWaktuTayang = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbGambarFilm).BeginInit();
            SuspendLayout();
            // 
            // pbGambarFilm
            // 
            pbGambarFilm.BackColor = Color.Transparent;
            pbGambarFilm.BackgroundImage = (Image)resources.GetObject("pbGambarFilm.BackgroundImage");
            pbGambarFilm.ErrorImage = null;
            pbGambarFilm.InitialImage = null;
            pbGambarFilm.Location = new Point(158, 166);
            pbGambarFilm.Margin = new Padding(2, 2, 2, 2);
            pbGambarFilm.Name = "pbGambarFilm";
            pbGambarFilm.Size = new Size(293, 425);
            pbGambarFilm.TabIndex = 0;
            pbGambarFilm.TabStop = false;
            pbGambarFilm.Click += pbGambarFilm_Click;
            // 
            // tbTambahJudul
            // 
            tbTambahJudul.BorderStyle = BorderStyle.None;
            tbTambahJudul.Font = new Font("Segoe UI", 12F);
            tbTambahJudul.Location = new Point(644, 230);
            tbTambahJudul.Margin = new Padding(2, 2, 2, 2);
            tbTambahJudul.Name = "tbTambahJudul";
            tbTambahJudul.Size = new Size(343, 27);
            tbTambahJudul.TabIndex = 1;
            // 
            // tbTambahGenre
            // 
            tbTambahGenre.BorderStyle = BorderStyle.None;
            tbTambahGenre.Font = new Font("Segoe UI", 12F);
            tbTambahGenre.Location = new Point(644, 346);
            tbTambahGenre.Margin = new Padding(2, 2, 2, 2);
            tbTambahGenre.Name = "tbTambahGenre";
            tbTambahGenre.Size = new Size(343, 27);
            tbTambahGenre.TabIndex = 2;
            // 
            // tbTambahSutradara
            // 
            tbTambahSutradara.BorderStyle = BorderStyle.None;
            tbTambahSutradara.Font = new Font("Segoe UI", 12F);
            tbTambahSutradara.Location = new Point(644, 461);
            tbTambahSutradara.Margin = new Padding(2, 2, 2, 2);
            tbTambahSutradara.Name = "tbTambahSutradara";
            tbTambahSutradara.Size = new Size(343, 27);
            tbTambahSutradara.TabIndex = 3;
            // 
            // tbTambahProduksi
            // 
            tbTambahProduksi.BorderStyle = BorderStyle.None;
            tbTambahProduksi.Font = new Font("Segoe UI", 12F);
            tbTambahProduksi.Location = new Point(644, 586);
            tbTambahProduksi.Margin = new Padding(2, 2, 2, 2);
            tbTambahProduksi.Name = "tbTambahProduksi";
            tbTambahProduksi.Size = new Size(343, 27);
            tbTambahProduksi.TabIndex = 4;
            // 
            // tbTambahAktor
            // 
            tbTambahAktor.BorderStyle = BorderStyle.None;
            tbTambahAktor.Font = new Font("Segoe UI", 12F);
            tbTambahAktor.Location = new Point(643, 695);
            tbTambahAktor.Margin = new Padding(2, 2, 2, 2);
            tbTambahAktor.Name = "tbTambahAktor";
            tbTambahAktor.Size = new Size(343, 27);
            tbTambahAktor.TabIndex = 5;
            // 
            // tbTambahBatasUmur
            // 
            tbTambahBatasUmur.BorderStyle = BorderStyle.None;
            tbTambahBatasUmur.Font = new Font("Segoe UI", 12F);
            tbTambahBatasUmur.Location = new Point(643, 808);
            tbTambahBatasUmur.Margin = new Padding(2, 2, 2, 2);
            tbTambahBatasUmur.Name = "tbTambahBatasUmur";
            tbTambahBatasUmur.Size = new Size(90, 27);
            tbTambahBatasUmur.TabIndex = 6;
            // 
            // btTambahSinopsis
            // 
            btTambahSinopsis.BackColor = Color.Transparent;
            btTambahSinopsis.FlatStyle = FlatStyle.Popup;
            btTambahSinopsis.Location = new Point(1000, 798);
            btTambahSinopsis.Margin = new Padding(2, 2, 2, 2);
            btTambahSinopsis.Name = "btTambahSinopsis";
            btTambahSinopsis.Size = new Size(58, 54);
            btTambahSinopsis.TabIndex = 7;
            btTambahSinopsis.UseVisualStyleBackColor = false;
            btTambahSinopsis.Click += btTambahSinopsis_Click;
            // 
            // dtTambahTanggalTayang
            // 
            dtTambahTanggalTayang.Font = new Font("Segoe UI", 12F);
            dtTambahTanggalTayang.Format = DateTimePickerFormat.Custom;
            dtTambahTanggalTayang.Location = new Point(1140, 339);
            dtTambahTanggalTayang.Margin = new Padding(2, 2, 2, 2);
            dtTambahTanggalTayang.Name = "dtTambahTanggalTayang";
            dtTambahTanggalTayang.Size = new Size(344, 34);
            dtTambahTanggalTayang.TabIndex = 8;
            dtTambahTanggalTayang.Value = new DateTime(2024, 11, 15, 0, 0, 0, 0);
            // 
            // tbTambahDurasi
            // 
            tbTambahDurasi.BorderStyle = BorderStyle.None;
            tbTambahDurasi.Font = new Font("Segoe UI", 12F);
            tbTambahDurasi.Location = new Point(1154, 461);
            tbTambahDurasi.Margin = new Padding(2, 2, 2, 2);
            tbTambahDurasi.Name = "tbTambahDurasi";
            tbTambahDurasi.Size = new Size(262, 27);
            tbTambahDurasi.TabIndex = 9;
            // 
            // tbTambahHarga
            // 
            tbTambahHarga.BorderStyle = BorderStyle.None;
            tbTambahHarga.Font = new Font("Segoe UI", 12F);
            tbTambahHarga.Location = new Point(1236, 577);
            tbTambahHarga.Margin = new Padding(2, 2, 2, 2);
            tbTambahHarga.Name = "tbTambahHarga";
            tbTambahHarga.Size = new Size(273, 27);
            tbTambahHarga.TabIndex = 10;
            // 
            // cbTambahStatus
            // 
            cbTambahStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTambahStatus.FlatStyle = FlatStyle.Flat;
            cbTambahStatus.Font = new Font("Segoe UI", 12F);
            cbTambahStatus.FormattingEnabled = true;
            cbTambahStatus.Items.AddRange(new object[] { "Sedang Tayang", "Tidak Tayang" });
            cbTambahStatus.Location = new Point(1140, 692);
            cbTambahStatus.Margin = new Padding(2, 2, 2, 2);
            cbTambahStatus.Name = "cbTambahStatus";
            cbTambahStatus.Size = new Size(344, 36);
            cbTambahStatus.TabIndex = 11;
            // 
            // cbTambahRuangan
            // 
            cbTambahRuangan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTambahRuangan.FlatStyle = FlatStyle.Flat;
            cbTambahRuangan.Font = new Font("Segoe UI", 12F);
            cbTambahRuangan.FormattingEnabled = true;
            cbTambahRuangan.Items.AddRange(new object[] { "Ruangan A", "Ruangan B", "Ruangan C" });
            cbTambahRuangan.Location = new Point(1140, 808);
            cbTambahRuangan.Margin = new Padding(2, 2, 2, 2);
            cbTambahRuangan.Name = "cbTambahRuangan";
            cbTambahRuangan.Size = new Size(344, 36);
            cbTambahRuangan.TabIndex = 13;
            // 
            // btSimpanTambahFilm
            // 
            btSimpanTambahFilm.BackColor = Color.Transparent;
            btSimpanTambahFilm.FlatStyle = FlatStyle.Popup;
            btSimpanTambahFilm.Location = new Point(883, 960);
            btSimpanTambahFilm.Margin = new Padding(2, 2, 2, 2);
            btSimpanTambahFilm.Name = "btSimpanTambahFilm";
            btSimpanTambahFilm.Size = new Size(361, 47);
            btSimpanTambahFilm.TabIndex = 14;
            btSimpanTambahFilm.Text = " ";
            btSimpanTambahFilm.UseVisualStyleBackColor = false;
            btSimpanTambahFilm.Click += btSimpanTambahFilm_Click;
            // 
            // cbWaktuTayang
            // 
            cbWaktuTayang.FlatStyle = FlatStyle.Flat;
            cbWaktuTayang.Font = new Font("Segoe UI", 12F);
            cbWaktuTayang.FormattingEnabled = true;
            cbWaktuTayang.Items.AddRange(new object[] { "09:00:00", "11:00:00", "13:00:00", "15:00:00", "17:00:00", "19:00:00", "22:00:00" });
            cbWaktuTayang.Location = new Point(1140, 227);
            cbWaktuTayang.Margin = new Padding(2, 2, 2, 2);
            cbWaktuTayang.Name = "cbWaktuTayang";
            cbWaktuTayang.Size = new Size(344, 36);
            cbWaktuTayang.TabIndex = 15;
            // 
            // V_tambahFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(cbWaktuTayang);
            Controls.Add(btSimpanTambahFilm);
            Controls.Add(cbTambahRuangan);
            Controls.Add(cbTambahStatus);
            Controls.Add(tbTambahHarga);
            Controls.Add(tbTambahDurasi);
            Controls.Add(dtTambahTanggalTayang);
            Controls.Add(btTambahSinopsis);
            Controls.Add(tbTambahBatasUmur);
            Controls.Add(tbTambahAktor);
            Controls.Add(tbTambahProduksi);
            Controls.Add(tbTambahSutradara);
            Controls.Add(tbTambahGenre);
            Controls.Add(tbTambahJudul);
            Controls.Add(pbGambarFilm);
            Margin = new Padding(2, 2, 2, 2);
            Name = "V_tambahFilm";
            Size = new Size(1920, 1080);
            Load += V_tambahFilm_Load;
            ((System.ComponentModel.ISupportInitialize)pbGambarFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbGambarFilm;
        private TextBox tbTambahJudul;
        private TextBox tbTambahGenre;
        private TextBox tbTambahSutradara;
        private TextBox tbTambahProduksi;
        private TextBox tbTambahAktor;
        private TextBox tbTambahBatasUmur;
        private Button btTambahSinopsis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private DateTimePicker dtTambahTanggalTayang;
        private TextBox tbTambahDurasi;
        private TextBox tbTambahHarga;
        private ComboBox cbTambahStatus;
        private ComboBox cbTambahRuangan;
        private Button btSimpanTambahFilm;
        private ComboBox cbWaktuTayang;
    }
}
