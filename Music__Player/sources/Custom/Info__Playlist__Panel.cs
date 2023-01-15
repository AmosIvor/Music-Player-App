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
    public partial class Info__Playlist__Panel : UserControl
    {
        public Info__Playlist__Panel()
        {
            InitializeComponent();
        }

        public Info__Playlist__Panel(DataRow row)
        {
            InitializeComponent();

            this.ID_Playlist = (int)row["ID_PLAYLIST"];

            this.Name_Playlist = row["NAME_PLAYLIST"].ToString();

            this.Number_Song = row["QUANTITY"].ToString() + " songs";

            if (!Convert.IsDBNull(row["IMAGE_PLAYLIST"]))
            {
                MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_PLAYLIST"]);

                Image temp = Image.FromStream(stream);

                this.Image_Playlist = temp;
            }
            else
            {
                this.Image_Playlist = IMAGE.DefaultPlaylist;
            }

            LoadEvent();
        }

        void LoadEvent()
        {
            pnlBackground.MouseDoubleClick += userControl_DoubleClick;

            pnlBackground.MouseEnter += userControl_MouseEnter;

            pnlBackground.MouseLeave += userControl_MouseLeave;

            btnPlay.MouseClick += btnPlay_MouseClickPlay;
        }

        private int id_Playlist;
        public int ID_Playlist
        {
            get { return id_Playlist; }
            set { id_Playlist = value; }
        }


        private string name_Playlist;
        public string Name_Playlist
        {
            get { return name_Playlist; }

            set { name_Playlist = value; lblName.Text = value; }
        }

        private string number_Song;
        public string Number_Song
        {
            get { return number_Song; }
            
            set { number_Song = value; lblNumber.Text = value; }
        }

        private Image image_Playlist;
        public Image Image_Playlist
        {
            get { return image_Playlist;}

            set { image_Playlist = value; pbImage.Image = image_Playlist; }
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
                    btnPlay.Checked = true;

                    pnlBackground.FillColor = SystemColors.ControlLight;
                }
                else
                {
                    btnPlay.Checked = false;

                    pnlBackground.FillColor = Color.White;
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

                if (isHovered == true || isSelected == true)
                {
                    pnlBackground.FillColor = SystemColors.ControlLight;

                    lblBin.Visible = false;

                    if (isHovered == false && isSelected == true && btnBin.Checked == false)
                    {
                        lblBin.Visible = true;
                    }
                }

                else
                {
                    pnlBackground.FillColor = Color.White;

                    lblNumber.Visible = true;

                    if (btnBin.Checked != true)
                    {
                        lblBin.Visible = true;
                    }
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


        private event MouseEventHandler _mouseClickPlay;

        public event MouseEventHandler MouseClickPlay
        {
            add
            {
                _mouseClickPlay += value;
            }
            remove
            {
                _mouseClickPlay -= value;
            }
        }


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

        private void btnPlay_MouseClickPlay(object sender, MouseEventArgs e)
        {
            _mouseClickPlay?.Invoke(sender, e);
        }

        #endregion

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Checked = !btnPlay.Checked;
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            //btnBin.Checked = !btnBin.Checked;
        }
    }
}
