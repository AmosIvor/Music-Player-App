namespace Music__Player.sources.Custom
{
    partial class Info__Album
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
            this.pnlBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BorderRadius = 8;
            this.pnlBackground.Controls.Add(this.btnPlay);
            this.pnlBackground.Controls.Add(this.lblTitle);
            this.pnlBackground.Controls.Add(this.pbImage);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.FillColor = System.Drawing.Color.Transparent;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.ShadowDecoration.Parent = this.pnlBackground;
            this.pnlBackground.Size = new System.Drawing.Size(245, 275);
            this.pnlBackground.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.CheckedState.Image = global::Music__Player.Properties.Resources.icon_pause_green;
            this.btnPlay.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPlay.CheckedState.Parent = this.btnPlay;
            this.btnPlay.HoverState.ImageSize = new System.Drawing.Size(60, 60);
            this.btnPlay.HoverState.Parent = this.btnPlay;
            this.btnPlay.Image = global::Music__Player.Properties.Resources.icon_play_green;
            this.btnPlay.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPlay.Location = new System.Drawing.Point(147, 143);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PressedState.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(60, 60);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.UseTransparentBackground = true;
            this.btnPlay.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(24, 229);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Stoney";
            // 
            // pbImage
            // 
            this.pbImage.BorderRadius = 8;
            this.pbImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbImage.Image = global::Music__Player.Properties.Resources.draft;
            this.pbImage.Location = new System.Drawing.Point(24, 23);
            this.pbImage.Name = "pbImage";
            this.pbImage.ShadowDecoration.Parent = this.pbImage;
            this.pbImage.Size = new System.Drawing.Size(196, 190);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // Info__Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlBackground);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Info__Album";
            this.Size = new System.Drawing.Size(245, 275);
            this.pnlBackground.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlBackground;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlay;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
    }
}
