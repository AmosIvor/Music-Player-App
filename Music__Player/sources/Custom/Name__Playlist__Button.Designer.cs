namespace Music__Player.sources.Custom
{
    partial class Name__Playlist__Button
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
            this.btnImage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.Transparent;
            this.btnImage.CheckedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnImage.CheckedState.Parent = this.btnImage;
            this.btnImage.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnImage.HoverState.Parent = this.btnImage;
            this.btnImage.Image = global::Music__Player.Properties.Resources.icon_name_playlist_white;
            this.btnImage.ImageSize = new System.Drawing.Size(25, 25);
            this.btnImage.Location = new System.Drawing.Point(7, 0);
            this.btnImage.Name = "btnImage";
            this.btnImage.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnImage.PressedState.Parent = this.btnImage;
            this.btnImage.Size = new System.Drawing.Size(45, 45);
            this.btnImage.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(55, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name1";
            // 
            // Name__Playlist__Button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnImage);
            this.Name = "Name__Playlist__Button";
            this.Size = new System.Drawing.Size(175, 45);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnImage;
        private System.Windows.Forms.Label lblName;
    }
}
