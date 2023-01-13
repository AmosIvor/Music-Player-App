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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.album__Display1 = new Music__Player.sources.Custom.Album__Display();
            this.album__Display2 = new Music__Player.sources.Custom.Album__Display();
            this.album__Display3 = new Music__Player.sources.Custom.Album__Display();
            this.album__Display4 = new Music__Player.sources.Custom.Album__Display();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.album__Display1);
            this.flowLayoutPanel1.Controls.Add(this.album__Display2);
            this.flowLayoutPanel1.Controls.Add(this.album__Display3);
            this.flowLayoutPanel1.Controls.Add(this.album__Display4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 66);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1359, 236);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thể loại nhạc";
            // 
            // album__Display1
            // 
            this.album__Display1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.album__Display1.Location = new System.Drawing.Point(3, 3);
            this.album__Display1.Name = "album__Display1";
            this.album__Display1.Size = new System.Drawing.Size(190, 230);
            this.album__Display1.TabIndex = 0;
            // 
            // album__Display2
            // 
            this.album__Display2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.album__Display2.Location = new System.Drawing.Point(199, 3);
            this.album__Display2.Name = "album__Display2";
            this.album__Display2.Size = new System.Drawing.Size(190, 230);
            this.album__Display2.TabIndex = 1;
            // 
            // album__Display3
            // 
            this.album__Display3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.album__Display3.Location = new System.Drawing.Point(395, 3);
            this.album__Display3.Name = "album__Display3";
            this.album__Display3.Size = new System.Drawing.Size(190, 230);
            this.album__Display3.TabIndex = 2;
            // 
            // album__Display4
            // 
            this.album__Display4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.album__Display4.Location = new System.Drawing.Point(591, 3);
            this.album__Display4.Name = "album__Display4";
            this.album__Display4.Size = new System.Drawing.Size(190, 230);
            this.album__Display4.TabIndex = 3;
            // 
            // Album__Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Album__Panel";
            this.Size = new System.Drawing.Size(1359, 302);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private Album__Display album__Display1;
        private Album__Display album__Display2;
        private Album__Display album__Display3;
        private Album__Display album__Display4;
    }
}
