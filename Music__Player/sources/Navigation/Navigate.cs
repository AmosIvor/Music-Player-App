using Music__Player.sources.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

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

        public Albums albumsScreen = new Albums();
        public Songs songsScreen = new Songs();
        public Recent recentScreen = new Recent();
        public Favorite favoriteScreen = new Favorite();
        public History historyScreen = new History();

        public Playlist playlistScreen = new Playlist();
        public Child__Playlist childPlaylistScreen = new Child__Playlist();
    }
}
