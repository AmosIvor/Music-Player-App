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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.songPlayingBottomBar = new Music__Player.sources.Custom.Song__Playing__BottomBar();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton3 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblNumberSong = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbPlaylist = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.fpnlSongs = new System.Windows.Forms.FlowLayoutPanel();
            this.dtgvSongs = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlaylist)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSongs)).BeginInit();
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
            // songPlayingBottomBar
            // 
            this.songPlayingBottomBar.BackColor = System.Drawing.Color.Transparent;
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
            this.guna2Panel2.Controls.Add(this.guna2ImageButton3);
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
            // guna2ImageButton3
            // 
            this.guna2ImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ImageButton3.CheckedState.Image = global::Music__Player.Properties.Resources.icon_pause_blue_200;
            this.guna2ImageButton3.CheckedState.ImageSize = new System.Drawing.Size(190, 190);
            this.guna2ImageButton3.CheckedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton3.HoverState.ImageSize = new System.Drawing.Size(190, 190);
            this.guna2ImageButton3.HoverState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Image = global::Music__Player.Properties.Resources.icon_play_blue_1;
            this.guna2ImageButton3.ImageSize = new System.Drawing.Size(190, 190);
            this.guna2ImageButton3.Location = new System.Drawing.Point(852, 123);
            this.guna2ImageButton3.Name = "guna2ImageButton3";
            this.guna2ImageButton3.PressedState.ImageSize = new System.Drawing.Size(190, 190);
            this.guna2ImageButton3.PressedState.Parent = this.guna2ImageButton3;
            this.guna2ImageButton3.Size = new System.Drawing.Size(200, 200);
            this.guna2ImageButton3.TabIndex = 4;
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
            this.guna2Panel3.Controls.Add(this.fpnlSongs);
            this.guna2Panel3.Controls.Add(this.dtgvSongs);
            this.guna2Panel3.Controls.Add(this.guna2TextBox1);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 360);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1359, 505);
            this.guna2Panel3.TabIndex = 3;
            // 
            // fpnlSongs
            // 
            this.fpnlSongs.AutoScroll = true;
            this.fpnlSongs.AutoScrollMinSize = new System.Drawing.Size(1260, 339);
            this.fpnlSongs.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlSongs.Location = new System.Drawing.Point(40, 131);
            this.fpnlSongs.Name = "fpnlSongs";
            this.fpnlSongs.Size = new System.Drawing.Size(1294, 341);
            this.fpnlSongs.TabIndex = 7;
            this.fpnlSongs.WrapContents = false;
            // 
            // dtgvSongs
            // 
            this.dtgvSongs.AllowUserToAddRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dtgvSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dtgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvSongs.BackgroundColor = System.Drawing.Color.White;
            this.dtgvSongs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvSongs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvSongs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dtgvSongs.ColumnHeadersHeight = 50;
            this.dtgvSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvSongs.DefaultCellStyle = dataGridViewCellStyle24;
            this.dtgvSongs.EnableHeadersVisualStyles = false;
            this.dtgvSongs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvSongs.Location = new System.Drawing.Point(40, 82);
            this.dtgvSongs.Name = "dtgvSongs";
            this.dtgvSongs.ReadOnly = true;
            this.dtgvSongs.RowHeadersVisible = false;
            this.dtgvSongs.RowHeadersWidth = 51;
            this.dtgvSongs.RowTemplate.Height = 50;
            this.dtgvSongs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvSongs.Size = new System.Drawing.Size(1280, 52);
            this.dtgvSongs.TabIndex = 5;
            this.dtgvSongs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtgvSongs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvSongs.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvSongs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvSongs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvSongs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvSongs.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvSongs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvSongs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvSongs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvSongs.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvSongs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvSongs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvSongs.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgvSongs.ThemeStyle.ReadOnly = true;
            this.dtgvSongs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvSongs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvSongs.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtgvSongs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvSongs.ThemeStyle.RowsStyle.Height = 50;
            this.dtgvSongs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvSongs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 50;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.HeaderText = "TITLE";
            this.Column2.MinimumWidth = 320;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 320;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.HeaderText = "ARTIST";
            this.Column3.MinimumWidth = 310;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 310;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.HeaderText = "ALBUM";
            this.Column4.MinimumWidth = 320;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 320;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.HeaderText = "#";
            this.Column5.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column5.MinimumWidth = 60;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "DURATION";
            this.Column6.MinimumWidth = 150;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 18;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = global::Music__Player.Properties.Resources.icon_search_blue;
            this.guna2TextBox1.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(28, 28);
            this.guna2TextBox1.Location = new System.Drawing.Point(1016, 17);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "Search ...";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(304, 44);
            this.guna2TextBox1.TabIndex = 4;
            this.guna2TextBox1.TextOffset = new System.Drawing.Point(10, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSongs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblNumberSong;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbPlaylist;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton3;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvSongs;
        private Custom.Song__Playing__BottomBar songPlayingBottomBar;
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.FlowLayoutPanel fpnlSongs;
    }
}
