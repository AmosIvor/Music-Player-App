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
using Music__Player.Properties;
using Music__Player.sources.Constant;
using Music__Player.sources.Custom;
using Music__Player.sources.DAO.CustomDAO;
using Music__Player.sources.DAO.FavoriteDAO;
using Music__Player.sources.DAO.HomeDAO;
using Music__Player.sources.DAO.PlaylistDAO;
using Music__Player.sources.DTO.ChildPlaylistDTO;

namespace Music__Player.sources.View
{
    public partial class Child__Playlist : UserControl
    {
        Panel pnlHovered = new Panel();

        Panel pnlOptioned = new Panel();

        public Child__Playlist()
        {
            InitializeComponent();

            LoadInitialSongBottomBar();
        }

        public void LoadChildPlaylist(int idPlaylist)
        {
            LoadListSongByIdPlaylist(idPlaylist);

            LoadEventClick();
        }

        #region Load Song by Playlist
        public void LoadListSongByIdPlaylist(int idPlaylist)
        {
            fpnlSongs.Controls.Clear();

            List<List__Song__Playlist> listSong = List__Song__Playlist__DAO.Instance.GetListSongByIdPlaylist(idPlaylist);

            int id = 1;

            foreach (List__Song__Playlist songByPlaylist in listSong)
            {
                songByPlaylist.ID = List__Song__Playlist__DAO.Instance.ConvertID(id++);

                songByPlaylist.MouseDoubleClickAdd += songByPlaylist_MouseDoubleClickAdd;

                songByPlaylist.MouseEnterAdd += songByPlaylist_MouseEnterAdd;

                songByPlaylist.MouseLeaveAdd += songByPlaylist_MouseLeaveAdd;

                songByPlaylist.MouseClickPlay += songByPlaylist_MouseClickPlay;

                songByPlaylist.MouseClickOption += songByPlaylist_MouseClickOption;

                songByPlaylist.MouseClickFavorite += songByPlaylist_MouseClickFavorite;

                fpnlSongs.Controls.Add(songByPlaylist);
            }

            LoadNumberSong();
        }

        private void songByPlaylist_MouseClickPlay(object sender, MouseEventArgs e)
        {
            if (fpnlSongs.Tag != null)
            {
                List__Song__Playlist prev = (List__Song__Playlist)fpnlSongs.Tag;

                prev.IsSelected = false;

                prev.IsHovered = false;
            }

            List__Song__Playlist curr = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

            fpnlSongs.Tag = curr;

            curr.IsSelected = true;

            Info__Song__Panel infoSong = new Info__Song__Panel(curr);

            Song__Playing__DAO.Instance.currInfoSongPanel = infoSong;

            Navigate.Navigation.Instance.historyScreen.InsertHistory();

            Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();

            Navigate.Navigation.Instance.playlistScreen.HandlePlayButtonInfoPlaylist();

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.SetSongPlaying(curr);
        }
        private void songByPlaylist_MouseDoubleClickAdd(object sender, MouseEventArgs e)
        {
            if (fpnlSongs.Tag != null)
            {
                List__Song__Playlist prevSelected = (List__Song__Playlist)fpnlSongs.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                List__Song__Playlist songByPlaylistInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                fpnlSongs.Tag = songByPlaylistInside;

                songByPlaylistInside.IsSelected = true;

                Info__Song__Panel infoSong = new Info__Song__Panel(songByPlaylistInside);

                Song__Playing__DAO.Instance.currInfoSongPanel = infoSong;

                Navigate.Navigation.Instance.historyScreen.InsertHistory();

                Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();

                Navigate.Navigation.Instance.playlistScreen.HandlePlayButtonInfoPlaylist();

                Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.SetSongPlaying(songByPlaylistInside);

                return;
            }

            List__Song__Playlist songByPlaylistOutside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromPanel(sender);

            fpnlSongs.Tag = songByPlaylistOutside;

            songByPlaylistOutside.IsSelected = true;

            Info__Song__Panel infoSongOutside = new Info__Song__Panel(songByPlaylistOutside);

            Song__Playing__DAO.Instance.currInfoSongPanel = infoSongOutside;

            Navigate.Navigation.Instance.historyScreen.InsertHistory();

            Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();

            Navigate.Navigation.Instance.playlistScreen.HandlePlayButtonInfoPlaylist();

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.SetSongPlaying(songByPlaylistOutside);
        }
        private void songByPlaylist_MouseEnterAdd(object sender, EventArgs e)
        {
            if (pnlHovered.Tag != null)
            {
                List__Song__Playlist prevHover = (List__Song__Playlist)pnlHovered.Tag;

                prevHover.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                List__Song__Playlist songByPlaylistInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songByPlaylistInside.IsHovered = true;

                pnlHovered.Tag = songByPlaylistInside;

                return;
            }

            List__Song__Playlist songByPlaylistOutside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromPanel(sender);

            songByPlaylistOutside.IsHovered = true;
        }
        private void songByPlaylist_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                List__Song__Playlist songByPlaylistInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songByPlaylistInside.IsHovered = false;

