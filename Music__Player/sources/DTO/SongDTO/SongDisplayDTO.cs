using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music__Player.sources.DTO.SongDTO
{
    public class SongDisplayDTO
    {
        public SongDisplayDTO(string title, string artist, string duration, Image imageSong, string album)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            ImageSong = imageSong;
            Album = album;
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
        private Image imageSong;
        public Image ImageSong
        {
            get { return imageSong; }
            set
            {
                imageSong = value;
            }
        }

        private string album;
        public string Album
        {
            get { return album; }
            set { album = value; }
        }
    }
}
