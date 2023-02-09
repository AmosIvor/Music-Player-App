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
    public partial class Name__Playlist__Button : UserControl
    {
        //Segoe UI Semibold, 10.8pt, style=Bold
        Font fontChecked = new Font("Segoe UI Semibold", 11.0F,  FontStyle.Bold);

        Font fontDefault = new Font("Segoe UI", 11.0F, FontStyle.Regular);

        public Name__Playlist__Button()
        {
            InitializeComponent();
        }

        public Name__Playlist__Button(DataRow row)
        {
            InitializeComponent();

            this.ID_Playlist = (int)row["ID_PLAYLIST"];

            this.Name_Playlist = row["NAME_PLAYLIST"].ToString();

            LoadInitialEvent();
        }

        void LoadInitialEvent()
        {
            this.MouseClick += userControl_MouseClick;

            this.MouseEnter += userControl_MouseEnter;

            this.MouseLeave += userControl_MouseLeave;
        }

        private int iD_Playlist;
        public int ID_Playlist
        {
            get { return iD_Playlist; }
            set { iD_Playlist = value; }
        }


        private string name_Playlist;
        public string Name_Playlist
        {
            get { return name_Playlist; }

            set { name_Playlist = value; lblName.Text = value; }
        }

        private bool isSelected;
        public bool IsSelected
        {
            get { return isSelected; }

            set
            {
                isSelected = value;

                if (isSelected == true)
                {
                    lblName.Font = fontChecked;
                }

                else
                {
                    lblName.Font = fontDefault;
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

                if (isHovered == true || isSelected == true)
                {
                    lblName.Font = fontChecked;
                }

                else
                {
                    lblName.Font = fontDefault;
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

                foreach (Control control in this.Controls)
                {
                    control.MouseClick += value;

                    control.Cursor = Cursors.Hand;
                }
            }
            remove
            {
                this.Cursor = Cursors.Default;

                _mouseClickAdd -= value;

                foreach (Control control in this.Controls)
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

                foreach (Control control in this.Controls)
                {
                    control.MouseEnter += value;

                    control.Cursor = Cursors.Hand;
                }
            }

            remove
            {
                this.Cursor = Cursors.Default;

                _mouseEnterAdd -= value;

                foreach (Control control in this.Controls)
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

        private void userControl_MouseClick(object sender, MouseEventArgs e)
        {
            _mouseClickAdd?.Invoke(sender, e);
        }

        private void userControl_MouseEnter(object sender, EventArgs e)
        {
            _mouseEnterAdd?.Invoke(sender, e);
        }

        private void userControl_MouseLeave(object sender, EventArgs e)
        {
            _mouseLeaveAdd?.Invoke(sender, e);
        }


    }
}
