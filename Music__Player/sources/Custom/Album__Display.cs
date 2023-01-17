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
    public partial class Album__Display : UserControl
    {
        public Album__Display()
        {
            InitializeComponent();
        }

        public Album__Display(DataRow row)
        {
            InitializeComponent();

        }

        private void btnPlaySong_MouseEnter(object sender, EventArgs e)
        {
            btnPlaySong.Visible = true;
        }

        private void btnPlaySong_MouseLeave(object sender, EventArgs e)
        {
            btnPlaySong.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
