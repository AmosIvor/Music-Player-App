using Music__Player.sources.Custom;
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

        public Song__Playing(Info__Song__Panel infoSong)
        {
            this.Title = infoSong.Title;

            this.Artist = infoSong.Artist;

            this.Duration = infoSong.Duration;

            this.Image_Song = infoSong.Image_Song;

            this.URL = infoSong.URL;
        }

        public Song__Playing(Artist__Panel artistPanel)
        {
            this.Title = artistPanel.Title;

            this.Artist = artistPanel.Artist;

            this.Duration = artistPanel.Duration;

            this.Image_Song = artistPanel.Image_Song;

            this.URL = artistPanel.URL;
        }

        public Song__Playing(List__Song__Playlist songPlaylist)
        {
            this.Title = songPlaylist.Title;

            this.Artist = songPlaylist.Artist;

            this.Duration = songPlaylist.Duration;

            this.Image_Song = songPlaylist.Image_Song;

            this.URL = songPlaylist.URL;
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

        private string url;
        public string URL
        {
            get { return url; }
            set { url = value; }
        }
    }
        
}
