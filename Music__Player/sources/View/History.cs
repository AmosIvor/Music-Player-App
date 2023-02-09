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
using Music__Player.sources.Custom;
using Music__Player.sources.DAO.CustomDAO;
using Music__Player.sources.DAO.FavoriteDAO;
using Music__Player.sources.DAO.HomeDAO;

namespace Music__Player.sources.View
{
    public partial class History : UserControl
    {
        Panel pnlHovered = new Panel();

        public History()
        {
            InitializeComponent();

            LoadHistory();

            LoadInitialSongBottomBar();

            LoadEventClick();
        }

        public void InsertHistory()
        {
            Song__History__DAO.Instance.InsertSongHistory(Song__Playing__DAO.Instance.currInfoSongPanel.Title);

            Navigate.Navigation.Instance.historyScreen.LoadHistory();
        }

        #region Load History

        public void LoadHistory()
        {
            fpnlSongs.Controls.Clear();

            List<Song__History> listSong = Song__History__DAO.Instance.GetListSongHistory();

            foreach (Song__History songHistory in listSong)
            {
                songHistory.MouseDoubleClickAdd += songHistory_MouseDoubleClickAdd;

                songHistory.MouseEnterAdd += songHistory_MouseEnterAdd;

                songHistory.MouseLeaveAdd += songHistory_MouseLeaveAdd;

                songHistory.MouseClickPlay += songHistory_MouseClickPlay;

                songHistory.MouseClickAddPlaylist += songHistory_MouseClickAddPlaylist;

                songHistory.MouseClickFavorite += songHistory_MouseClickFavorite;

                fpnlSongs.Controls.Add(songHistory);
            }

            LoadDateTime();
        }
        private void songHistory_MouseClickPlay(object sender, MouseEventArgs e)
        {
            if (fpnlSongs.Tag != null)
            {
                Song__History prev = (Song__History)fpnlSongs.Tag;

                prev.IsSelected = false;

                prev.IsHovered = false;
            }

            Song__History curr = Song__History__DAO.Instance.GetSongHistoryFromControlIntoPanel(sender);

            fpnlSongs.Tag = curr;

            curr.IsSelected = true;

            Info__Song__Panel infoSong = new Info__Song__Panel(curr);

            Song__Playing__DAO.Instance.currInfoSongPanel = infoSong;

            Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();

        }
        private void songHistory_MouseDoubleClickAdd(object sender, MouseEventArgs e)
        {
            if (fpnlSongs.Tag != null)
            {
                Song__History prevSelected = (Song__History)fpnlSongs.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Song__History songByPlaylistInside = Song__History__DAO.Instance.GetSongHistoryFromControlIntoPanel(sender);

                fpnlSongs.Tag = songByPlaylistInside;

                songByPlaylistInside.IsSelected = true;

                Info__Song__Panel infoSong = new Info__Song__Panel(songByPlaylistInside);

                Song__Playing__DAO.Instance.currInfoSongPanel = infoSong;

                Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();

                return;
            }

            Song__History songByPlaylistOutside = Song__History__DAO.Instance.GetSongHistoryFromPanel(sender);

            fpnlSongs.Tag = songByPlaylistOutside;

            songByPlaylistOutside.IsSelected = true;

            Info__Song__Panel infoSongOutside = new Info__Song__Panel(songByPlaylistOutside);

            Song__Playing__DAO.Instance.currInfoSongPanel = infoSongOutside;

            Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();
        }
        private void songHistory_MouseEnterAdd(object sender, EventArgs e)
        {
            if (pnlHovered.Tag != null)
            {
                Song__History prevHover = (Song__History)pnlHovered.Tag;

                prevHover.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Song__History songByPlaylistInside = Song__History__DAO.Instance.GetSongHistoryFromControlIntoPanel(sender);

                songByPlaylistInside.IsHovered = true;

                pnlHovered.Tag = songByPlaylistInside;

                return;
            }

            Song__History songByPlaylistOutside = Song__History__DAO.Instance.GetSongHistoryFromPanel(sender);

            songByPlaylistOutside.IsHovered = true;
        }
        private void songHistory_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Song__History songByPlaylistInside = Song__History__DAO.Instance.GetSongHistoryFromControlIntoPanel(sender);

                songByPlaylistInside.IsHovered = false;

                return;
            }

            Song__History songByPlaylistOutside = Song__History__DAO.Instance.GetSongHistoryFromPanel(sender);

            songByPlaylistOutside.IsHovered = false;
        }

        private void songHistory_MouseClickAddPlaylist(object sender, MouseEventArgs e)
        {
            try
            {
                Dropdown__Playlist__DAO.Instance.AddPlaylistEventInUserControl(this);

                Song__History songByPlaylistInside = Song__History__DAO.Instance.GetSongHistoryFromControlIntoPanel(sender);

                Dropdown__Playlist__DAO.Instance.songSelecting = songByPlaylistInside.Title;
            }

            catch { }
        }

        private void songHistory_MouseClickFavorite(object sender, MouseEventArgs e)
        {
            try
            {
                Song__History curr = Song__History__DAO.Instance.GetSongHistoryFromControlIntoPanel(sender);

                curr.IsFavorite = curr.IsFavorite == false ? true : false;

                SongFavoriteAllScreen(curr);
            }

            catch { }
        }

        void LoadEventClick()
        {
            Dropdown__Playlist__DAO.Instance.GetAllControls(this);
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

        private void LoadInitialSongBottomBar()
        {
            songPlayingBottomBar.LoadInitialSong();

            LoadEventBottomBar();
        }

        public void HandleButtonPlay(bool isPlay)
        {
            songPlayingBottomBar.IsPlay = isPlay;
        }

        #endregion

        #region Handle Favorite

        public void SongFavoriteInHistory(bool isFavorite)
        {
            Song__History curr = fpnlSongs.Controls.OfType<Song__History>().FirstOrDefault(c => c.Title == FavoriteDAO.Instance.nameSong);

            curr.IsFavorite = isFavorite;
        }

        void SongFavoriteAllScreen(Song__History curr)
        {
            FavoriteDAO.Instance.nameSong = curr.Title;

            Navigate.Navigation.homeScreen.SongFavoriteInHome(curr.IsFavorite);

            Navigate.Navigation.Instance.childPlaylistScreen.SongFavoriteInChildPlaylist(curr.IsFavorite);

            Navigate.Navigation.Instance.childPlaylistScreenPlayingSong.SongFavoriteInChildPlaylist(curr.IsFavorite);
        }

        #endregion

        #region Date Time
        
        void LoadDateTime()
        {
            DateTime today = DateTime.Now;

            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);

            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadListByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        void LoadListByDate(DateTime fromDate, DateTime toDate)
        {
            fpnlSongs.Controls.Clear();

            List<Song__History> listSong = Song__History__DAO.Instance.GetListSongByDate(fromDate, toDate);

            foreach (Song__History songHistory in listSong)
            {
                songHistory.MouseDoubleClickAdd += songHistory_MouseDoubleClickAdd;

                songHistory.MouseEnterAdd += songHistory_MouseEnterAdd;

                songHistory.MouseLeaveAdd += songHistory_MouseLeaveAdd;

                songHistory.MouseClickPlay += songHistory_MouseClickPlay;

                songHistory.MouseClickAddPlaylist += songHistory_MouseClickAddPlaylist;

                songHistory.MouseClickFavorite += songHistory_MouseClickFavorite;

                fpnlSongs.Controls.Add(songHistory);
            }
        }

        #endregion
    }
}
