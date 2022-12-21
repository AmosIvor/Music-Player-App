using Music__Player.sources.Custom;
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
    public partial class Playlist : UserControl
    {
        Playlist__Add__Panel panelAddPlaylist = new Playlist__Add__Panel();

        //private static Playlist instance;
        //public static Playlist Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new Playlist();

        //        return instance;
        //    }

        //    private set { instance = value; }
        //}
        public Playlist()
        {
            InitializeComponent();

            LoadPlaylists();

            
        }

        void LoadPlaylists()
        {
            fpnlPlaylists.Controls.Clear();

            List<Info__Playlist__Panel> listInfoPlaylist = Info__Playlist__Panel__DAO.Instance.GetListInfoPlaylistPanel();

            foreach (Info__Playlist__Panel infoPlaylist in listInfoPlaylist)
            {
                fpnlPlaylists.Controls.Add(infoPlaylist);
            }

            fpnlPlaylists.Controls.Add(panelAddPlaylist);

            lblTitle.Text = $"Amos Ivor - {fpnlPlaylists.Controls.Count - 1} playlists";
        }

        public void LoadSongPlayingBottomBar()
        {
            songPlayingBottomBar.LoadSongPlaying();
        }

        
    }
}
