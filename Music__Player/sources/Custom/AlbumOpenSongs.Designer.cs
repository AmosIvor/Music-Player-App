namespace Music__Player.sources.Custom
{
    partial class AlbumOpenSongs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNameAlbum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.songs_Display1 = new Music__Player.sources.Custom.Songs_Display();
            this.songs_Display2 = new Music__Player.sources.Custom.Songs_Display();
            this.songs_Display3 = new Music__Player.sources.Custom.Songs_Display();
            this.songs_Display4 = new Music__Player.sources.Custom.Songs_Display();
            this.songs_Display5 = new Music__Player.sources.Custom.Songs_Display();
            this.songs_Display6 = new Music__Player.sources.Custom.Songs_Display();
            this.song__Playing__BottomBar1 = new Music__Player.sources.Custom.Song__Playing__BottomBar();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNameAlbum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2PictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 188);
            this.panel1.TabIndex = 1;
            // 
            // lbNameAlbum
            // 
            this.lbNameAlbum.AutoSize = true;
            this.lbNameAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameAlbum.Location = new System.Drawing.Point(231, 73);
            this.lbNameAlbum.Name = "lbNameAlbum";
            this.lbNameAlbum.Size = new System.Drawing.Size(232, 42);
            this.lbNameAlbum.TabIndex = 2;
            this.lbNameAlbum.Text = "Name Album";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compilation";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = global::Music__Player.Properties.Resources.draft;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(204, 188);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.songs_Display1);
            this.flowLayoutPanel1.Controls.Add(this.songs_Display2);
            this.flowLayoutPanel1.Controls.Add(this.songs_Display3);
            this.flowLayoutPanel1.Controls.Add(this.songs_Display4);
            this.flowLayoutPanel1.Controls.Add(this.songs_Display5);
            this.flowLayoutPanel1.Controls.Add(this.songs_Display6);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 289);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1184, 560);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // songs_Display1
            // 
            this.songs_Display1.Album = null;
            this.songs_Display1.Artist = null;
            this.songs_Display1.BackColor = System.Drawing.Color.Transparent;
            this.songs_Display1.Duration = null;
            this.songs_Display1.Id = null;
            this.songs_Display1.ImageSong = null;
            this.songs_Display1.IsSelectedSong = false;
            this.songs_Display1.Location = new System.Drawing.Point(34, 3);
            this.songs_Display1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.songs_Display1.Name = "songs_Display1";
            this.songs_Display1.NameSong = null;
            this.songs_Display1.PlayingBottomBar = null;
            this.songs_Display1.Size = new System.Drawing.Size(1126, 84);
            this.songs_Display1.TabIndex = 0;
            this.songs_Display1.URL = null;
            // 
            // songs_Display2
            // 
            this.songs_Display2.Album = null;
            this.songs_Display2.Artist = null;
            this.songs_Display2.BackColor = System.Drawing.Color.Transparent;
            this.songs_Display2.Duration = null;
            this.songs_Display2.Id = null;
            this.songs_Display2.ImageSong = null;
            this.songs_Display2.IsSelectedSong = false;
            this.songs_Display2.Location = new System.Drawing.Point(34, 100);
            this.songs_Display2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.songs_Display2.Name = "songs_Display2";
            this.songs_Display2.NameSong = null;
            this.songs_Display2.PlayingBottomBar = null;
            this.songs_Display2.Size = new System.Drawing.Size(1126, 84);
            this.songs_Display2.TabIndex = 1;
            this.songs_Display2.URL = null;
            // 
            // songs_Display3
            // 
            this.songs_Display3.Album = null;
            this.songs_Display3.Artist = null;
            this.songs_Display3.BackColor = System.Drawing.Color.Transparent;
            this.songs_Display3.Duration = null;
            this.songs_Display3.Id = null;
            this.songs_Display3.ImageSong = null;
            this.songs_Display3.IsSelectedSong = false;
            this.songs_Display3.Location = new System.Drawing.Point(34, 197);
            this.songs_Display3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.songs_Display3.Name = "songs_Display3";
            this.songs_Display3.NameSong = null;
            this.songs_Display3.PlayingBottomBar = null;
            this.songs_Display3.Size = new System.Drawing.Size(1126, 84);
            this.songs_Display3.TabIndex = 2;
            this.songs_Display3.URL = null;
            // 
            // songs_Display4
            // 
            this.songs_Display4.Album = null;
            this.songs_Display4.Artist = null;
            this.songs_Display4.BackColor = System.Drawing.Color.Transparent;
            this.songs_Display4.Duration = null;
            this.songs_Display4.Id = null;
            this.songs_Display4.ImageSong = null;
            this.songs_Display4.IsSelectedSong = false;
            this.songs_Display4.Location = new System.Drawing.Point(34, 294);
            this.songs_Display4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.songs_Display4.Name = "songs_Display4";
            this.songs_Display4.NameSong = null;
            this.songs_Display4.PlayingBottomBar = null;
            this.songs_Display4.Size = new System.Drawing.Size(1126, 84);
            this.songs_Display4.TabIndex = 3;
            this.songs_Display4.URL = null;
            // 
            // songs_Display5
            // 
            this.songs_Display5.Album = null;
            this.songs_Display5.Artist = null;
            this.songs_Display5.BackColor = System.Drawing.Color.Transparent;
            this.songs_Display5.Duration = null;
            this.songs_Display5.Id = null;
            this.songs_Display5.ImageSong = null;
            this.songs_Display5.IsSelectedSong = false;
            this.songs_Display5.Location = new System.Drawing.Point(34, 391);
            this.songs_Display5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.songs_Display5.Name = "songs_Display5";
            this.songs_Display5.NameSong = null;
            this.songs_Display5.PlayingBottomBar = null;
            this.songs_Display5.Size = new System.Drawing.Size(1126, 84);
            this.songs_Display5.TabIndex = 4;
            this.songs_Display5.URL = null;
            // 
            // songs_Display6
            // 
            this.songs_Display6.Album = null;
            this.songs_Display6.Artist = null;
            this.songs_Display6.BackColor = System.Drawing.Color.Transparent;
            this.songs_Display6.Duration = null;
            this.songs_Display6.Id = null;
            this.songs_Display6.ImageSong = null;
            this.songs_Display6.IsSelectedSong = false;
            this.songs_Display6.Location = new System.Drawing.Point(34, 488);
            this.songs_Display6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.songs_Display6.Name = "songs_Display6";
            this.songs_Display6.NameSong = null;
            this.songs_Display6.PlayingBottomBar = null;
            this.songs_Display6.Size = new System.Drawing.Size(1126, 84);
            this.songs_Display6.TabIndex = 5;
            this.songs_Display6.URL = null;
            // 
            // song__Playing__BottomBar1
            // 
            this.song__Playing__BottomBar1.BackColor = System.Drawing.Color.Transparent;
            this.song__Playing__BottomBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.song__Playing__BottomBar1.IsPlay = false;
            this.song__Playing__BottomBar1.Location = new System.Drawing.Point(0, 865);
            this.song__Playing__BottomBar1.Name = "song__Playing__BottomBar1";
            this.song__Playing__BottomBar1.Size = new System.Drawing.Size(1359, 100);
            this.song__Playing__BottomBar1.SongPlaying = null;
            this.song__Playing__BottomBar1.TabIndex = 0;
            // 
            // AlbumOpenSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.song__Playing__BottomBar1);
            this.Name = "AlbumOpenSongs";
            this.Size = new System.Drawing.Size(1359, 965);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Song__Playing__BottomBar song__Playing__BottomBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNameAlbum;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Songs_Display songs_Display1;
        private Songs_Display songs_Display2;
        private Songs_Display songs_Display3;
        private Songs_Display songs_Display4;
        private Songs_Display songs_Display5;
        private Songs_Display songs_Display6;
    }
}
