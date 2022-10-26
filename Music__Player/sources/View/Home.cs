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
    public partial class Home : UserControl
    {
        private int location = 0;
        public Home()
        {
            InitializeComponent();
            fpanelArtists.AutoScrollPosition = new Point(0, 0);
            fpanelArtists.HorizontalScroll.Maximum = fpanelArtists.Width;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            //int change = fpanelArtists.HorizontalScroll.Value + fpanelArtists.HorizontalScroll.SmallChange * 30;
            //fpanelArtists.AutoScrollPosition = new Point(change, 0);

            if (location - fpanelArtists.HorizontalScroll.SmallChange * 30 > 0)
            {
                location -= 30;
                fpanelArtists.HorizontalScroll.Value = location;
            }
            //else
            //{
            //    location = 0;
            //    fpanelArtists.AutoScrollPosition = new Point(location, 0);
            //}
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            //int change = fpanelArtists.HorizontalScroll.Value - fpanelArtists.HorizontalScroll.SmallChange * 30;
            //fpanelArtists.AutoScrollPosition = new Point(change, 0); 
            if ((location + fpanelArtists.HorizontalScroll.SmallChange * 30) < fpanelArtists.HorizontalScroll.Maximum)
            {
                location += 30;
                fpanelArtists.HorizontalScroll.Value = location;
            }
            //else
            //{
            //    location = fpanelArtists.HorizontalScroll.Maximum;
            //    fpanelArtists.AutoScrollPosition = new Point(location, 0);
            //}
        }

    }
}