                return;
            }

            List__Song__Playlist songByPlaylistOutside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromPanel(sender);

            songByPlaylistOutside.IsHovered = false;
        }

        private void songByPlaylist_MouseClickOption(object sender, MouseEventArgs e)
        {
            try
            {
                if (pnlOptioned.Tag != null)
                {
                    List__Song__Playlist prevSong = (List__Song__Playlist)pnlOptioned.Tag;

                    prevSong.IsOptioned = false;
                }

                List__Song__Playlist songByPlaylistInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songByPlaylistInside.IsOptioned = true;

                pnlOptioned.Tag = songByPlaylistInside;

                Context__Menu__DAO.Instance.ShowContextMenuInUserControl(this, "playlist");
                
                Dropdown__Playlist__DAO.Instance.songSelecting = songByPlaylistInside.Title;
            }

            catch { }
        }

        private void songByPlaylist_MouseClickFavorite(object sender, MouseEventArgs e)
        {
            // doing
            try
            {
                List__Song__Playlist songByPlaylist = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songByPlaylist.IsFavorite = (songByPlaylist.IsFavorite == false) ? true : false;

                SongFavoriteAllScreen(songByPlaylist);                
            }

            catch { }
        }

        private void LoadEventClick()
        {
            Context__Menu__DAO.Instance.GetAllControls(this);

            Dropdown__Playlist__DAO.Instance.GetAllControls(this);
        }

        #endregion

        #region Load Title
        //public void LoadTitle(int idPlaylist)
        //{
        //    PlaylistDTO titlePlaylist = PlaylistDAO.Instance.GetPlaylistByID(idPlaylist);

        //    pbPlaylist.Image = titlePlaylist.Image_Playlist;

        //    lblTitle.Text = titlePlaylist.Name_Playlist;

        //    lblNumberSong.Text = "Amos Ivor - " + titlePlaylist.Quantity + " songs";
        //}

        public void LoadTitle(Image imagePlaylist, string title)
        {
            pbPlaylist.Image = imagePlaylist;

            lblTitle.Text = title;
        }

        public void LoadNumberSong()
        {
            lblNumberSong.Text = $"Amos Ivor - {fpnlSongs.Controls.Count} songs";
        }

        public void LoadNumberSongInPlayist(Info__Playlist__Panel infoPlaylist)
        {
            infoPlaylist.Number_Song = fpnlSongs.Controls.Count + " songs";
        }

        #endregion

        #region Back Button

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigate.Navigation.Instance.mainScreen.LoadPlaylists();
        }

        #endregion

        #region Bottom Bar
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

        #region Play First Song 
        public void PlayFirstSong()
        {
            Song__Playing__DAO.Instance.PlayFirstSong(fpnlSongs);
        }

        #endregion

        #region Load Song Playing 

        void LoadSongPlayingAllScreen(List__Song__Playlist song)
        {
            fpnlSongs.Tag = song;

            song.IsSelected = true;

            Info__Song__Panel infoSong = new Info__Song__Panel(song);

            Song__Playing__DAO.Instance.currInfoSongPanel = infoSong;

            Navigate.Navigation.Instance.playlistScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.LoadSongPlayingBottomBar();

            Navigate.Navigation.Instance.childPlaylistScreen.LoadSongPlayingBottomBar();

            Navigate.Navigation.homeScreen.LoadSongPlaying();
        }

        #endregion

        #region Set Song Playing
        public void SetSongPlaying(List__Song__Playlist song)
        {
            if (fpnlSongs.Tag != null)
            {
                List__Song__Playlist prevSelected = (List__Song__Playlist)fpnlSongs.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            List__Song__Playlist songByPlaylist = fpnlSongs.Controls.OfType<List__Song__Playlist>().FirstOrDefault(c => c.ID == song.ID);

            songByPlaylist.IsSelected = true;

            fpnlSongs.Tag = songByPlaylist;
        }

        #endregion

        #region Delete Song

        public void DeleteSong(string nameSong)
        {
            Context__Menu__DAO.Instance.DeleteSong(fpnlSongs, nameSong);
        }

        #endregion

        #region Handle Favorite

        public void SongFavoriteInChildPlaylist(bool isFavorite)
        {
            List__Song__Playlist curr = fpnlSongs.Controls.OfType<List__Song__Playlist>().First(c => c.Title == FavoriteDAO.Instance.nameSong);

            curr.IsFavorite = isFavorite;
        }

        void SongFavoriteAllScreen(List__Song__Playlist curr)
        {
            FavoriteDAO.Instance.nameSong = curr.Title;

            Navigate.Navigation.homeScreen.SongFavoriteInHome(curr.IsFavorite);

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.SongFavoriteInChildPlaylist(curr.IsFavorite);

            Navigate.Navigation.Instance.historyScreen.SongFavoriteInHistory(curr.IsFavorite);
        }

        #endregion

    }
}
