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
    public class List__Song__Playlist__DAO
    {
        private static List__Song__Playlist__DAO instance;
        public static List__Song__Playlist__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new List__Song__Playlist__DAO();
                return instance;
            }

            private set { instance = value; }
        }

        private List__Song__Playlist__DAO() { }

        public List<List__Song__Playlist> GetListSongByIdPlaylist(int idPlaylist)
        {
            List<List__Song__Playlist> listSongPlaylist = new List<List__Song__Playlist>();

            string query = "Exec Proc_Get_List_Song_In_Playlist_By_ID_Playlist @id_playlist";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { idPlaylist });

            foreach (DataRow item in data.Rows)
            {
                List__Song__Playlist panel = new List__Song__Playlist(item);

                listSongPlaylist.Add(panel);
            }

            return listSongPlaylist;
        }

        public List<List__Song__Playlist> GetListSongByIdGenre(string idGenre)
        {
            List<List__Song__Playlist> listSong = new List<List__Song__Playlist>();

            string query = "Exec PROC_Get_List_Song_By_ID_Genre @id_genre";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { Convert.ToInt32(idGenre) }) ;

            foreach (DataRow item in data.Rows)
            {
                List__Song__Playlist panel = new List__Song__Playlist(item);

                panel.IsAdd = true;

                listSong.Add(panel);
            }

            return listSong;
        }

        public List<List__Song__Playlist> GetListSongByArtist(string nameArtist)
        {
            List<List__Song__Playlist> listSong = new List<List__Song__Playlist>();

            string query = "EXEC PROC_Get_List_Song_By_Name_Artist @name_artist";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { nameArtist });

            foreach (DataRow item in data.Rows)
            {
                List__Song__Playlist panel = new List__Song__Playlist(item);

                panel.IsAdd = true;

                listSong.Add(panel);
            }

            return listSong;
        }

        public string ConvertID(int id)
        {
            if (id.ToString().Length == 1)
                return "0" + id;

            return id.ToString();
        }

        public List__Song__Playlist GetListSongPlaylistFromControlIntoPanel(object sender)
        {
            Control control = (Control)sender;

            Guna2Panel pnl = (Guna2Panel)control.Parent;

            List__Song__Playlist isp = (List__Song__Playlist)pnl.Parent;

            return isp;
        }

        public List__Song__Playlist GetListSongPlaylistFromPanel(object sender)
        {
            Guna2Panel pnl = (Guna2Panel)sender;

            List__Song__Playlist isp = (List__Song__Playlist)pnl.Parent;

            return isp;
        }
    }
}
