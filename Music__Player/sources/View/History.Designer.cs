namespace Music__Player.sources.View
{
    partial class History
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpkToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpkFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.panelPlayMusic = new Guna.UI2.WinForms.Guna2Panel();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.fpnlSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.songPlayingBottomBar = new Music__Player.sources.Custom.Song__Playing__BottomBar();
            this.song__History9 = new Music__Player.sources.Custom.Song__History();
            this.song__History1 = new Music__Player.sources.Custom.Song__History();
            this.song__History2 = new Music__Player.sources.Custom.Song__History();
            this.song__History3 = new Music__Player.sources.Custom.Song__History();
            this.song__History4 = new Music__Player.sources.Custom.Song__History();
            this.song__History5 = new Music__Player.sources.Custom.Song__History();
            this.song__History6 = new Music__Player.sources.Custom.Song__History();
            this.song__History7 = new Music__Player.sources.Custom.Song__History();
            this.song__History8 = new Music__Player.sources.Custom.Song__History();
            this.song__History10 = new Music__Player.sources.Custom.Song__History();
            this.panelPlayMusic.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.fpnlSongs.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "History played";
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CheckedState.Parent = this.dtpkToDate;
            this.dtpkToDate.FillColor = System.Drawing.Color.White;
            this.dtpkToDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkToDate.HoverState.Parent = this.dtpkToDate;
            this.dtpkToDate.Location = new System.Drawing.Point(1040, 107);
            this.dtpkToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.ShadowDecoration.Parent = this.dtpkToDate;
            this.dtpkToDate.Size = new System.Drawing.Size(200, 40);
            this.dtpkToDate.TabIndex = 1;
            this.dtpkToDate.Value = new System.DateTime(2022, 10, 20, 15, 43, 10, 942);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpkFromDate.CheckedState.Parent = this.dtpkFromDate;
            this.dtpkFromDate.FillColor = System.Drawing.Color.White;
            this.dtpkFromDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkFromDate.HoverState.Parent = this.dtpkFromDate;
            this.dtpkFromDate.Location = new System.Drawing.Point(824, 107);
            this.dtpkFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.ShadowDecoration.Parent = this.dtpkFromDate;
            this.dtpkFromDate.Size = new System.Drawing.Size(200, 40);
            this.dtpkFromDate.TabIndex = 2;
            this.dtpkFromDate.Value = new System.DateTime(2022, 10, 20, 15, 43, 16, 639);
            // 
            // panelPlayMusic
            // 
            this.panelPlayMusic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPlayMusic.Controls.Add(this.songPlayingBottomBar);
            this.panelPlayMusic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPlayMusic.Location = new System.Drawing.Point(0, 865);
            this.panelPlayMusic.Name = "panelPlayMusic";
            this.panelPlayMusic.ShadowDecoration.Parent = this.panelPlayMusic;
            this.panelPlayMusic.Size = new System.Drawing.Size(1359, 100);
            this.panelPlayMusic.TabIndex = 4;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Controls.Add(this.label7);
            this.panelContent.Controls.Add(this.label5);
            this.panelContent.Controls.Add(this.label4);
            this.panelContent.Controls.Add(this.label3);
            this.panelContent.Controls.Add(this.label6);
            this.panelContent.Controls.Add(this.label2);
            this.panelContent.Controls.Add(this.guna2Separator1);
            this.panelContent.Controls.Add(this.fpnlSongs);
            this.panelContent.Controls.Add(this.btnSearch);
            this.panelContent.Controls.Add(this.dtpkToDate);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.ShadowDecoration.Parent = this.panelContent;
            this.panelContent.Size = new System.Drawing.Size(1359, 965);
            this.panelContent.TabIndex = 5;
            // 
            // fpnlSongs
            // 
            this.fpnlSongs.AutoScroll = true;
            this.fpnlSongs.Controls.Add(this.song__History10);
            this.fpnlSongs.Controls.Add(this.song__History9);
            this.fpnlSongs.Controls.Add(this.song__History1);
            this.fpnlSongs.Controls.Add(this.song__History2);
            this.fpnlSongs.Controls.Add(this.song__History3);
            this.fpnlSongs.Controls.Add(this.song__History4);
            this.fpnlSongs.Controls.Add(this.song__History5);
            this.fpnlSongs.Controls.Add(this.song__History6);
            this.fpnlSongs.Controls.Add(this.song__History7);
            this.fpnlSongs.Controls.Add(this.song__History8);
            this.fpnlSongs.Location = new System.Drawing.Point(21, 230);
            this.fpnlSongs.Name = "fpnlSongs";
            this.fpnlSongs.Size = new System.Drawing.Size(1295, 596);
            this.fpnlSongs.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.CheckedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::Music__Player.Properties.Resources.icon_search_blue;
            this.btnSearch.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSearch.Location = new System.Drawing.Point(1259, 107);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnSearch.PressedState.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(21, 218);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1273, 10);
            this.guna2Separator1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "TITLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "ARTIST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(643, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "ALBUM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(958, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "DURATION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1168, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "DATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "#";
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
            // song__History9
            // 
            this.song__History9.Artist = null;
            this.song__History9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.song__History9.Date_Song = null;
            this.song__History9.Duration = null;
            this.song__History9.ID = null;
            this.song__History9.Image_Song = null;
            this.song__History9.IsFavorite = false;
            this.song__History9.IsHovered = false;
            this.song__History9.IsSelected = false;
            this.song__History9.Location = new System.Drawing.Point(3, 73);
            this.song__History9.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.song__History9.Name = "song__History9";
            this.song__History9.Name_Album = null;
            this.song__History9.Size = new System.Drawing.Size(1270, 70);
            this.song__History9.TabIndex = 8;
            this.song__History9.Title = null;
            this.song__History9.URL = null;
            // 
            // song__History1
            // 
            this.song__History1.Artist = null;
            this.song__History1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.song__History1.Date_Song = null;
            this.song__History1.Duration = null;
            this.song__History1.ID = null;
            this.song__History1.Image_Song = null;
            this.song__History1.IsFavorite = false;
            this.song__History1.IsHovered = false;
            this.song__History1.IsSelected = false;
            this.song__History1.Location = new System.Drawing.Point(3, 146);
            this.song__History1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.song__History1.Name = "song__History1";
            this.song__History1.Name_Album = null;
            this.song__History1.Size = new System.Drawing.Size(1270, 70);
            this.song__History1.TabIndex = 0;
            this.song__History1.Title = null;
            this.song__History1.URL = null;
            // 
            // song__History2
            // 
            this.song__History2.Artist = null;
            this.song__History2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.song__History2.Date_Song = null;
            this.song__History2.Duration = null;
            this.song__History2.ID = null;
            this.song__History2.Image_Song = null;
            this.song__History2.IsFavorite = false;
            this.song__History2.IsHovered = false;
            this.song__History2.IsSelected = false;
            this.song__History2.Location = new System.Drawing.Point(3, 219);
            this.song__History2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.song__History2.Name = "song__History2";
            this.song__History2.Name_Album = null;
            this.song__History2.Size = new System.Drawing.Size(1270, 70);
            this.song__History2.TabIndex = 1;
            this.song__History2.Title = null;
            this.song__History2.URL = null;
            // 
            // song__History3
            // 
            this.song__History3.Artist = null;
            this.song__History3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.song__History3.Date_Song = null;
            this.song__History3.Duration = null;
            this.song__History3.ID = null;
            this.song__History3.Image_Song = null;
            this.song__History3.IsFavorite = false;
            this.song__History3.IsHovered = false;
            this.song__History3.IsSelected = false;
            this.song__History3.Location = new System.Drawing.Point(3, 292);
            this.song__History3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.song__History3.Name = "song__History3";
            this.song__History3.Name_Album = null;
            this.song__History3.Size = new System.Drawing.Size(1270, 70);
            this.song__History3.TabIndex = 2;
            this.song__History3.Title = null;
            this.song__History3.URL = null;
            // 
            // song__History4
            // 
            this.song__History4.Artist = null;
            this.song__History4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.song__History4.Date_Song = null;
            this.song__History4.Duration = null;
            this.song__History4.ID = null;
            this.song__History4.Image_Song = null;
            this.song__History4.IsFavorite = false;
            this.song__History4.IsHovered = false;
            this.song__History4.IsSelected = false;
            this.song__History4.Location = new System.Drawing.Point(3, 365);
            this.song__History4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.song__History4.Name = "song__History4";
            this.song__History4.Name_Album = null;
            this.song__History4.Size = new System.Drawing.Size(1270, 70);
            this.song__History4.TabIndex = 3;
            this.song__History4.Title = null;
            this.song__History4.URL = null;
            // 
            // song__History5
            // 
            this.song__History5.Artist = null;
            this.song__History5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.song__History5.Date_Song = null;
            this.song__History5.Duration = null;
            this.song__History5.ID = null;
            this.song__History5.Image_Song = null;
            this.song__History5.IsFavorite = false;
            this.song__History5.IsHovered = false;
            this.song__History5.IsSelected = false;
            this.song__History5.Location = new System.Drawing.Point(3, 438);
            this.song__History5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.song__History5.Name = "song__History5";
            this.song__History5.Name_Album = null;
            this.song__History5.Size = new System.Drawing.Size(1270, 70);
            this.song__History5.TabIndex = 4;
            this.song__History5.Title = null;
            this.song__History5.URL = null;
            // 
            // song__History6
            // 
            this.song__History6.Artist = null;
            this.song__History6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.song__History6.Date_Song = null;
            this.song__History6.Duration = null;
            this.song__History6.ID = null;
            this.song__History6.Image_Song = null;
            this.song__History6.IsFavorite = false;
            this.song__History6.IsHovered = false;
            this.song__History6.IsSelected = false;
            this.song__History6.Location = new System.Drawing.Point(3, 511);
            this.song__History6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.song__History6.Name = "song__History6";
            this.song__History6.Name_Album = null;
            this.song__History6.Size = new System.Drawing.Size(1270, 70);
            this.song__History6.TabIndex = 5;
            this.song__History6.Title = null;
            this.song__History6.URL = null;
            // 
            // song__History7
            // 
            this.song__History7.Artist = null;
            this.song__History7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.song__History7.Date_Song = null;
            this.song__History7.Duration = null;
            this.song__History7.ID = null;
            this.song__History7.Image_Song = null;
            this.song__History7.IsFavorite = false;
            this.song__History7.IsHovered = false;
            this.song__History7.IsSelected = false;
            this.song__History7.Location = new System.Drawing.Point(3, 584);
            this.song__History7.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.song__History7.Name = "song__History7";
            this.song__History7.Name_Album = null;
            this.song__History7.Size = new System.Drawing.Size(1270, 70);
            this.song__History7.TabIndex = 6;
            this.song__History7.Title = null;
            this.song__History7.URL = null;
            // 
            // song__History8
            // 
            this.song__History8.Artist = null;
            this.song__History8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.song__History8.Date_Song = null;
            this.song__History8.Duration = null;
            this.song__History8.ID = null;
            this.song__History8.Image_Song = null;
            this.song__History8.IsFavorite = false;
            this.song__History8.IsHovered = false;
            this.song__History8.IsSelected = false;
            this.song__History8.Location = new System.Drawing.Point(3, 657);
            this.song__History8.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.song__History8.Name = "song__History8";
            this.song__History8.Name_Album = null;
            this.song__History8.Size = new System.Drawing.Size(1270, 70);
            this.song__History8.TabIndex = 7;
            this.song__History8.Title = null;
            this.song__History8.URL = null;
            // 
            // song__History10
            // 
            this.song__History10.Artist = null;
            this.song__History10.BackColor = System.Drawing.Color.Transparent;
            this.song__History10.Date_Song = null;
            this.song__History10.Duration = null;
            this.song__History10.ID = null;
            this.song__History10.Image_Song = null;
            this.song__History10.IsFavorite = false;
            this.song__History10.IsHovered = false;
            this.song__History10.IsSelected = false;
            this.song__History10.Location = new System.Drawing.Point(3, 0);
            this.song__History10.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.song__History10.Name = "song__History10";
            this.song__History10.Name_Album = null;
            this.song__History10.Size = new System.Drawing.Size(1270, 70);
            this.song__History10.TabIndex = 9;
            this.song__History10.Title = null;
            this.song__History10.URL = null;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPlayMusic);
            this.Controls.Add(this.dtpkFromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContent);
            this.Name = "History";
            this.Size = new System.Drawing.Size(1359, 965);
            this.panelPlayMusic.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.fpnlSongs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkFromDate;
        private Guna.UI2.WinForms.Guna2ImageButton btnSearch;
        private Guna.UI2.WinForms.Guna2Panel panelPlayMusic;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private System.Windows.Forms.FlowLayoutPanel fpnlSongs;
        private Custom.Song__History song__History9;
        private Custom.Song__History song__History1;
        private Custom.Song__History song__History2;
        private Custom.Song__History song__History3;
        private Custom.Song__History song__History4;
        private Custom.Song__History song__History5;
        private Custom.Song__History song__History6;
        private Custom.Song__History song__History7;
        private Custom.Song__History song__History8;
        private Custom.Song__Playing__BottomBar songPlayingBottomBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Custom.Song__History song__History10;
    }
}
