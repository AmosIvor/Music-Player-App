﻿using Music__Player.sources.DAO;
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
    public partial class Songs_Display : UserControl
    {
        public Songs_Display()
        {
            InitializeComponent();
        }

        public Songs_Display(DataRow row, List<Songs_Display> listSongs)
        {
            InitializeComponent();
            Id = row["ID_SONG"].ToString();

            MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_SONG"]);
            Image temp = Image.FromStream(stream);
            ImageSong = temp;

            NameSong = row["NAME_SONG"].ToString();
            Artist = row["ARTIST"].ToString();
            Duration = row["DURATION"].ToString() ;
            Album = row["NAME_ALBUM"].ToString();
            URL = row["LINK"].ToString();

            this.listSongs = listSongs;

            if (row["ISFAVORITE"].ToString() == "False")           
                IsSelectedFavorite = false;
            else
                IsSelectedFavorite = true;
        }

        private List<Songs_Display> listSongs;

        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                lbId.Text = id;
            }
        }

        private Image imageSong;
        public Image ImageSong
        {
            get { return imageSong; }
            set
            {
                imageSong = value;
                pbImageSong.Image = imageSong;
            }
        }

        private string nameSong;
        public string NameSong
        {
            get { return nameSong; }
            set
            {
                nameSong = value;
                lbNameSong.Text = nameSong;
            }
        }

        private string artist;
        public string Artist
        {
            get { return artist; }
            set
            {
                artist = value;
                lbArtist.Text = artist;
            }
        }

        private string duration;
        public string Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                lbTimeSong.Text = duration;
            }
        }

        private string album;
        public string Album
        {
            get { return album; }
            set
            {
                album = value;
                lbAlbum.Text = album;
            }
        }

        private string url;
        public string URL
        {
            get { return url; }
            set { url = value;}
        }

        private bool isSelectedFavorite;
        private bool IsSelectedFavorite
        {
            get 
            { 
                return isSelectedFavorite; 
            }
            set
            {
                if (value == false)
                {
                    favoriteBox.Image = null;
                    isSelectedFavorite = false;
                }
                else
                {
                    isSelectedFavorite = true;
                    favoriteBox.Image = Properties.Resources.icon_love_green;
                }
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            if (!isSelectedFavorite)
            {
                favoriteBox.Size = new Size(30, 30);
                favoriteBox.Image = Properties.Resources.icon_love_green;
            }
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            if (!isSelectedFavorite)
            {
                favoriteBox.Image = null;
                favoriteBox.Size = new Size(28, 28);
            }
        }

        private void HandleMouseEnter(object sender, EventArgs e)
        {
            foreach(Control control in ShadowPanelSong.Controls)
            {
                control.BackColor = Color.Gainsboro;
            }
            Cursor = Cursors.Hand;
            lbId.Visible = false;
            picturePlaySong.Visible = true;
            ShadowPanelSong.FillColor = Color.Gainsboro;
            if (!isSelectedFavorite)
            {
                favoriteBox.Image = Properties.Resources.icon_love_black;
            }
        }

        private void HandleMouseLeave(object sender, EventArgs e)
        {
            foreach (Control control in ShadowPanelSong.Controls)
            {
                control.BackColor = Color.WhiteSmoke;
            }
            Cursor = Cursors.Default;
            lbId.Visible = true;
            picturePlaySong.Visible = false;    
            ShadowPanelSong.FillColor = Color.WhiteSmoke;
            if (!isSelectedFavorite)
            {
                favoriteBox.Image = null;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (IsSelectedFavorite == true)
            {
                IsSelectedFavorite = false;
                DataProviderDAO.Instance.ExecuteNonQuery($"UPDATE FAVORITES\r\nSET ISFAVORITE = 0\r\nWHERE ID_SONG = {Id}");
            }
            else
            {
                IsSelectedFavorite = true;
                DataProviderDAO.Instance.ExecuteNonQuery($"UPDATE FAVORITES\r\nSET ISFAVORITE = 1\r\nWHERE ID_SONG = {Id}");
            }
        }

        private bool isSelectedSong = false;
        public bool IsSelectedSong
        {
            get { return isSelectedSong; }
            set
            {
                if (value == true) 
                {
                    picturePlaySong.Image = Properties.Resources.icon_play_blue;
                    isSelectedSong = true;
                } else
                {
                    picturePlaySong.Image = Properties.Resources.icon_pause_blue;
                    isSelectedSong = false;
                }
            }
        }
        private void lbTimeSong_Click(object sender, EventArgs e)
        {
            if (IsSelectedSong == true)
            {
                IsSelectedSong = false;
            } else
            {
                foreach (Songs_Display songs in listSongs)
                {
                    if (songs.IsSelectedSong == true)
                        songs.IsSelectedSong = false;
                }
                IsSelectedSong = true;
            }
        }
    }
}
