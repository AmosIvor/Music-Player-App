using Guna.UI2.WinForms;
using Music__Player.sources.Custom;
using Music__Player.sources.DAO.CustomDAO;
using Music__Player.sources.DTO.HomeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO.HomeDAO
{
    public class Song__Playing__DAO
    {
        private static Song__Playing__DAO instance;
        public static Song__Playing__DAO Instance
        {
            get
            {
                if (instance == null)

                    instance = new Song__Playing__DAO();

                return instance;
            }
            private set { instance = value; }
        }

        private Song__Playing__DAO() { }

        public Info__Song__Panel currInfoSongPanel;

        public Song__Playing songPlayingByInfoSongPanel;

        public void SetSongPlayingByInfoSongPanel(Guna2ShadowPanel pnlMain, Guna2PictureBox pbImage, Label lblTitle, Label lblArtist, Label lblDuration)
        {
            songPlayingByInfoSongPanel = new Song__Playing(currInfoSongPanel);

            lblTitle.Text = songPlayingByInfoSongPanel.Title;

            lblTitle.Location = new System.Drawing.Point(CenterHorizontal(pnlMain, lblTitle), lblTitle.Location.Y);

            lblArtist.Text = songPlayingByInfoSongPanel.Artist;

            lblArtist.Location = new System.Drawing.Point(CenterHorizontal(pnlMain, lblArtist), lblArtist.Location.Y);

            lblDuration.Text = songPlayingByInfoSongPanel.Duration;

            pbImage.Image = songPlayingByInfoSongPanel.Image_Song;
        }

        public void SetSongPlayingBottomBar(Guna2PictureBox pbImage, Label lblNameSong, Label lblArtist, Label lblDuration)
        {
            songPlayingByInfoSongPanel = new Song__Playing(currInfoSongPanel);

            lblNameSong.Text = songPlayingByInfoSongPanel.Title;

            lblArtist.Text = songPlayingByInfoSongPanel.Artist;

            pbImage.Image = songPlayingByInfoSongPanel.Image_Song;

            lblDuration.Text = songPlayingByInfoSongPanel.Duration;
        }

        private int CenterHorizontal(Guna2ShadowPanel mainPanel, Control control)
        {
            int temp = (mainPanel.Width - control.Width) / 2;

            return (mainPanel.Location.X + temp - 44);
        }

        public void LoadSongPlayingAllScreen()
        {
            Navigate.Navigation.Instance.historyScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.playlistScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.childPlaylistScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.homeScreen.LoadSongPlaying();
        }


    }
}
