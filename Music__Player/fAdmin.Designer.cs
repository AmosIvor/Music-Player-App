namespace Music__Player
{
    partial class fAdmin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panelSlideBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.panelSlideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 10;
            this.btnHome.BorderThickness = 1;
            this.btnHome.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnHome.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnHome.CheckedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.CustomImages.CheckedImage = global::Music__Player.Properties.Resources.icon_home_blue;
            this.btnHome.CustomImages.Image = global::Music__Player.Properties.Resources.icon_home_white;
            this.btnHome.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnHome.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHome.CustomImages.Parent = this.btnHome;
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(27, 88);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(170, 45);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Insert Song";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.TextOffset = new System.Drawing.Point(47, 0);
            // 
            // panelSlideBar
            // 
            this.panelSlideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelSlideBar.Controls.Add(this.btnUser);
            this.panelSlideBar.Controls.Add(this.btnDangXuat);
            this.panelSlideBar.Controls.Add(this.btnHome);
            this.panelSlideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelSlideBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.panelSlideBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelSlideBar.Location = new System.Drawing.Point(0, 0);
            this.panelSlideBar.Name = "panelSlideBar";
            this.panelSlideBar.ShadowDecoration.Parent = this.panelSlideBar;
            this.panelSlideBar.Size = new System.Drawing.Size(242, 918);
            this.panelSlideBar.TabIndex = 2;
            this.panelSlideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlideBar_Paint);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BorderColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BorderRadius = 10;
            this.btnDangXuat.BorderThickness = 1;
            this.btnDangXuat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDangXuat.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDangXuat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnDangXuat.CheckedState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.CheckedState.Parent = this.btnDangXuat;
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.CustomImages.Image = global::Music__Player.Properties.Resources.logoutIcon;
            this.btnDangXuat.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.CustomImages.ImageOffset = new System.Drawing.Point(7, 0);
            this.btnDangXuat.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDangXuat.CustomImages.Parent = this.btnDangXuat;
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnDangXuat.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.HoverState.Parent = this.btnDangXuat;
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Location = new System.Drawing.Point(27, 155);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ShadowDecoration.Parent = this.btnDangXuat;
            this.btnDangXuat.Size = new System.Drawing.Size(170, 45);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.TextOffset = new System.Drawing.Point(47, 0);
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click_1);
            // 
            // btnUser
            // 
            this.btnUser.BorderRadius = 20;
            this.btnUser.CheckedState.Parent = this.btnUser;
            this.btnUser.CustomImages.Image = global::Music__Player.Properties.Resources.user;
            this.btnUser.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.CustomImages.ImageSize = new System.Drawing.Size(25, 25);
            this.btnUser.CustomImages.Parent = this.btnUser;
            this.btnUser.FillColor = System.Drawing.Color.White;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUser.HoverState.FillColor = System.Drawing.Color.White;
            this.btnUser.HoverState.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnUser.HoverState.Parent = this.btnUser;
            this.btnUser.Location = new System.Drawing.Point(27, 23);
            this.btnUser.Name = "btnUser";
            this.btnUser.PressedColor = System.Drawing.Color.Transparent;
            this.btnUser.ShadowDecoration.Parent = this.btnUser;
            this.btnUser.Size = new System.Drawing.Size(170, 45);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "Admin";
            this.btnUser.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 918);
            this.Controls.Add(this.panelSlideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.panelSlideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSlideBar;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnUser;
    }
}