using Music__Player.sources.Custom;
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

namespace Music__Player.sources.View
{
    public partial class Albums : UserControl
    {
        public Albums()
        {
            InitializeComponent();
            Load_Album();
        }

        private void Albums_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void Load_Album()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Album__Panel> listAlbums = AlbumDisplayDAO.Instance.GetAlbumsPanel();
            foreach (Album__Panel album in listAlbums)
            {
                flowLayoutPanel1.Controls.Add(album);
            }
        }
    }
}
