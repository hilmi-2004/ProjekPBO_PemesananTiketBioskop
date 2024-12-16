namespace ProjekPBO_PemesananTiketBioskop.App.View.UC_V
{
    partial class V_EditProfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_EditProfilAdmin));
            tbUsernameAdmin = new TextBox();
            tbEmailAdmin = new TextBox();
            tbPasswordAmin = new TextBox();
            tbNomorTeleponAdmin = new TextBox();
            btSimpanProfilAdmin = new Button();
            btBatalProfilAdmin = new Button();
            SuspendLayout();
            // 
            // tbUsernameAdmin
            // 
            tbUsernameAdmin.BorderStyle = BorderStyle.None;
            tbUsernameAdmin.Font = new Font("Segoe UI", 12F);
            tbUsernameAdmin.Location = new Point(634, 314);
            tbUsernameAdmin.Margin = new Padding(2, 2, 2, 2);
            tbUsernameAdmin.Name = "tbUsernameAdmin";
            tbUsernameAdmin.Size = new Size(343, 27);
            tbUsernameAdmin.TabIndex = 0;
            // 
            // tbEmailAdmin
            // 
            tbEmailAdmin.BorderStyle = BorderStyle.None;
            tbEmailAdmin.Font = new Font("Segoe UI", 12F);
            tbEmailAdmin.Location = new Point(634, 427);
            tbEmailAdmin.Margin = new Padding(2, 2, 2, 2);
            tbEmailAdmin.Name = "tbEmailAdmin";
            tbEmailAdmin.Size = new Size(343, 27);
            tbEmailAdmin.TabIndex = 1;
            // 
            // tbPasswordAmin
            // 
            tbPasswordAmin.BorderStyle = BorderStyle.None;
            tbPasswordAmin.Font = new Font("Segoe UI", 12F);
            tbPasswordAmin.Location = new Point(634, 546);
            tbPasswordAmin.Margin = new Padding(2, 2, 2, 2);
            tbPasswordAmin.Name = "tbPasswordAmin";
            tbPasswordAmin.Size = new Size(343, 27);
            tbPasswordAmin.TabIndex = 2;
            // 
            // tbNomorTeleponAdmin
            // 
            tbNomorTeleponAdmin.BorderStyle = BorderStyle.None;
            tbNomorTeleponAdmin.Font = new Font("Segoe UI", 12F);
            tbNomorTeleponAdmin.Location = new Point(634, 671);
            tbNomorTeleponAdmin.Margin = new Padding(2, 2, 2, 2);
            tbNomorTeleponAdmin.Name = "tbNomorTeleponAdmin";
            tbNomorTeleponAdmin.Size = new Size(343, 27);
            tbNomorTeleponAdmin.TabIndex = 3;
            // 
            // btSimpanProfilAdmin
            // 
            btSimpanProfilAdmin.BackColor = Color.Transparent;
            btSimpanProfilAdmin.FlatStyle = FlatStyle.Popup;
            btSimpanProfilAdmin.Location = new Point(869, 832);
            btSimpanProfilAdmin.Margin = new Padding(2, 2, 2, 2);
            btSimpanProfilAdmin.Name = "btSimpanProfilAdmin";
            btSimpanProfilAdmin.Size = new Size(192, 49);
            btSimpanProfilAdmin.TabIndex = 4;
            btSimpanProfilAdmin.UseVisualStyleBackColor = false;
            btSimpanProfilAdmin.Click += btSimpanProfilAdmin_Click;
            // 
            // btBatalProfilAdmin
            // 
            btBatalProfilAdmin.BackColor = Color.Transparent;
            btBatalProfilAdmin.FlatStyle = FlatStyle.Popup;
            btBatalProfilAdmin.Location = new Point(619, 832);
            btBatalProfilAdmin.Margin = new Padding(2, 2, 2, 2);
            btBatalProfilAdmin.Name = "btBatalProfilAdmin";
            btBatalProfilAdmin.Size = new Size(199, 49);
            btBatalProfilAdmin.TabIndex = 5;
            btBatalProfilAdmin.UseVisualStyleBackColor = false;
            btBatalProfilAdmin.Click += btBatalProfilAdmin_Click;
            // 
            // V_EditProfilAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btBatalProfilAdmin);
            Controls.Add(btSimpanProfilAdmin);
            Controls.Add(tbNomorTeleponAdmin);
            Controls.Add(tbPasswordAmin);
            Controls.Add(tbEmailAdmin);
            Controls.Add(tbUsernameAdmin);
            Margin = new Padding(2, 2, 2, 2);
            Name = "V_EditProfilAdmin";
            Size = new Size(1920, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsernameAdmin;
        private TextBox tbEmailAdmin;
        private TextBox tbPasswordAmin;
        private TextBox tbNomorTeleponAdmin;
        private Button btSimpanProfilAdmin;
        private Button btBatalProfilAdmin;
    }
}
