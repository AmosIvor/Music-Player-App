namespace Music__Player.sources.View
{
    partial class Child__Playlist
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblNumberSong = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbPlaylist = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.fpnlSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.list__Song__Playlist1 = new Music__Player.sources.Custom.List__Song__Playlist();
            this.songPlayingBottomBar = new Music__Player.sources.Custom.Song__Playing__BottomBar();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylist)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.fpnlSongs.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Panel1.Controls.Add(this.songPlayingBottomBar);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 865);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1359, 100);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Lavender;
            this.guna2Panel2.Controls.Add(this.btnBack);
            this.guna2Panel2.Controls.Add(this.btnNext);
            this.guna2Panel2.Controls.Add(this.lblNumberSong);
            this.guna2Panel2.Controls.Add(this.lblTitle);
            this.guna2Panel2.Controls.Add(this.pbPlaylist);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1359, 360);
            this.guna2Panel2.TabIndex = 2;
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
            this.lblNumberSong.Size = new System.Drawing.Size(272, 38);
            this.lblNumberSong.TabIndex = 3;
            this.lblNumberSong.Text = "Amos Ivor - 3 songs";
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
            this.lblTitle.Text = "Jerome Bell";
            // 
            // pbPlaylist
            // 
            this.pbPlaylist.BorderRadius = 20;
            this.pbPlaylist.Image = global::Music__Player.Properties.Resources.draft;
            this.pbPlaylist.Location = new System.Drawing.Point(40, 99);
            this.pbPlaylist.Name = "pbPlaylist";
            this.pbPlaylist.ShadowDecoration.Parent = this.pbPlaylist;
            this.pbPlaylist.Size = new System.Drawing.Size(224, 224);
            this.pbPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlaylist.TabIndex = 1;
            this.pbPlaylist.TabStop = false;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.Controls.Add(this.label4);
            this.guna2Panel3.Controls.Add(this.label1);
            this.guna2Panel3.Controls.Add(this.label6);
            this.guna2Panel3.Controls.Add(this.label2);
            this.guna2Panel3.Controls.Add(this.guna2Separator1);
            this.guna2Panel3.Controls.Add(this.fpnlSongs);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 360);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1359, 505);
            this.guna2Panel3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1157, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "DURATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(800, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "ALBUM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(487, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "ARTIST";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "#";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "TITLE";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(40, 121);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1273, 10);
            this.guna2Separator1.TabIndex = 8;
            // 
            // fpnlSongs
            // 
            this.fpnlSongs.AutoScroll = true;
            this.fpnlSongs.AutoScrollMinSize = new System.Drawing.Size(1260, 339);
            this.fpnlSongs.Controls.Add(this.list__Song__Playlist1);
            this.fpnlSongs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlSongs.Location = new System.Drawing.Point(40, 131);
            this.fpnlSongs.Name = "fpnlSongs";
            this.fpnlSongs.Size = new System.Drawing.Size(1294, 341);
            this.fpnlSongs.TabIndex = 7;
            this.fpnlSongs.WrapContents = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "List Songs";
            // 
            // list__Song__Playlist1
            // 
            this.list__Song__Playlist1.Artist = null;
            this.list__Song__Playlist1.BackColor = System.Drawing.Color.White;
            this.list__Song__Playlist1.Duration = null;
            this.list__Song__Playlist1.ID = null;
            this.list__Song__Playlist1.Image_Song = null;
            this.list__Song__Playlist1.IsAdd = false;
            this.list__Song__Playlist1.IsFavorite = false;
            this.list__Song__Playlist1.IsHovered = false;
            this.list__Song__Playlist1.IsOptioned = false;
            this.list__Song__Playlist1.IsSelected = false;
            this.list__Song__Playlist1.Location = new System.Drawing.Point(3, 0);
            this.list__Song__Playlist1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.list__Song__Playlist1.Name = "list__Song__Playlist1";
            this.list__Song__Playlist1.Name_Album = null;
            this.list__Song__Playlist1.Size = new System.Drawing.Size(1270, 70);
            this.list__Song__Playlist1.TabIndex = 0;
            this.list__Song__Playlist1.Title = null;
            this.list__Song__Playlist1.URL = null;
            // 
            // songPlayingBottomBar
            // 
            this.songPlayingBottomBar.BackColor = System.Drawing.Color.Transparent;
            this.songPlayingBottomBar.FlowLayoutPanel1 = null;
            this.songPlayingBottomBar.IsPlay = false;
            this.songPlayingBottomBar.ListSong = null;
            this.songPlayingBottomBar.Location = new System.Drawing.Point(0, 0);
            this.songPlayingBottomBar.Name = "songPlayingBottomBar";
            this.songPlayingBottomBar.PlayingSong = null;
            this.songPlayingBottomBar.Size = new System.Drawing.Size(1359, 100);
            this.songPlayingBottomBar.TabIndex = 0;
            // 
            // Child__Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Child__Playlist";
            this.Size = new System.Drawing.Size(1359, 965);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylist)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.fpnlSongs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblNumberSong;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbPlaylist;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label label3;
        private Custom.Song__Playing__BottomBar songPlayingBottomBar;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private System.Windows.Forms.FlowLayoutPanel fpnlSongs;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Custom.List__Song__Playlist list__Song__Playlist1;
    }
}
