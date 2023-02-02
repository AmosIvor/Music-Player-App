using Music__Player.sources.DAO.CustomDAO;
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
        public Favorite()
        {
            InitializeComponent();

            LoadFavorite();
        }

        void LoadFavorite()
        {
            LoadEventClick();
        }

        void LoadEventClick()
        {
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
    }
}
