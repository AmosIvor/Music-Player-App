namespace Music__Player.sources.Custom
{
    partial class Info__Song__Panel
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
            this.pnlBackground = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblFavorite = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnFavorite = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackground.Controls.Add(this.lblFavorite);
            this.pnlBackground.Controls.Add(this.btnFavorite);
            this.pnlBackground.Controls.Add(this.pbImage);
            this.pnlBackground.Controls.Add(this.lblDuration);
            this.pnlBackground.Controls.Add(this.lblTitle);
            this.pnlBackground.Controls.Add(this.lblArtist);
            this.pnlBackground.Controls.Add(this.lblNumber);
            this.pnlBackground.Controls.Add(this.btnPlay);
            this.pnlBackground.FillColor = System.Drawing.Color.White;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Radius = 5;
            this.pnlBackground.ShadowColor = System.Drawing.Color.Black;
            this.pnlBackground.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlBackground.Size = new System.Drawing.Size(702, 109);
            this.pnlBackground.TabIndex = 1;
            // 
            // lblFavorite
            // 
            this.lblFavorite.BackColor = System.Drawing.Color.Transparent;
            this.lblFavorite.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFavorite.ForeColor = System.Drawing.Color.Black;
            this.lblFavorite.Location = new System.Drawing.Point(561, 34);
            this.lblFavorite.Name = "lblFavorite";
            this.lblFavorite.Size = new System.Drawing.Size(40, 40);
            this.lblFavorite.TabIndex = 6;
            this.lblFavorite.Tag = "";
            this.lblFavorite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(618, 42);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(44, 20);
            this.lblDuration.TabIndex = 4;
            this.lblDuration.Text = "05:20";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(152, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Tag = "";
            this.lblTitle.Text = "Rockstar Rockstar";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoEllipsis = true;
            this.lblArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.ForeColor = System.Drawing.Color.DimGray;
            this.lblArtist.Location = new System.Drawing.Point(380, 42);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(155, 20);
            this.lblArtist.TabIndex = 1;
            this.lblArtist.Text = "Phan Mạnh Quỳnh";
            // 
            // lblNumber
            // 
            this.lblNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNumber.Location = new System.Drawing.Point(12, 34);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(40, 40);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Tag = "";
            this.lblNumber.Text = "01";
            this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btnFavorite.CheckedState.Image = global::Music__Player.Properties.Resources.icon_love_green;
            this.btnFavorite.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnFavorite.CheckedState.Parent = this.btnFavorite;
            this.btnFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite.HoverState.Image = global::Music__Player.Properties.Resources.icon_love_green;
            this.btnFavorite.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnFavorite.HoverState.Parent = this.btnFavorite;
            this.btnFavorite.Image = global::Music__Player.Properties.Resources.icon_love_black;
            this.btnFavorite.ImageSize = new System.Drawing.Size(24, 24);
            this.btnFavorite.Location = new System.Drawing.Point(561, 34);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.PressedState.Parent = this.btnFavorite;
            this.btnFavorite.Size = new System.Drawing.Size(40, 40);
            this.btnFavorite.TabIndex = 5;
            this.btnFavorite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFavorite_MouseClick);
            // 
            // pbImage
            // 
            this.pbImage.BorderRadius = 15;
            this.pbImage.Image = global::Music__Player.Properties.Resources.draft;
            this.pbImage.Location = new System.Drawing.Point(64, 18);
            this.pbImage.Name = "pbImage";
            this.pbImage.ShadowDecoration.Parent = this.pbImage;
            this.pbImage.Size = new System.Drawing.Size(78, 77);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 2;
            this.pbImage.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.CheckedState.Image = global::Music__Player.Properties.Resources.icon_play_blue;
            this.btnPlay.CheckedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPlay.CheckedState.Parent = this.btnPlay;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.HoverState.Image = global::Music__Player.Properties.Resources.icon_pause_blue;
            this.btnPlay.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPlay.HoverState.Parent = this.btnPlay;
            this.btnPlay.Image = global::Music__Player.Properties.Resources.icon_pause_blue;
            this.btnPlay.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPlay.Location = new System.Drawing.Point(12, 34);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PressedState.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPlay_MouseClick);
            // 
            // Info__Song__Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlBackground);
            this.Name = "Info__Song__Panel";
            this.Size = new System.Drawing.Size(702, 109);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlBackground;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblArtist;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlay;
        private Guna.UI2.WinForms.Guna2ImageButton btnFavorite;
        private System.Windows.Forms.Label lblFavorite;
    }
}
