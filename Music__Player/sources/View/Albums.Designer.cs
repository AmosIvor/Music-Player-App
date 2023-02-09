namespace Music__Player.sources.View
{
    partial class Albums
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
            this.btnBack = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnNext = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fpnlArtist = new System.Windows.Forms.FlowLayoutPanel();
            this.fpnlGenre = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.songPlayingBottomBar = new Music__Player.sources.Custom.Song__Playing__BottomBar();
            this.pnlBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 0;
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
            this.btnNext.TabIndex = 0;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
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
            this.pnlBottom.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.fpnlArtist);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.fpnlGenre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1359, 865);
            this.panel1.TabIndex = 4;
            // 
            // fpnlArtist
            // 
            this.fpnlArtist.AutoScroll = true;
            this.fpnlArtist.Location = new System.Drawing.Point(46, 510);
            this.fpnlArtist.Name = "fpnlArtist";
            this.fpnlArtist.Size = new System.Drawing.Size(1294, 303);
            this.fpnlArtist.TabIndex = 5;
            // 
            // fpnlGenre
            // 
            this.fpnlGenre.Location = new System.Drawing.Point(43, 121);
            this.fpnlGenre.Name = "fpnlGenre";
            this.fpnlGenre.Size = new System.Drawing.Size(1294, 303);
            this.fpnlGenre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Genre";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Artist";
            // 
            // songPlayingBottomBar
            // 
            this.songPlayingBottomBar.BackColor = System.Drawing.Color.Transparent;
            this.songPlayingBottomBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songPlayingBottomBar.IsPlay = false;
            this.songPlayingBottomBar.ListSong = null;
            this.songPlayingBottomBar.Location = new System.Drawing.Point(0, 0);
            this.songPlayingBottomBar.Name = "songPlayingBottomBar";
            this.songPlayingBottomBar.PlayingSong = null;
            this.songPlayingBottomBar.Size = new System.Drawing.Size(1359, 100);
            this.songPlayingBottomBar.TabIndex = 0;
            // 
            // Albums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBottom);
            this.Name = "Albums";
            this.Size = new System.Drawing.Size(1359, 965);
            this.pnlBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnBack;
        private Guna.UI2.WinForms.Guna2ImageButton btnNext;
        private Guna.UI2.WinForms.Guna2Panel pnlBottom;
        private Custom.Song__Playing__BottomBar songPlayingBottomBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel fpnlArtist;
        private System.Windows.Forms.FlowLayoutPanel fpnlGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}
