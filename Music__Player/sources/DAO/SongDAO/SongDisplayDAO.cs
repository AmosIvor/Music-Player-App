using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public List<Songs_Display> GetListSongDisplay(Song__Playing__BottomBar songPlayingBar)
        {
            List<Songs_Display> listSongs = new List<Songs_Display>();
            string query = "SELECT SONG.ID_SONG, NAME_SONG, ARTIST,LINK, IMAGE_SONG, DURATION, NAME_ALBUM\r\nFROM SONG, ALBUMS\r\nWHERE SONG.ID_ALBUM = ALBUMS.ID_ALBUM";
            
            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);
            int id = 1;
            foreach (DataRow row in data.Rows) 
            {
                Songs_Display songDisplay = new Songs_Display(row, listSongs, id.ToString(), songPlayingBar);
                ++id;
                listSongs.Add(songDisplay);
            }
            return listSongs;
        }

        public List<Songs_Display> GetListSongSearch(string nameSong, Song__Playing__BottomBar songPlayingBar)
        {
            List<Songs_Display> listSongs = new List<Songs_Display>();
            string query = $"SELECT SONG.ID_SONG, NAME_SONG, ARTIST,LINK, IMAGE_SONG, DURATION, NAME_ALBUM, ISFAVORITE\r\nFROM SONG, ALBUMS, FAVORITES\r\nWHERE SONG.ID_ALBUM = ALBUMS.ID_ALBUM AND SONG.ID_ALBUM = FAVORITES.ID_SONG\r\nAND SONG.NAME_SONG LIKE N'%{nameSong}%'";
            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);
            int id = 1;
            foreach (DataRow row in data.Rows)
            {
                Songs_Display songDisplay = new Songs_Display(row, listSongs, id.ToString(), songPlayingBar);
                songDisplay.BackColor = Color.Gray;
                ++id;
                listSongs.Add(songDisplay);
            }

            // Songs isn't searched
            query = $"SELECT SONG.ID_SONG, NAME_SONG, ARTIST,LINK, IMAGE_SONG, DURATION, NAME_ALBUM, ISFAVORITE\r\nFROM SONG, ALBUMS, FAVORITES\r\nWHERE SONG.ID_ALBUM = ALBUMS.ID_ALBUM AND SONG.ID_ALBUM = FAVORITES.ID_SONG\r\nAND SONG.NAME_SONG NOT IN (\r\n\tSELECT NAME_SONG\r\n\tFROM SONG, ALBUMS, FAVORITES\r\n\tWHERE SONG.ID_ALBUM = ALBUMS.ID_ALBUM AND SONG.ID_ALBUM = FAVORITES.ID_SONG\r\n\tAND SONG.NAME_SONG LIKE N'%{nameSong}%')";
            data = DataProviderDAO.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Songs_Display songDisplay = new Songs_Display(row, listSongs, id.ToString(), songPlayingBar);
                ++id;
                listSongs.Add(songDisplay);
            }
            return listSongs;
        }

       
    }
}
