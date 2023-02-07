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
    public class Name__Playlist__Panel__DAO
    {
        private static Name__Playlist__Panel__DAO instance;

        public static Name__Playlist__Panel__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Name__Playlist__Panel__DAO();

                return instance;
            }

            private set { instance = value; }
        }

        private Name__Playlist__Panel__DAO() { }

        public List<Name__Playlist__Panel> GetListNamePlaylist()
        {
            List<Name__Playlist__Panel> listName = new List<Name__Playlist__Panel>();

            // Add Create new playlist
            Name__Playlist__Panel firstRow = new Name__Playlist__Panel("Create new playlist");

            firstRow.IsCreated = true;

            listName.Add(firstRow);

            string query = "Select * From PLAYLISTS";
            
            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Name__Playlist__Panel namePlaylist = new Name__Playlist__Panel(item);

                listName.Add(namePlaylist);
            }

            return listName;
        }

        public Name__Playlist__Panel GetNamePlaylistFromControlIntoPanel(object sender)
        {
            Control control = (Control)sender;

            Guna2Panel panel = (Guna2Panel)control.Parent;

            Name__Playlist__Panel namePlaylist = (Name__Playlist__Panel)panel.Parent;

            return namePlaylist;
        }

        public Name__Playlist__Panel GetNamePlaylistFromPanel(object sender)
        {
            Guna2Panel panel = (Guna2Panel)sender;

            Name__Playlist__Panel namePlaylist = (Name__Playlist__Panel)panel.Parent;

            return namePlaylist;
        }
    }
}
