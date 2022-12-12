using Guna.UI2.WinForms;
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

        public void RunMP3(string url, Timer timer)
        {
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

        public void btnPlay_Click(Guna2ImageButton btn)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                btn.Checked = false;

                player.controls.pause();
            }

            else if (player.playState == WMPPlayState.wmppsPaused)
            {
                btn.Checked = true;

                player.controls.play();
            }
        }
    }
}
