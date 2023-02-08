using Music__Player.sources.DTO.ChildAlbumDTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music__Player.sources.DAO.AlbumDAO
{
    public class AlbumDAO
    {
        private static AlbumDAO instance;
        public static AlbumDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AlbumDAO();

                return instance;
            }

            private set { instance = value; }
        }
        private AlbumDAO() { }

        public bool isArtist = false;

        public AlbumDTO GetAlbumByID(string idGenre)
        {
            string query = $"Select NAME_GENRE, IMAGE_GENRE From GENRE where ID_GENRE = {Convert.ToInt32(idGenre)}";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            AlbumDTO playlist = new AlbumDTO(data.Rows[0]);

            return playlist;
        }

        
    }
}
