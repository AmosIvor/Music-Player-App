namespace Music__Player.sources.View
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.panelHome = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlTest = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblCountFpanelsSong = new System.Windows.Forms.Label();
            this.fpanelArtists = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSongPlaying = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnAddPlaylist = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbPlaying = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblArtistPlaying = new System.Windows.Forms.Label();
            this.lblTitlePlaying = new System.Windows.Forms.Label();
            this.guna2ImageButton5 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnRepeat = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnSkip = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.sliderTimeMusic = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fpanelSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.timerMusic = new System.Windows.Forms.Timer(this.components);
            this.dropdown__Playlist1 = new Music__Player.sources.Custom.Dropdown__Playlist();
            this.artist__Panel7 = new Music__Player.sources.Custom.Artist__Panel();
            this.artist__Panel9 = new Music__Player.sources.Custom.Artist__Panel();
            this.artist__Panel8 = new Music__Player.sources.Custom.Artist__Panel();
            this.artist__Panel10 = new Music__Player.sources.Custom.Artist__Panel();
            this.artist__Panel11 = new Music__Player.sources.Custom.Artist__Panel();
            this.info__Song__Panel10 = new Music__Player.sources.Custom.Info__Song__Panel();
            this.info__Song__Panel6 = new Music__Player.sources.Custom.Info__Song__Panel();
            this.info__Song__Panel7 = new Music__Player.sources.Custom.Info__Song__Panel();
            this.info__Song__Panel8 = new Music__Player.sources.Custom.Info__Song__Panel();
            this.info__Song__Panel9 = new Music__Player.sources.Custom.Info__Song__Panel();
            this.panelHome.SuspendLayout();
            this.pnlTest.SuspendLayout();
            this.fpanelArtists.SuspendLayout();
            this.pnlSongPlaying.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaying)).BeginInit();
            this.fpanelSongs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHome
            // 
            this.panelHome.AutoScroll = true;
            this.panelHome.Controls.Add(this.pnlTest);
            this.panelHome.Controls.Add(this.btnExit);
            this.panelHome.Controls.Add(this.lblCountFpanelsSong);
            this.panelHome.Controls.Add(this.fpanelArtists);
            this.panelHome.Controls.Add(this.pnlSongPlaying);
            this.panelHome.Controls.Add(this.label12);
            this.panelHome.Controls.Add(this.label8);
            this.panelHome.Controls.Add(this.label3);
            this.panelHome.Controls.Add(this.fpanelSongs);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.panelHome.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.panelHome.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelHome.Location = new System.Drawing.Point(0, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.ShadowDecoration.Parent = this.panelHome;
            this.panelHome.Size = new System.Drawing.Size(1359, 965);
            this.panelHome.TabIndex = 3;
            // 
            // pnlTest
            // 
            this.pnlTest.BackColor = System.Drawing.Color.Transparent;
            this.pnlTest.Controls.Add(this.dropdown__Playlist1);
            this.pnlTest.FillColor = System.Drawing.Color.White;
            this.pnlTest.Location = new System.Drawing.Point(513, 470);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.ShadowColor = System.Drawing.Color.Black;
            this.pnlTest.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlTest.Size = new System.Drawing.Size(293, 280);
            this.pnlTest.TabIndex = 7;
            this.pnlTest.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(38, 38);
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Image = global::Music__Player.Properties.Resources.icon_power_black;
            this.btnExit.ImageSize = new System.Drawing.Size(34, 34);
            this.btnExit.Location = new System.Drawing.Point(1213, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnExit.PressedState.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(44, 44);
            this.btnExit.TabIndex = 11;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCountFpanelsSong
            // 
            this.lblCountFpanelsSong.AutoSize = true;
            this.lblCountFpanelsSong.BackColor = System.Drawing.Color.Transparent;
            this.lblCountFpanelsSong.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountFpanelsSong.ForeColor = System.Drawing.Color.DimGray;
            this.lblCountFpanelsSong.Location = new System.Drawing.Point(1126, 447);
            this.lblCountFpanelsSong.Name = "lblCountFpanelsSong";
            this.lblCountFpanelsSong.Size = new System.Drawing.Size(131, 20);
            this.lblCountFpanelsSong.TabIndex = 6;
            this.lblCountFpanelsSong.Text = "5 songs on the list";
            // 
            // fpanelArtists
            // 
            this.fpanelArtists.Controls.Add(this.artist__Panel7);
            this.fpanelArtists.Controls.Add(this.artist__Panel9);
            this.fpanelArtists.Controls.Add(this.artist__Panel8);
            this.fpanelArtists.Controls.Add(this.artist__Panel10);
            this.fpanelArtists.Controls.Add(this.artist__Panel11);
            this.fpanelArtists.Location = new System.Drawing.Point(43, 124);
            this.fpanelArtists.Name = "fpanelArtists";
            this.fpanelArtists.Size = new System.Drawing.Size(1294, 303);
            this.fpanelArtists.TabIndex = 9;
            this.fpanelArtists.WrapContents = false;
            // 
            // pnlSongPlaying
            // 
            this.pnlSongPlaying.BackColor = System.Drawing.Color.Transparent;
            this.pnlSongPlaying.Controls.Add(this.btnAddPlaylist);
            this.pnlSongPlaying.Controls.Add(this.pbPlaying);
            this.pnlSongPlaying.Controls.Add(this.lblEnd);
            this.pnlSongPlaying.Controls.Add(this.lblStart);
            this.pnlSongPlaying.Controls.Add(this.label7);
            this.pnlSongPlaying.Controls.Add(this.label6);
            this.pnlSongPlaying.Controls.Add(this.lblArtistPlaying);
            this.pnlSongPlaying.Controls.Add(this.lblTitlePlaying);
            this.pnlSongPlaying.Controls.Add(this.guna2ImageButton5);
            this.pnlSongPlaying.Controls.Add(this.guna2ImageButton1);
            this.pnlSongPlaying.Controls.Add(this.btnRepeat);
            this.pnlSongPlaying.Controls.Add(this.btnSkip);
            this.pnlSongPlaying.Controls.Add(this.btnPlay);
            this.pnlSongPlaying.Controls.Add(this.sliderTimeMusic);
            this.pnlSongPlaying.FillColor = System.Drawing.Color.White;
            this.pnlSongPlaying.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSongPlaying.Location = new System.Drawing.Point(44, 487);
            this.pnlSongPlaying.Name = "pnlSongPlaying";
            this.pnlSongPlaying.Radius = 10;
            this.pnlSongPlaying.ShadowColor = System.Drawing.Color.Black;
            this.pnlSongPlaying.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlSongPlaying.Size = new System.Drawing.Size(503, 459);
            this.pnlSongPlaying.TabIndex = 0;
            // 
            // btnAddPlaylist
            // 
            this.btnAddPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPlaylist.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnAddPlaylist.CheckedState.Parent = this.btnAddPlaylist;
            this.btnAddPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPlaylist.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddPlaylist.HoverState.Parent = this.btnAddPlaylist;
            this.btnAddPlaylist.Image = global::Music__Player.Properties.Resources.icon_add_playlist;
            this.btnAddPlaylist.ImageSize = new System.Drawing.Size(24, 24);
            this.btnAddPlaylist.Location = new System.Drawing.Point(404, 9);
            this.btnAddPlaylist.Name = "btnAddPlaylist";
            this.btnAddPlaylist.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnAddPlaylist.PressedState.Parent = this.btnAddPlaylist;
            this.btnAddPlaylist.Size = new System.Drawing.Size(45, 45);
            this.btnAddPlaylist.TabIndex = 6;
            this.btnAddPlaylist.Click += new System.EventHandler(this.btnAddPlaylist_Click);
            // 
            // pbPlaying
            // 
            this.pbPlaying.Image = global::Music__Player.Properties.Resources.draft;
            this.pbPlaying.Location = new System.Drawing.Point(181, 63);
            this.pbPlaying.Name = "pbPlaying";
            this.pbPlaying.ShadowDecoration.Parent = this.pbPlaying;
            this.pbPlaying.Size = new System.Drawing.Size(141, 138);
            this.pbPlaying.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlaying.TabIndex = 5;
            this.pbPlaying.TabStop = false;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(399, 325);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(44, 20);
            this.lblEnd.TabIndex = 4;
            this.lblEnd.Text = "05:20";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(58, 325);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(44, 20);
            this.lblStart.TabIndex = 4;
            this.lblStart.Text = "00:00";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(108, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 20);
            this.label7.TabIndex = 1;
            this.label7.Tag = "";
            this.label7.Text = "Rockstar Rockstar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(59, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Next - ";
            // 
            // lblArtistPlaying
            // 
            this.lblArtistPlaying.AutoSize = true;
            this.lblArtistPlaying.BackColor = System.Drawing.Color.Transparent;
            this.lblArtistPlaying.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtistPlaying.ForeColor = System.Drawing.Color.DimGray;
            this.lblArtistPlaying.Location = new System.Drawing.Point(205, 253);
            this.lblArtistPlaying.Name = "lblArtistPlaying";
            this.lblArtistPlaying.Size = new System.Drawing.Size(93, 20);
            this.lblArtistPlaying.TabIndex = 1;
            this.lblArtistPlaying.Text = "Post Malone";
            // 
            // lblTitlePlaying
            // 
            this.lblTitlePlaying.AutoSize = true;
            this.lblTitlePlaying.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlePlaying.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePlaying.ForeColor = System.Drawing.Color.Black;
            this.lblTitlePlaying.Location = new System.Drawing.Point(192, 223);
            this.lblTitlePlaying.Name = "lblTitlePlaying";
            this.lblTitlePlaying.Size = new System.Drawing.Size(119, 25);
            this.lblTitlePlaying.TabIndex = 1;
            this.lblTitlePlaying.Text = "Saint-Tropez";
            // 
            // guna2ImageButton5
            // 
            this.guna2ImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton5.CheckedState.ImageSize = new System.Drawing.Size(34, 34);
            this.guna2ImageButton5.CheckedState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton5.HoverState.ImageSize = new System.Drawing.Size(38, 38);
            this.guna2ImageButton5.HoverState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.Image = global::Music__Player.Properties.Resources.icon_start_blue;
            this.guna2ImageButton5.ImageSize = new System.Drawing.Size(34, 34);
            this.guna2ImageButton5.Location = new System.Drawing.Point(142, 376);
            this.guna2ImageButton5.Name = "guna2ImageButton5";
            this.guna2ImageButton5.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.guna2ImageButton5.PressedState.Parent = this.guna2ImageButton5;
            this.guna2ImageButton5.Size = new System.Drawing.Size(45, 45);
            this.guna2ImageButton5.TabIndex = 3;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::Music__Player.Properties.Resources.icon_shuffle_blue;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(394, 376);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(45, 45);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // btnRepeat
            // 
            this.btnRepeat.BackColor = System.Drawing.Color.Transparent;
            this.btnRepeat.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRepeat.CheckedState.Parent = this.btnRepeat;
            this.btnRepeat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRepeat.HoverState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnRepeat.HoverState.Parent = this.btnRepeat;
            this.btnRepeat.Image = global::Music__Player.Properties.Resources.icon_repeat_blue;
            this.btnRepeat.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRepeat.Location = new System.Drawing.Point(64, 376);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRepeat.PressedState.Parent = this.btnRepeat;
            this.btnRepeat.Size = new System.Drawing.Size(45, 45);
            this.btnRepeat.TabIndex = 3;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.Transparent;
            this.btnSkip.CheckedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnSkip.CheckedState.Parent = this.btnSkip;
            this.btnSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSkip.HoverState.ImageSize = new System.Drawing.Size(38, 38);
            this.btnSkip.HoverState.Parent = this.btnSkip;
            this.btnSkip.Image = global::Music__Player.Properties.Resources.icon_end_blue;
            this.btnSkip.ImageSize = new System.Drawing.Size(34, 34);
            this.btnSkip.Location = new System.Drawing.Point(313, 376);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.PressedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnSkip.PressedState.Parent = this.btnSkip;
            this.btnSkip.Size = new System.Drawing.Size(45, 45);
            this.btnSkip.TabIndex = 3;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.CheckedState.Image = global::Music__Player.Properties.Resources.icon_play_blue;
            this.btnPlay.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPlay.CheckedState.Parent = this.btnPlay;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.HoverState.ImageSize = new System.Drawing.Size(65, 65);
            this.btnPlay.HoverState.Parent = this.btnPlay;
            this.btnPlay.Image = global::Music__Player.Properties.Resources.icon_pause_blue;
            this.btnPlay.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPlay.Location = new System.Drawing.Point(219, 366);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPlay.PressedState.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(65, 65);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // sliderTimeMusic
            // 
            this.sliderTimeMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderTimeMusic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.sliderTimeMusic.HoverState.Parent = this.sliderTimeMusic;
            this.sliderTimeMusic.Location = new System.Drawing.Point(64, 299);
            this.sliderTimeMusic.Name = "sliderTimeMusic";
            this.sliderTimeMusic.Size = new System.Drawing.Size(375, 23);
            this.sliderTimeMusic.TabIndex = 0;
            this.sliderTimeMusic.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sliderTimeMusic.Scroll += new System.Windows.Forms.ScrollEventHandler(this.sliderTimeMusic_Scroll);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(596, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 26);
            this.label12.TabIndex = 1;
            this.label12.Text = "Next Song";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 26);
            this.label8.TabIndex = 1;
            this.label8.Text = "Top Artists";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Now Playing";
            // 
            // fpanelSongs
            // 
            this.fpanelSongs.AutoScroll = true;
            this.fpanelSongs.Controls.Add(this.info__Song__Panel10);
            this.fpanelSongs.Controls.Add(this.info__Song__Panel6);
            this.fpanelSongs.Controls.Add(this.info__Song__Panel7);
            this.fpanelSongs.Controls.Add(this.info__Song__Panel8);
            this.fpanelSongs.Controls.Add(this.info__Song__Panel9);
            this.fpanelSongs.Location = new System.Drawing.Point(598, 487);
            this.fpanelSongs.Name = "fpanelSongs";
            this.fpanelSongs.Size = new System.Drawing.Size(733, 459);
            this.fpanelSongs.TabIndex = 10;
            // 
            // timerMusic
            // 
            this.timerMusic.Tick += new System.EventHandler(this.timerMusic_Tick);
            // 
            // dropdown__Playlist1
            // 
            this.dropdown__Playlist1.BackColor = System.Drawing.Color.Transparent;
            this.dropdown__Playlist1.Location = new System.Drawing.Point(0, 0);
            this.dropdown__Playlist1.Name = "dropdown__Playlist1";
            this.dropdown__Playlist1.Size = new System.Drawing.Size(287, 274);
            this.dropdown__Playlist1.TabIndex = 0;
            // 
            // artist__Panel7
            // 
            this.artist__Panel7.Artist = null;
            this.artist__Panel7.BackColor = System.Drawing.Color.Transparent;
            this.artist__Panel7.Duration = null;
            this.artist__Panel7.Image_Song = null;
            this.artist__Panel7.IsHovered = false;
            this.artist__Panel7.IsPlay = false;
            this.artist__Panel7.IsSelected = false;
            this.artist__Panel7.Location = new System.Drawing.Point(3, 3);
            this.artist__Panel7.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.artist__Panel7.Name = "artist__Panel7";
            this.artist__Panel7.Size = new System.Drawing.Size(245, 296);
            this.artist__Panel7.TabIndex = 0;
            this.artist__Panel7.Title = null;
            this.artist__Panel7.URL = null;
            // 
            // artist__Panel9
            // 
            this.artist__Panel9.Artist = null;
            this.artist__Panel9.BackColor = System.Drawing.Color.Transparent;
            this.artist__Panel9.Duration = null;
            this.artist__Panel9.Image_Song = null;
            this.artist__Panel9.IsHovered = false;
            this.artist__Panel9.IsPlay = false;
            this.artist__Panel9.IsSelected = false;
            this.artist__Panel9.Location = new System.Drawing.Point(262, 3);
            this.artist__Panel9.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.artist__Panel9.Name = "artist__Panel9";
            this.artist__Panel9.Size = new System.Drawing.Size(245, 296);
            this.artist__Panel9.TabIndex = 2;
            this.artist__Panel9.Title = null;
            this.artist__Panel9.URL = null;
            // 
            // artist__Panel8
            // 
            this.artist__Panel8.Artist = null;
            this.artist__Panel8.BackColor = System.Drawing.Color.Transparent;
            this.artist__Panel8.Duration = null;
            this.artist__Panel8.Image_Song = null;
            this.artist__Panel8.IsHovered = false;
            this.artist__Panel8.IsPlay = false;
            this.artist__Panel8.IsSelected = false;
            this.artist__Panel8.Location = new System.Drawing.Point(521, 3);
            this.artist__Panel8.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.artist__Panel8.Name = "artist__Panel8";
            this.artist__Panel8.Size = new System.Drawing.Size(245, 296);
            this.artist__Panel8.TabIndex = 1;
            this.artist__Panel8.Title = null;
            this.artist__Panel8.URL = null;
            // 
            // artist__Panel10
            // 
            this.artist__Panel10.Artist = null;
            this.artist__Panel10.BackColor = System.Drawing.Color.Transparent;
            this.artist__Panel10.Duration = null;
            this.artist__Panel10.Image_Song = null;
            this.artist__Panel10.IsHovered = false;
            this.artist__Panel10.IsPlay = false;
            this.artist__Panel10.IsSelected = false;
            this.artist__Panel10.Location = new System.Drawing.Point(780, 3);
            this.artist__Panel10.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.artist__Panel10.Name = "artist__Panel10";
            this.artist__Panel10.Size = new System.Drawing.Size(245, 296);
            this.artist__Panel10.TabIndex = 3;
            this.artist__Panel10.Title = null;
            this.artist__Panel10.URL = null;
            // 
            // artist__Panel11
            // 
            this.artist__Panel11.Artist = null;
            this.artist__Panel11.BackColor = System.Drawing.Color.Transparent;
            this.artist__Panel11.Duration = null;
            this.artist__Panel11.Image_Song = null;
            this.artist__Panel11.IsHovered = false;
            this.artist__Panel11.IsPlay = false;
            this.artist__Panel11.IsSelected = false;
            this.artist__Panel11.Location = new System.Drawing.Point(1039, 3);
            this.artist__Panel11.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.artist__Panel11.Name = "artist__Panel11";
            this.artist__Panel11.Size = new System.Drawing.Size(245, 296);
            this.artist__Panel11.TabIndex = 4;
            this.artist__Panel11.Title = null;
            this.artist__Panel11.URL = null;
            // 
            // info__Song__Panel10
            // 
            this.info__Song__Panel10.Artist = null;
            this.info__Song__Panel10.BackColor = System.Drawing.Color.Transparent;
            this.info__Song__Panel10.Duration = null;
            this.info__Song__Panel10.ID = null;
            this.info__Song__Panel10.Image_Song = null;
            this.info__Song__Panel10.IsFavorite = false;
            this.info__Song__Panel10.IsHovered = false;
            this.info__Song__Panel10.IsPlay = false;
            this.info__Song__Panel10.IsSelected = false;
            this.info__Song__Panel10.Location = new System.Drawing.Point(3, 3);
            this.info__Song__Panel10.Name = "info__Song__Panel10";
            this.info__Song__Panel10.Size = new System.Drawing.Size(702, 109);
            this.info__Song__Panel10.TabIndex = 4;
            this.info__Song__Panel10.Title = null;
            this.info__Song__Panel10.URL = null;
            // 
            // info__Song__Panel6
            // 
            this.info__Song__Panel6.Artist = null;
            this.info__Song__Panel6.BackColor = System.Drawing.Color.Transparent;
            this.info__Song__Panel6.Duration = null;
            this.info__Song__Panel6.ID = null;
            this.info__Song__Panel6.Image_Song = null;
            this.info__Song__Panel6.IsFavorite = false;
            this.info__Song__Panel6.IsHovered = false;
            this.info__Song__Panel6.IsPlay = false;
            this.info__Song__Panel6.IsSelected = false;
            this.info__Song__Panel6.Location = new System.Drawing.Point(3, 118);
            this.info__Song__Panel6.Name = "info__Song__Panel6";
            this.info__Song__Panel6.Size = new System.Drawing.Size(702, 109);
            this.info__Song__Panel6.TabIndex = 0;
            this.info__Song__Panel6.Title = null;
            this.info__Song__Panel6.URL = null;
            // 
            // info__Song__Panel7
            // 
            this.info__Song__Panel7.Artist = null;
            this.info__Song__Panel7.BackColor = System.Drawing.Color.Transparent;
            this.info__Song__Panel7.Duration = null;
            this.info__Song__Panel7.ID = null;
            this.info__Song__Panel7.Image_Song = null;
            this.info__Song__Panel7.IsFavorite = false;
            this.info__Song__Panel7.IsHovered = false;
            this.info__Song__Panel7.IsPlay = false;
            this.info__Song__Panel7.IsSelected = false;
            this.info__Song__Panel7.Location = new System.Drawing.Point(3, 233);
            this.info__Song__Panel7.Name = "info__Song__Panel7";
            this.info__Song__Panel7.Size = new System.Drawing.Size(702, 109);
            this.info__Song__Panel7.TabIndex = 1;
            this.info__Song__Panel7.Title = null;
            this.info__Song__Panel7.URL = null;
            // 
            // info__Song__Panel8
            // 
            this.info__Song__Panel8.Artist = null;
            this.info__Song__Panel8.BackColor = System.Drawing.Color.Transparent;
            this.info__Song__Panel8.Duration = null;
            this.info__Song__Panel8.ID = null;
            this.info__Song__Panel8.Image_Song = null;
            this.info__Song__Panel8.IsFavorite = false;
            this.info__Song__Panel8.IsHovered = false;
            this.info__Song__Panel8.IsPlay = false;
            this.info__Song__Panel8.IsSelected = false;
            this.info__Song__Panel8.Location = new System.Drawing.Point(3, 348);
            this.info__Song__Panel8.Name = "info__Song__Panel8";
            this.info__Song__Panel8.Size = new System.Drawing.Size(702, 109);
            this.info__Song__Panel8.TabIndex = 2;
            this.info__Song__Panel8.Title = null;
            this.info__Song__Panel8.URL = null;
            // 
            // info__Song__Panel9
            // 
            this.info__Song__Panel9.Artist = null;
            this.info__Song__Panel9.BackColor = System.Drawing.Color.Transparent;
            this.info__Song__Panel9.Duration = null;
            this.info__Song__Panel9.ID = null;
            this.info__Song__Panel9.Image_Song = null;
            this.info__Song__Panel9.IsFavorite = false;
            this.info__Song__Panel9.IsHovered = false;
            this.info__Song__Panel9.IsPlay = false;
            this.info__Song__Panel9.IsSelected = false;
            this.info__Song__Panel9.Location = new System.Drawing.Point(3, 463);
            this.info__Song__Panel9.Name = "info__Song__Panel9";
            this.info__Song__Panel9.Size = new System.Drawing.Size(702, 109);
            this.info__Song__Panel9.TabIndex = 3;
            this.info__Song__Panel9.Title = null;
            this.info__Song__Panel9.URL = null;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelHome);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1359, 965);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.pnlTest.ResumeLayout(false);
            this.fpanelArtists.ResumeLayout(false);
            this.pnlSongPlaying.ResumeLayout(false);
            this.pnlSongPlaying.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaying)).EndInit();
            this.fpanelSongs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelHome;
        private System.Windows.Forms.Label lblCountFpanelsSong;
        private System.Windows.Forms.FlowLayoutPanel fpanelArtists;
        private Custom.Artist__Panel artist__Panel1;
        private Custom.Artist__Panel artist__Panel2;
        private Custom.Artist__Panel artist__Panel3;
        private Custom.Artist__Panel artist__Panel4;
        private Custom.Artist__Panel artist__Panel5;
        private Custom.Artist__Panel artist__Panel6;
        private System.Windows.Forms.FlowLayoutPanel fpanelSongs;
        private Custom.Info__Song__Panel info__Song__Panel5;
        private Custom.Info__Song__Panel info__Song__Panel1;
        private Custom.Info__Song__Panel info__Song__Panel2;
        private Custom.Info__Song__Panel info__Song__Panel3;
        private Custom.Info__Song__Panel info__Song__Panel4;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlSongPlaying;
        private Guna.UI2.WinForms.Guna2PictureBox pbPlaying;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblArtistPlaying;
        private System.Windows.Forms.Label lblTitlePlaying;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton5;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btnRepeat;
        private Guna.UI2.WinForms.Guna2ImageButton btnSkip;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlay;
        private Guna.UI2.WinForms.Guna2TrackBar sliderTimeMusic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private Custom.Info__Song__Panel info__Song__Panel10;
        private Custom.Info__Song__Panel info__Song__Panel6;
        private Custom.Info__Song__Panel info__Song__Panel7;
        private Custom.Info__Song__Panel info__Song__Panel8;
        private Custom.Info__Song__Panel info__Song__Panel9;
        private Custom.Artist__Panel artist__Panel7;
        private Custom.Artist__Panel artist__Panel9;
        private Custom.Artist__Panel artist__Panel8;
        private Custom.Artist__Panel artist__Panel10;
        private Custom.Artist__Panel artist__Panel11;
        private System.Windows.Forms.Timer timerMusic;
        private Guna.UI2.WinForms.Guna2ImageButton btnAddPlaylist;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTest;
        private Custom.Dropdown__Playlist dropdown__Playlist1;
    }
}
