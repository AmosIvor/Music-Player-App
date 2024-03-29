﻿using Music__Player.sources.Custom;
using Music__Player.sources.DAO.CustomDAO;
using Music__Player.sources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Music__Player.sources.DAO.PlaylistDAO;

namespace Music__Player.sources.View
{
    public partial class Playlist : UserControl
    {
        Playlist__Add__Panel pnlAddPlaylist = new Playlist__Add__Panel();

        Panel pnlHovered = new Panel();

        public Info__Playlist__Panel playlistSongPlaying;

        Panel pnlClicked = new Panel();

        public bool isClick = false;

        public Playlist()
        {
            InitializeComponent();

            LoadPlaylists();

            LoadInitialSongBottomBar();
        }

        #region Load Playlists
        public void LoadPlaylists()
        {
            fpnlPlaylists.Controls.Clear();

            List<Info__Playlist__Panel> listInfoPlaylist = Info__Playlist__Panel__DAO.Instance.GetListInfoPlaylistPanel();

            foreach (Info__Playlist__Panel infoPlaylist in listInfoPlaylist)
            {
                infoPlaylist.MouseDoubleClickAdd += InfoPlaylist_MouseDoubleClickAdd;

                infoPlaylist.MouseEnterAdd += InfoPlaylist_MouseEnterAdd;

                infoPlaylist.MouseLeaveAdd += InfoPlaylist_MouseLeaveAdd;

                infoPlaylist.MouseClickPlay += InfoPlaylist_MouseClickPlay;

                infoPlaylist.MouseClickBin += InfoPlaylist_MouseClickBin;

                fpnlPlaylists.Controls.Add(infoPlaylist);
            }

            fpnlPlaylists.Controls.Add(pnlAddPlaylist);

            LoadEventAddPlaylist();

            LoadEventClick();

            lblTitle.Text = $"Amos Ivor - {fpnlPlaylists.Controls.Count - 1} playlists";
        }

        #endregion

        #region Load Event Panel Add Playlist
        void LoadEventAddPlaylist()
        {
            pnlAddPlaylist.MouseDoubleClickAdd += pnlAddPlaylist_MouseDoubleClickAdd;

            pnlAddPlaylist.MouseEnterAdd += pnlAddPlaylist_MouseEnterAdd;

            pnlAddPlaylist.MouseLeaveAdd += pnlAddPlaylist_MouseLeaveAdd;

            pnlAddPlaylist.MouseClickCreate += pnlAddPlaylist_MouseClickCreate;
        }

        private void pnlAddPlaylist_MouseClickCreate(object sender, MouseEventArgs e)
        {
            if (fpnlPlaylists.Tag != null)
            {
                Info__Playlist__Panel prevSelected = (Info__Playlist__Panel)fpnlPlaylists.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            Popup__Create__Playlist__DAO.Instance.ShowPopup();
        }
        private void pnlAddPlaylist_MouseDoubleClickAdd(object sender, MouseEventArgs e)
        {
            if (fpnlPlaylists.Tag != null)
            {
                Info__Playlist__Panel prevSelected = (Info__Playlist__Panel)fpnlPlaylists.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton)
            {
                Playlist__Add__Panel playlistAddInside = Playlist__Add__Panel__DAO.Instance.GetPlaylistAddPanelFromControlIntoPanel(sender);

                playlistAddInside.IsHovered = false;

                Popup__Create__Playlist__DAO.Instance.ShowPopup();

                return;
            }

            Playlist__Add__Panel playlistAddOutside = Playlist__Add__Panel__DAO.Instance.GetPlaylistAddPanelFromPanel(sender);

            playlistAddOutside.IsHovered = false;

            Popup__Create__Playlist__DAO.Instance.ShowPopup();
        }
        private void pnlAddPlaylist_MouseEnterAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton)
            {
                Playlist__Add__Panel playlistAddInside = Playlist__Add__Panel__DAO.Instance.GetPlaylistAddPanelFromControlIntoPanel(sender);

                playlistAddInside.IsHovered = true;

                return;
            }

            Playlist__Add__Panel playlistAddOutside = Playlist__Add__Panel__DAO.Instance.GetPlaylistAddPanelFromPanel(sender);

