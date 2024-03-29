﻿namespace Music__Player.sources.Custom
{
    partial class Item__Menu
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
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.ShadowDecoration.Parent = this.pnlMain;
            this.pnlMain.Size = new System.Drawing.Size(302, 49);
            this.pnlMain.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Location = new System.Drawing.Point(55, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(240, 44);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Add to playlist";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImage
            // 
            this.btnImage.CheckedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnImage.CheckedState.Parent = this.btnImage;
            this.btnImage.HoverState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnImage.HoverState.Parent = this.btnImage;
            this.btnImage.Image = global::Music__Player.Properties.Resources.icon_add_playlist;
            this.btnImage.ImageSize = new System.Drawing.Size(24, 24);
            this.btnImage.Location = new System.Drawing.Point(7, 8);
            this.btnImage.Name = "btnImage";
            this.btnImage.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnImage.PressedState.Parent = this.btnImage;
            this.btnImage.Size = new System.Drawing.Size(35, 35);
            this.btnImage.TabIndex = 7;
            // 
            // Item__Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Name = "Item__Menu";
            this.Size = new System.Drawing.Size(302, 49);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2ImageButton btnImage;
    }
}
