namespace Music__Player.sources.Custom
{
    partial class Context__Menu
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
            this.fpnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // fpnlMain
            // 
            this.fpnlMain.AutoScroll = true;
            this.fpnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.fpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlMain.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlMain.Location = new System.Drawing.Point(0, 0);
            this.fpnlMain.Name = "fpnlMain";
            this.fpnlMain.Size = new System.Drawing.Size(304, 104);
            this.fpnlMain.TabIndex = 1;
            this.fpnlMain.WrapContents = false;
            // 
            // Context__Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnlMain);
            this.Name = "Context__Menu";
            this.Size = new System.Drawing.Size(304, 104);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel fpnlMain;
    }
}
