namespace Music__Player.sources.View
{
    partial class Songs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Songs));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.searchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton2 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.userControl11 = new Music__Player.sources.Custom.slide1();
            this.RadioBtn4 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioBtn2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioBtn3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.RadioBtn1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.slideBtnLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.slide31 = new Music__Player.sources.Custom.slide3();
            this.slide41 = new Music__Player.sources.Custom.slide4();
            this.slide21 = new Music__Player.sources.Custom.slide2();
            this.slide11 = new Music__Player.sources.Custom.slide1();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.songs_Display1 = new Music__Player.sources.Custom.Songs_Display();
            this.songs_Display2 = new Music__Player.sources.Custom.Songs_Display();
            this.songs_Display3 = new Music__Player.sources.Custom.Songs_Display();
            this.songs_Display4 = new Music__Player.sources.Custom.Songs_Display();
            this.songs_Display5 = new Music__Player.sources.Custom.Songs_Display();
            this.songs_Display6 = new Music__Player.sources.Custom.Songs_Display();
            this.lblEnd = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.song__Playing__BottomBar1 = new Music__Player.sources.Custom.Song__Playing__BottomBar();
            this.guna2Panel2.SuspendLayout();
            this.slideBtnLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel2.Controls.Add(this.searchBar);
            this.guna2Panel2.Controls.Add(this.guna2ImageButton1);
            this.guna2Panel2.Controls.Add(this.guna2ImageButton2);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1359, 100);
            this.guna2Panel2.TabIndex = 1;
            // 
            // searchBar
            // 
            this.searchBar.BorderColor = System.Drawing.Color.Silver;
            this.searchBar.BorderRadius = 18;
            this.searchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBar.DefaultText = "";
            this.searchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar.DisabledState.Parent = this.searchBar;
            this.searchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar.FocusedState.Parent = this.searchBar;
            this.searchBar.ForeColor = System.Drawing.Color.Black;
            this.searchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBar.HoverState.Parent = this.searchBar;
            this.searchBar.IconLeft = global::Music__Player.Properties.Resources.icon_search_blue;
            this.searchBar.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.searchBar.IconLeftSize = new System.Drawing.Size(28, 28);
            this.searchBar.Location = new System.Drawing.Point(585, 26);
            this.searchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBar.Name = "searchBar";
            this.searchBar.PasswordChar = '\0';
            this.searchBar.PlaceholderText = "Search for favorite song ...";
            this.searchBar.SelectedText = "";
            this.searchBar.ShadowDecoration.Parent = this.searchBar;
            this.searchBar.Size = new System.Drawing.Size(567, 44);
            this.searchBar.TabIndex = 6;
            this.searchBar.TextOffset = new System.Drawing.Point(15, 0);
            this.searchBar.TextChanged += new System.EventHandler(this.searchBar_TextChanged);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(26, 26);
            this.guna2ImageButton1.Location = new System.Drawing.Point(88, 26);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(44, 44);
            this.guna2ImageButton1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.guna2ImageButton1, "Go forward");
            // 
            // guna2ImageButton2
            // 
            this.guna2ImageButton2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2ImageButton2.CheckedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton2.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton2.HoverState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton2.Image")));
            this.guna2ImageButton2.ImageSize = new System.Drawing.Size(26, 26);
            this.guna2ImageButton2.Location = new System.Drawing.Point(38, 26);
            this.guna2ImageButton2.Name = "guna2ImageButton2";
            this.guna2ImageButton2.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.guna2ImageButton2.PressedState.Parent = this.guna2ImageButton2;
            this.guna2ImageButton2.Size = new System.Drawing.Size(44, 44);
            this.guna2ImageButton2.TabIndex = 3;
            this.toolTip1.SetToolTip(this.guna2ImageButton2, "Go Back");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // userControl11
            // 
            this.userControl11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl11.BackgroundImage")));
            this.userControl11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userControl11.Location = new System.Drawing.Point(0, 0);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1359, 297);
            this.userControl11.TabIndex = 0;
            // 
            // RadioBtn4
            // 
            this.RadioBtn4.AllowDrop = true;
            this.RadioBtn4.CheckedState.BorderColor = System.Drawing.Color.Gray;
            this.RadioBtn4.CheckedState.BorderThickness = 2;
            this.RadioBtn4.CheckedState.FillColor = System.Drawing.Color.White;
            this.RadioBtn4.CheckedState.InnerColor = System.Drawing.Color.Gray;
            this.RadioBtn4.CheckedState.InnerOffset = 10;
            this.RadioBtn4.CheckedState.Parent = this.RadioBtn4;
            this.RadioBtn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtn4.Location = new System.Drawing.Point(66, 3);
            this.RadioBtn4.Name = "RadioBtn4";
            this.RadioBtn4.ShadowDecoration.Parent = this.RadioBtn4;
            this.RadioBtn4.Size = new System.Drawing.Size(15, 15);
            this.RadioBtn4.TabIndex = 10;
            this.RadioBtn4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioBtn4.UncheckedState.BorderThickness = 2;
            this.RadioBtn4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioBtn4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioBtn4.UncheckedState.Parent = this.RadioBtn4;
            this.RadioBtn4.CheckedChanged += new System.EventHandler(this.RadioBtn4_CheckedChanged);
            // 
            // RadioBtn2
            // 
            this.RadioBtn2.AllowDrop = true;
            this.RadioBtn2.CheckedState.BorderColor = System.Drawing.Color.Gray;
            this.RadioBtn2.CheckedState.BorderThickness = 2;
            this.RadioBtn2.CheckedState.FillColor = System.Drawing.Color.White;
            this.RadioBtn2.CheckedState.InnerColor = System.Drawing.Color.Gray;
            this.RadioBtn2.CheckedState.InnerOffset = 10;
            this.RadioBtn2.CheckedState.Parent = this.RadioBtn2;
            this.RadioBtn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtn2.Location = new System.Drawing.Point(24, 3);
            this.RadioBtn2.Name = "RadioBtn2";
            this.RadioBtn2.ShadowDecoration.Parent = this.RadioBtn2;
            this.RadioBtn2.Size = new System.Drawing.Size(15, 15);
            this.RadioBtn2.TabIndex = 9;
            this.RadioBtn2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioBtn2.UncheckedState.BorderThickness = 2;
            this.RadioBtn2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioBtn2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioBtn2.UncheckedState.Parent = this.RadioBtn2;
            this.RadioBtn2.CheckedChanged += new System.EventHandler(this.RadioBtn2_CheckedChanged);
            // 
            // RadioBtn3
            // 
            this.RadioBtn3.AllowDrop = true;
            this.RadioBtn3.CheckedState.BorderColor = System.Drawing.Color.Gray;
            this.RadioBtn3.CheckedState.BorderThickness = 2;
            this.RadioBtn3.CheckedState.FillColor = System.Drawing.Color.White;
            this.RadioBtn3.CheckedState.InnerColor = System.Drawing.Color.Gray;
            this.RadioBtn3.CheckedState.InnerOffset = 10;
            this.RadioBtn3.CheckedState.Parent = this.RadioBtn3;
            this.RadioBtn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtn3.Location = new System.Drawing.Point(45, 3);
            this.RadioBtn3.Name = "RadioBtn3";
            this.RadioBtn3.ShadowDecoration.Parent = this.RadioBtn3;
            this.RadioBtn3.Size = new System.Drawing.Size(15, 15);
            this.RadioBtn3.TabIndex = 7;
            this.RadioBtn3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioBtn3.UncheckedState.BorderThickness = 2;
            this.RadioBtn3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioBtn3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioBtn3.UncheckedState.Parent = this.RadioBtn3;
            this.RadioBtn3.CheckedChanged += new System.EventHandler(this.RadioBtn3_CheckedChanged);
            // 
            // RadioBtn1
            // 
            this.RadioBtn1.AllowDrop = true;
            this.RadioBtn1.Checked = true;
            this.RadioBtn1.CheckedState.BorderColor = System.Drawing.Color.Gray;
            this.RadioBtn1.CheckedState.BorderThickness = 2;
            this.RadioBtn1.CheckedState.FillColor = System.Drawing.Color.White;
            this.RadioBtn1.CheckedState.InnerColor = System.Drawing.Color.Gray;
            this.RadioBtn1.CheckedState.InnerOffset = 10;
            this.RadioBtn1.CheckedState.Parent = this.RadioBtn1;
            this.RadioBtn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadioBtn1.Location = new System.Drawing.Point(3, 3);
            this.RadioBtn1.Name = "RadioBtn1";
            this.RadioBtn1.ShadowDecoration.Parent = this.RadioBtn1;
            this.RadioBtn1.Size = new System.Drawing.Size(15, 15);
            this.RadioBtn1.TabIndex = 1;
            this.RadioBtn1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RadioBtn1.UncheckedState.BorderThickness = 2;
            this.RadioBtn1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RadioBtn1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RadioBtn1.UncheckedState.Parent = this.RadioBtn1;
            this.RadioBtn1.Click += new System.EventHandler(this.RadioBtn1_CheckedChanged);
            // 
            // slideBtnLayoutPanel
            // 
            this.slideBtnLayoutPanel.Controls.Add(this.RadioBtn1);
            this.slideBtnLayoutPanel.Controls.Add(this.RadioBtn2);
            this.slideBtnLayoutPanel.Controls.Add(this.RadioBtn3);
            this.slideBtnLayoutPanel.Controls.Add(this.RadioBtn4);
            this.slideBtnLayoutPanel.Location = new System.Drawing.Point(585, 398);
            this.slideBtnLayoutPanel.Name = "slideBtnLayoutPanel";
            this.slideBtnLayoutPanel.Size = new System.Drawing.Size(85, 23);
            this.slideBtnLayoutPanel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.slide31);
            this.panel1.Controls.Add(this.slide41);
            this.panel1.Controls.Add(this.slide21);
            this.panel1.Controls.Add(this.slide11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 295);
            this.panel1.TabIndex = 7;
            // 
            // slide31
            // 
            this.slide31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slide31.BackgroundImage")));
            this.slide31.Location = new System.Drawing.Point(114, -2);
            this.slide31.Name = "slide31";
            this.slide31.Size = new System.Drawing.Size(1126, 297);
            this.slide31.TabIndex = 4;
            // 
            // slide41
            // 
            this.slide41.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slide41.BackgroundImage")));
            this.slide41.Location = new System.Drawing.Point(114, -2);
            this.slide41.Name = "slide41";
            this.slide41.Size = new System.Drawing.Size(1126, 297);
            this.slide41.TabIndex = 3;
            // 
            // slide21
            // 
            this.slide21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slide21.BackgroundImage")));
            this.slide21.Location = new System.Drawing.Point(114, 0);
            this.slide21.Name = "slide21";
            this.slide21.Size = new System.Drawing.Size(1126, 297);
            this.slide21.TabIndex = 1;
            // 
            // slide11
            // 
            this.slide11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("slide11.BackgroundImage")));
            this.slide11.Location = new System.Drawing.Point(114, -2);
            this.slide11.Name = "slide11";
            this.slide11.Size = new System.Drawing.Size(1126, 297);
            this.slide11.TabIndex = 0;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(88, 448);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1184, 414);
            this.flowLayoutPanel1.TabIndex = 8;
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
            this.songs_Display6.Size = new System.Drawing.Size(1126, 84);
            this.songs_Display6.TabIndex = 5;
            this.songs_Display6.URL = null;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(1312, 6);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(44, 20);
            this.lblEnd.TabIndex = 11;
            this.lblEnd.Text = "05:20";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.song__Playing__BottomBar1);
            this.guna2Panel1.Controls.Add(this.lblEnd);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 868);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1359, 97);
            this.guna2Panel1.TabIndex = 0;
            // 
            // song__Playing__BottomBar1
            // 
            this.song__Playing__BottomBar1.BackColor = System.Drawing.Color.Transparent;
            this.song__Playing__BottomBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.song__Playing__BottomBar1.Location = new System.Drawing.Point(0, -3);
            this.song__Playing__BottomBar1.Name = "song__Playing__BottomBar1";
            this.song__Playing__BottomBar1.Size = new System.Drawing.Size(1359, 100);
            this.song__Playing__BottomBar1.TabIndex = 12;
            // 
            // Songs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.slideBtnLayoutPanel);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Songs";
            this.Size = new System.Drawing.Size(1359, 965);
            this.Load += new System.EventHandler(this.Songs_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.slideBtnLayoutPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioBtn1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioBtn4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioBtn2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton RadioBtn3;
        private System.Windows.Forms.FlowLayoutPanel slideBtnLayoutPanel;
        private Custom.slide1 userControl11;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private Custom.slide2 slide21;
        private Custom.slide1 slide11;
        private Custom.slide4 slide41;
        private Custom.slide3 slide31;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Custom.Songs_Display songs_Display1;
        private Custom.Songs_Display songs_Display2;
        private Custom.Songs_Display songs_Display3;
        private Custom.Songs_Display songs_Display4;
        private Custom.Songs_Display songs_Display5;
        private Custom.Songs_Display songs_Display6;
        private Guna.UI2.WinForms.Guna2TextBox searchBar;
        private System.Windows.Forms.Label lblEnd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Custom.Song__Playing__BottomBar song__Playing__BottomBar1;
    }
}
