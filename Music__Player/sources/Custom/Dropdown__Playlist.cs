using Guna.UI2.WinForms;
using Music__Player.sources.DAO.CustomDAO;
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
    public partial class Dropdown__Playlist : UserControl
    {
        FlowLayoutPanel fpHovered = new FlowLayoutPanel();
        public Dropdown__Playlist()
        {
            InitializeComponent();

            LoadDropdown();
        }

        void LoadDropdown()
        {
            fpnlMain.Controls.Clear();

            List<Name__Playlist__Panel> listNamePlaylist = Name__Playlist__Panel__DAO.Instance.GetListNamePlaylist();

            foreach (Name__Playlist__Panel namePlaylist in listNamePlaylist)
            {
                namePlaylist.MouseEnterAdd += namePlaylist_MouseEnterAdd;

                namePlaylist.MouseLeaveAdd += namePlaylist_MouseLeaveAdd;

                fpnlMain.Controls.Add(namePlaylist);
            }
        }

        private void namePlaylist_MouseEnterAdd(object sender, EventArgs e)
        {
            //if (fpHovered.Tag != null)
            //{
            //    Name__Playlist prev = (Name__Playlist)fpHovered.Tag;

            //    prev.IsHovered = false;
            //}

            if (sender is Guna2ImageButton || sender is Label)
            {
                Name__Playlist__Panel namePlaylistInside = Name__Playlist__Panel__DAO.Instance.GetNamePlaylistFromControlIntoPanel(sender);

                namePlaylistInside.IsHovered = true;

                fpHovered.Tag = namePlaylistInside;

                return;
            }

            Name__Playlist__Panel namePlaylistOutside = Name__Playlist__Panel__DAO.Instance.GetNamePlaylistFromPanel(sender);

            namePlaylistOutside.IsHovered = true;
        }

        private void namePlaylist_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Guna2ImageButton || sender is Label)
            {
                Name__Playlist__Panel namePlaylistInside = Name__Playlist__Panel__DAO.Instance.GetNamePlaylistFromControlIntoPanel(sender);

                namePlaylistInside.IsHovered = false;

                return;
            }

            Name__Playlist__Panel namePlaylistOutside = Name__Playlist__Panel__DAO.Instance.GetNamePlaylistFromPanel(sender);

            namePlaylistOutside.IsHovered = false;
        }
    }
}
