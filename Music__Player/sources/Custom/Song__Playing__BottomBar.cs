using Music__Player.Properties;
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
        //private static Song__Playing__Bottom__Bar instance;
        //public static Song__Playing__Bottom__Bar Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new Song__Playing__Bottom__Bar();

        //        return instance;
        //    }

        //    private set { instance = value; }
        //}

        public Song__Playing__BottomBar()
        {
            InitializeComponent();
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

        public void LoadSongPlaying()
        {
            Media__Player.Instance.RunMP3(Home.musicPlaying.URL, timerMusic);

            Song__Playing__DAO.Instance.SetSongPlayingBottomBar(Home.musicPlaying, pbImage, lblNameSong, lblArtist, lblEnd);
        }

        private void timerMusic_Tick(object sender, EventArgs e)
        {
            Media__Player.Instance.EventTimer(timerMusic, btnPlay, sliderTimeMusic, lblStart, lblEnd);
        }

        private void sliderTimeMusic_Scroll(object sender, ScrollEventArgs e)
        {
            Media__Player.Instance.SliderTimeMusicScroll(sliderTimeMusic);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Media__Player.Instance.btnPlay_Click(btnPlay, this);
            if (IsPlay == true)
            {
                IsPlay = false;
            } else 
                IsPlay = true;
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            try
            {
                if (Home.musicPlaying != null)
                {
                    Media__Player.Instance.RunMP3(Home.musicPlaying.URL, timerMusic);
                }
                if (songPlaying != null)
                {
                    Media__Player.Instance.RunMP3(songPlaying.URL, timerMusic);
                }
            }
            catch 
            {

            }
        }

        private Songs_Display songPlaying;
        public Songs_Display SongPlaying
        {
            get { return songPlaying; }
            set
            {
                songPlaying = value;
            }
        }
        public void setPlayingBottomBar(Songs_Display song)
        {
            songPlaying = song;
            pbImage.Image = song.ImageSong;
            lblNameSong.Text = song.NameSong;
            lblStart.Text = "00:00";
            lblEnd.Text = song.Duration;
            lblArtist.Text = song.Artist;
            IsPlay = true;
            Media__Player.Instance.RunMP3(songPlaying.URL, timerMusic);
        }
    }
} 
