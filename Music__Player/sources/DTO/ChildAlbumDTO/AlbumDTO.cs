using Music__Player.sources.Constant;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music__Player.sources.DTO.ChildAlbumDTO
{
    public class AlbumDTO
    {
        public AlbumDTO(DataRow row)
        {
            this.Name_Album = row["NAME_GENRE"].ToString();

            if (!Convert.IsDBNull(row["IMAGE_GENRE"]))
            {
                MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_GENRE"]);

                Image temp = Image.FromStream(stream);

                this.Image_Album = temp;
            }
            else
            {
                this.Image_Album = IMAGE.DefaultPlaylist;
            }
        }

        public AlbumDTO(DataRow row, bool isArtist)
        {
            this.Name_Album = row["ARTIST"].ToString();

            if (!Convert.IsDBNull(row["IMAGE_SONG"]))
            {
                MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_SONG"]);

                Image temp = Image.FromStream(stream);

                this.Image_Album = temp;
            }
            else
            {
                this.Image_Album = IMAGE.DefaultPlaylist;
            }
        }

        private string name_Album;
        public string Name_Album
        {
            get { return name_Album; }
            set { name_Album = value; }
        }

        private Image image_Album;
        public Image Image_Album
        {
            get { return image_Album; }
            set { image_Album = value; }
        }
    }
}
