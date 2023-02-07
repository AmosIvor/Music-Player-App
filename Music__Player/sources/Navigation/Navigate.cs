using Guna.UI2.WinForms;
using Music__Player.sources.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.Navigate
{
    public class Navigation
    {
        private static Navigation instance;
        public static Navigation Instance
        {
            get
            {
                if (instance == null)
                    instance = new Navigation();
                return instance;
            }
            private set { instance = value; }
        }

        private Navigation() { }

        public Main__Screen mainScreen = new Main__Screen();

        public static Home homeScreen = new Home();

        public Songs songsScreen = new Songs();

        public Albums albumsScreen = new Albums();

        public Recent recentScreen = new Recent();

        public Favorite favoriteScreen = new Favorite();

        public History historyScreen = new History();

        public Playlist playlistScreen = new Playlist();

        public Child__Playlist childPlaylistScreen = new Child__Playlist();

        public Child__Playlist childPlaylistScreenPlayingSong = new Child__Playlist();

        public void ShowCurrentScreen(Panel panel, UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;

            userControl.Visible = true;

            panel.Controls.Add(userControl);

            panel.Tag = userControl;
        }

        public void ChangeVerticalLine(Control Vline, Control button)
        {
            int LocationX = Vline.Location.X;

            int LocationY = button.Location.Y;

            Vline.Location = new Point(LocationX, LocationY);
        }

        public void NavigateScreen(Guna2GradientPanel pnlMainScreen,Control buttonNavigation, UserControl currScreen, Control verticalLine)
        {
            ChangeVerticalLine(verticalLine, buttonNavigation);

            UserControl prevScreen = (UserControl)pnlMainScreen.Tag;

            prevScreen.Visible = false;

            ShowCurrentScreen(pnlMainScreen, currScreen);
        }
    }
}
