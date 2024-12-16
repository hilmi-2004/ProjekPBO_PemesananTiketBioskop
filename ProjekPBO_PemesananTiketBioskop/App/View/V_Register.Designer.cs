namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Register));
            btLoginHalRegister = new Button();
            tbEmailRegister = new TextBox();
            tbUsernameRegister = new TextBox();
            tbNotelpRegister = new TextBox();
            tbPasswordRegister = new TextBox();
            btRegister = new Button();
            SuspendLayout();
            // 
            // btLoginHalRegister
            // 
            btLoginHalRegister.BackColor = Color.Transparent;
            btLoginHalRegister.FlatAppearance.BorderSize = 0;
            btLoginHalRegister.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btLoginHalRegister.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btLoginHalRegister.FlatStyle = FlatStyle.Flat;
            btLoginHalRegister.ForeColor = Color.Transparent;
            btLoginHalRegister.Location = new Point(1628, 974);
            btLoginHalRegister.Margin = new Padding(2);
            btLoginHalRegister.Name = "btLoginHalRegister";
            btLoginHalRegister.Size = new Size(58, 25);
            btLoginHalRegister.TabIndex = 0;
            btLoginHalRegister.UseVisualStyleBackColor = false;
            btLoginHalRegister.Click += btLoginHalRegister_Click;
            // 
            // tbEmailRegister
            // 
            tbEmailRegister.BorderStyle = BorderStyle.None;
            tbEmailRegister.Font = new Font("Segoe UI", 12F);
            tbEmailRegister.ForeColor = Color.Black;
            tbEmailRegister.Location = new Point(1334, 383);
            tbEmailRegister.Margin = new Padding(2);
            tbEmailRegister.Name = "tbEmailRegister";
            tbEmailRegister.Size = new Size(343, 27);
            tbEmailRegister.TabIndex = 1;
            // 
            // tbUsernameRegister
            // 
            tbUsernameRegister.BorderStyle = BorderStyle.None;
            tbUsernameRegister.Font = new Font("Segoe UI", 12F);
            tbUsernameRegister.ForeColor = Color.Black;
            tbUsernameRegister.Location = new Point(1334, 505);
            tbUsernameRegister.Margin = new Padding(2);
            tbUsernameRegister.Name = "tbUsernameRegister";
            tbUsernameRegister.Size = new Size(343, 27);
            tbUsernameRegister.TabIndex = 2;
            // 
            // tbNotelpRegister
            // 
            tbNotelpRegister.BorderStyle = BorderStyle.None;
            tbNotelpRegister.Font = new Font("Segoe UI", 12F);
            tbNotelpRegister.ForeColor = Color.Black;
            tbNotelpRegister.Location = new Point(1334, 625);
            tbNotelpRegister.Margin = new Padding(2);
            tbNotelpRegister.Name = "tbNotelpRegister";
            tbNotelpRegister.Size = new Size(343, 27);
            tbNotelpRegister.TabIndex = 3;
            // 
            // tbPasswordRegister
            // 
            tbPasswordRegister.BorderStyle = BorderStyle.None;
            tbPasswordRegister.Font = new Font("Segoe UI", 12F);
            tbPasswordRegister.ForeColor = Color.Black;
            tbPasswordRegister.Location = new Point(1334, 752);
            tbPasswordRegister.Margin = new Padding(2);
            tbPasswordRegister.Name = "tbPasswordRegister";
            tbPasswordRegister.Size = new Size(343, 27);
            tbPasswordRegister.TabIndex = 4;
            // 
            // btRegister
            // 
            btRegister.BackColor = Color.Transparent;
            btRegister.FlatAppearance.BorderSize = 0;
            btRegister.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btRegister.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btRegister.FlatStyle = FlatStyle.Popup;
            btRegister.ForeColor = Color.Transparent;
            btRegister.Location = new Point(1314, 835);
            btRegister.Margin = new Padding(2);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(446, 52);
            btRegister.TabIndex = 5;
            btRegister.UseVisualStyleBackColor = false;
            btRegister.Click += btRegister_Click;
            // 
            // V_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1902, 1033);
            Controls.Add(btRegister);
            Controls.Add(tbPasswordRegister);
            Controls.Add(tbNotelpRegister);
            Controls.Add(tbUsernameRegister);
            Controls.Add(tbEmailRegister);
            Controls.Add(btLoginHalRegister);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "V_Register";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLoginHalRegister;
        private TextBox tbEmailRegister;
        private TextBox tbUsernameRegister;
        private TextBox tbNotelpRegister;
        private TextBox tbPasswordRegister;
        private Button btRegister;
    }
}