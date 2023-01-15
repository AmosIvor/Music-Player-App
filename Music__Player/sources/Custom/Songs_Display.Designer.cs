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
            this.ShadowPanelSong = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.picturePlaySong = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.lbTimeSong = new System.Windows.Forms.Label();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbNameSong = new System.Windows.Forms.Label();
            this.pbImageSong = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbId = new System.Windows.Forms.Label();
            this.ShadowPanelSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlaySong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSong)).BeginInit();
            this.SuspendLayout();
            // 
            // ShadowPanelSong
            // 
            this.ShadowPanelSong.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanelSong.Controls.Add(this.picturePlaySong);
            this.ShadowPanelSong.Controls.Add(this.pictureBox1);
            this.ShadowPanelSong.Controls.Add(this.lbAlbum);
            this.ShadowPanelSong.Controls.Add(this.lbTimeSong);
            this.ShadowPanelSong.Controls.Add(this.lbArtist);
            this.ShadowPanelSong.Controls.Add(this.lbNameSong);
            this.ShadowPanelSong.Controls.Add(this.pbImageSong);
            this.ShadowPanelSong.Controls.Add(this.lbId);
            this.ShadowPanelSong.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ShadowPanelSong.Location = new System.Drawing.Point(9, 3);
            this.ShadowPanelSong.Name = "ShadowPanelSong";
            this.ShadowPanelSong.Radius = 5;
            this.ShadowPanelSong.ShadowColor = System.Drawing.Color.Black;
            this.ShadowPanelSong.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.ShadowPanelSong.Size = new System.Drawing.Size(1120, 81);
            this.ShadowPanelSong.TabIndex = 8;
            this.ShadowPanelSong.Click += new System.EventHandler(this.lbTimeSong_Click);
            this.ShadowPanelSong.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.ShadowPanelSong.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            // 
            // picturePlaySong
            // 
            this.picturePlaySong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picturePlaySong.Image = global::Music__Player.Properties.Resources.icon_pause_blue;
            this.picturePlaySong.Location = new System.Drawing.Point(30, 14);
            this.picturePlaySong.Name = "picturePlaySong";
            this.picturePlaySong.Size = new System.Drawing.Size(48, 50);
            this.picturePlaySong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePlaySong.TabIndex = 15;
            this.picturePlaySong.TabStop = false;
            this.picturePlaySong.Visible = false;
            this.picturePlaySong.Click += new System.EventHandler(this.lbTimeSong_Click);
            this.picturePlaySong.DoubleClick += new System.EventHandler(this.lbTimeSong_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::Music__Player.Properties.Resources.icon_love_black;
            this.pictureBox1.Location = new System.Drawing.Point(930, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // lbAlbum
            // 
            this.lbAlbum.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbAlbum.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlbum.Location = new System.Drawing.Point(724, 27);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(199, 25);
            this.lbAlbum.TabIndex = 13;
            this.lbAlbum.Text = "Album";
            this.lbAlbum.Click += new System.EventHandler(this.lbTimeSong_Click);
            this.lbAlbum.DoubleClick += new System.EventHandler(this.lbTimeSong_Click);
            this.lbAlbum.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.lbAlbum.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            // 
            // lbTimeSong
            // 
            this.lbTimeSong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTimeSong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeSong.Location = new System.Drawing.Point(1003, 29);
            this.lbTimeSong.Name = "lbTimeSong";
            this.lbTimeSong.Size = new System.Drawing.Size(65, 20);
            this.lbTimeSong.TabIndex = 12;
            this.lbTimeSong.Text = "3:40";
            this.lbTimeSong.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbTimeSong.Click += new System.EventHandler(this.lbTimeSong_Click);
            this.lbTimeSong.DoubleClick += new System.EventHandler(this.lbTimeSong_Click);
            this.lbTimeSong.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.lbTimeSong.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            // 
            // lbArtist
            // 
            this.lbArtist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbArtist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtist.Location = new System.Drawing.Point(480, 29);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(160, 23);
            this.lbArtist.TabIndex = 11;
            this.lbArtist.Text = "Nhạc sĩ";
            this.lbArtist.Click += new System.EventHandler(this.lbTimeSong_Click);
            this.lbArtist.DoubleClick += new System.EventHandler(this.lbTimeSong_Click);
            this.lbArtist.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.lbArtist.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            // 
            // lbNameSong
            // 
            this.lbNameSong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbNameSong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSong.Location = new System.Drawing.Point(203, 29);
            this.lbNameSong.Name = "lbNameSong";
            this.lbNameSong.Size = new System.Drawing.Size(271, 23);
            this.lbNameSong.TabIndex = 10;
            this.lbNameSong.Text = "Đây là 1 bài hát ";
            this.lbNameSong.Click += new System.EventHandler(this.lbTimeSong_Click);
            this.lbNameSong.DoubleClick += new System.EventHandler(this.lbTimeSong_Click);
            this.lbNameSong.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.lbNameSong.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
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
            this.pbImageSong.Click += new System.EventHandler(this.lbTimeSong_Click);
            this.pbImageSong.DoubleClick += new System.EventHandler(this.lbTimeSong_Click);
            this.pbImageSong.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.pbImageSong.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            // 
            // lbId
            // 
            this.lbId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.Black;
            this.lbId.Location = new System.Drawing.Point(38, 21);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(40, 40);
            this.lbId.TabIndex = 8;
            this.lbId.Tag = "";
            this.lbId.Text = "01";
            this.lbId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbId.Click += new System.EventHandler(this.lbTimeSong_Click);
            this.lbId.DoubleClick += new System.EventHandler(this.lbTimeSong_Click);
            this.lbId.MouseEnter += new System.EventHandler(this.HandleMouseEnter);
            this.lbId.MouseLeave += new System.EventHandler(this.HandleMouseLeave);
            // 
            // Songs_Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ShadowPanelSong);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = "Songs_Display";
            this.Size = new System.Drawing.Size(1126, 84);
            this.ShadowPanelSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picturePlaySong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanelSong;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.Label lbTimeSong;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbNameSong;
        private Guna.UI2.WinForms.Guna2PictureBox pbImageSong;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picturePlaySong;
    }
}
