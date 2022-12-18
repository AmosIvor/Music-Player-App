using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Music__Player.sources.Custom;
using Music__Player.sources.DAO.SongDAO;

namespace Music__Player.sources.View
{
    public partial class Songs : UserControl
    {
        public Songs()
        {
            InitializeComponent();
            UserControl.CheckForIllegalCrossThreadCalls = false;
            Load_Display_Song();
        }
        private void LoadNextSlide()
        {
            
            foreach(UserControl userControl in panel1.Controls)
            {
                Thread.Sleep(2000);
                userControl.BringToFront();
            }
        }

        private void RadioBtn1_CheckedChanged(object sender, EventArgs e)
        {
            slide11.BringToFront();
        }

        private void RadioBtn2_CheckedChanged(object sender, EventArgs e)
        {
            slide21.BringToFront();
        }
        private void RadioBtn3_CheckedChanged(object sender, EventArgs e)
        {
            slide31.BringToFront();
        }
        private void RadioBtn4_CheckedChanged(object sender, EventArgs e)
        {
            slide41.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(LoadNextSlide);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }

        private void Songs_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void Load_Display_Song()
        {
            flowLayoutPanel1.Controls.Clear();
            List<Songs_Display> listSongDisplay = SongDisplayDAO.Instance.GetListSongDisplay();
            foreach(Songs_Display song in listSongDisplay)
            {

            }
        }
    }
}
