namespace Music__Player.sources.Custom
{
    partial class Album__Display
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnPlaySong = new Guna.UI2.WinForms.Guna2ImageButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Music__Player.Properties.Resources.draft;
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.btnPlaySong_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.btnPlaySong_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.btnPlaySong_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Album Collection...";
            this.label1.MouseEnter += new System.EventHandler(this.btnPlaySong_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.btnPlaySong_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.btnPlaySong_MouseEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bùi Anh Hưng 1";
            this.label2.MouseEnter += new System.EventHandler(this.btnPlaySong_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.btnPlaySong_MouseLeave);
            this.label2.MouseHover += new System.EventHandler(this.btnPlaySong_MouseEnter);
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.btnPlaySong);
            this.guna2ShadowPanel1.Controls.Add(this.label2);
            this.guna2ShadowPanel1.Controls.Add(this.label1);
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(3, 3);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.DimGray;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(205, 264);
            this.guna2ShadowPanel1.TabIndex = 0;
            this.guna2ShadowPanel1.MouseEnter += new System.EventHandler(this.btnPlaySong_MouseEnter);
            this.guna2ShadowPanel1.MouseLeave += new System.EventHandler(this.btnPlaySong_MouseLeave);
            this.guna2ShadowPanel1.MouseHover += new System.EventHandler(this.btnPlaySong_MouseEnter);
            // 
            // btnPlaySong
            // 
            this.btnPlaySong.CheckedState.Parent = this.btnPlaySong;
            this.btnPlaySong.HoverState.Parent = this.btnPlaySong;
            this.btnPlaySong.Image = global::Music__Player.Properties.Resources.icon_play_green;
            this.btnPlaySong.ImageSize = new System.Drawing.Size(50, 50);
            this.btnPlaySong.Location = new System.Drawing.Point(130, 118);
            this.btnPlaySong.Name = "btnPlaySong";
            this.btnPlaySong.PressedState.Parent = this.btnPlaySong;
            this.btnPlaySong.Size = new System.Drawing.Size(54, 53);
            this.btnPlaySong.TabIndex = 3;
            this.btnPlaySong.UseTransparentBackground = true;
            this.btnPlaySong.Visible = false;
            this.btnPlaySong.MouseEnter += new System.EventHandler(this.btnPlaySong_MouseEnter);
            this.btnPlaySong.MouseLeave += new System.EventHandler(this.btnPlaySong_MouseLeave);
            this.btnPlaySong.MouseHover += new System.EventHandler(this.btnPlaySong_MouseEnter);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Album__Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ShadowPanel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Album__Display";
            this.Size = new System.Drawing.Size(213, 274);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.ImageList imageList1;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlaySong;
        private System.Windows.Forms.ImageList imageList2;
    }
}
