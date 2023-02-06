using Guna.UI2.WinForms.Suite;
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
    public partial class Album__Display : UserControl
    {
        public Album__Display()
        {
            InitializeComponent();
        }

        public Album__Display(DataRow row)
        {
            InitializeComponent();
            AlbumName = row["NAME_ALBUM"].ToString();

            MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_ALBUM"]);
            Image tmp = Image.FromStream(stream);
            ImageAlbum = tmp;

        }
        private string albumName;
        public string AlbumName
        { 
            get { return albumName; 
        } 
        set
            {
                albumName = value;
                lbNameAlbum.Text = albumName;
            } 
        }

        private Image imageAlbum;
        public Image ImageAlbum
        {
            get { return imageAlbum;}
            set { 
                imageAlbum = value;
                pbImageAlbum.Image = imageAlbum;
            }
        }
        private void btnPlaySong_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
            foreach (Control control in ShadowPanel.Controls)
            {
                control.BackColor = Color.Gainsboro;
            }
            ShadowPanel.FillColor = Color.Gainsboro;

        }

        private void btnPlaySong_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            foreach (Control control in ShadowPanel.Controls)
            {
                control.BackColor = Color.WhiteSmoke;
            }
            ShadowPanel.FillColor = Color.WhiteSmoke;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void ShadowPanel_Click(object sender, EventArgs e)
        {
            AlbumOpenSongs instance = new AlbumOpenSongs();
            
        }
    }
}
