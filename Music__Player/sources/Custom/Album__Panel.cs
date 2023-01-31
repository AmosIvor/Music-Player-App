using Music__Player.sources.DAO;
using Music__Player.sources.DAO.AlbumDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.Custom
{
    public partial class Album__Panel : UserControl
    {
        public Album__Panel()
        {
            InitializeComponent();
        }

        public Album__Panel(DataRow row)
        {
            InitializeComponent();
            TypeAlbum = row["TYPE_ALBUM"].ToString();
            LoadAlbum();
        }
        private string typeAlbum;
        public string TypeAlbum
        {
            get { return typeAlbum; }
            set
            {
                typeAlbum = value;
                lbTypeAlbum.Text = value;
            }
        }
        private void LoadAlbum()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Album__Display> listAlbumDisplays = AlbumDisplayDAO.Instance.GetAlbumsDisplay(TypeAlbum);
            foreach (Album__Display albumDisplay in listAlbumDisplays)
            {
                flowLayoutPanel1.Controls.Add(albumDisplay);
            }
        }
    }
}
