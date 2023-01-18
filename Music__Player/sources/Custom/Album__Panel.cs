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

    }
}
