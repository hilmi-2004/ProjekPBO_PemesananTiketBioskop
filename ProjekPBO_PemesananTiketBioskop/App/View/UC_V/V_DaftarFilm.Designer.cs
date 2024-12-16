namespace ProjekPBO_PemesananTiketBioskop.App.View.UC_V
{
    partial class V_DaftarFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DaftarFilm));
            btTambahFilm = new Button();
            dgDaftarFilm = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgDaftarFilm).BeginInit();
            SuspendLayout();
            // 
            // btTambahFilm
            // 
            btTambahFilm.BackColor = Color.Transparent;
            btTambahFilm.FlatStyle = FlatStyle.Popup;
            btTambahFilm.Location = new Point(1295, 971);
            btTambahFilm.Margin = new Padding(2);
            btTambahFilm.Name = "btTambahFilm";
            btTambahFilm.Size = new Size(206, 50);
            btTambahFilm.TabIndex = 0;
            btTambahFilm.UseVisualStyleBackColor = false;
            btTambahFilm.Click += btTambahFilm_Click;
            // 
            // dgDaftarFilm
            // 
            dgDaftarFilm.BackgroundColor = SystemColors.Window;
            dgDaftarFilm.BorderStyle = BorderStyle.None;
            dgDaftarFilm.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgDaftarFilm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDaftarFilm.GridColor = SystemColors.WindowText;
            dgDaftarFilm.Location = new Point(272, 238);
            dgDaftarFilm.Margin = new Padding(2);
            dgDaftarFilm.Name = "dgDaftarFilm";
            dgDaftarFilm.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgDaftarFilm.Size = new Size(1153, 560);
            dgDaftarFilm.TabIndex = 1;
            dgDaftarFilm.CellContentClick += dgDaftarFilm_CellContentClick;
            // 
            // V_DaftarFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(dgDaftarFilm);
            Controls.Add(btTambahFilm);
            Margin = new Padding(2);
            Name = "V_DaftarFilm";
            Size = new Size(1920, 1080);
            Load += V_DaftarFilm_Load;
            ((System.ComponentModel.ISupportInitialize)dgDaftarFilm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btTambahFilm;
        private DataGridView dgDaftarFilm;
    }
}
