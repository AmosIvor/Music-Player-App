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
    public partial class List__Song__Playlist : UserControl
    {
        public List__Song__Playlist()
        {
            InitializeComponent();
        }

        public List__Song__Playlist(DataRow row)
        {
            InitializeComponent();

            this.Title = row["NAME_SONG"].ToString();

            this.Artist = row["ARTIST"].ToString();

            this.URL = row["LINK"].ToString();

            this.Duration = row["DURATION"].ToString();

            this.Name_Album = row["NAME_ALBUM"].ToString();

            MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_SONG"]);

            Image temp = Image.FromStream(stream);

            this.Image_Song = temp;

            LoadInitialEvent();
        }

        #region Initial

        private void LoadInitialEvent()
        {
            pnlBackground.MouseDoubleClick += userControl_DoubleClick;

            pnlBackground.MouseEnter += userControl_MouseEnter;

            pnlBackground.MouseLeave += userControl_MouseLeave;

            btnPlay.MouseClick += btnPlay_MouseClickPlay;
        }

        private string iD;
        public string ID
        {
            get { return iD; }
            set { iD = value; lblPlay.Text = value; }
        }

        private Image image_Song;
        public Image Image_Song
        {
            get { return image_Song; }
            set { image_Song = value; pbImage.Image = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; lblTitle.Text = value; }
        }

        private string artist;
        public string Artist
        {
            get { return artist; }
            set { artist = value; lblArtist.Text = value; }
        }

        private string duration;
        public string Duration
        {
            get { return duration; }
            set { duration = value; lblDuration.Text = value; }
        }

        private string url;
        public string URL
        {
            get { return url; }

            set { url = value; }
        }

        private string name_album;
        public string Name_Album
        {
            get { return name_album; }
            set { name_album = value; lblAlbum.Text = value; }
        }

        private bool isFavorite;
        public bool IsFavorite
        {
            get { return isFavorite; }
            set
            {
                isFavorite = value;

                if (isFavorite == true)
                {
                    btnFavorite.Checked = true;
                }
                else
                {
                    btnFavorite.Checked = false;
                }
            }
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
                    lblPlay.Visible = false;

                    btnPlay.Checked = true;

                    pnlBackground.FillColor = SystemColors.ControlLight;
                }
                else
                {
                    btnPlay.Checked = false;

                    pnlBackground.FillColor = Color.Transparent;
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

                    lblPlay.Visible = false;

                    lblFavorite.Visible = false;

                    if (isHovered == false && isSelected == true && btnFavorite.Checked == false)
                    {
                        lblFavorite.Visible = true;

                    }
                }

                else
                {
                    pnlBackground.FillColor = Color.Transparent;

                    lblPlay.Visible = true;

                    if (btnFavorite.Checked != true)
                    {
                        lblFavorite.Visible = true;
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

        private void btnPlay_MouseClickPlay(object sender, MouseEventArgs e)
        {
            _mouseClickPlay?.Invoke(sender, e);
        }

        private void btnFavorite_MouseClick(object sender, MouseEventArgs e)
        {
            btnFavorite.Checked = !btnFavorite.Checked;

            isFavorite = btnFavorite.Checked;
        }


        #endregion

    }
}
