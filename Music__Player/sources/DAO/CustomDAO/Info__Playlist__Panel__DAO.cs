using Guna.UI2.WinForms;
using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO.CustomDAO
{
    public class Info__Playlist__Panel__DAO
    {
        private static Info__Playlist__Panel__DAO instance;
        public static Info__Playlist__Panel__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Info__Playlist__Panel__DAO();
                return instance;
            }

            private set { instance = value; }
        }

        private Info__Playlist__Panel__DAO() { }

        public List<Info__Playlist__Panel> GetListInfoPlaylistPanel()
        {
            List<Info__Playlist__Panel> listInfoPlaylist = new List<Info__Playlist__Panel>();

            string query = "Select * from PLAYLISTS";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Info__Playlist__Panel infoPlaylist = new Info__Playlist__Panel(item);

                listInfoPlaylist.Add(infoPlaylist);
            }

            return listInfoPlaylist;
        }

        public Info__Playlist__Panel GetInfoPlaylistPanelFromControlIntoPanel(object sender)
        {
            Control control = sender as Control;

            Guna2ShadowPanel panel = (Guna2ShadowPanel)control.Parent;

            Info__Playlist__Panel parent = (Info__Playlist__Panel)panel.Parent;

            return parent;
        }
        public Info__Playlist__Panel GetInfoPlaylistPanelFromPanel(object sender)
        {
            Guna2ShadowPanel panel = (Guna2ShadowPanel)sender;

            Info__Playlist__Panel parent = (Info__Playlist__Panel)panel.Parent;

            return parent;
        }

    }
}
