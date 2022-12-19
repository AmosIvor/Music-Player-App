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
    public class Popup__Create__Playlist__DAO
    {
        private static Popup__Create__Playlist__DAO instance;
        public static Popup__Create__Playlist__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Popup__Create__Playlist__DAO();

                return instance;
            }
            private set { instance = value; }
        }

        private Popup__Create__Playlist__DAO() { }

        public void ShowPopup()
        {
            using (Popup__Create__Playlist popupCreatePlaylist = new Popup__Create__Playlist())
            {
                Form__Background__DAO.Instance.InitialForm();

                popupCreatePlaylist.Owner = Form__Background__DAO.formBackground;

                popupCreatePlaylist.ShowDialog();

                Form__Background__DAO.formBackground.Dispose();
            }
        }

        public int IsExist(string name)
        {
            string query = "Select NAME_PLAYLIST from PLAYLISTS where NAME_PLAYLIST = N'" + name +"'";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)

                return 1;

            return -1;
        }

        public int InsertPlaylist(string name)
        {
            int data = IsExist(name);

            string query = "Exec Proc_Insert_Playlist_By_Name @name_playlist";

            DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { name });

            return data;

                
        }
    }
}
