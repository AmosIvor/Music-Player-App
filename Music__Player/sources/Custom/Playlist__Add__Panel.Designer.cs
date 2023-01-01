namespace Music__Player.sources.Custom
{
    partial class Playlist__Add__Panel
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
            this.pnlBackground = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnCreate = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblCreate = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackground.Controls.Add(this.btnCreate);
            this.pnlBackground.Controls.Add(this.lblCreate);
            this.pnlBackground.FillColor = System.Drawing.Color.White;
            this.pnlBackground.Location = new System.Drawing.Point(3, 3);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Radius = 10;
            this.pnlBackground.ShadowColor = System.Drawing.Color.Black;
            this.pnlBackground.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnlBackground.Size = new System.Drawing.Size(583, 164);
            this.pnlBackground.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.CheckedState.ImageSize = new System.Drawing.Size(74, 74);
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.HoverState.ImageSize = new System.Drawing.Size(78, 78);
            this.btnCreate.HoverState.Parent = this.btnCreate;
            this.btnCreate.Image = global::Music__Player.Properties.Resources.icon_createplaylist_blue;
            this.btnCreate.ImageSize = new System.Drawing.Size(74, 74);
            this.btnCreate.Location = new System.Drawing.Point(51, 45);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.PressedState.ImageSize = new System.Drawing.Size(74, 74);
            this.btnCreate.PressedState.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(74, 74);
            this.btnCreate.TabIndex = 3;
            // 
            // lblCreate
            // 
            this.lblCreate.AutoSize = true;
            this.lblCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreate.Location = new System.Drawing.Point(180, 67);
            this.lblCreate.Name = "lblCreate";
            this.lblCreate.Size = new System.Drawing.Size(227, 31);
            this.lblCreate.TabIndex = 2;
            this.lblCreate.Text = "Create a new playlist";
            // 
            // Playlist__Add__Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlBackground);
            this.Margin = new System.Windows.Forms.Padding(64, 50, 3, 0);
            this.Name = "Playlist__Add__Panel";
            this.Size = new System.Drawing.Size(587, 168);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlBackground;
        private System.Windows.Forms.Label lblCreate;
        private Guna.UI2.WinForms.Guna2ImageButton btnCreate;
    }
}
