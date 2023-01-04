using Music__Player.sources.DTO.ChildPlaylistDTO;
using Music__Player.sources.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music__Player.sources.DAO.PlaylistDAO
{
    public class PlaylistDAO
    {
        private static PlaylistDAO instance;
        public static PlaylistDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PlaylistDAO();

                return instance;
            }

            private set { instance = value; }
        }
        private PlaylistDAO() { }

        public PlaylistDTO GetPlaylistByID(int idPlaylist)
        {
            string query = $"Select NAME_PLAYLIST, QUANTITY, IMAGE_PLAYLIST from Playlists where ID_PLAYLIST = {idPlaylist}";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            PlaylistDTO playlist = new PlaylistDTO(data.Rows[0]);

            return playlist;
        }
    }
}
