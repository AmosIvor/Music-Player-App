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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.panelSlideBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsertSQL = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataSong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Song = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerticalLine = new Guna.UI2.WinForms.Guna2VSeparator();
            this.panelSlideBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSong)).BeginInit();
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
            this.btnHome.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.HoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(36, 90);
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
            this.panelSlideBar.Controls.Add(this.VerticalLine);
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
            // 
            // btnUser
            // 
            this.btnUser.BorderColor = System.Drawing.Color.White;
            this.btnUser.BorderRadius = 20;
            this.btnUser.BorderThickness = 2;
            this.btnUser.CheckedState.Parent = this.btnUser;
            this.btnUser.CustomImages.Image = global::Music__Player.Properties.Resources.icon_user;
            this.btnUser.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUser.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUser.CustomImages.Parent = this.btnUser;
            this.btnUser.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnUser.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.HoverState.Parent = this.btnUser;
            this.btnUser.Location = new System.Drawing.Point(27, 23);
            this.btnUser.Name = "btnUser";
            this.btnUser.PressedColor = System.Drawing.Color.Transparent;
            this.btnUser.PressedDepth = 0;
            this.btnUser.ShadowDecoration.Parent = this.btnUser;
            this.btnUser.Size = new System.Drawing.Size(187, 45);
            this.btnUser.TabIndex = 9;
            this.btnUser.Text = "ADMIN";
            this.btnUser.TextOffset = new System.Drawing.Point(3, 0);
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
            this.btnDangXuat.Location = new System.Drawing.Point(36, 154);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.ShadowDecoration.Parent = this.btnDangXuat;
            this.btnDangXuat.Size = new System.Drawing.Size(170, 45);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.TextOffset = new System.Drawing.Point(47, 0);
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInsertSQL);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(242, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1341, 918);
            this.panel1.TabIndex = 3;
            // 
            // btnInsertSQL
            // 
            this.btnInsertSQL.BackColor = System.Drawing.Color.Silver;
            this.btnInsertSQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertSQL.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertSQL.Location = new System.Drawing.Point(926, 786);
            this.btnInsertSQL.Name = "btnInsertSQL";
            this.btnInsertSQL.Size = new System.Drawing.Size(209, 53);
            this.btnInsertSQL.TabIndex = 4;
            this.btnInsertSQL.Text = "Insert Into Database";
            this.btnInsertSQL.UseVisualStyleBackColor = false;
            this.btnInsertSQL.Click += new System.EventHandler(this.btnInsertSQL_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Silver;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(205, 79);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(209, 53);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert From File ...";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataSong);
            this.panel3.Location = new System.Drawing.Point(205, 174);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 568);
            this.panel3.TabIndex = 3;
            // 
            // dataSong
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dataSong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataSong.BackgroundColor = System.Drawing.Color.White;
            this.dataSong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataSong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataSong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataSong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataSong.ColumnHeadersHeight = 40;
            this.dataSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.Song,
            this.Album});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataSong.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataSong.EnableHeadersVisualStyles = false;
            this.dataSong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataSong.Location = new System.Drawing.Point(3, 3);
            this.dataSong.Name = "dataSong";
            this.dataSong.RowHeadersVisible = false;
            this.dataSong.RowHeadersWidth = 51;
            this.dataSong.RowTemplate.Height = 40;
            this.dataSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataSong.Size = new System.Drawing.Size(924, 562);
            this.dataSong.TabIndex = 0;
            this.dataSong.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dataSong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataSong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataSong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataSong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataSong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataSong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataSong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataSong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataSong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataSong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataSong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataSong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataSong.ThemeStyle.HeaderStyle.Height = 40;
            this.dataSong.ThemeStyle.ReadOnly = false;
            this.dataSong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataSong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataSong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataSong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataSong.ThemeStyle.RowsStyle.Height = 40;
            this.dataSong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataSong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.HeaderText = "#";
            this.STT.MinimumWidth = 50;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // Song
            // 
            this.Song.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Song.HeaderText = "Name Song";
            this.Song.MinimumWidth = 300;
            this.Song.Name = "Song";
            this.Song.Width = 300;
            // 
            // Album
            // 
            this.Album.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Album.HeaderText = "Album";
            this.Album.MinimumWidth = 6;
            this.Album.Name = "Album";
            // 
            // VerticalLine
            // 
            this.VerticalLine.FillColor = System.Drawing.Color.White;
            this.VerticalLine.FillThickness = 5;
            this.VerticalLine.Location = new System.Drawing.Point(-2, 90);
            this.VerticalLine.Name = "VerticalLine";
            this.VerticalLine.Size = new System.Drawing.Size(10, 45);
            this.VerticalLine.TabIndex = 10;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 918);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSlideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fAdmin";
            this.panelSlideBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2GradientPanel panelSlideBar;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInsertSQL;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2DataGridView dataSong;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Song;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private Guna.UI2.WinForms.Guna2VSeparator VerticalLine;
    }
}