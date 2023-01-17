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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.album__Panel2 = new Music__Player.sources.Custom.Album__Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.album__Panel3 = new Music__Player.sources.Custom.Album__Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.album__Panel1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1359, 965);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // album__Panel1
            // 
            this.album__Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.album__Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.album__Panel1.Location = new System.Drawing.Point(3, 3);
            this.album__Panel1.Name = "album__Panel1";
            this.album__Panel1.Size = new System.Drawing.Size(1359, 363);
            this.album__Panel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.album__Panel2);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 372);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1371, 744);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // album__Panel2
            // 
            this.album__Panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.album__Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.album__Panel2.Location = new System.Drawing.Point(3, 3);
            this.album__Panel2.Name = "album__Panel2";
            this.album__Panel2.Size = new System.Drawing.Size(1359, 363);
            this.album__Panel2.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoScroll = true;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.album__Panel3);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 372);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1365, 369);
            this.flowLayoutPanel3.TabIndex = 1;
            this.flowLayoutPanel3.WrapContents = false;
            // 
            // album__Panel3
            // 
            this.album__Panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.album__Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.album__Panel3.Location = new System.Drawing.Point(3, 3);
            this.album__Panel3.Name = "album__Panel3";
            this.album__Panel3.Size = new System.Drawing.Size(1359, 363);
            this.album__Panel3.TabIndex = 0;
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
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Custom.Album__Panel album__Panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Custom.Album__Panel album__Panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private Custom.Album__Panel album__Panel3;
    }
}
