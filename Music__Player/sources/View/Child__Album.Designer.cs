namespace Music__Player.sources.Custom
{
    partial class Child__Album
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
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.songPlayingBottomBar = new Music__Player.sources.Custom.Song__Playing__BottomBar();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblNumberSong = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbAlbum = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fpnlSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBottom.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.songPlayingBottomBar);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 865);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.ShadowDecoration.Parent = this.pnlBottom;
            this.pnlBottom.Size = new System.Drawing.Size(1359, 100);
            this.pnlBottom.TabIndex = 4;
            // 
            // songPlayingBottomBar
            // 
            this.songPlayingBottomBar.BackColor = System.Drawing.Color.Transparent;
            this.songPlayingBottomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songPlayingBottomBar.IsPlay = false;
            this.songPlayingBottomBar.Location = new System.Drawing.Point(0, 0);
            this.songPlayingBottomBar.Name = "songPlayingBottomBar";
            this.songPlayingBottomBar.Size = new System.Drawing.Size(1359, 100);
            this.songPlayingBottomBar.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Lavender;
            this.guna2Panel2.Controls.Add(this.btnBack);
            this.guna2Panel2.Controls.Add(this.btnNext);
            this.guna2Panel2.Controls.Add(this.lblNumberSong);
            this.guna2Panel2.Controls.Add(this.lblTitle);
            this.guna2Panel2.Controls.Add(this.pbAlbum);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1359, 360);
            this.guna2Panel2.TabIndex = 5;
            // 
            // btnBack
            // 
            this.btnBack.CheckedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnBack.CheckedState.Parent = this.btnBack;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.btnBack.HoverState.Parent = this.btnBack;
            this.btnBack.Image = global::Music__Player.Properties.Resources.icon_back_blue;
            this.btnBack.ImageSize = new System.Drawing.Size(34, 34);
            this.btnBack.Location = new System.Drawing.Point(40, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnBack.PressedState.Parent = this.btnBack;
            this.btnBack.Size = new System.Drawing.Size(36, 36);
            this.btnBack.TabIndex = 5;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.CheckedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnNext.CheckedState.Parent = this.btnNext;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.HoverState.ImageSize = new System.Drawing.Size(36, 36);
            this.btnNext.HoverState.Parent = this.btnNext;
            this.btnNext.Image = global::Music__Player.Properties.Resources.icon_skip_blue;
            this.btnNext.ImageSize = new System.Drawing.Size(34, 34);
            this.btnNext.Location = new System.Drawing.Point(91, 18);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnNext.PressedState.Parent = this.btnNext;
            this.btnNext.Size = new System.Drawing.Size(36, 36);
            this.btnNext.TabIndex = 6;
            // 
            // lblNumberSong
            // 
            this.lblNumberSong.AutoSize = true;
            this.lblNumberSong.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberSong.Location = new System.Drawing.Point(339, 251);
            this.lblNumberSong.Name = "lblNumberSong";
            this.lblNumberSong.Size = new System.Drawing.Size(147, 38);
            this.lblNumberSong.TabIndex = 3;
            this.lblNumberSong.Text = "Amos Ivor";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(325, 130);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(470, 93);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Genre";
            // 
            // pbAlbum
            // 
            this.pbAlbum.BorderRadius = 20;
            this.pbAlbum.Image = global::Music__Player.Properties.Resources.draft;
            this.pbAlbum.Location = new System.Drawing.Point(40, 99);
            this.pbAlbum.Name = "pbAlbum";
            this.pbAlbum.ShadowDecoration.Parent = this.pbAlbum;
            this.pbAlbum.Size = new System.Drawing.Size(224, 224);
            this.pbAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAlbum.TabIndex = 1;
            this.pbAlbum.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fpnlSongs);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 360);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 505);
            this.panel1.TabIndex = 6;
            // 
            // fpnlSongs
            // 
            this.fpnlSongs.AutoScroll = true;
            this.fpnlSongs.AutoScrollMinSize = new System.Drawing.Size(1260, 339);
            this.fpnlSongs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlSongs.Location = new System.Drawing.Point(40, 131);
            this.fpnlSongs.Name = "fpnlSongs";
            this.fpnlSongs.Size = new System.Drawing.Size(1294, 341);
            this.fpnlSongs.TabIndex = 8;
            this.fpnlSongs.WrapContents = false;
            // 
            // Child__Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.pnlBottom);
            this.Name = "Child__Album";
            this.Size = new System.Drawing.Size(1359, 965);
            this.pnlBottom.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlbum)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Song__Playing__BottomBar songPlayingBottomBar;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private System.Windows.Forms.Label lblNumberSong;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbAlbum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fpnlSongs;
    }
}
