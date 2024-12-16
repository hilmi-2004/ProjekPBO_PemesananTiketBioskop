namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_HalPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalPelanggan));
            btLogoutPelanggan = new Button();
            btRiwayatPelanggan = new Button();
            btProfilPelanggan = new Button();
            SuspendLayout();
            // 
            // btLogoutPelanggan
            // 
            btLogoutPelanggan.BackColor = Color.Transparent;
            btLogoutPelanggan.FlatAppearance.BorderSize = 0;
            btLogoutPelanggan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btLogoutPelanggan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btLogoutPelanggan.FlatStyle = FlatStyle.Flat;
            btLogoutPelanggan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btLogoutPelanggan.ForeColor = Color.Black;
            btLogoutPelanggan.Location = new Point(1200, 94);
            btLogoutPelanggan.Margin = new Padding(2);
            btLogoutPelanggan.Name = "btLogoutPelanggan";
            btLogoutPelanggan.Size = new Size(120, 37);
            btLogoutPelanggan.TabIndex = 1;
            btLogoutPelanggan.UseVisualStyleBackColor = false;
            btLogoutPelanggan.Click += btLogoutPelanggan_Click;
            // 
            // btRiwayatPelanggan
            // 
            btRiwayatPelanggan.BackColor = Color.Transparent;
            btRiwayatPelanggan.FlatAppearance.BorderSize = 0;
            btRiwayatPelanggan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btRiwayatPelanggan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btRiwayatPelanggan.FlatStyle = FlatStyle.Flat;
            btRiwayatPelanggan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btRiwayatPelanggan.ForeColor = Color.Black;
            btRiwayatPelanggan.Location = new Point(984, 94);
            btRiwayatPelanggan.Margin = new Padding(2);
            btRiwayatPelanggan.Name = "btRiwayatPelanggan";
            btRiwayatPelanggan.Size = new Size(127, 37);
            btRiwayatPelanggan.TabIndex = 2;
            btRiwayatPelanggan.UseVisualStyleBackColor = false;
            btRiwayatPelanggan.Click += btRiwayatPelanggan_Click;
            // 
            // btProfilPelanggan
            // 
            btProfilPelanggan.BackColor = Color.Transparent;
            btProfilPelanggan.FlatAppearance.BorderSize = 0;
            btProfilPelanggan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btProfilPelanggan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btProfilPelanggan.FlatStyle = FlatStyle.Flat;
            btProfilPelanggan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btProfilPelanggan.ForeColor = Color.Black;
            btProfilPelanggan.Location = new Point(804, 94);
            btProfilPelanggan.Margin = new Padding(2);
            btProfilPelanggan.Name = "btProfilPelanggan";
            btProfilPelanggan.Size = new Size(90, 37);
            btProfilPelanggan.TabIndex = 3;
            btProfilPelanggan.UseVisualStyleBackColor = false;
            btProfilPelanggan.Click += btProfilPelanggan_Click;
            // 
            // V_HalPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(btProfilPelanggan);
            Controls.Add(btRiwayatPelanggan);
            Controls.Add(btLogoutPelanggan);
            Margin = new Padding(2);
            Name = "V_HalPelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_HalPelanggan";
            ResumeLayout(false);
        }

        #endregion
        private Button btLogoutPelanggan;
        private Button btRiwayatPelanggan;
        private Button btProfilPelanggan;
    }
}