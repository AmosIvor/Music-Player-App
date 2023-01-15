using Music__Player.sources.Constant;
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
    public partial class Item__Menu : UserControl
    {
        Color background = Color.FromArgb(192, 192, 255);
        public Item__Menu()
        {
            InitializeComponent();
        }

        public Item__Menu(string itemName, Image icon)
        {
            InitializeComponent();

            this.Item_Name = itemName;

            this.Icon = icon;

            LoadInitialEvent();
        }
        void LoadInitialEvent()
        {
            pnlMain.MouseEnter += userControl_MouseEnter;

            pnlMain.MouseLeave += userControl_MouseLeave;

            pnlMain.MouseClick += userControl_MouseClick;
        }

        private string item_Name;
        public string Item_Name
        {
            get { return item_Name; }
            set { item_Name = value; lblName.Text = value; }
        }

        private Image icon;
        public Image Icon
        {
            get { return icon; }
            set { icon = value; btnImage.Image = value; }
        }

        private bool isAdd;
        public bool IsAdd
        {
            get { return isAdd;}
            set 
            { 
                isAdd = value;

                if (isAdd == true)
                {
                    lblName.Image = ICON.Next;

                    lblName.ImageAlign = ContentAlignment.MiddleRight;
                }
            }
        }

        private bool isHovered;
        public bool IsHovered
        {
            get { return isHovered; }

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
