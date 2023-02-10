using Guna.UI2.WinForms;
using Music__Player.sources.DAO.HomeDAO;
using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Music__Player.sources.PlayMusic
{
    public class Media__Player
    {
        private static Media__Player instance;
        public static Media__Player Instance
        {
            get
            {
                if (instance == null)
                    instance = new Media__Player();

                return instance;
            }

            private set { instance = value; }
        }
        private Media__Player() { }

        public WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public bool isPlay = false;

        private Song__Playing__BottomBar bottomBar;
        public Song__Playing__BottomBar BottomBar
        {
            get { return bottomBar; }
            set
            {
                bottomBar = value;
            }
        }
        public void RunMP3(string url, Timer timer)
        {
            player.settings.volume = 30;

            player.URL = url;

            player.controls.play();
            
            timer.Enabled = true;
        }
        
        public void EventTimer(Timer timer1, Guna2ImageButton btnPlay, Guna2TrackBar sliderTimeMusic, Label lblStart, Label lblEnd)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                btnPlay.Checked = true;

                sliderTimeMusic.Maximum = (int)player.controls.currentItem.duration;

                sliderTimeMusic.Value = (int)player.controls.currentPosition;

                lblEnd.Text = player.controls.currentItem.durationString;

                lblStart.Text = player.controls.currentPositionString;
            }
            else if (player.playState == WMPPlayState.wmppsStopped)
            {
                timer1.Enabled = false;

                lblStart.Text = lblEnd.Text;

                btnPlay.Checked = false;

                sliderTimeMusic.Value = sliderTimeMusic.Maximum;

                return;
            }
        }

        public void SliderTimeMusicScroll(Guna2TrackBar sliderTimeMusic)
        {
            player.controls.currentPosition = sliderTimeMusic.Value;
        }

        public void SliderVolumeMusicScroll(Guna2TrackBar sliderVolumeMusic)
        {
            player.settings.volume = sliderVolumeMusic.Value;
        }

        public void btnPlay_HomeClick(Guna2ImageButton btn)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                Console.WriteLine("Into1");
                btn.Checked = false;

                isPlay = false;

                player.controls.pause();
            }
            else if (player.playState == WMPPlayState.wmppsPaused)
            {
                Console.WriteLine("Into2");
                btn.Checked = true;

                isPlay = true;
                
                player.controls.play();
            }
            else
            {
                Navigate.Navigation.homeScreen.SearchAndPlaySong(Song__Playing__DAO.Instance.currInfoSongPanel);
            }
        }

        public void btnPlayEvent(Guna2ImageButton btn)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                btn.Checked = false;

                isPlay = false;

                player.controls.pause();
            }
            else if (player.playState == WMPPlayState.wmppsPaused)
            {
                btn.Checked = true;

                isPlay = true;

                player.controls.play();
            }
        }

        public void NavigateAllScreen()
        {
            Navigate.Navigation.Instance.historyScreen.HandleButtonPlay(isPlay);

            Navigate.Navigation.Instance.favoriteScreen.HandleButtonPlay(isPlay);

            Navigate.Navigation.Instance.playlistScreen.HandleButtonPlay(isPlay);

            Navigate.Navigation.Instance.childPlaylistScreen.HandleButtonPlay(isPlay);

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.HandleButtonPlay(isPlay);

            Navigate.Navigation.Instance.albumsScreen.HandleButtonPlay(isPlay);

            Navigate.Navigation.Instance.childAlbumScreen.HandleButtonPlay(isPlay);

            Navigate.Navigation.Instance.songsScreen.HandleButtonPlay(isPlay);

            Navigate.Navigation.homeScreen.HandleButtonPlay(isPlay);
        }

    }
}
