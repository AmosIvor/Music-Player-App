namespace Music__Player.sources.Custom
{
    partial class Info__Playlist__Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info__Playlist__Panel));
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.pnlBackground = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblBin = new System.Windows.Forms.Label();
            this.btnBin = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPlay = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbImage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(180, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(236, 31);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Jerome Bell";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.ForeColor = System.Drawing.Color.Gray;
            this.lblNumber.Location = new System.Drawing.Point(180, 91);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(83, 28);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "3 songs";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackground.Controls.Add(this.lblBin);
            this.pnlBackground.Controls.Add(this.btnBin);
            this.pnlBackground.Controls.Add(this.btnPlay);
            this.pnlBackground.Controls.Add(this.lblNumber);
            this.pnlBackground.Controls.Add(this.pbImage);
            this.pnlBackground.Controls.Add(this.lblName);
            this.pnlBackground.FillColor = System.Drawing.Color.White;
            this.pnlBackground.Location = new System.Drawing.Point(3, 3);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Radius = 10;
            this.pnlBackground.ShadowColor = System.Drawing.Color.Black;
            this.pnlBackground.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlBackground.Size = new System.Drawing.Size(583, 164);
            this.pnlBackground.TabIndex = 1;
            // 
            // lblBin
            // 
            this.lblBin.Location = new System.Drawing.Point(510, 52);
            this.lblBin.Name = "lblBin";
            this.lblBin.Size = new System.Drawing.Size(60, 60);
            this.lblBin.TabIndex = 4;
            // 
            // btnBin
            // 
            this.btnBin.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnBin.CheckedState.Parent = this.btnBin;
            this.btnBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBin.HoverState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnBin.HoverState.Parent = this.btnBin;
            this.btnBin.Image = global::Music__Player.Properties.Resources.icon_bin_black1;
            this.btnBin.ImageSize = new System.Drawing.Size(55, 55);
            this.btnBin.Location = new System.Drawing.Point(510, 52);
            this.btnBin.Name = "btnBin";
            this.btnBin.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnBin.PressedState.Parent = this.btnBin;
            this.btnBin.Size = new System.Drawing.Size(60, 60);
            this.btnBin.TabIndex = 3;
            // 
            // btnPlay
            // 
            this.btnPlay.CheckedState.Image = global::Music__Player.Properties.Resources.icon_play_blue;
            this.btnPlay.CheckedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPlay.CheckedState.Parent = this.btnPlay;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.HoverState.ImageSize = new System.Drawing.Size(59, 59);
            this.btnPlay.HoverState.Parent = this.btnPlay;
            this.btnPlay.Image = global::Music__Player.Properties.Resources.icon_pause_blue;
            this.btnPlay.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPlay.Location = new System.Drawing.Point(435, 52);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnPlay.PressedState.Parent = this.btnPlay;
            this.btnPlay.Size = new System.Drawing.Size(60, 60);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
            this.pbImage.Location = new System.Drawing.Point(21, 15);
            this.pbImage.Name = "pbImage";
            this.pbImage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbImage.ShadowDecoration.Parent = this.pbImage;
            this.pbImage.Size = new System.Drawing.Size(134, 134);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // Info__Playlist__Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlBackground);
            this.Margin = new System.Windows.Forms.Padding(64, 50, 3, 0);
            this.Name = "Info__Playlist__Panel";
            this.Size = new System.Drawing.Size(587, 168);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlBackground;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlay;
        private Guna.UI2.WinForms.Guna2ImageButton btnBin;
        private System.Windows.Forms.Label lblBin;
    }
}
