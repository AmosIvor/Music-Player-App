namespace Music__Player.sources.Custom
{
    partial class Name__Playlist__Panel
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
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.btnImage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.btnImage);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(265, 46);
            this.pnlMain.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(46, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(215, 30);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tran Tuan Vu";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImage
            // 
            this.btnImage.CheckedState.Parent = this.btnImage;
            this.btnImage.HoverState.Parent = this.btnImage;
            this.btnImage.Image = global::Music__Player.Properties.Resources.icon_playlist;
            this.btnImage.ImageSize = new System.Drawing.Size(24, 24);
            this.btnImage.Location = new System.Drawing.Point(3, 6);
            this.btnImage.Name = "btnImage";
            this.btnImage.PressedState.Parent = this.btnImage;
            this.btnImage.Size = new System.Drawing.Size(35, 35);
            this.btnImage.TabIndex = 0;
            // 
            // Name__Playlist__Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Name = "Name__Playlist__Panel";
            this.Size = new System.Drawing.Size(265, 46);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2ImageButton btnImage;
        private System.Windows.Forms.Label lblName;
    }
}
