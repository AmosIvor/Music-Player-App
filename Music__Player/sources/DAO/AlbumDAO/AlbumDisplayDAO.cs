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

        public List<Album__Display> GetAlbumDisPlay()
        {
            List<Album__Display> listAlbums = new List<Album__Display>();
            string query = "";
            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Album__Display album__Display= new Album__Display();
                listAlbums.Add(album__Display);
            }
            return listAlbums;
        }
    }
}
