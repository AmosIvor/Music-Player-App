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
        }

        public void LoadSongPlayingByInfoSongPanel()
        {
            Media__Player.Instance.RunMP3(Song__Playing__DAO.Instance.currInfoSongPanel.URL, timerMusic);

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

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Media__Player.Instance.btnPlay_Click(btnPlay, timerMusic);
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            try
            {
                if (Song__Playing__DAO.Instance.currInfoSongPanel != null)
                {
                    Media__Player.Instance.RunMP3(Song__Playing__DAO.Instance.currInfoSongPanel.URL, timerMusic);
                }
            }
            catch { }
        }
    }
}
