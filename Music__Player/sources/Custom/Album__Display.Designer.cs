namespace Music__Player.sources.Custom
{
    partial class Album__Display
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
            this.pbImageAlbum = new System.Windows.Forms.PictureBox();
            this.lbNameAlbum = new System.Windows.Forms.Label();
            this.ShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnPlaySong = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageAlbum)).BeginInit();
            this.ShadowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbImageAlbum
            // 
            this.pbImageAlbum.Image = global::Music__Player.Properties.Resources.draft;
            this.pbImageAlbum.Location = new System.Drawing.Point(18, 17);
            this.pbImageAlbum.Name = "pbImageAlbum";
            this.pbImageAlbum.Size = new System.Drawing.Size(167, 160);
            this.pbImageAlbum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageAlbum.TabIndex = 0;
            this.pbImageAlbum.TabStop = false;
            this.pbImageAlbum.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbImageAlbum.MouseEnter += new System.EventHandler(this.btnPlaySong_MouseEnter);
            this.pbImageAlbum.MouseLeave += new System.EventHandler(this.btnPlaySong_MouseLeave);
            this.pbImageAlbum.MouseHover += new System.EventHandler(this.btnPlaySong_MouseEnter);
            // 
            // lbNameAlbum
            // 
            this.lbNameAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameAlbum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbNameAlbum.Location = new System.Drawing.Point(15, 204);
            this.lbNameAlbum.Name = "lbNameAlbum";
            this.lbNameAlbum.Size = new System.Drawing.Size(169, 40);
            this.lbNameAlbum.TabIndex = 1;
            this.lbNameAlbum.Text = "Album Collection Hello Hung dep trai";
            this.lbNameAlbum.MouseEnter += new System.EventHandler(this.btnPlaySong_MouseEnter);
            this.lbNameAlbum.MouseLeave += new System.EventHandler(this.btnPlaySong_MouseLeave);
            this.lbNameAlbum.MouseHover += new System.EventHandler(this.btnPlaySong_MouseEnter);
            // 
            // ShadowPanel
            // 
            this.ShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.ShadowPanel.Controls.Add(this.btnPlaySong);
            this.ShadowPanel.Controls.Add(this.lbNameAlbum);
            this.ShadowPanel.Controls.Add(this.pbImageAlbum);
            this.ShadowPanel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.ShadowPanel.Location = new System.Drawing.Point(5, 3);
            this.ShadowPanel.Name = "ShadowPanel";
            this.ShadowPanel.Radius = 2;
            this.ShadowPanel.ShadowColor = System.Drawing.Color.DimGray;
            this.ShadowPanel.Size = new System.Drawing.Size(201, 271);
            this.ShadowPanel.TabIndex = 0;
            this.ShadowPanel.MouseEnter += new System.EventHandler(this.btnPlaySong_MouseEnter);
            this.ShadowPanel.MouseLeave += new System.EventHandler(this.btnPlaySong_MouseLeave);
            this.ShadowPanel.MouseHover += new System.EventHandler(this.btnPlaySong_MouseEnter);
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.CheckedState.Image = global::Music__Player.Properties.Resources.icon_pause_green;
            this.btnPlaySong.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPlaySong.CheckedState.Parent = this.btnPlaySong;
            this.btnPlaySong.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPlaySong.HoverState.Parent = this.btnPlaySong;
            this.btnPlaySong.Image = global::Music__Player.Properties.Resources.icon_play_green;
            this.btnPlaySong.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPlaySong.Location = new System.Drawing.Point(130, 119);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPlaySong.PressedState.Parent = this.btnPlaySong;
            this.btnPlaySong.Size = new System.Drawing.Size(54, 53);
            this.btnPlaySong.TabIndex = 3;
            this.btnPlaySong.UseTransparentBackground = true;
            this.btnPlaySong.MouseEnter += new System.EventHandler(this.btnPlaySong_MouseEnter);
            this.btnPlaySong.MouseLeave += new System.EventHandler(this.btnPlaySong_MouseLeave);
            this.btnPlaySong.MouseHover += new System.EventHandler(this.btnPlaySong_MouseEnter);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Album__Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ShadowPanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Album__Display";
            this.Size = new System.Drawing.Size(213, 274);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageAlbum)).EndInit();
            this.ShadowPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImageAlbum;
        private System.Windows.Forms.Label lbNameAlbum;
        private Guna.UI2.WinForms.Guna2ShadowPanel ShadowPanel;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlaySong;
        private System.Windows.Forms.ImageList imageList2;
    }
}
