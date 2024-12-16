namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_RiwayatPemesanan
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button btKembaliRiwayat;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RiwayatPemesanan));
            dgvRiwayatPesanan = new DataGridView();
            btKembaliRiwayat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPesanan).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayatPesanan
            // 
            dgvRiwayatPesanan.BackgroundColor = Color.White;
            dgvRiwayatPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatPesanan.Location = new Point(188, 182);
            dgvRiwayatPesanan.Margin = new Padding(2);
            dgvRiwayatPesanan.Name = "dgvRiwayatPesanan";
            dgvRiwayatPesanan.RowHeadersWidth = 62;
            dgvRiwayatPesanan.Size = new Size(1316, 671);
            dgvRiwayatPesanan.TabIndex = 0;
            // 
            // btKembaliRiwayat
            // 
            btKembaliRiwayat.BackColor = Color.Transparent;
            btKembaliRiwayat.FlatStyle = FlatStyle.Flat;
            btKembaliRiwayat.ForeColor = Color.Transparent;
            btKembaliRiwayat.Location = new Point(1592, 974);
            btKembaliRiwayat.Name = "btKembaliRiwayat";
            btKembaliRiwayat.Size = new Size(191, 44);
            btKembaliRiwayat.TabIndex = 1;
            btKembaliRiwayat.UseVisualStyleBackColor = false;
            btKembaliRiwayat.Click += btKembaliRiwayat_Click;
            // 
            // V_RiwayatPemesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(btKembaliRiwayat);
            Controls.Add(dgvRiwayatPesanan);
            Margin = new Padding(2);
            Name = "V_RiwayatPemesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_RiwayatPemesanan";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPesanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRiwayatPesanan;
        private Button btKembaliRiwayat;
    }
}