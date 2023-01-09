using Guna.UI2.WinForms;
using Music__Player.sources.DAO.CustomDAO;
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

namespace Music__Player.sources.Custom
{
    public partial class Dropdown__Playlist : UserControl
    {
        FlowLayoutPanel fpHovered = new FlowLayoutPanel();

        Name__Playlist__Panel namePlaylistFirst;

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

                namePlaylist.MouseClickAdd += namePlaylist_MouseClickAdd;

                fpnlMain.Controls.Add(namePlaylist);
            }

            namePlaylistFirst = listNamePlaylist[0];
        }

        private void namePlaylist_MouseEnterAdd(object sender, EventArgs e)
        {
            if (fpHovered.Tag != null)
            {
                Name__Playlist__Panel prev = (Name__Playlist__Panel)fpHovered.Tag;

                prev.IsHovered = false;
            }

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

        private void namePlaylist_MouseClickAdd(object sender, MouseEventArgs e)
        {
            if (sender is Guna2ImageButton || sender is Label)
            {
                Name__Playlist__Panel namePlaylistInside = Name__Playlist__Panel__DAO.Instance.GetNamePlaylistFromControlIntoPanel(sender);

                Dropdown__Playlist__DAO.Instance.pnlBackground.Visible = false;

                if (namePlaylistInside == namePlaylistFirst)
                {
                    Popup__Create__Playlist__DAO.Instance.ShowPopup();

                    return;
                }

                Dropdown__Playlist__DAO.Instance.InsertSongPlaylist(namePlaylistInside.ID_Playlist);

                return;
            }

            Name__Playlist__Panel namePlaylistOutside = Name__Playlist__Panel__DAO.Instance.GetNamePlaylistFromPanel(sender);

            Dropdown__Playlist__DAO.Instance.pnlBackground.Visible = false;

            if (namePlaylistOutside == namePlaylistFirst)
            {
                Popup__Create__Playlist__DAO.Instance.ShowPopup();

                return;
            }

            Dropdown__Playlist__DAO.Instance.InsertSongPlaylist(namePlaylistOutside.ID_Playlist);
        }

        
    }
}
