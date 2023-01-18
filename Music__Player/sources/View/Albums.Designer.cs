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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.album__Panel1 = new Music__Player.sources.Custom.Album__Panel();
            this.album__Panel2 = new Music__Player.sources.Custom.Album__Panel();
            this.album__Panel3 = new Music__Player.sources.Custom.Album__Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.album__Panel1);
            this.flowLayoutPanel1.Controls.Add(this.album__Panel2);
            this.flowLayoutPanel1.Controls.Add(this.album__Panel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1359, 965);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // album__Panel1
            // 
            this.album__Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.album__Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.album__Panel1.Location = new System.Drawing.Point(3, 3);
            this.album__Panel1.Name = "album__Panel1";
            this.album__Panel1.Size = new System.Drawing.Size(1359, 363);
            this.album__Panel1.TabIndex = 0;
            this.album__Panel1.TypeAlbum = null;
            // 
            // album__Panel2
            // 
            this.album__Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.album__Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.album__Panel2.Location = new System.Drawing.Point(3, 372);
            this.album__Panel2.Name = "album__Panel2";
            this.album__Panel2.Size = new System.Drawing.Size(1359, 363);
            this.album__Panel2.TabIndex = 1;
            this.album__Panel2.TypeAlbum = null;
            // 
            // album__Panel3
            // 
            this.album__Panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.album__Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.album__Panel3.Location = new System.Drawing.Point(3, 741);
            this.album__Panel3.Name = "album__Panel3";
            this.album__Panel3.Size = new System.Drawing.Size(1359, 363);
            this.album__Panel3.TabIndex = 2;
            this.album__Panel3.TypeAlbum = null;
            // 
            // Albums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Albums";
            this.Size = new System.Drawing.Size(1359, 965);
            this.Load += new System.EventHandler(this.Albums_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Custom.Album__Panel album__Panel1;
        private Custom.Album__Panel album__Panel2;
        private Custom.Album__Panel album__Panel3;
    }
}
