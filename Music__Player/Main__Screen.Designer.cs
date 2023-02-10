namespace Music__Player
{
    partial class Main__Screen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dragForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelSlideBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.fpnlPlaylists = new System.Windows.Forms.FlowLayoutPanel();
            this.name__Playlist__Button6 = new Music__Player.sources.Custom.Name__Playlist__Button();
            this.name__Playlist__Button5 = new Music__Player.sources.Custom.Name__Playlist__Button();
            this.name__Playlist__Button4 = new Music__Player.sources.Custom.Name__Playlist__Button();
            this.name__Playlist__Button1 = new Music__Player.sources.Custom.Name__Playlist__Button();
            this.name__Playlist__Button2 = new Music__Player.sources.Custom.Name__Playlist__Button();
            this.name__Playlist__Button3 = new Music__Player.sources.Custom.Name__Playlist__Button();
            this.VerticalLine = new Guna.UI2.WinForms.Guna2VSeparator();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnCreatePlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlbums = new Guna.UI2.WinForms.Guna2Button();
            this.btnFavorite = new Guna.UI2.WinForms.Guna2Button();
            this.btnSongs = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.borderForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelMainScreen = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelSlideBar.SuspendLayout();
            this.fpnlPlaylists.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragForm
            // 
            this.dragForm.TargetControl = this.panelSlideBar;
            // 
            // panelSlideBar
            // 
            this.panelSlideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelSlideBar.Controls.Add(this.btnUser);
            this.panelSlideBar.Controls.Add(this.btnLogOut);
            this.panelSlideBar.Controls.Add(this.guna2Separator1);
            this.panelSlideBar.Controls.Add(this.fpnlPlaylists);
            this.panelSlideBar.Controls.Add(this.VerticalLine);
            this.panelSlideBar.Controls.Add(this.lblLibrary);
            this.panelSlideBar.Controls.Add(this.lblMenu);
            this.panelSlideBar.Controls.Add(this.btnCreatePlaylist);
            this.panelSlideBar.Controls.Add(this.btnPlaylist);
            this.panelSlideBar.Controls.Add(this.btnHistory);
            this.panelSlideBar.Controls.Add(this.btnAlbums);
            this.panelSlideBar.Controls.Add(this.btnFavorite);
            this.panelSlideBar.Controls.Add(this.btnSongs);
            this.panelSlideBar.Controls.Add(this.btnHome);
            this.panelSlideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelSlideBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelSlideBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelSlideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSlideBar.Name = "panelSlideBar";
            this.panelSlideBar.ShadowDecoration.Parent = this.panelSlideBar;
            this.panelSlideBar.Size = new System.Drawing.Size(242, 965);
            this.panelSlideBar.TabIndex = 1;
            // 
            // btnUser
            // 
            this.btnUser.BorderColor = System.Drawing.Color.White;
            this.btnUser.BorderRadius = 20;
            this.btnUser.BorderThickness = 2;
            this.btnUser.CheckedState.Parent = this.btnUser;
            this.btnUser.CustomImages.Image = global::Music__Player.Properties.Resources.icon_user;
            this.btnUser.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUser.CustomImages.Parent = this.btnUser;
            this.btnUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUser.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.HoverState.Parent = this.btnUser;
            this.btnUser.Location = new System.Drawing.Point(27, 23);
            this.btnUser.Name = "btnUser";
            this.btnUser.PressedColor = System.Drawing.Color.Transparent;
            this.btnUser.PressedDepth = 0;
            this.btnUser.ShadowDecoration.Parent = this.btnUser;
            this.btnUser.Size = new System.Drawing.Size(187, 45);
            this.btnUser.TabIndex = 8;
            this.btnUser.Text = "An Hung";
            this.btnUser.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BorderRadius = 10;
            this.btnLogOut.BorderThickness = 1;
            this.btnLogOut.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLogOut.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLogOut.CheckedState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.CustomImages.Image = global::Music__Player.Properties.Resources.logoutIcon;
            this.btnLogOut.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnLogOut.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogOut.CustomImages.Parent = this.btnLogOut;
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.Location = new System.Drawing.Point(36, 902);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(170, 45);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.TextOffset = new System.Drawing.Point(47, 0);
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(55, 566);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(151, 10);
            this.guna2Separator1.TabIndex = 6;
            // 
            // fpnlPlaylists
            // 
            this.fpnlPlaylists.AutoScroll = true;
            this.fpnlPlaylists.Controls.Add(this.name__Playlist__Button6);
            this.fpnlPlaylists.Controls.Add(this.name__Playlist__Button5);
            this.fpnlPlaylists.Controls.Add(this.name__Playlist__Button4);
            this.fpnlPlaylists.Controls.Add(this.name__Playlist__Button1);
            this.fpnlPlaylists.Controls.Add(this.name__Playlist__Button2);
            this.fpnlPlaylists.Controls.Add(this.name__Playlist__Button3);
            this.fpnlPlaylists.Location = new System.Drawing.Point(7, 596);
            this.fpnlPlaylists.Name = "fpnlPlaylists";
            this.fpnlPlaylists.Padding = new System.Windows.Forms.Padding(26, 0, 0, 0);
            this.fpnlPlaylists.Size = new System.Drawing.Size(233, 264);
            this.fpnlPlaylists.TabIndex = 5;
            // 
            // name__Playlist__Button6
            // 
            this.name__Playlist__Button6.BackColor = System.Drawing.Color.Transparent;
            this.name__Playlist__Button6.ID_Playlist = 0;
            this.name__Playlist__Button6.IsHovered = false;
            this.name__Playlist__Button6.IsSelected = false;
            this.name__Playlist__Button6.Location = new System.Drawing.Point(29, 3);
            this.name__Playlist__Button6.Name = "name__Playlist__Button6";
            this.name__Playlist__Button6.Name_Playlist = null;
            this.name__Playlist__Button6.Size = new System.Drawing.Size(175, 45);
            this.name__Playlist__Button6.TabIndex = 5;
            // 
            // name__Playlist__Button5
            // 
            this.name__Playlist__Button5.BackColor = System.Drawing.Color.Transparent;
            this.name__Playlist__Button5.ID_Playlist = 0;
            this.name__Playlist__Button5.IsHovered = false;
            this.name__Playlist__Button5.IsSelected = false;
            this.name__Playlist__Button5.Location = new System.Drawing.Point(29, 54);
            this.name__Playlist__Button5.Name = "name__Playlist__Button5";
            this.name__Playlist__Button5.Name_Playlist = null;
            this.name__Playlist__Button5.Size = new System.Drawing.Size(175, 45);
            this.name__Playlist__Button5.TabIndex = 4;
            // 
            // name__Playlist__Button4
            // 
            this.name__Playlist__Button4.BackColor = System.Drawing.Color.Transparent;
            this.name__Playlist__Button4.ID_Playlist = 0;
            this.name__Playlist__Button4.IsHovered = false;
            this.name__Playlist__Button4.IsSelected = false;
            this.name__Playlist__Button4.Location = new System.Drawing.Point(29, 105);
            this.name__Playlist__Button4.Name = "name__Playlist__Button4";
            this.name__Playlist__Button4.Name_Playlist = null;
            this.name__Playlist__Button4.Size = new System.Drawing.Size(175, 45);
            this.name__Playlist__Button4.TabIndex = 3;
            // 
            // name__Playlist__Button1
            // 
            this.name__Playlist__Button1.BackColor = System.Drawing.Color.Transparent;
            this.name__Playlist__Button1.ID_Playlist = 0;
            this.name__Playlist__Button1.IsHovered = false;
            this.name__Playlist__Button1.IsSelected = false;
            this.name__Playlist__Button1.Location = new System.Drawing.Point(29, 156);
            this.name__Playlist__Button1.Name = "name__Playlist__Button1";
            this.name__Playlist__Button1.Name_Playlist = null;
            this.name__Playlist__Button1.Size = new System.Drawing.Size(175, 45);
            this.name__Playlist__Button1.TabIndex = 0;
            // 
            // name__Playlist__Button2
            // 
            this.name__Playlist__Button2.BackColor = System.Drawing.Color.Transparent;
            this.name__Playlist__Button2.ID_Playlist = 0;
            this.name__Playlist__Button2.IsHovered = false;
            this.name__Playlist__Button2.IsSelected = false;
            this.name__Playlist__Button2.Location = new System.Drawing.Point(29, 207);
            this.name__Playlist__Button2.Name = "name__Playlist__Button2";
            this.name__Playlist__Button2.Name_Playlist = null;
            this.name__Playlist__Button2.Size = new System.Drawing.Size(175, 45);
            this.name__Playlist__Button2.TabIndex = 1;
            // 
            // name__Playlist__Button3
            // 
            this.name__Playlist__Button3.BackColor = System.Drawing.Color.Transparent;
            this.name__Playlist__Button3.ID_Playlist = 0;
            this.name__Playlist__Button3.IsHovered = false;
            this.name__Playlist__Button3.IsSelected = false;
            this.name__Playlist__Button3.Location = new System.Drawing.Point(29, 258);
            this.name__Playlist__Button3.Name = "name__Playlist__Button3";
            this.name__Playlist__Button3.Name_Playlist = null;
            this.name__Playlist__Button3.Size = new System.Drawing.Size(175, 45);
            this.name__Playlist__Button3.TabIndex = 2;
            // 
            // VerticalLine
            // 
            this.VerticalLine.FillColor = System.Drawing.Color.White;
            this.VerticalLine.FillThickness = 5;
            this.VerticalLine.Location = new System.Drawing.Point(-2, 160);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(10, 45);
            this.VerticalLine.TabIndex = 4;
            // 
            // lblLibrary
            // 
            this.lblLibrary.AutoSize = true;
            this.lblLibrary.BackColor = System.Drawing.Color.Transparent;
            this.lblLibrary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrary.ForeColor = System.Drawing.Color.White;
            this.lblLibrary.Location = new System.Drawing.Point(32, 320);
            this.lblLibrary.Name = "lblLibrary";
            this.lblLibrary.Size = new System.Drawing.Size(76, 23);
            this.lblLibrary.TabIndex = 1;
            this.lblLibrary.Text = "LIBRARY";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.White;
            this.lblMenu.Location = new System.Drawing.Point(32, 123);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(60, 23);
            this.lblMenu.TabIndex = 1;
            this.lblMenu.Text = "MENU";
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnCreatePlaylist.BorderColor = System.Drawing.Color.Transparent;
            this.btnCreatePlaylist.BorderRadius = 10;
            this.btnCreatePlaylist.BorderThickness = 1;
            this.btnCreatePlaylist.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCreatePlaylist.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlaylist.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCreatePlaylist.CheckedState.Parent = this.btnCreatePlaylist;
            this.btnCreatePlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreatePlaylist.CustomImages.CheckedImage = global::Music__Player.Properties.Resources.icon_createplaylist_blue;
            this.btnCreatePlaylist.CustomImages.Image = global::Music__Player.Properties.Resources.icon_createplaylist_white;
            this.btnCreatePlaylist.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreatePlaylist.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnCreatePlaylist.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCreatePlaylist.CustomImages.Parent = this.btnCreatePlaylist;
            this.btnCreatePlaylist.FillColor = System.Drawing.Color.Transparent;
            this.btnCreatePlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlaylist.ForeColor = System.Drawing.Color.White;
            this.btnCreatePlaylist.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnCreatePlaylist.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnCreatePlaylist.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePlaylist.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCreatePlaylist.HoverState.Parent = this.btnCreatePlaylist;
            this.btnCreatePlaylist.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreatePlaylist.Location = new System.Drawing.Point(36, 510);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.ShadowDecoration.Parent = this.btnCreatePlaylist;
            this.btnCreatePlaylist.Size = new System.Drawing.Size(204, 45);
            this.btnCreatePlaylist.TabIndex = 0;
            this.btnCreatePlaylist.Text = "Create Playlist";
            this.btnCreatePlaylist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreatePlaylist.TextOffset = new System.Drawing.Point(47, 0);
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.BorderRadius = 10;
            this.btnPlaylist.BorderThickness = 1;
            this.btnPlaylist.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnPlaylist.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnPlaylist.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnPlaylist.CheckedState.Parent = this.btnPlaylist;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.CustomImages.CheckedImage = global::Music__Player.Properties.Resources.icon_playlist_blue;
            this.btnPlaylist.CustomImages.Image = global::Music__Player.Properties.Resources.icon_playlist_white;
            this.btnPlaylist.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlaylist.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnPlaylist.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPlaylist.CustomImages.Parent = this.btnPlaylist;
            this.btnPlaylist.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.White;
            this.btnPlaylist.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnPlaylist.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPlaylist.HoverState.Parent = this.btnPlaylist;
            this.btnPlaylist.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlaylist.Location = new System.Drawing.Point(36, 459);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.ShadowDecoration.Parent = this.btnPlaylist;
            this.btnPlaylist.Size = new System.Drawing.Size(170, 45);
            this.btnPlaylist.TabIndex = 0;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPlaylist.TextOffset = new System.Drawing.Point(47, 0);
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BorderColor = System.Drawing.Color.Transparent;
            this.btnHistory.BorderRadius = 10;
            this.btnHistory.BorderThickness = 1;
            this.btnHistory.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHistory.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnHistory.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHistory.CheckedState.Parent = this.btnHistory;
            this.btnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistory.CustomImages.CheckedImage = global::Music__Player.Properties.Resources.icon_history_blue;
            this.btnHistory.CustomImages.Image = global::Music__Player.Properties.Resources.icon_history_white;
            this.btnHistory.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnHistory.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHistory.CustomImages.Parent = this.btnHistory;
            this.btnHistory.FillColor = System.Drawing.Color.Transparent;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.ForeColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnHistory.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHistory.HoverState.Parent = this.btnHistory;
            this.btnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.Location = new System.Drawing.Point(36, 358);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.ShadowDecoration.Parent = this.btnHistory;
            this.btnHistory.Size = new System.Drawing.Size(170, 45);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.Text = "History";
            this.btnHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistory.TextOffset = new System.Drawing.Point(47, 0);
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnAlbums
            // 
            this.btnAlbums.BackColor = System.Drawing.Color.Transparent;
            this.btnAlbums.BorderColor = System.Drawing.Color.Transparent;
            this.btnAlbums.BorderRadius = 10;
            this.btnAlbums.BorderThickness = 1;
            this.btnAlbums.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAlbums.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAlbums.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbums.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnAlbums.CheckedState.Parent = this.btnAlbums;
            this.btnAlbums.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbums.CustomImages.CheckedImage = global::Music__Player.Properties.Resources.icon_album_blue;
            this.btnAlbums.CustomImages.Image = global::Music__Player.Properties.Resources.icon_album_white;
            this.btnAlbums.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAlbums.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnAlbums.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAlbums.CustomImages.Parent = this.btnAlbums;
            this.btnAlbums.FillColor = System.Drawing.Color.Transparent;
            this.btnAlbums.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbums.ForeColor = System.Drawing.Color.White;
            this.btnAlbums.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnAlbums.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnAlbums.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlbums.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnAlbums.HoverState.Parent = this.btnAlbums;
            this.btnAlbums.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAlbums.Location = new System.Drawing.Point(36, 261);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.ShadowDecoration.Parent = this.btnAlbums;
            this.btnAlbums.Size = new System.Drawing.Size(170, 45);
            this.btnAlbums.TabIndex = 0;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAlbums.TextOffset = new System.Drawing.Point(47, 0);
            this.btnAlbums.Click += new System.EventHandler(this.btnAlbums_Click);
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.Transparent;
            this.btnFavorite.BorderColor = System.Drawing.Color.Transparent;
            this.btnFavorite.BorderRadius = 10;
            this.btnFavorite.BorderThickness = 1;
            this.btnFavorite.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnFavorite.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnFavorite.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnFavorite.CheckedState.Parent = this.btnFavorite;
            this.btnFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFavorite.CustomImages.CheckedImage = global::Music__Player.Properties.Resources.icon_favorite_blue;
            this.btnFavorite.CustomImages.Image = global::Music__Player.Properties.Resources.icon_favorite_white;
            this.btnFavorite.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFavorite.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnFavorite.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFavorite.CustomImages.Parent = this.btnFavorite;
            this.btnFavorite.FillColor = System.Drawing.Color.Transparent;
            this.btnFavorite.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnFavorite.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnFavorite.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFavorite.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFavorite.HoverState.Parent = this.btnFavorite;
            this.btnFavorite.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFavorite.Location = new System.Drawing.Point(36, 408);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.ShadowDecoration.Parent = this.btnFavorite;
            this.btnFavorite.Size = new System.Drawing.Size(170, 45);
            this.btnFavorite.TabIndex = 0;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFavorite.TextOffset = new System.Drawing.Point(47, 0);
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnSongs
            // 
            this.btnSongs.BackColor = System.Drawing.Color.Transparent;
            this.btnSongs.BorderColor = System.Drawing.Color.Transparent;
            this.btnSongs.BorderRadius = 10;
            this.btnSongs.BorderThickness = 1;
            this.btnSongs.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSongs.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSongs.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSongs.CheckedState.Parent = this.btnSongs;
            this.btnSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSongs.CustomImages.CheckedImage = global::Music__Player.Properties.Resources.icon_song_blue;
            this.btnSongs.CustomImages.Image = global::Music__Player.Properties.Resources.icon_song_white;
            this.btnSongs.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSongs.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnSongs.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSongs.CustomImages.Parent = this.btnSongs;
            this.btnSongs.FillColor = System.Drawing.Color.Transparent;
            this.btnSongs.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.ForeColor = System.Drawing.Color.White;
            this.btnSongs.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnSongs.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnSongs.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSongs.HoverState.Parent = this.btnSongs;
            this.btnSongs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSongs.Location = new System.Drawing.Point(36, 211);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.ShadowDecoration.Parent = this.btnSongs;
            this.btnSongs.Size = new System.Drawing.Size(170, 45);
            this.btnSongs.TabIndex = 0;
            this.btnSongs.Text = "Songs";
            this.btnSongs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSongs.TextOffset = new System.Drawing.Point(47, 0);
            this.btnSongs.Click += new System.EventHandler(this.btnSongs_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderThickness = 1;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnHome.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.CustomImages.CheckedImage = global::Music__Player.Properties.Resources.icon_home_blue;
            this.btnHome.CustomImages.Image = global::Music__Player.Properties.Resources.icon_home_white;
            this.btnHome.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnHome.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(36, 160);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(170, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(47, 0);
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // borderForm
            // 
            this.borderForm.TargetControl = this;
            // 
            // panelMainScreen
            // 
            this.panelMainScreen.AutoScroll = true;
            this.panelMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainScreen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.panelMainScreen.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.panelMainScreen.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelMainScreen.Location = new System.Drawing.Point(242, 0);
            this.panelMainScreen.Name = "panelMainScreen";
            this.panelMainScreen.ShadowDecoration.Parent = this.panelMainScreen;
            this.panelMainScreen.Size = new System.Drawing.Size(1359, 965);
            this.panelMainScreen.TabIndex = 2;
            // 
            // Main__Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 965);
            this.Controls.Add(this.panelMainScreen);
            this.Controls.Add(this.panelSlideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main__Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSlideBar.ResumeLayout(false);
            this.panelSlideBar.PerformLayout();
            this.fpnlPlaylists.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl dragForm;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSlideBar;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnAlbums;
        private Guna.UI2.WinForms.Guna2Button btnSongs;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblLibrary;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnFavorite;
        private Guna.UI2.WinForms.Guna2VSeparator VerticalLine;
        private Guna.UI2.WinForms.Guna2Elipse borderForm;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMainScreen;
        private Guna.UI2.WinForms.Guna2Button btnCreatePlaylist;
        private System.Windows.Forms.FlowLayoutPanel fpnlPlaylists;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private sources.Custom.Name__Playlist__Button name__Playlist__Button5;
        private sources.Custom.Name__Playlist__Button name__Playlist__Button4;
        private sources.Custom.Name__Playlist__Button name__Playlist__Button1;
        private sources.Custom.Name__Playlist__Button name__Playlist__Button2;
        private sources.Custom.Name__Playlist__Button name__Playlist__Button3;
        private sources.Custom.Name__Playlist__Button name__Playlist__Button6;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnPlaylist;
    }
}

