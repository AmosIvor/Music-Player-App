using Music__Player.sources.Custom;
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
    public partial class Playlist : UserControl
    {
        public Playlist()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Info__Playlist__Panel info = new Info__Playlist__Panel();
            Playlist__Add__Panel add = new Playlist__Add__Panel();

            flowLayoutPanel1.Controls.Add(info);
            flowLayoutPanel1.Controls.Add(add);
        }
    }
}
