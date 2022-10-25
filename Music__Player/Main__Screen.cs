using Music__Player.sources.Custom;
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
        Songs songsScreen = new Songs();
        Albums albumsScreen = new Albums();

        Recent recentScreen = new Recent();
        Favorite favoriteScreen = new Favorite();
        History historyScreen = new History();

        Playlist playlistScreen = new Playlist();
        Child__Playlist childPlaylistScreen = new Child__Playlist();
        
        public Main__Screen()
        {
            InitializeComponent();
            initMainScreen();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void initMainScreen()
        {
            btnHome.Checked = true;
            panelMainScreen.Tag = homeScreen;
        }
        private void showPanel(Panel panel, UserControl userControl)
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

            showPanel(panelMainScreen, songsScreen);
        }
        private void btnAlbums_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnAlbums);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            showPanel(panelMainScreen, recentScreen);
        }

        #endregion

        #region LIBRARY

        private void btnRecent_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnRecent);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            showPanel(panelMainScreen, recentScreen);
        }
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnFavorite);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            showPanel(panelMainScreen, favoriteScreen);
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnHistory);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            showPanel(panelMainScreen, historyScreen);
        }

        #endregion

        #region PLAYLIST

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnPlaylist);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            showPanel(panelMainScreen, playlistScreen);
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            changeVerticalLine(VerticalLine, btnCreatePlaylist);
            UserControl currentScreen = (UserControl)panelMainScreen.Tag;
            currentScreen.Visible = false;

            showPanel(panelMainScreen, childPlaylistScreen);
        }

        #endregion
    }
}
