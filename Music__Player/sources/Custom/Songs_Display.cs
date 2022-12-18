using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.Custom
{
    public partial class Songs_Display : UserControl
    {
        public Songs_Display()
        {
            InitializeComponent();
        }

        public Songs_Display(DataRow row)
        {
            InitializeComponent();
            Id = row["ID_SONG"].ToString();

            MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_SONG"]);
            Image temp = Image.FromStream(stream);
            ImageSong = temp;

            NameSong = row["NAME_SONG"].ToString();
            Artist = row["ARTIST"].ToString();
            Duration = row["DURATION"].ToString() ;
            Album = row["NAME_ALBUM"].ToString();
            URL = row["LINK"].ToString();
        }

        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                lbId.Text = id;
            }
        }

        private Image imageSong;
        public Image ImageSong
        {
            get { return imageSong; }
            set
            { imageSong = value; }
        }

        private string nameSong;
        public string NameSong
        {
            get { return nameSong; }
            set
            {
                nameSong = value;
                lbNameSong.Text = nameSong;
            }
        }


        private string artist;
        public string Artist
        {
            get { return artist; }
            set
            {
                artist = value;
                lbArtist.Text = artist;
            }
        }

        private string duration;
        public string Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                lbTimeSong.Text = duration;
            }
        }

        private string album;
        public string Album
        {
            get { return album; }
            set
            {
                album = value;
                lbAlbum.Text = album;
            }
        }

        private string url;
        public string URL
        {
            get { return url; }
            set { url = value;}
        }
    }
}
