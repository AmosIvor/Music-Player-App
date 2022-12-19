using Music__Player.sources.Constant;
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
    public partial class Info__Playlist__Panel : UserControl
    {
        public Info__Playlist__Panel()
        {
            InitializeComponent();
        }

        public Info__Playlist__Panel(DataRow row)
        {
            InitializeComponent();

            this.Name_Playlist = row["NAME_PLAYLIST"].ToString();

            this.Number_Song = row["QUANTITY"].ToString() + " songs";

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

            set { name_Playlist = value; lblName.Text = value; }
        }

        private string number_Song;
        public string Number_Song
        {
            get { return number_Song; }
            
            set { number_Song = value; lblNumber.Text = value; }
        }

        private Image image_Playlist;
        public Image Image_Playlist
        {
            get { return image_Playlist;}

            set { image_Playlist = value; pbImage.Image = image_Playlist; }
        }
        
    }
}
