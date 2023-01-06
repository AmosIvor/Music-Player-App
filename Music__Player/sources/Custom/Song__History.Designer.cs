namespace Music__Player.sources.Custom
{
    partial class Song__History
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
            this.pnlBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.lblPlay = new System.Windows.Forms.Label();
            this.btnPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnFavorite = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackground.Controls.Add(this.pbImage);
            this.pnlBackground.Controls.Add(this.lblDate);
            this.pnlBackground.Controls.Add(this.lblDuration);
            this.pnlBackground.Controls.Add(this.lblAlbum);
            this.pnlBackground.Controls.Add(this.lblArtist);
            this.pnlBackground.Controls.Add(this.lblTitle);
            this.pnlBackground.Controls.Add(this.lblFavorite);
            this.pnlBackground.Controls.Add(this.lblPlay);
            this.pnlBackground.Controls.Add(this.btnPlay);
            this.pnlBackground.Controls.Add(this.btnFavorite);
            this.pnlBackground.FillColor = System.Drawing.Color.Transparent;
            this.pnlBackground.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.ShadowDecoration.Parent = this.pnlBackground;
            this.pnlBackground.Size = new System.Drawing.Size(1270, 70);
            this.pnlBackground.TabIndex = 1;
            // 
            // pbImage
            // 
            this.pbImage.BorderRadius = 10;
            this.pbImage.Image = global::Music__Player.Properties.Resources.draft;
            this.pbImage.Location = new System.Drawing.Point(50, 6);
            this.pbImage.Name = "pbImage";
            this.pbImage.ShadowDecoration.Parent = this.pbImage;
            this.pbImage.Size = new System.Drawing.Size(60, 59);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 3;
            this.pbImage.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(1067, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(200, 25);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "20 September 2022";
            // 
            // lblDuration
            // 
            this.lblDuration.Location = new System.Drawing.Point(972, 23);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(59, 25);
            this.lblDuration.TabIndex = 0;
            this.lblDuration.Text = "03:14";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoEllipsis = true;
            this.lblAlbum.Location = new System.Drawing.Point(618, 23);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(250, 25);
            this.lblAlbum.TabIndex = 0;
            this.lblAlbum.Text = "Ivvro AmosVu";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoEllipsis = true;
            this.lblArtist.Location = new System.Drawing.Point(396, 23);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(200, 25);
            this.lblArtist.TabIndex = 0;
            this.lblArtist.Text = "Amos Ivor";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(124, 23);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(250, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Tran Tuan Vu";
            // 
            // lblFavorite
            // 
            this.lblFavorite.BackColor = System.Drawing.Color.Transparent;
            this.lblFavorite.Location = new System.Drawing.Point(904, 19);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(32, 32);
            this.lblFavorite.TabIndex = 0;
            this.lblFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlay
            // 
            this.lblPlay.Location = new System.Drawing.Point(4, 19);
            this.lblPlay.Name = "lblPlay";
            this.lblPlay.Size = new System.Drawing.Size(32, 32);
            this.lblPlay.TabIndex = 0;
            this.lblPlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlay
            // 
            this.btnPlay.CheckedState.Image = global::Music__Player.Properties.Resources.icon_play_blue;
            this.btnPlay.CheckedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnPlay.CheckedState.Parent = this.btnPlay;
            this.btnPlay.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlay.HoverState.Parent = this.btnPlay;
            this.btnPlay.Image = global::Music__Player.Properties.Resources.icon_pause_blue;
            this.btnPlay.ImageSize = new System.Drawing.Size(26, 26);
            this.btnPlay.Location = new System.Drawing.Point(4, 19);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnPlay.PressedState.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(32, 32);
            this.btnPlay.TabIndex = 2;
            // 
            // btnFavorite
            // 
            this.btnFavorite.CheckedState.Image = global::Music__Player.Properties.Resources.icon_love_green;
            this.btnFavorite.CheckedState.Parent = this.btnFavorite;
            this.btnFavorite.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnFavorite.HoverState.Parent = this.btnFavorite;
            this.btnFavorite.Image = global::Music__Player.Properties.Resources.icon_love_black;
            this.btnFavorite.Location = new System.Drawing.Point(904, 19);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.PressedState.Parent = this.btnFavorite;
            this.btnFavorite.Size = new System.Drawing.Size(32, 32);
            this.btnFavorite.TabIndex = 1;
            // 
            // Song__History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.pnlBackground);
            this.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.Name = "Song__History";
            this.Size = new System.Drawing.Size(1270, 70);
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBackground;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFavorite;
        private System.Windows.Forms.Label lblPlay;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlay;
        private Guna.UI2.WinForms.Guna2ImageButton btnFavorite;
        private System.Windows.Forms.Label lblDate;
    }
}
