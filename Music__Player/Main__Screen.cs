using Music__Player.sources.Custom;
using Music__Player.sources.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player
{
    public partial class Main__Screen : Form
    {
        private int location = 0;
        public Main__Screen()
        {
            InitializeComponent();
            fpanelArtists.AutoScrollPosition = new Point(0, 0);
            fpanelArtists.HorizontalScroll.Maximum = fpanelArtists.Width;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSongs_Click(object sender, EventArgs e)
        {
            if (this.panelMainScreen.Controls.Count > 0)
                this.panelMainScreen.Controls.Clear();
            Songs test = new Songs();
            test.Dock = DockStyle.Fill;
            this.panelMainScreen.Controls.Add(test);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (this.panelMainScreen.Controls.Count > 0)
                this.panelMainScreen.Controls.Clear();
            History history = new History();
            history.Dock = DockStyle.Fill;
            this.panelMainScreen.Controls.Add(history);
        }
    }
}
