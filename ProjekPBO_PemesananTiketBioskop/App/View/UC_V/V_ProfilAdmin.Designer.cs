namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_ProfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ProfilAdmin));
            lbUsernameAdmin = new Label();
            lbEmailAdmin = new Label();
            lbPasswordAdmin = new Label();
            lbNomorTelp = new Label();
            btEditProfilAdmin = new Button();
            SuspendLayout();
            // 
            // lbUsernameAdmin
            // 
            lbUsernameAdmin.AutoSize = true;
            lbUsernameAdmin.BackColor = Color.White;
            lbUsernameAdmin.Font = new Font("Segoe UI", 12F);
            lbUsernameAdmin.Location = new Point(689, 320);
            lbUsernameAdmin.Margin = new Padding(2, 0, 2, 0);
            lbUsernameAdmin.Name = "lbUsernameAdmin";
            lbUsernameAdmin.Size = new Size(99, 28);
            lbUsernameAdmin.TabIndex = 0;
            lbUsernameAdmin.Text = "Username";
            // 
            // lbEmailAdmin
            // 
            lbEmailAdmin.AutoSize = true;
            lbEmailAdmin.BackColor = Color.White;
            lbEmailAdmin.Font = new Font("Segoe UI", 12F);
            lbEmailAdmin.Location = new Point(689, 432);
            lbEmailAdmin.Margin = new Padding(2, 0, 2, 0);
            lbEmailAdmin.Name = "lbEmailAdmin";
            lbEmailAdmin.Size = new Size(59, 28);
            lbEmailAdmin.TabIndex = 1;
            lbEmailAdmin.Text = "Email";
            // 
            // lbPasswordAdmin
            // 
            lbPasswordAdmin.AutoSize = true;
            lbPasswordAdmin.BackColor = Color.White;
            lbPasswordAdmin.Font = new Font("Segoe UI", 12F);
            lbPasswordAdmin.Location = new Point(689, 558);
            lbPasswordAdmin.Margin = new Padding(2, 0, 2, 0);
            lbPasswordAdmin.Name = "lbPasswordAdmin";
            lbPasswordAdmin.Size = new Size(93, 28);
            lbPasswordAdmin.TabIndex = 2;
            lbPasswordAdmin.Text = "Password";
            // 
            // lbNomorTelp
            // 
            lbNomorTelp.AutoSize = true;
            lbNomorTelp.BackColor = Color.White;
            lbNomorTelp.Font = new Font("Segoe UI", 12F);
            lbNomorTelp.Location = new Point(689, 675);
            lbNomorTelp.Margin = new Padding(2, 0, 2, 0);
            lbNomorTelp.Name = "lbNomorTelp";
            lbNomorTelp.Size = new Size(148, 28);
            lbNomorTelp.TabIndex = 3;
            lbNomorTelp.Text = "Nomor Telepon";
            // 
            // btEditProfilAdmin
            // 
            btEditProfilAdmin.BackColor = Color.Transparent;
            btEditProfilAdmin.FlatStyle = FlatStyle.Popup;
            btEditProfilAdmin.Location = new Point(809, 855);
            btEditProfilAdmin.Margin = new Padding(2, 2, 2, 2);
            btEditProfilAdmin.Name = "btEditProfilAdmin";
            btEditProfilAdmin.Size = new Size(166, 43);
            btEditProfilAdmin.TabIndex = 4;
            btEditProfilAdmin.UseVisualStyleBackColor = false;
            btEditProfilAdmin.Click += btEditProfilAdmin_Click;
            // 
            // V_ProfilAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btEditProfilAdmin);
            Controls.Add(lbNomorTelp);
            Controls.Add(lbPasswordAdmin);
            Controls.Add(lbEmailAdmin);
            Controls.Add(lbUsernameAdmin);
            Margin = new Padding(2, 2, 2, 2);
            Name = "V_ProfilAdmin";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsernameAdmin;
        private Label lbEmailAdmin;
        private Label lbPasswordAdmin;
        private Label lbNomorTelp;
        private Button btEditProfilAdmin;
    }
}
