using Guna.UI2.WinForms;
using Music__Player.sources.Custom;
using Music__Player.sources.DAO.CustomDAO;
using Music__Player.sources.DAO.FavoriteDAO;
using Music__Player.sources.DAO.HomeDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.View
{
    public partial class Favorite : UserControl
    {
        Panel pnlHovered = new Panel();

        Panel pnlOptioned = new Panel();

        public Favorite()
        {
            InitializeComponent();

            LoadFavorite();

            LoadInitialSongBottomBar();

            LoadEventClick();
        }

        void LoadFavorite()
        {
            List<List__Song__Playlist> listSong = FavoriteDAO.Instance.GetListSongFavorite();

            int id = 1;

            foreach (List__Song__Playlist songFavorite in listSong)
            {
                songFavorite.ID = List__Song__Playlist__DAO.Instance.ConvertID(id++);

                songFavorite.MouseDoubleClickAdd += songFavorite_MouseDoubleClickAdd;

                songFavorite.MouseEnterAdd += songFavorite_MouseEnterAdd;

                songFavorite.MouseLeaveAdd += songFavorite_MouseLeaveAdd;

                songFavorite.MouseClickPlay += songFavorite_MouseClickPlay;

                songFavorite.MouseClickOption += songFavorite_MouseClickOption;

                songFavorite.MouseClickFavorite += songFavorite_MouseClickFavorite;

                fpnlSongs.Controls.Add(songFavorite);
            }
        }

        private void songFavorite_MouseClickPlay(object sender, MouseEventArgs e)
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

            btnPlayTop.Checked = true;

            Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();
        }
        private void songFavorite_MouseDoubleClickAdd(object sender, MouseEventArgs e)
        {
            if (fpnlSongs.Tag != null)
            {
                List__Song__Playlist prevSelected = (List__Song__Playlist)fpnlSongs.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                List__Song__Playlist songFavoriteInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                fpnlSongs.Tag = songFavoriteInside;

                songFavoriteInside.IsSelected = true;

                Info__Song__Panel infoSong = new Info__Song__Panel(songFavoriteInside);

                Song__Playing__DAO.Instance.currInfoSongPanel = infoSong;

                Navigate.Navigation.Instance.historyScreen.InsertHistory();

                Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();

                return;
            }

            List__Song__Playlist songFavoriteOutside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromPanel(sender);

            fpnlSongs.Tag = songFavoriteOutside;

            songFavoriteOutside.IsSelected = true;

            Info__Song__Panel infoSongOutside = new Info__Song__Panel(songFavoriteOutside);

            Song__Playing__DAO.Instance.currInfoSongPanel = infoSongOutside;

            Navigate.Navigation.Instance.historyScreen.InsertHistory();

            Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();
        }
        private void songFavorite_MouseEnterAdd(object sender, EventArgs e)
        {
            if (pnlHovered.Tag != null)
            {
                List__Song__Playlist prevHover = (List__Song__Playlist)pnlHovered.Tag;

                prevHover.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                List__Song__Playlist songFavoriteInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songFavoriteInside.IsHovered = true;

                pnlHovered.Tag = songFavoriteInside;

                return;
            }

            List__Song__Playlist songFavoriteOutside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromPanel(sender);

            songFavoriteOutside.IsHovered = true;
        }
        private void songFavorite_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                List__Song__Playlist songFavoriteInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songFavoriteInside.IsHovered = false;

                return;
            }

            List__Song__Playlist songFavoriteOutside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromPanel(sender);

            songFavoriteOutside.IsHovered = false;
        }

        private void songFavorite_MouseClickOption(object sender, MouseEventArgs e)
        {
            try
            {
                if (pnlOptioned.Tag != null)
                {
                    List__Song__Playlist prevSong = (List__Song__Playlist)pnlOptioned.Tag;

                    prevSong.IsOptioned = false;
                }

                List__Song__Playlist songFavoriteInside = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songFavoriteInside.IsOptioned = true;

                pnlOptioned.Tag = songFavoriteInside;

                Context__Menu__DAO.Instance.ShowContextMenuInUserControl(this, "favorite");

                Dropdown__Playlist__DAO.Instance.songSelecting = songFavoriteInside.Title;
            }

            catch { }
        }

        private void songFavorite_MouseClickFavorite(object sender, MouseEventArgs e)
        {
            // doing
            try
            {
                List__Song__Playlist songFavorite = List__Song__Playlist__DAO.Instance.GetListSongPlaylistFromControlIntoPanel(sender);

                songFavorite.IsFavorite = (songFavorite.IsFavorite == false) ? true : false;

                if (songFavorite.IsFavorite == false)
                {
                    Dropdown__Playlist__DAO.Instance.songSelecting = songFavorite.Title;

                    Context__Menu__DAO.Instance.DeleteSongFavorite();
                }
            }

            catch { }
        }

        private void LoadEventClick()
        {
            Context__Menu__DAO.Instance.GetAllControls(this);

            Dropdown__Playlist__DAO.Instance.GetAllControls(this);
        }

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

        private void LoadInitialSongBottomBar()
        {
            songPlayingBottomBar.LoadInitialSong();

            LoadEventBottomBar();
        }
        #endregion

        #region Handle Favorite

        #endregion

        #region Delete Song

        public void DeleteSong(string nameSong)
        {
            Context__Menu__DAO.Instance.DeleteSong(fpnlSongs, nameSong);
        }

        #endregion

        #region Button Play Top

        private void btnPlayTop_Click(object sender, EventArgs e)
        {
            btnPlayTop.Checked = !btnPlayTop.Checked;

            Song__Playing__DAO.Instance.PlayFirstSong(fpnlSongs);
        }

        

        #endregion

        #region Pause Song

        

        public void PauseSong()
        {
            if (btnPlayTop.Checked == true)
            {
                btnPlayTop.Checked = false;
            }

            if (fpnlSongs.Tag == null)
            {
                return;
            }
        }

        #endregion
    }
}
