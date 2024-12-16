namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_ProfilPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ProfilPelanggan));
            lbUsernamePengguna = new Label();
            lbEmailPengguna = new Label();
            lbPasswordPengguna = new Label();
            lbNomorTeleponPengguna = new Label();
            btEditProdilPengguna = new Button();
            btKembaliProfilPengguna = new Button();
            SuspendLayout();
            // 
            // lbUsernamePengguna
            // 
            lbUsernamePengguna.AutoSize = true;
            lbUsernamePengguna.BackColor = Color.White;
            lbUsernamePengguna.Font = new Font("Segoe UI", 12F);
            lbUsernamePengguna.Location = new Point(800, 407);
            lbUsernamePengguna.Margin = new Padding(2, 0, 2, 0);
            lbUsernamePengguna.Name = "lbUsernamePengguna";
            lbUsernamePengguna.Size = new Size(99, 28);
            lbUsernamePengguna.TabIndex = 1;
            lbUsernamePengguna.Text = "Username";
            // 
            // lbEmailPengguna
            // 
            lbEmailPengguna.AutoSize = true;
            lbEmailPengguna.BackColor = Color.White;
            lbEmailPengguna.Font = new Font("Segoe UI", 12F);
            lbEmailPengguna.Location = new Point(800, 528);
            lbEmailPengguna.Margin = new Padding(2, 0, 2, 0);
            lbEmailPengguna.Name = "lbEmailPengguna";
            lbEmailPengguna.Size = new Size(59, 28);
            lbEmailPengguna.TabIndex = 2;
            lbEmailPengguna.Text = "Email";
            // 
            // lbPasswordPengguna
            // 
            lbPasswordPengguna.AutoSize = true;
            lbPasswordPengguna.BackColor = Color.White;
            lbPasswordPengguna.Font = new Font("Segoe UI", 12F);
            lbPasswordPengguna.Location = new Point(806, 648);
            lbPasswordPengguna.Margin = new Padding(2, 0, 2, 0);
            lbPasswordPengguna.Name = "lbPasswordPengguna";
            lbPasswordPengguna.Size = new Size(93, 28);
            lbPasswordPengguna.TabIndex = 3;
            lbPasswordPengguna.Text = "Password";
            // 
            // lbNomorTeleponPengguna
            // 
            lbNomorTeleponPengguna.AutoSize = true;
            lbNomorTeleponPengguna.BackColor = Color.White;
            lbNomorTeleponPengguna.Font = new Font("Segoe UI", 12F);
            lbNomorTeleponPengguna.Location = new Point(800, 766);
            lbNomorTeleponPengguna.Margin = new Padding(2, 0, 2, 0);
            lbNomorTeleponPengguna.Name = "lbNomorTeleponPengguna";
            lbNomorTeleponPengguna.Size = new Size(99, 28);
            lbNomorTeleponPengguna.TabIndex = 4;
            lbNomorTeleponPengguna.Text = "Username";
            // 
            // btEditProdilPengguna
            // 
            btEditProdilPengguna.BackColor = Color.Transparent;
            btEditProdilPengguna.FlatStyle = FlatStyle.Popup;
            btEditProdilPengguna.Location = new Point(1028, 919);
            btEditProdilPengguna.Margin = new Padding(2, 2, 2, 2);
            btEditProdilPengguna.Name = "btEditProdilPengguna";
            btEditProdilPengguna.Size = new Size(194, 44);
            btEditProdilPengguna.TabIndex = 5;
            btEditProdilPengguna.UseVisualStyleBackColor = false;
            btEditProdilPengguna.Click += btEditProdilPengguna_Click;
            // 
            // btKembaliProfilPengguna
            // 
            btKembaliProfilPengguna.BackColor = Color.Transparent;
            btKembaliProfilPengguna.FlatStyle = FlatStyle.Popup;
            btKembaliProfilPengguna.Location = new Point(784, 919);
            btKembaliProfilPengguna.Margin = new Padding(2, 2, 2, 2);
            btKembaliProfilPengguna.Name = "btKembaliProfilPengguna";
            btKembaliProfilPengguna.Size = new Size(194, 44);
            btKembaliProfilPengguna.TabIndex = 6;
            btKembaliProfilPengguna.UseVisualStyleBackColor = false;
            btKembaliProfilPengguna.Click += btKembaliProfilPengguna_Click;
            // 
            // V_ProfilPelanggan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(btKembaliProfilPengguna);
            Controls.Add(btEditProdilPengguna);
            Controls.Add(lbNomorTeleponPengguna);
            Controls.Add(lbPasswordPengguna);
            Controls.Add(lbEmailPengguna);
            Controls.Add(lbUsernamePengguna);
            Margin = new Padding(2, 2, 2, 2);
            Name = "V_ProfilPelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_ProfilPelanggan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsernamePengguna;
        private Label lbEmailPengguna;
        private Label lbPasswordPengguna;
        private Label lbNomorTeleponPengguna;
        private Button btEditProdilPengguna;
        private Button btKembaliProfilPengguna;
    }
}