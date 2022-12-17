using Guna.UI2.WinForms;
using Music__Player.sources.Custom;
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
        //Songs songsScreen = new Songs();
        //Albums albumsScreen = new Albums();

        //Recent recentScreen = new Recent();
        //Favorite favoriteScreen = new Favorite();
        //History historyScreen = new History();

        //Playlist playlistScreen = new Playlist();
        //Child__Playlist childPlaylistScreen = new Child__Playlist();
        FlowLayoutPanel fpnlHoverPlaylist = new FlowLayoutPanel();
        public Main__Screen()
        {
            InitializeComponent();

            LoadMainScreen();
        }

        #region Handle EXIT

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion


        void LoadMainScreen()
        {
            btnHome.Checked = true;

            panelMainScreen.Tag = homeScreen;

            LoadMenuBarPlaylists();

        }

        void LoadMenuBarPlaylists()
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

        void showPanel(Panel panel, UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControl.Visible = true;
            panel.Controls.Add(userControl);
            panel.Tag = userControl;
        }

        private void changeVerticalLine(Control Vline, Control button)
        {
            int LocationX = Vline.Location.X;
            int LocationY = button.Location.Y;
            Vline.Location = new Point(LocationX, LocationY);
        }

        #region HOME

        private void btnHome_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnHome);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            showPanel(panelMainScreen, homeScreen);
        }
        private void btnSongs_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnSongs);
            Console.WriteLine(panelMainScreen.Tag.ToString());
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            //showPanel(panelMainScreen, songsScreen);
            showPanel(panelMainScreen, Navigation.Instance.songsScreen);
        }
        private void btnAlbums_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnAlbums);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            //showPanel(panelMainScreen, recentScreen);
            showPanel(panelMainScreen, Navigation.Instance.recentScreen);
        }

        #endregion

        #region LIBRARY

        private void btnRecent_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnRecent);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            //showPanel(panelMainScreen, recentScreen);
            showPanel(panelMainScreen, Navigation.Instance.recentScreen);
        }
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnFavorite);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            //showPanel(panelMainScreen, favoriteScreen);
            showPanel(panelMainScreen, Navigation.Instance.favoriteScreen);
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnHistory);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            //showPanel(panelMainScreen, historyScreen);
            showPanel(panelMainScreen, Navigation.Instance.historyScreen);
        }

        #endregion

        #region PLAYLIST

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnPlaylist);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            //showPanel(panelMainScreen, playlistScreen);
            showPanel(panelMainScreen, Navigation.Instance.playlistScreen);
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnCreatePlaylist);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            //showPanel(panelMainScreen, childPlaylistScreen);
            showPanel(panelMainScreen, Navigation.Instance.childPlaylistScreen);
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
