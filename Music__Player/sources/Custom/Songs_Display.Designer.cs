namespace Music__Player.sources.Custom
{
    partial class Songs_Display
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.lbTimeSong = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbNameSong = new System.Windows.Forms.Label();
            this.pbImageSong = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbId = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSong)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lbAlbum);
            this.guna2ShadowPanel1.Controls.Add(this.lbTimeSong);
            this.guna2ShadowPanel1.Controls.Add(this.lbArtist);
            this.guna2ShadowPanel1.Controls.Add(this.lbNameSong);
            this.guna2ShadowPanel1.Controls.Add(this.pbImageSong);
            this.guna2ShadowPanel1.Controls.Add(this.lbId);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1123, 81);
            this.guna2ShadowPanel1.TabIndex = 8;
            // 
            // lbAlbum
            // 
            this.lbAlbum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlbum.Location = new System.Drawing.Point(880, 29);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(199, 23);
            this.lbAlbum.TabIndex = 13;
            this.lbAlbum.Text = "Album";
            // 
            // lbTimeSong
            // 
            this.lbTimeSong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeSong.Location = new System.Drawing.Point(787, 29);
            this.lbTimeSong.Name = "lbTimeSong";
            this.lbTimeSong.Size = new System.Drawing.Size(50, 23);
            this.lbTimeSong.TabIndex = 12;
            this.lbTimeSong.Text = "3:40";
            // 
            // lbArtist
            // 
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtist.Location = new System.Drawing.Point(584, 29);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(160, 23);
            this.lbArtist.TabIndex = 11;
            this.lbArtist.Text = "Nhạc sĩ";
            // 
            // lbNameSong
            // 
            this.lbNameSong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSong.Location = new System.Drawing.Point(203, 29);
            this.lbNameSong.Name = "lbNameSong";
            this.lbNameSong.Size = new System.Drawing.Size(338, 23);
            this.lbNameSong.TabIndex = 10;
            this.lbNameSong.Text = "Đây là 1 bài hát ";
            // 
            // pbImageSong
            // 
            this.pbImageSong.BorderRadius = 15;
            this.pbImageSong.Image = global::Music__Player.Properties.Resources.draft;
            this.pbImageSong.Location = new System.Drawing.Point(97, 2);
            this.pbImageSong.Name = "pbImageSong";
            this.pbImageSong.ShadowDecoration.Parent = this.pbImageSong;
            this.pbImageSong.Size = new System.Drawing.Size(63, 71);
            this.pbImageSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImageSong.TabIndex = 9;
            this.pbImageSong.TabStop = false;
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.Transparent;
            this.lbId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.Black;
            this.lbId.Location = new System.Drawing.Point(14, 21);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(40, 40);
            this.lbId.TabIndex = 8;
            this.lbId.Tag = "";
            this.lbId.Text = "01";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Songs_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "Songs_Display";
            this.Size = new System.Drawing.Size(1126, 84);
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.Label lbTimeSong;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbNameSong;
        private Guna.UI2.WinForms.Guna2PictureBox pbImageSong;
        private System.Windows.Forms.Label lbId;
    }
}
