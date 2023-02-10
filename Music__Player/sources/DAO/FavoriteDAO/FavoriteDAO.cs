using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO.FavoriteDAO
{
    public class FavoriteDAO
    {
        private static FavoriteDAO instance;
        public static FavoriteDAO Instance
        {
            get
            {
                if (instance == null)

                    instance = new FavoriteDAO();

                return instance;
            }
            private set { instance = value; }
        }

        private FavoriteDAO() { }

        public string nameSong = "";

        public List__Song__Playlist currSongFavorite;

        public List<List__Song__Playlist> GetListSongFavorite()
        {
            List<List__Song__Playlist> listSong = new List<List__Song__Playlist>();

            string query = "EXEC PROC_Get_List_Song_Favorite";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                List__Song__Playlist song = new List__Song__Playlist(row);

                song.IsFavorite = true;

                listSong.Add(song);
            }

            return listSong;
        }

    }
}
