using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music__Player.sources.DAO.CustomDAO
{
    public class Song__History__DAO
    {
        private static Song__History__DAO instance;
        public static Song__History__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Song__History__DAO();
                return instance;
            }
            private set { instance = value; }
        }
        private Song__History__DAO() { }
        public List<Song__History> GetListSongHistory()
        {
            List<Song__History> listSongHistory = new List<Song__History>();


            return listSongHistory;
        }
    }
}
