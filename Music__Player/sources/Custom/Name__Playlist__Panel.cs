using Music__Player.sources.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.Custom
{
    public partial class Name__Playlist__Panel : UserControl
    {
        Color background = Color.FromArgb(192, 192, 255);
        public Name__Playlist__Panel()
        {
            InitializeComponent();
        }

        public Name__Playlist__Panel(DataRow row)
        {
            InitializeComponent();

            this.Name_Playlist = row["NAME_PLAYLIST"].ToString();

            this.IsCreated = false;

            LoadInitialEvent();
        }

        public Name__Playlist__Panel(string name_Playlist)
        {
            InitializeComponent();

            this.Name_Playlist = name_Playlist;

            this.IsCreated = false;

            LoadInitialEvent();
        }

        void LoadInitialEvent()
        {
            pnlMain.MouseEnter += userControl_MouseEnter;

            pnlMain.MouseLeave += userControl_MouseLeave;

            pnlMain.MouseClick += userControl_MouseClick;
        }

        private string name_Playlist;
        public string Name_Playlist
        {
            get { return name_Playlist;}

            set { name_Playlist = value; lblName.Text = name_Playlist; }
        }

        private bool isCreated;
        public bool IsCreated
        {
            get { return isCreated;}

            set
            {
                isCreated = value;

                if (isCreated == true)
                {
                    btnImage.Image = ICON.Playlist_Create;
                }
                else
                {
                    btnImage.Image = ICON.Playlist;
                }
            }
        }

        private bool isHovered;
        public bool IsHovered
        {
            get { return isHovered;}

            set
            {
                isHovered = value;

                if (isHovered == false)
                {
                    pnlMain.FillColor = background;
                }

                else
                {
                    pnlMain.FillColor = Color.FromArgb(20, 0, 0, 0);
                }
            }
        }

        private event MouseEventHandler _mouseClickAdd;

        public event MouseEventHandler MouseClickAdd
        {
            add
            {
                this.Cursor = Cursors.Hand;

                _mouseClickAdd += value;

                foreach (Control control in pnlMain.Controls)
                {
                    control.MouseClick += value;

                    control.Cursor = Cursors.Hand;
                }
            }

            remove
            {
                this.Cursor = Cursors.Default;

                _mouseClickAdd -= value;

                foreach (Control control in pnlMain.Controls)
                {
                    control.MouseClick -= value;

                    Cursor = Cursors.Default;
                }
            }
        }

        private event EventHandler _mouseEnterAdd;

        public event EventHandler MouseEnterAdd
        {
            add
            {
                this.Cursor = Cursors.Hand;

                _mouseEnterAdd += value;

                foreach (Control control in pnlMain.Controls)
                {
                    control.MouseEnter += value;

                    control.Cursor = Cursors.Hand;
                }
            }

            remove
            {
                this.Cursor = Cursors.Default;

                _mouseEnterAdd -= value;

                foreach (Control control in pnlMain.Controls)
                {
                    control.MouseEnter -= value;

                    Cursor = Cursors.Default;
                }
            }
        }


        private event EventHandler _mouseLeaveAdd;

        public event EventHandler MouseLeaveAdd
        {
            add
            {
                _mouseLeaveAdd += value;
            }

            remove
            {
                _mouseLeaveAdd -= value;
            }
        }

        #region Event

        private void userControl_MouseEnter(object sender, EventArgs e)
        {
            _mouseEnterAdd?.Invoke(sender, e);
        }

        private void userControl_MouseLeave(object sender, EventArgs e)
        {
            _mouseLeaveAdd?.Invoke(sender, e);
        }

        private void userControl_MouseClick(object sender, MouseEventArgs e)
        {
            _mouseClickAdd?.Invoke(sender, e);
        }
        #endregion

    }
}
