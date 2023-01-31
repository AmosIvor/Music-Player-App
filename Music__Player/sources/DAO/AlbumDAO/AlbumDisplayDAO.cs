using Music__Player.sources.Custom;
using Music__Player.sources.DAO.SongDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music__Player.sources.DAO.AlbumDAO
{
    public class AlbumDisplayDAO
    {
        private static AlbumDisplayDAO instance;
        public static AlbumDisplayDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AlbumDisplayDAO();
                return instance;
            }
            private set
            {
                Instance = value;
            }
        }
        private AlbumDisplayDAO() { }

        public List<Album__Panel> GetAlbumsPanel()
        {
            List<Album__Panel> listAlbums = new List<Album__Panel>();
            string query = "SELECT TYPE_ALBUM \r\nFROM ALBUMS\r\nGROUP BY TYPE_ALBUM\r\nORDER BY LEN(TYPE_ALBUM)";
            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Album__Panel albumPanel= new Album__Panel(row);
                listAlbums.Add(albumPanel);
            }
            return listAlbums;
        }

        public List<Album__Display> GetAlbumsDisplay(string nameAlbum)
        {
            List<Album__Display> listAlbums = new List<Album__Display>();
            string query = $"SELECT *\r\nFROM ALBUMS\r\nWHERE TYPE_ALBUM = N'{nameAlbum}'";
            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Album__Display albumDisplay = new Album__Display(row);
                listAlbums.Add(albumDisplay);
            }
            return listAlbums;
        }
    }
}
