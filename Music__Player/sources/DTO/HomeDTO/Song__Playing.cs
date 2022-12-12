using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music__Player.sources.DTO.HomeDTO
{
    public class Song__Playing
    {
        public Song__Playing(string title, string artist, string duration, Image imageSong)
        {
            this.Title = title;

            this.Artist = artist;

            this.Duration = duration;

            this.Image_Song = imageSong;
        }

        private string title;
        public string Title
        {
            get { return title; }

            set { title = value; }
        }

        private string artist;
        public string Artist
        {
            get { return artist; }

            set { artist = value; }
        }

        private string duration;
        public string Duration
        {
            get { return duration; }

            set { duration = value; }
        }
    

        private Image image_Song;
        public Image Image_Song
        {
            get { return image_Song; }

            set { image_Song = value; }
        }
    }
        
}
