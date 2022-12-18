using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music__Player.sources.DAO.SongDAO
{
    public class SongDisplayDAO
    {
        private static SongDisplayDAO instance;
        public static SongDisplayDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new SongDisplayDAO();
                return instance;
            }
            private set
            {
                Instance = value;
            }
        }
        private SongDisplayDAO() { }
        public List<Songs_Display> GetListSongDisplay()
        {
            List<Songs_Display> listSong = new List<Songs_Display>();
            string query = "SELECT SONG.ID_SONG, NAME_SONG, ARTIST,LINK, IMAGE_SONG, DURATION, NAME_ALBUM, ISFAVORITE\r\nFROM SONG, ALBUMS, FAVORITES\r\nWHERE SONG.ID_ALBUM = ALBUMS.ID_ALBUM AND SONG.ID_ALBUM = FAVORITES.ID_SONG";
            
            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);
            
            foreach (DataRow row in data.Rows) 
            {
                Songs_Display songDisplay = new Songs_Display(row);
                listSong.Add(songDisplay);
            }
            return listSong;
        }

    }
}
