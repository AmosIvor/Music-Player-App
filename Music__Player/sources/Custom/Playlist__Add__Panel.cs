using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.Custom
{
    public partial class Playlist__Add__Panel : UserControl
    {
        public Playlist__Add__Panel()
        {
            InitializeComponent();

            LoadEvent();
        }

        void LoadEvent()
        {
            pnlBackground.MouseEnter += userControl_MouseEnter;

            pnlBackground.MouseLeave += userControl_MouseLeave;

            pnlBackground.MouseDoubleClick += userControl_DoubleClick;

            btnCreate.MouseClick += btnCreate_MouseClickCreate;
        }

        #region Initial

        private bool isHovered;
        public bool IsHovered
        {
            get { return isHovered; }

            set
            {
                isHovered = value;

                if (isHovered == true)
                {
                    pnlBackground.FillColor = SystemColors.ControlLight;
                }

                else
                {
                    pnlBackground.FillColor = Color.White;
                }
            }
        }

        private event MouseEventHandler _mouseDoubleClickAdd;

        public event MouseEventHandler MouseDoubleClickAdd
        {
            add
            {
                this.Cursor = Cursors.Hand;

                _mouseDoubleClickAdd += value;

                foreach (Control control in pnlBackground.Controls)
                {
                    control.MouseDoubleClick += value;

                    control.Cursor = Cursors.Hand;
                }
            }
            remove
            {
                this.Cursor = Cursors.Default;

                _mouseDoubleClickAdd -= value;

                foreach (Control control in pnlBackground.Controls)
                {
                    control.MouseDoubleClick -= value;

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

                foreach (Control control in pnlBackground.Controls)
                {
                    control.MouseEnter += value;

                    control.Cursor = Cursors.Hand;
                }
            }

            remove
            {
                this.Cursor = Cursors.Default;

                _mouseEnterAdd -= value;

                foreach (Control control in pnlBackground.Controls)
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


        private event MouseEventHandler _mouseClickCreate;

        public event MouseEventHandler MouseClickCreate
        {
            add
            {
                _mouseClickCreate += value;
            }
            remove
            {
                _mouseClickCreate -= value;
            }
        }

        #endregion

        #region Event

        private void userControl_DoubleClick(object sender, MouseEventArgs e)
        {
            _mouseDoubleClickAdd?.Invoke(sender, e);
        }

        private void userControl_MouseEnter(object sender, EventArgs e)
        {
            _mouseEnterAdd?.Invoke(sender, e);
        }

        private void userControl_MouseLeave(object sender, EventArgs e)
        {
            _mouseLeaveAdd?.Invoke(sender, e);
        }

        private void btnCreate_MouseClickCreate(object sender, MouseEventArgs e)
        {
            pnlBackground.FillColor = Color.White;

            _mouseClickCreate?.Invoke(sender, e);
        }

        #endregion
    }
}
