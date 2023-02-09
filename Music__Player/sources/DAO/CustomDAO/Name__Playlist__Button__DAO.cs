using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO.MainScreenDAO
{
    public class Name__Playlist__Button__DAO
    {
        private static Name__Playlist__Button__DAO instance;
        public static Name__Playlist__Button__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Name__Playlist__Button__DAO();

                return instance;
            }
        }
        private Name__Playlist__Button__DAO() { }

        public List<Name__Playlist__Button> GetListNamePlaylist()
        {
            List<Name__Playlist__Button> listNamePlaylist = new List<Name__Playlist__Button>();

            string query = "Select ID_PLAYLIST, NAME_PLAYLIST From PLAYLISTS";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Name__Playlist__Button namePlaylist = new Name__Playlist__Button(item);

                listNamePlaylist.Add(namePlaylist);
            }

            return listNamePlaylist;
        }

        public Name__Playlist__Button GetNamePlaylistButtonFromControl(object sender)
        {
            Control control = (Control)sender;

            return (Name__Playlist__Button)control.Parent;
        }
    }
}
