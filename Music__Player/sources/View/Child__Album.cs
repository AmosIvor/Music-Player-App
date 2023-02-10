using Guna.UI2.WinForms;
using Music__Player.sources.DAO.AlbumDAO;
using Music__Player.sources.DAO.CustomDAO;
using Music__Player.sources.DAO.HomeDAO;
using Music__Player.sources.DTO.ChildAlbumDTO;
using Music__Player.sources.PlayMusic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.Custom
{
    public partial class Child__Album : UserControl
    {
        Panel pnlHovered = new Panel();

        Panel pnlOptioned = new Panel();

        public Child__Album()
        {
            InitializeComponent();

            LoadInitialSongBottomBar();
        }

        public void LoadChildAlbum(string idGenre)
        {
            LoadListSongByIdGenre(idGenre);

            LoadEventClick();
        }

        private void LoadEventClick()
        {
            Dropdown__Playlist__DAO.Instance.GetAllControls(this);
        }

        #region Load Title

        public void LoadTitle(Image imageAlbum, string title)
        {
            pbAlbum.Image = imageAlbum;

            lblTitle.Text = title;
        }

        #endregion

        #region Load Song by Playlist
        public void LoadListSongByIdGenre(string idGenre)
        {
            fpnlSongs.Controls.Clear();

            List<List__Song__Playlist> listSong;

            if (AlbumDAO.Instance.isArtist == false)
            {
                listSong = List__Song__Playlist__DAO.Instance.GetListSongByIdGenre(idGenre);
            }
            else
            {
                listSong = List__Song__Playlist__DAO.Instance.GetListSongByArtist(idGenre);
            }


            int id = 1;

            foreach (List__Song__Playlist songAlbum in listSong)
            {
                songAlbum.ID = List__Song__Playlist__DAO.Instance.ConvertID(id++);

                songAlbum.MouseDoubleClickAdd += songAlbum_MouseDoubleClickAdd;

                songAlbum.MouseEnterAdd += songAlbum_MouseEnterAdd;

                songAlbum.MouseLeaveAdd += songAlbum_MouseLeaveAdd;

                songAlbum.MouseClickPlay += songAlbum_MouseClickPlay;

                songAlbum.MouseClickOption += songAlbum_MouseClickOption;

                songAlbum.MouseClickFavorite += songAlbum_MouseClickFavorite;

                fpnlSongs.Controls.Add(songAlbum);
            }
        }

        private void songAlbum_MouseClickPlay(object sender, MouseEventArgs e)
        {
            List__Song__Playlist curr = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);
            
            Info__Song__Panel infoSong = new Info__Song__Panel(curr);

            if (Song__Playing__DAO.Instance.currInfoSongPanel != null && infoSong.Title == Song__Playing__DAO.Instance.currInfoSongPanel.Title)
            {
                Media__Player.Instance.btnPlay_HomeClick((Guna2ImageButton)sender);

                Media__Player.Instance.NavigateAllScreen();

                return;
            }

            if (fpnlSongs.Tag != null)
            {
                List__Song__Playlist prev = (List__Song__Playlist)fpnlSongs.Tag;

                prev.IsSelected = false;

                prev.IsHovered = false;
            }

            fpnlSongs.Tag = curr;

            curr.IsSelected = true;

            Song__Playing__DAO.Instance.currInfoSongPanel = infoSong;

            Navigate.Navigation.Instance.historyScreen.InsertHistory();

            Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();
        }
        private void songAlbum_MouseDoubleClickAdd(object sender, MouseEventArgs e)
        {
            if (fpnlSongs.Tag != null)
            {
                List__Song__Playlist prevSelected = (List__Song__Playlist)fpnlSongs.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                List__Song__Playlist songAlbumInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                fpnlSongs.Tag = songAlbumInside;

                songAlbumInside.IsSelected = true;

                Info__Song__Panel infoSong = new Info__Song__Panel(songAlbumInside);

                Song__Playing__DAO.Instance.currInfoSongPanel = infoSong;

                Navigate.Navigation.Instance.historyScreen.InsertHistory();

                Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();

                return;
            }

            List__Song__Playlist songAlbumOutside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromPanel(sender);

            fpnlSongs.Tag = songAlbumOutside;

            songAlbumOutside.IsSelected = true;

            Info__Song__Panel infoSongOutside = new Info__Song__Panel(songAlbumOutside);

            Song__Playing__DAO.Instance.currInfoSongPanel = infoSongOutside;

            Navigate.Navigation.Instance.historyScreen.InsertHistory();

            Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();
        }
        private void songAlbum_MouseEnterAdd(object sender, EventArgs e)
        {
            if (pnlHovered.Tag != null)
            {
                List__Song__Playlist prevHover = (List__Song__Playlist)pnlHovered.Tag;

                prevHover.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                List__Song__Playlist songAlbumInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songAlbumInside.IsHovered = true;

                pnlHovered.Tag = songAlbumInside;

                return;
            }

            List__Song__Playlist songAlbumOutside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromPanel(sender);

            songAlbumOutside.IsHovered = true;
        }
        private void songAlbum_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                List__Song__Playlist songAlbumInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songAlbumInside.IsHovered = false;

                return;
            }

            List__Song__Playlist songAlbumOutside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromPanel(sender);

            songAlbumOutside.IsHovered = false;
        }

        private void songAlbum_MouseClickOption(object sender, MouseEventArgs e)
        {
            try
            {
                if (pnlOptioned.Tag != null)
                {
                    List__Song__Playlist prevSong = (List__Song__Playlist)pnlOptioned.Tag;

                    prevSong.IsOptioned = false;
                }

                List__Song__Playlist songAlbumInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songAlbumInside.IsOptioned = true;

                pnlOptioned.Tag = songAlbumInside;

                Dropdown__Playlist__DAO.Instance.AddPlaylistEventInUserControl(this);

                Dropdown__Playlist__DAO.Instance.songSelecting = songAlbumInside.Title;
            }

            catch { }
        }

        private void songAlbum_MouseClickFavorite(object sender, MouseEventArgs e)
        {
            // doing
            try
            {
                List__Song__Playlist songAlbum = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songAlbum.IsFavorite = (songAlbum.IsFavorite == false) ? true : false;

                //SongFavoriteAllScreen(songAlbum);
            }

            catch { }
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

        #region Back Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigate.Navigation.Instance.mainScreen.LoadAlbum();
        }

        #endregion


    }
}
