using Music__Player.Properties;
using Music__Player.sources.DAO.CustomDAO;
using Music__Player.sources.DAO.HomeDAO;
using Music__Player.sources.PlayMusic;
using Music__Player.sources.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Music__Player.sources.Custom
{
    public partial class Song__Playing__BottomBar : UserControl
    {
        public Song__Playing__BottomBar()
        {
            InitializeComponent();

            LoadEvent();
        }

        #region Initial Event

        void LoadEvent()
        {
            btnAddPlaylist.Click += btnAddPlaylist_Click;
        }

        private event EventHandler _mouseClickAddPlaylist;

        public event EventHandler MouseClickAddPlaylist
        {
            add
            {
                _mouseClickAddPlaylist += value;
            }

            remove
            {
                _mouseClickAddPlaylist -= value;
            }
        }

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            _mouseClickAddPlaylist?.Invoke(sender, e);
        }

       

        #endregion

        public void LoadSongPlayingByInfoSongPanel()
        {
            Media__Player.Instance.RunMP3(Song__Playing__DAO.Instance.currInfoSongPanel.URL, timerMusic);

            LoadInitialSong();
        }

        public void LoadInitialSong()
        {
            Song__Playing__DAO.Instance.SetSongPlayingBottomBar(pbImage, lblNameSong, lblArtist, lblEnd);
        }
        private void timerMusic_Tick(object sender, EventArgs e)
        {
            Media__Player.Instance.EventTimer(timerMusic, btnPlay, sliderTimeMusic, lblStart, lblEnd);
        }

        private void sliderTimeMusic_Scroll(object sender, ScrollEventArgs e)
        {
            Media__Player.Instance.SliderTimeMusicScroll(sliderTimeMusic);
        }

        private void sliderVolume_Scroll(object sender, ScrollEventArgs e)
        {
            Media__Player.Instance.SliderVolumeMusicScroll(sliderVolume);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Media__Player.Instance.btnPlay_Click(btnPlay, timerMusic, this);
            IsPlay = !IsPlay;
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            try
            {
                if (Song__Playing__DAO.Instance.currInfoSongPanel != null)
                {
                    Media__Player.Instance.RunMP3(Song__Playing__DAO.Instance.currInfoSongPanel.URL, timerMusic);
                }

                if (playingSong != null)
                {
                    Media__Player.Instance.RunMP3(playingSong.URL, timerMusic);
                    lblStart.Text = "00:00";
                }
            }
            catch { }
        }

        private void btnAddPlaylist_MouseClick(object sender, MouseEventArgs e)
        {
            Dropdown__Playlist__DAO.Instance.songSelecting = lblNameSong.Text;
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
                    btnPlay.Image = Resources.pause_100px_png1;
                }
                else
                {
                    btnPlay.Image = Resources.play_100px_png1;
                }
            }
        }

        private Songs_Display playingSong;
        public Songs_Display PlayingSong
        {
            get { return playingSong; }
            set
            {
                playingSong = value;
            }
        }

        
        public void setPlayingSong(Songs_Display song)
        {
            pbImage.Image = song.ImageSong;
            lblNameSong.Text = song.NameSong;
            lblArtist.Text = song.Artist;
            IsPlay = true;
            PlayingSong= song;
            lblStart.Text = "00:00";
            sliderTimeMusic.Value = 0;
            lblEnd.Text = song.Duration;
            Media__Player.Instance.RunMP3(song.URL, timerMusic);
        }
    }
}
