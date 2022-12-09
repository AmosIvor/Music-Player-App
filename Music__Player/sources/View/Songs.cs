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

namespace Music__Player.sources.View
{
    public partial class Songs : UserControl
    {
        public Songs()
        {
            InitializeComponent();
            UserControl.CheckForIllegalCrossThreadCalls = false;
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

    }
}
