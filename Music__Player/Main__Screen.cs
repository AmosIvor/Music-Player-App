using Guna.UI2.WinForms;
using Music__Player.sources.Custom;
using Music__Player.sources.DAO.CustomDAO;
using Music__Player.sources.DAO.MainScreenDAO;
using Music__Player.sources.Navigate;
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

namespace Music__Player
{
    public partial class Main__Screen : Form
    {
        #region Inital

        FlowLayoutPanel fpnlHoverPlaylist = new FlowLayoutPanel();

        #endregion

        public Main__Screen()
        {
            InitializeComponent();

            LoadMainScreen();
        }

        public Main__Screen(string name)
        {
            InitializeComponent();

            LoadMainScreen();

            UserName = name;
        }

        private string userName;
        public string UserName
        {
            get { return userName; } 
            set
            {
                userName = value;
                btnUser.Text = userName;
            } 
        }
        void LoadMainScreen()
        {
            btnHome.Checked = true;

            panelMainScreen.Controls.Add(Navigation.homeScreen);

            panelMainScreen.Tag = Navigation.homeScreen;

            LoadMenuBarPlaylists();
        }

        #region Handle EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region MenuBar
        public void LoadMenuBarPlaylists()
        {
            fpnlPlaylists.Controls.Clear();

            List<Name__Playlist__Button> listNamePlaylist = Name__Playlist__Button__DAO.Instance.GetListNamePlaylist();

            foreach (Name__Playlist__Button namePlaylist in listNamePlaylist)
            {
                namePlaylist.MouseClickAdd += namePlaylist_MouseClickAdd;

                namePlaylist.MouseEnterAdd += namePlaylist_MouseEnterAdd;

                namePlaylist.MouseLeaveAdd += namePlaylist_MouseLeaveAdd;

                fpnlPlaylists.Controls.Add(namePlaylist);
            }
        }

        private void namePlaylist_MouseClickAdd(object sender, MouseEventArgs e)
        {
            if (fpnlPlaylists.Tag != null)
            {
                Name__Playlist__Button prev = (Name__Playlist__Button)fpnlPlaylists.Tag;

                prev.IsSelected = false;
            }

            if (sender is Label || sender is Guna2ImageButton)
            {
                Name__Playlist__Button namePlaylistInside = Name__Playlist__Button__DAO.Instance.GetNamePlaylistButtonFromControl(sender);

                namePlaylistInside.IsSelected = true;

                fpnlPlaylists.Tag = namePlaylistInside;

                return;
            }

            Name__Playlist__Button namePlaylistOutside = (Name__Playlist__Button)sender;

            namePlaylistOutside.IsSelected = true;

            fpnlPlaylists.Tag = namePlaylistOutside;
        }
        private void namePlaylist_MouseEnterAdd(object sender, EventArgs e)
        {
            if (fpnlHoverPlaylist.Tag != null)
            {
                Name__Playlist__Button prev = (Name__Playlist__Button)fpnlHoverPlaylist.Tag;

                prev.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton)
            {
                Name__Playlist__Button namePlaylistInside = Name__Playlist__Button__DAO.Instance.GetNamePlaylistButtonFromControl(sender);

                namePlaylistInside.IsHovered = true;

                fpnlHoverPlaylist.Tag = namePlaylistInside;

                return;
            }
            Name__Playlist__Button namePlaylistOutside = (Name__Playlist__Button)sender;

            namePlaylistOutside.IsHovered = true;

            fpnlHoverPlaylist.Tag = namePlaylistOutside;
        }
        private void namePlaylist_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton)
            {
                Name__Playlist__Button namePlaylistInside = Name__Playlist__Button__DAO.Instance.GetNamePlaylistButtonFromControl(sender);

                namePlaylistInside.IsHovered = false;

                return;
            }
            Name__Playlist__Button namePlaylistOutside = (Name__Playlist__Button)sender;

            namePlaylistOutside.IsHovered = true;
        }

        #endregion 

        #region HOME
        private void btnHome_Click(object sender, EventArgs e)
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnHome, Navigation.homeScreen, VerticalLine);
        }
        private void btnSongs_Click(object sender, EventArgs e)
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnSongs, Navigation.Instance.songsScreen, VerticalLine);
        }
        private void btnAlbums_Click(object sender, EventArgs e)
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnAlbums, Navigation.Instance.albumsScreen, VerticalLine);
        }

        #endregion

        #region LIBRARY
        private void btnRecent_Click(object sender, EventArgs e)
        {
            //Navigation.Instance.NavigateScreen(panelMainScreen, btnRecent, Navigation.Instance.recentScreen, VerticalLine);
        }
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnFavorite, Navigation.Instance.favoriteScreen, VerticalLine);
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnHistory, Navigation.Instance.historyScreen, VerticalLine);
        }

        #endregion

        #region PLAYLIST

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnPlaylist, Navigation.Instance.playlistScreen, VerticalLine);

            btnPlaylist.Checked = true;
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            Popup__Create__Playlist__DAO.Instance.ShowPopup();

            btnCreatePlaylist.Checked = false;
        }

        public void LoadChildPlaylist()
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnPlaylist, Navigation.Instance.childPlaylistScreen, VerticalLine);
        }

        public void LoadChildPlaylistPlayingSong()
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnPlaylist, Navigation.Instance.childPlaylistScreenPlayingSong, VerticalLine);
        }

        public void LoadPlaylists()
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnPlaylist, Navigation.Instance.playlistScreen, VerticalLine);

            btnPlaylist.Checked = true;
        }

        public void LoadChildAlbum()
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnPlaylist, Navigation.Instance.childAlbumScreen, VerticalLine);
        }

        public void LoadAlbum()
        {
            Navigation.Instance.NavigateScreen(panelMainScreen, btnAlbums, Navigation.Instance.albumsScreen, VerticalLine);

            btnAlbums.Checked = true;
        }

        #endregion

        #region Exit
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        #endregion

        public void LoadUser(string name)
        {
            btnUser.Text = name;
        }
    }
}
