namespace Music__Player.sources.Custom
{
    partial class Album__Panel
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
            this.lbTypeAlbum = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.album__Display1 = new Music__Player.sources.Custom.Album__Display();
            this.album__Display2 = new Music__Player.sources.Custom.Album__Display();
            this.album__Display3 = new Music__Player.sources.Custom.Album__Display();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTypeAlbum
            // 
            this.lbTypeAlbum.AutoSize = true;
            this.lbTypeAlbum.BackColor = System.Drawing.Color.Transparent;
            this.lbTypeAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeAlbum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTypeAlbum.Location = new System.Drawing.Point(3, 20);
            this.lbTypeAlbum.Name = "lbTypeAlbum";
            this.lbTypeAlbum.Size = new System.Drawing.Size(179, 30);
            this.lbTypeAlbum.TabIndex = 1;
            this.lbTypeAlbum.Text = "Thể loại nhạc";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.album__Display1);
            this.flowLayoutPanel1.Controls.Add(this.album__Display2);
            this.flowLayoutPanel1.Controls.Add(this.album__Display3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1359, 287);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // album__Display1
            // 
            this.album__Display1.AlbumName = null;
            this.album__Display1.BackColor = System.Drawing.Color.Transparent;
            this.album__Display1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.album__Display1.ImageAlbum = null;
            this.album__Display1.Location = new System.Drawing.Point(3, 3);
            this.album__Display1.Name = "album__Display1";
            this.album__Display1.Size = new System.Drawing.Size(213, 274);
            this.album__Display1.TabIndex = 0;
            // 
            // album__Display2
            // 
            this.album__Display2.AlbumName = null;
            this.album__Display2.BackColor = System.Drawing.Color.Transparent;
            this.album__Display2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.album__Display2.ImageAlbum = null;
            this.album__Display2.Location = new System.Drawing.Point(222, 3);
            this.album__Display2.Name = "album__Display2";
            this.album__Display2.Size = new System.Drawing.Size(213, 274);
            this.album__Display2.TabIndex = 1;
            // 
            // album__Display3
            // 
            this.album__Display3.AlbumName = null;
            this.album__Display3.BackColor = System.Drawing.Color.Transparent;
            this.album__Display3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.album__Display3.ImageAlbum = null;
            this.album__Display3.Location = new System.Drawing.Point(441, 3);
            this.album__Display3.Name = "album__Display3";
            this.album__Display3.Size = new System.Drawing.Size(213, 274);
            this.album__Display3.TabIndex = 2;
            // 
            // Album__Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.lbTypeAlbum);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Album__Panel";
            this.Size = new System.Drawing.Size(1359, 363);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTypeAlbum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Album__Display album__Display1;
        private Album__Display album__Display2;
        private Album__Display album__Display3;
    }
}
