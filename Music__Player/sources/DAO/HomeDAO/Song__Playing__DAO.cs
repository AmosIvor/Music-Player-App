﻿using Guna.UI2.WinForms;
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

        public Info__Song__Panel initialSong;

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

        public void SetSongPlayingByInfoSongPanel(Info__Song__Panel info, Guna2ShadowPanel pnlMain, Guna2PictureBox pbImage, Label lblTitle, Label lblArtist, Label lblDuration)
        {
            lblTitle.Text = info.Title;

            lblTitle.Location = new System.Drawing.Point(CenterHorizontal(pnlMain, lblTitle), lblTitle.Location.Y);

            lblArtist.Text = info.Artist;

            lblArtist.Location = new System.Drawing.Point(CenterHorizontal(pnlMain, lblArtist), lblArtist.Location.Y);

            lblDuration.Text = info.Duration;

            pbImage.Image = info.Image_Song;
        }

        public void SetSongPlayingBottomBar(Guna2PictureBox pbImage, Label lblNameSong, Label lblArtist, Label lblDuration)
        {
            songPlayingByInfoSongPanel = new Song__Playing(currInfoSongPanel);

            lblNameSong.Text = songPlayingByInfoSongPanel.Title;

            lblArtist.Text = songPlayingByInfoSongPanel.Artist;

            pbImage.Image = songPlayingByInfoSongPanel.Image_Song;

            lblDuration.Text = songPlayingByInfoSongPanel.Duration;
        }

        public void SetSongPlayingBottomBar(bool isInitial, Guna2PictureBox pbImage, Label lblNameSong, Label lblArtist, Label lblDuration)
        {
            songPlayingByInfoSongPanel = new Song__Playing(initialSong);

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

        public void PlayFirstSong(FlowLayoutPanel fpnlSongs)
        {
            if (fpnlSongs.Controls.Count == 0)
            {
                return;
            }
            List__Song__Playlist firstSong = fpnlSongs.Controls.OfType<List__Song__Playlist>().FirstOrDefault(c => c.ID == "01");

            fpnlSongs.Tag = firstSong;

            firstSong.IsSelected = true;

            Info__Song__Panel infoSongOutside = new Info__Song__Panel(firstSong);

            currInfoSongPanel = infoSongOutside;

            Navigate.Navigation.Instance.historyScreen.InsertHistory();

            LoadSongPlayingAllScreen();
        }

        public void LoadSongPlayingAllScreen()
        {
            Navigate.Navigation.Instance.historyScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.playlistScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.childPlaylistScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.favoriteScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.songsScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.childAlbumScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.albumsScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.homeScreen.LoadSongPlaying();
        }
    }
}
