using Music__Player.sources.Constant;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music__Player.sources.DTO.ChildPlaylistDTO
{
    public class PlaylistDTO
    {
        public PlaylistDTO(DataRow row)
        {
            this.Name_Playlist = row["NAME_PLAYLIST"].ToString();

            this.Quantity = (int)row["QUANTITY"];

            if (!Convert.IsDBNull(row["IMAGE_PLAYLIST"]))
            {
                MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_PLAYLIST"]);

                Image temp = Image.FromStream(stream);

                this.Image_Playlist = temp;
            }
            else
            {
                this.Image_Playlist = IMAGE.DefaultPlaylist;
            }
        }
        private string name_Playlist;
        public string Name_Playlist
        {
            get { return name_Playlist; }
            set { name_Playlist = value; }
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        private Image image_Playlist;
        public Image Image_Playlist
        {
            get { return image_Playlist; }
            set { image_Playlist = value; }
        }
    }
}
