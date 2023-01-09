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
using Music__Player.sources.DAO.HomeDAO;
using Music__Player.sources.DAO.PlaylistDAO;
using Music__Player.sources.DTO.ChildPlaylistDTO;

namespace Music__Player.sources.View
{
    public partial class Child__Playlist : UserControl
    {
        Panel pnlHovered = new Panel();
        public Child__Playlist()
        {
            InitializeComponent();

            FormatDataGridView();

            LoadInitialSongBottomBar();
        }

        public void LoadChildPlaylist(int idPlaylist)
        {
            LoadTitle(idPlaylist);

            LoadListSongByIdPlaylist(idPlaylist);
        }

        void FormatDataGridView()
        {
            dtgvSongs.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvSongs.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvSongs.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dtgvSongs.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

                fpnlSongs.Controls.Add(songByPlaylist);
            }
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

        #endregion

        #region Load Title

        public void LoadTitle(int idPlaylist)
        {
            PlaylistDTO titlePlaylist = PlaylistDAO.Instance.GetPlaylistByID(idPlaylist);

            pbPlaylist.Image = titlePlaylist.Image_Playlist;

            lblTitle.Text = titlePlaylist.Name_Playlist;

            lblNumberSong.Text = "Amos Ivor - " + titlePlaylist.Quantity + " songs";
        }

        #endregion

        #region Back Button

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigate.Navigation.Instance.mainScreen.LoadPlaylists();
        }

        #endregion

        #region Song Playing Bottom Bar
        public void LoadSongPlayingBottomBar()
        {
            songPlayingBottomBar.LoadSongPlayingByInfoSongPanel();
        }

        public void LoadInitialSongBottomBar()
        {
            songPlayingBottomBar.LoadInitialSong();
        }
        #endregion

        #region Play First Song 
        public void PlayFirstSong()
        {
            if (fpnlSongs.Controls.Count == 0)
            {
                return;
            }
            List__Song__Playlist firstSong = fpnlSongs.Controls.OfType<List__Song__Playlist>().FirstOrDefault(c => c.ID == "01");

            fpnlSongs.Tag = firstSong;

            firstSong.IsSelected = true;

            Info__Song__Panel infoSongOutside = new Info__Song__Panel(firstSong);

            Song__Playing__DAO.Instance.currInfoSongPanel = infoSongOutside;

            Song__Playing__DAO.Instance.LoadSongPlayingAllScreen();
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
    }
}
