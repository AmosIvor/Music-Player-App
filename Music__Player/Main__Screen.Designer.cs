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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main__Screen));
            this.dragForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panelSlideBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.VerticalLine = new Guna.UI2.WinForms.Guna2VSeparator();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button10 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.btnName1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlaylist = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.lblLibrary = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnCreatePlaylist = new Guna.UI2.WinForms.Guna2Button();
            this.btnLocalFiles = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlbums = new Guna.UI2.WinForms.Guna2Button();
            this.btnFavorite = new Guna.UI2.WinForms.Guna2Button();
            this.btnRecent = new Guna.UI2.WinForms.Guna2Button();
            this.btnSongs = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.borderForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelMainScreen = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.homeScreen = new Music__Player.sources.View.Home();
            this.panelTitle.SuspendLayout();
            this.panelSlideBar.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelMainScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dragForm
            // 
            this.dragForm.TargetControl = this.panelTitle;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTitle.Controls.Add(this.btnExit);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.ShadowDecoration.Parent = this.panelTitle;
            this.panelTitle.Size = new System.Drawing.Size(1601, 36);
            this.panelTitle.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.Parent = this.btnExit;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.CustomImages.Parent = this.btnExit;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.Location = new System.Drawing.Point(1566, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(35, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "x";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelSlideBar
            // 
            this.panelSlideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelSlideBar.Controls.Add(this.VerticalLine);
            this.panelSlideBar.Controls.Add(this.guna2Panel1);
            this.panelSlideBar.Controls.Add(this.btnPlaylist);
            this.panelSlideBar.Controls.Add(this.lblPlaylist);
            this.panelSlideBar.Controls.Add(this.lblLibrary);
            this.panelSlideBar.Controls.Add(this.lblMenu);
            this.panelSlideBar.Controls.Add(this.btnCreatePlaylist);
            this.panelSlideBar.Controls.Add(this.btnLocalFiles);
            this.panelSlideBar.Controls.Add(this.btnHistory);
            this.panelSlideBar.Controls.Add(this.btnAlbums);
            this.panelSlideBar.Controls.Add(this.btnFavorite);
            this.panelSlideBar.Controls.Add(this.btnRecent);
            this.panelSlideBar.Controls.Add(this.btnSongs);
            this.panelSlideBar.Controls.Add(this.btnHome);
            this.panelSlideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelSlideBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelSlideBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelSlideBar.Location = new System.Drawing.Point(0, 36);
            this.panelSlideBar.Name = "panelSlideBar";
            this.panelSlideBar.ShadowDecoration.Parent = this.panelSlideBar;
            this.panelSlideBar.Size = new System.Drawing.Size(242, 965);
            this.panelSlideBar.TabIndex = 1;
            // 
            // VerticalLine
            // 
            this.VerticalLine.FillColor = System.Drawing.Color.White;
            this.VerticalLine.FillThickness = 5;
            this.VerticalLine.Location = new System.Drawing.Point(-2, 75);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(10, 45);
            this.VerticalLine.TabIndex = 4;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.AutoScrollMinSize = new System.Drawing.Size(0, 150);
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.guna2Button9);
            this.guna2Panel1.Controls.Add(this.guna2Button10);
            this.guna2Panel1.Controls.Add(this.guna2Button11);
            this.guna2Panel1.Controls.Add(this.btnName1);
            this.guna2Panel1.Location = new System.Drawing.Point(7, 577);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(227, 215);
            this.guna2Panel1.TabIndex = 3;
            // 
            // guna2Button9
            // 
            this.guna2Button9.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button9.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button9.BorderRadius = 10;
            this.guna2Button9.BorderThickness = 1;
            this.guna2Button9.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button9.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button9.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button9.CheckedState.Parent = this.guna2Button9;
            this.guna2Button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button9.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("guna2Button9.CustomImages.CheckedImage")));
            this.guna2Button9.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button9.CustomImages.Image")));
            this.guna2Button9.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.guna2Button9.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button9.CustomImages.Parent = this.guna2Button9;
            this.guna2Button9.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button9.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button9.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button9.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button9.HoverState.Parent = this.guna2Button9;
            this.guna2Button9.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.Location = new System.Drawing.Point(29, 162);
            this.guna2Button9.Name = "guna2Button9";
            this.guna2Button9.ShadowDecoration.Parent = this.guna2Button9;
            this.guna2Button9.Size = new System.Drawing.Size(170, 45);
            this.guna2Button9.TabIndex = 1;
            this.guna2Button9.Text = "Name4";
            this.guna2Button9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button9.TextOffset = new System.Drawing.Point(47, 0);
            // 
            // guna2Button10
            // 
            this.guna2Button10.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button10.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button10.BorderRadius = 10;
            this.guna2Button10.BorderThickness = 1;
            this.guna2Button10.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button10.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button10.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button10.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button10.CheckedState.Parent = this.guna2Button10;
            this.guna2Button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button10.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("guna2Button10.CustomImages.CheckedImage")));
            this.guna2Button10.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button10.CustomImages.Image")));
            this.guna2Button10.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button10.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.guna2Button10.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button10.CustomImages.Parent = this.guna2Button10;
            this.guna2Button10.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button10.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button10.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button10.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button10.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button10.HoverState.Parent = this.guna2Button10;
            this.guna2Button10.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button10.Location = new System.Drawing.Point(29, 111);
            this.guna2Button10.Name = "guna2Button10";
            this.guna2Button10.ShadowDecoration.Parent = this.guna2Button10;
            this.guna2Button10.Size = new System.Drawing.Size(170, 45);
            this.guna2Button10.TabIndex = 2;
            this.guna2Button10.Text = "Name3";
            this.guna2Button10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button10.TextOffset = new System.Drawing.Point(47, 0);
            // 
            // guna2Button11
            // 
            this.guna2Button11.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button11.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button11.BorderRadius = 10;
            this.guna2Button11.BorderThickness = 1;
            this.guna2Button11.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button11.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button11.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Button11.CheckedState.Parent = this.guna2Button11;
            this.guna2Button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button11.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("guna2Button11.CustomImages.CheckedImage")));
            this.guna2Button11.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button11.CustomImages.Image")));
            this.guna2Button11.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button11.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.guna2Button11.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button11.CustomImages.Parent = this.guna2Button11;
            this.guna2Button11.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2Button11.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button11.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button11.HoverState.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.HoverState.Parent = this.guna2Button11;
            this.guna2Button11.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button11.Location = new System.Drawing.Point(29, 60);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.ShadowDecoration.Parent = this.guna2Button11;
            this.guna2Button11.Size = new System.Drawing.Size(170, 45);
            this.guna2Button11.TabIndex = 3;
            this.guna2Button11.Text = "Name2";
            this.guna2Button11.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button11.TextOffset = new System.Drawing.Point(47, 0);
            // 
            // btnName1
            // 
            this.btnName1.BackColor = System.Drawing.Color.Transparent;
            this.btnName1.BorderColor = System.Drawing.Color.Transparent;
            this.btnName1.BorderRadius = 10;
            this.btnName1.BorderThickness = 1;
            this.btnName1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnName1.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnName1.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName1.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnName1.CheckedState.Parent = this.btnName1;
            this.btnName1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnName1.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnName1.CustomImages.CheckedImage")));
            this.btnName1.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btnName1.CustomImages.Image")));
            this.btnName1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnName1.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnName1.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnName1.CustomImages.Parent = this.btnName1;
            this.btnName1.FillColor = System.Drawing.Color.Transparent;
            this.btnName1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName1.ForeColor = System.Drawing.Color.White;
            this.btnName1.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnName1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnName1.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnName1.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnName1.HoverState.Parent = this.btnName1;
            this.btnName1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnName1.Location = new System.Drawing.Point(29, 9);
            this.btnName1.Name = "btnName1";
            this.btnName1.ShadowDecoration.Parent = this.btnName1;
            this.btnName1.Size = new System.Drawing.Size(170, 45);
            this.btnName1.TabIndex = 4;
            this.btnName1.Text = "Name1";
            this.btnName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnName1.TextOffset = new System.Drawing.Point(47, 0);
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.btnPlaylist.CheckedState.ImageSize = new System.Drawing.Size(34, 34);
            this.btnPlaylist.CheckedState.Parent = this.btnPlaylist;
            this.btnPlaylist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaylist.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnPlaylist.HoverState.Parent = this.btnPlaylist;
            this.btnPlaylist.Image = global::Music__Player.Properties.Resources.icon_skip_blue;
            this.btnPlaylist.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPlaylist.Location = new System.Drawing.Point(172, 436);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.PressedState.Parent = this.btnPlaylist;
            this.btnPlaylist.Size = new System.Drawing.Size(34, 34);
            this.btnPlaylist.TabIndex = 2;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.lblPlaylist.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaylist.ForeColor = System.Drawing.Color.White;
            this.lblPlaylist.Location = new System.Drawing.Point(32, 442);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(79, 23);
            this.lblPlaylist.TabIndex = 1;
            this.lblPlaylist.Text = "PLAYLIST";
            // 
            // lblLibrary
            // 
            this.lblLibrary.AutoSize = true;
            this.lblLibrary.BackColor = System.Drawing.Color.Transparent;
            this.lblLibrary.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibrary.ForeColor = System.Drawing.Color.White;
            this.lblLibrary.Location = new System.Drawing.Point(32, 241);
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
            this.lblMenu.Location = new System.Drawing.Point(32, 41);
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
            this.btnCreatePlaylist.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
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
            this.btnCreatePlaylist.Location = new System.Drawing.Point(36, 531);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.ShadowDecoration.Parent = this.btnCreatePlaylist;
            this.btnCreatePlaylist.Size = new System.Drawing.Size(204, 45);
            this.btnCreatePlaylist.TabIndex = 0;
            this.btnCreatePlaylist.Text = "Create Playlist";
            this.btnCreatePlaylist.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCreatePlaylist.TextOffset = new System.Drawing.Point(47, 0);
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // btnLocalFiles
            // 
            this.btnLocalFiles.BackColor = System.Drawing.Color.Transparent;
            this.btnLocalFiles.BorderColor = System.Drawing.Color.Transparent;
            this.btnLocalFiles.BorderRadius = 10;
            this.btnLocalFiles.BorderThickness = 1;
            this.btnLocalFiles.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLocalFiles.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLocalFiles.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalFiles.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLocalFiles.CheckedState.Parent = this.btnLocalFiles;
            this.btnLocalFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLocalFiles.CustomImages.CheckedImage = global::Music__Player.Properties.Resources.icon_file_blue;
            this.btnLocalFiles.CustomImages.Image = global::Music__Player.Properties.Resources.icon_file_white;
            this.btnLocalFiles.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLocalFiles.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnLocalFiles.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLocalFiles.CustomImages.Parent = this.btnLocalFiles;
            this.btnLocalFiles.FillColor = System.Drawing.Color.Transparent;
            this.btnLocalFiles.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalFiles.ForeColor = System.Drawing.Color.White;
            this.btnLocalFiles.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnLocalFiles.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLocalFiles.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLocalFiles.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLocalFiles.HoverState.Parent = this.btnLocalFiles;
            this.btnLocalFiles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLocalFiles.Location = new System.Drawing.Point(36, 377);
            this.btnLocalFiles.Name = "btnLocalFiles";
            this.btnLocalFiles.ShadowDecoration.Parent = this.btnLocalFiles;
            this.btnLocalFiles.Size = new System.Drawing.Size(170, 45);
            this.btnLocalFiles.TabIndex = 0;
            this.btnLocalFiles.Text = "Local Files";
            this.btnLocalFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLocalFiles.TextOffset = new System.Drawing.Point(47, 0);
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
            this.btnHistory.Location = new System.Drawing.Point(36, 326);
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
            this.btnAlbums.Location = new System.Drawing.Point(36, 177);
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
            this.btnFavorite.Location = new System.Drawing.Point(36, 480);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.ShadowDecoration.Parent = this.btnFavorite;
            this.btnFavorite.Size = new System.Drawing.Size(170, 45);
            this.btnFavorite.TabIndex = 0;
            this.btnFavorite.Text = "Favorite";
            this.btnFavorite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFavorite.TextOffset = new System.Drawing.Point(47, 0);
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // btnRecent
            // 
            this.btnRecent.BackColor = System.Drawing.Color.Transparent;
            this.btnRecent.BorderColor = System.Drawing.Color.Transparent;
            this.btnRecent.BorderRadius = 10;
            this.btnRecent.BorderThickness = 1;
            this.btnRecent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRecent.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRecent.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecent.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnRecent.CheckedState.Parent = this.btnRecent;
            this.btnRecent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecent.CustomImages.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnRecent.CustomImages.CheckedImage")));
            this.btnRecent.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("btnRecent.CustomImages.Image")));
            this.btnRecent.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRecent.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnRecent.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRecent.CustomImages.Parent = this.btnRecent;
            this.btnRecent.FillColor = System.Drawing.Color.Transparent;
            this.btnRecent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecent.ForeColor = System.Drawing.Color.White;
            this.btnRecent.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnRecent.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnRecent.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecent.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRecent.HoverState.Parent = this.btnRecent;
            this.btnRecent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRecent.Location = new System.Drawing.Point(36, 275);
            this.btnRecent.Name = "btnRecent";
            this.btnRecent.ShadowDecoration.Parent = this.btnRecent;
            this.btnRecent.Size = new System.Drawing.Size(170, 45);
            this.btnRecent.TabIndex = 0;
            this.btnRecent.Text = "Recent";
            this.btnRecent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRecent.TextOffset = new System.Drawing.Point(47, 0);
            this.btnRecent.Click += new System.EventHandler(this.btnRecent_Click);
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
            this.btnSongs.Location = new System.Drawing.Point(36, 126);
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
            this.btnHome.Location = new System.Drawing.Point(36, 75);
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
            this.panelMainScreen.Controls.Add(this.homeScreen);
            this.panelMainScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainScreen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.panelMainScreen.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.panelMainScreen.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelMainScreen.Location = new System.Drawing.Point(242, 36);
            this.panelMainScreen.Name = "panelMainScreen";
            this.panelMainScreen.ShadowDecoration.Parent = this.panelMainScreen;
            this.panelMainScreen.Size = new System.Drawing.Size(1359, 965);
            this.panelMainScreen.TabIndex = 2;
            // 
            // homeScreen
            // 
            this.homeScreen.BackColor = System.Drawing.Color.Transparent;
            this.homeScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeScreen.Location = new System.Drawing.Point(0, 0);
            this.homeScreen.Name = "homeScreen";
            this.homeScreen.Size = new System.Drawing.Size(1359, 965);
            this.homeScreen.TabIndex = 0;
            // 
            // Main__Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 1001);
            this.Controls.Add(this.panelMainScreen);
            this.Controls.Add(this.panelSlideBar);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main__Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTitle.ResumeLayout(false);
            this.panelSlideBar.ResumeLayout(false);
            this.panelSlideBar.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.panelMainScreen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl dragForm;
        private Guna.UI2.WinForms.Guna2Panel panelTitle;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSlideBar;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnAlbums;
        private Guna.UI2.WinForms.Guna2Button btnSongs;
        private System.Windows.Forms.Label lblMenu;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlaylist;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Label lblLibrary;
        private Guna.UI2.WinForms.Guna2Button btnLocalFiles;
        private Guna.UI2.WinForms.Guna2Button btnHistory;
        private Guna.UI2.WinForms.Guna2Button btnFavorite;
        private Guna.UI2.WinForms.Guna2Button btnRecent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button9;
        private Guna.UI2.WinForms.Guna2Button guna2Button10;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2Button btnName1;
        private Guna.UI2.WinForms.Guna2VSeparator VerticalLine;
        private Guna.UI2.WinForms.Guna2Elipse borderForm;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMainScreen;
        private sources.View.Home homeScreen;
        private Guna.UI2.WinForms.Guna2Button btnCreatePlaylist;
    }
}