            playlistAddOutside.IsHovered = true;
        }
        private void pnlAddPlaylist_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton)
            {
                Playlist__Add__Panel playlistAddInside = Playlist__Add__Panel__DAO.Instance.GetPlaylistAddPanelFromControlIntoPanel(sender);

                playlistAddInside.IsHovered = false;

                return;
            }

            Playlist__Add__Panel playlistAddOutside = Playlist__Add__Panel__DAO.Instance.GetPlaylistAddPanelFromPanel(sender);

            playlistAddOutside.IsHovered = false;
        }

        #endregion

        #region Load Info Playlist Panel
        private void InfoPlaylist_MouseClickPlay(object sender, MouseEventArgs e)
        {
            if (fpnlPlaylists.Tag != null)
            {
                Info__Playlist__Panel prevSelected = (Info__Playlist__Panel)fpnlPlaylists.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            Info__Playlist__Panel curr = Info__Playlist__Panel__DAO.Instance.GetInfoPlaylistPanelFromControlIntoPanel(sender);

            curr.IsSelected = true;

            Context__Menu__DAO.Instance.currChildPlaylist = curr.ID_Playlist;

            fpnlPlaylists.Tag = curr;

            pnlClicked.Tag = curr;

            playlistSongPlaying = curr;

            pnlClicked.Tag = curr;

            Navigate.Navigation.Instance.mainScreen.LoadChildPlaylistPlayingSong();

            PauseSongInSomeScreen();

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.LoadChildPlaylist(curr.ID_Playlist);

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.LoadTitle(curr.Image_Playlist, curr.Name_Playlist);

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.PlayFirstSong();
        }
        private void InfoPlaylist_MouseDoubleClickAdd(object sender, MouseEventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton || sender is Guna2CirclePictureBox)
            {
                Info__Playlist__Panel infoPlaylistInside = Info__Playlist__Panel__DAO.Instance.GetInfoPlaylistPanelFromControlIntoPanel(sender);

                if (playlistSongPlaying == infoPlaylistInside)
                {
                    Navigate.Navigation.Instance.mainScreen.LoadChildPlaylistPlayingSong();

                    pnlClicked.Tag = infoPlaylistInside;

                    return;
                }

                pnlClicked.Tag = infoPlaylistInside;

                Context__Menu__DAO.Instance.currChildPlaylist = infoPlaylistInside.ID_Playlist;

                Navigate.Navigation.Instance.mainScreen.LoadChildPlaylist();

                Navigate.Navigation.Instance.childPlaylistScreen.LoadChildPlaylist(infoPlaylistInside.ID_Playlist);

                Navigate.Navigation.Instance.childPlaylistScreen.LoadTitle(infoPlaylistInside.Image_Playlist, infoPlaylistInside.Name_Playlist);

                return;
            }

            Info__Playlist__Panel infoPlaylistOutside = Info__Playlist__Panel__DAO.Instance.GetInfoPlaylistPanelFromPanel(sender);

            if (playlistSongPlaying == infoPlaylistOutside)
            {
                Navigate.Navigation.Instance.mainScreen.LoadChildPlaylistPlayingSong();

                pnlClicked.Tag = infoPlaylistOutside;

                return;
            }

            pnlClicked.Tag = infoPlaylistOutside;

            Context__Menu__DAO.Instance.currChildPlaylist = infoPlaylistOutside.ID_Playlist;

            Navigate.Navigation.Instance.mainScreen.LoadChildPlaylist();

            Navigate.Navigation.Instance.childPlaylistScreen.LoadChildPlaylist(infoPlaylistOutside.ID_Playlist);

            Navigate.Navigation.Instance.childPlaylistScreen.LoadTitle(infoPlaylistOutside.Image_Playlist, infoPlaylistOutside.Name_Playlist);
        }
        private void InfoPlaylist_MouseEnterAdd(object sender, EventArgs e)
        {
            if (pnlHovered.Tag != null)
            {
                Info__Playlist__Panel prevHover = (Info__Playlist__Panel)pnlHovered.Tag;

                prevHover.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2CirclePictureBox)
            {
                Info__Playlist__Panel infoPlaylistInside = Info__Playlist__Panel__DAO.Instance.GetInfoPlaylistPanelFromControlIntoPanel(sender);

                infoPlaylistInside.IsHovered = true;

                pnlHovered.Tag = infoPlaylistInside;

                return;
            }

            Info__Playlist__Panel infoPlaylistOutside = Info__Playlist__Panel__DAO.Instance.GetInfoPlaylistPanelFromPanel(sender);

            infoPlaylistOutside.IsHovered = true;
        }
        private void InfoPlaylist_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton || sender is Guna2CirclePictureBox)
            {
                Info__Playlist__Panel infoPlaylistInside = Info__Playlist__Panel__DAO.Instance.GetInfoPlaylistPanelFromControlIntoPanel(sender);

                infoPlaylistInside.IsHovered = false;

                return;
            }

            Info__Playlist__Panel infoPlaylistOutside = Info__Playlist__Panel__DAO.Instance.GetInfoPlaylistPanelFromPanel(sender);

            infoPlaylistOutside.IsHovered = false;
        }
        private void InfoPlaylist_MouseClickBin(object sender, MouseEventArgs e)
        {
            try
            {
                Info__Playlist__Panel infoPlaylistInside = Info__Playlist__Panel__DAO.Instance.GetInfoPlaylistPanelFromControlIntoPanel(sender);

                PlaylistDAO.Instance.DeletePlaylist(infoPlaylistInside.ID_Playlist);

                fpnlPlaylists.Controls.Remove(infoPlaylistInside);

                Navigate.Navigation.Instance.mainScreen.DeletePlaylistMenuBar(infoPlaylistInside.Name_Playlist);
            }

            catch { }
        }

        #endregion

        #region BottomBar
        void LoadEventClick()
        {
            Dropdown__Playlist__DAO.Instance.GetAllControls(this);
        }

        void LoadEventBottomBar()
        {
            songPlayingBottomBar.MouseClickAddPlaylist += SongPlayingBottomBar_MouseClickAddPlaylist;
        }

        private void SongPlayingBottomBar_MouseClickAddPlaylist(object sender, EventArgs e)
        {
            Dropdown__Playlist__DAO.Instance.AddPlaylistEventInUserControl(this);
        }

        public void LoadSongPlayingBottomBar()
        {
            songPlayingBottomBar.LoadSongPlayingByInfoSongPanel();
        }

        public void LoadInitialSongBottomBar()
        {
            songPlayingBottomBar.LoadInitialSong();

            LoadEventBottomBar();
        }

        public void HandleButtonPlay(bool isPlay)
        {
            songPlayingBottomBar.IsPlay = isPlay;
        }

        #endregion

        #region Navigate
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pnlClicked.Tag == null)

                return;

            Info__Playlist__Panel prevClicked = (Info__Playlist__Panel)pnlClicked.Tag;

            if (playlistSongPlaying == prevClicked)
            {
                Navigate.Navigation.Instance.mainScreen.LoadChildPlaylistPlayingSong();

                return;
            }

            Navigate.Navigation.Instance.mainScreen.LoadChildPlaylist();
        }

        #endregion

        #region Handle PlayButton
        public void HandlePlayButtonInfoPlaylist()
        {
            if (fpnlPlaylists.Tag != null)
            {
                Info__Playlist__Panel prevSelected = (Info__Playlist__Panel)fpnlPlaylists.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            if (pnlClicked.Tag != null)
            {
                Info__Playlist__Panel prevClicked = (Info__Playlist__Panel)pnlClicked.Tag;

                prevClicked.IsSelected = true;

                if (prevClicked != playlistSongPlaying)
                {
                    Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.LoadChildPlaylist(prevClicked.ID_Playlist);

                    Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.LoadTitle(prevClicked.Image_Playlist, prevClicked.Name_Playlist);

                    Context__Menu__DAO.Instance.currChildPlaylist = prevClicked.ID_Playlist;
                }

                fpnlPlaylists.Tag = prevClicked;

                playlistSongPlaying = prevClicked;
            }

        }

        #endregion

        #region Number Playlist
        
        public void LoadNumberSongInPlaylist()
        {
            if (pnlClicked.Tag == null)

                return;

            Info__Playlist__Panel prevClicked = (Info__Playlist__Panel)pnlClicked.Tag;

            Navigate.Navigation.Instance.childPlaylistScreen.LoadNumberSongInPlayist(prevClicked);
        }

        #endregion

        #region Pause Song
        

        public void PauseSongInSomeScreen()
        {
            Navigate.Navigation.Instance.albumsScreen.PauseSongInAlbum();

            Navigate.Navigation.Instance.favoriteScreen.PauseSongInFavorite();

            Navigate.Navigation.Instance.songsScreen.PauseSongInSong();
        }

        #endregion 
    }
}
