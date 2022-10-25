using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music__Player.Properties;

namespace Music__Player.sources.View
{
    public partial class Child__Playlist : UserControl
    {
        
        public Child__Playlist()
        {
            InitializeComponent();
            datagridviewListSongs.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridviewListSongs.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridviewListSongs.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datagridviewListSongs.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //datagridviewListSongs.Columns[5].HeaderCell.Style.Padding = new Padding(0, 0, 50, 0);
            //datagridviewListSongs.Columns[5].DefaultCellStyle.Padding = new Padding(0, 0, 50, 0);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Bitmap favorite = new Bitmap(Resources.icon_favorite_blue);
            datagridviewListSongs.Rows.Add(
                new object[]
                {
                    "01",
                    "Tran Tuan Vu",
                    "Tuan Vu Author",
                    "Tuan Vu Tran Album",
                    favorite,
                    "03:15"
                }
                );
            
            

        }
    }
}
