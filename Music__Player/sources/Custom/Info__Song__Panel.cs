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
    public partial class Info__Song__Panel : UserControl
    {
        public Info__Song__Panel()
        {
            InitializeComponent();
        }

        #region Initial

        public Info__Song__Panel(Songs_Display songDisplay)
        {
            InitializeComponent();

            this.Title = songDisplay.NameSong;

            this.Artist = songDisplay.Artist;

            this.Duration = songDisplay.Duration;

            this.Image_Song = songDisplay.ImageSong;

            this.URL = songDisplay.URL;

            LoadInitialEvent();
        }
        public Info__Song__Panel(List__Song__Playlist songByPlaylist)
        {
            InitializeComponent();

            this.Title = songByPlaylist.Title;

            this.Artist = songByPlaylist.Artist;

            this.Duration = songByPlaylist.Duration;

            this.Image_Song = songByPlaylist.Image_Song;

            this.URL = songByPlaylist.URL;

            LoadInitialEvent();
        }

        public Info__Song__Panel(Song__History songHistory)
        {
            InitializeComponent();

            this.Title = songHistory.Title;

            this.Artist = songHistory.Artist;

            this.Duration = songHistory.Duration;

            this.Image_Song = songHistory.Image_Song;

            this.URL = songHistory.URL;

            LoadInitialEvent();
        }

        public Info__Song__Panel(DataRow row)
        {
            InitializeComponent();

            this.Title = row["NAME_SONG"].ToString();

            this.Artist = row["ARTIST"].ToString();

            this.Duration = row["DURATION"].ToString();

            MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_SONG"]);

            Image temp = Image.FromStream(stream);

            this.Image_Song = temp;

            this.URL = row["LINK"].ToString();

            LoadInitialEvent();
        }

        private void LoadInitialEvent()
        {
            pnlBackground.MouseDoubleClick += userControl_DoubleClick;

            pnlBackground.MouseEnter += userControl_MouseEnter;

            pnlBackground.MouseLeave += userControl_MouseLeave;

            btnPlay.MouseClick += btnPlay_MouseClickPlay;

            btnFavorite.MouseClick += btnFavorite_MouseClickFavorite;
        }

        private string iD;
        public string ID
        {
            get { return iD; }
            set { iD = value; lblNumber.Text = value; }
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

        private bool isFavorite;
        public bool IsFavorite
        {
            get { return isFavorite; }
            set
            {
                isFavorite = value;

                if (isFavorite == true)
                {
                    lblFavorite.Visible = false;

                    btnFavorite.Checked = true;
                }
                else
                {
                    lblFavorite.Visible = true;

                    btnFavorite.Checked = false;
                }
            }
        }

        private bool isPlay;
        public bool IsPlay
        {
            get { return isPlay; }
            set
            {
                isPlay = value;

                if (isPlay == true)
                {
                    btnPlay.Checked = true;
                }
                else
                {
                    btnPlay.Checked = false;
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
                    lblNumber.Visible = false;

                    btnPlay.Checked = true;

                    pnlBackground.FillColor = SystemColors.Info;
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
                    pnlBackground.FillColor = SystemColors.Info;

                    lblNumber.Visible = false;

                    lblFavorite.Visible = false;

                    if (isHovered == false && isSelected == true && btnFavorite.Checked == false)
                    {
                        lblFavorite.Visible = true;

                    }
                }

                else
                {
                    pnlBackground.FillColor = Color.White;

                    lblNumber.Visible = true;

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

        private event MouseEventHandler _mouseClickFavorite;

        public event MouseEventHandler MouseClickFavorite
        {
            add
            {
                _mouseClickFavorite += value;
            }
            remove
            {
                _mouseClickFavorite -= value;
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

        #endregion

        private void btnFavorite_MouseClickFavorite(object sender, MouseEventArgs e)
        {
            _mouseClickFavorite?.Invoke(sender, e);
        }

        private void btnPlay_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}
