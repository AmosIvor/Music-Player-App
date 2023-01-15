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
    public partial class Context__Menu : UserControl
    {
        FlowLayoutPanel fpHovered = new FlowLayoutPanel();

        Item__Menu itemMenuAddPlaylist;

        public Context__Menu()
        {
            InitializeComponent();

            LoadContextMenu();
        }

        void LoadContextMenu()
        {
            fpnlMain.Controls.Clear();

            List<Item__Menu> listItemMenu = Item__Menu__DAO.Instance.GetListItemMenu();

            foreach (Item__Menu itemMenu in listItemMenu)
            {
                itemMenu.MouseEnterAdd += itemMenu_MouseEnterAdd;

                itemMenu.MouseLeaveAdd += itemMenu_MouseLeaveAdd;

                itemMenu.MouseClickAdd += itemMenu_MouseClickAdd;

                fpnlMain.Controls.Add(itemMenu);
            }

            listItemMenu[1].IsAdd = true;

            itemMenuAddPlaylist = listItemMenu[1]; 
        }

        private void itemMenu_MouseClickAdd(object sender, MouseEventArgs e)
        {
            if (sender is Guna2ImageButton || sender is Label)
            {
                Item__Menu itemMenuInside = Item__Menu__DAO.Instance.GetItemMenuFromControlIntoPanel(sender);

                if (itemMenuInside == itemMenuAddPlaylist)
                {
                    return;
                }

                Dropdown__Playlist__DAO.Instance.pnlBackground.Visible = false;

                Context__Menu__DAO.Instance.pnlContextMenu.Visible = false;

                Context__Menu__DAO.Instance.DeleteSongPlaylist();

                return;
            }

            Item__Menu itemMenuOutside = Item__Menu__DAO.Instance.GetItemMenuFromPanel(sender);

            if (itemMenuOutside == itemMenuAddPlaylist)
            {
                return;
            }

            Dropdown__Playlist__DAO.Instance.pnlBackground.Visible = false;

            Context__Menu__DAO.Instance.pnlContextMenu.Visible = false;

            Context__Menu__DAO.Instance.DeleteSongPlaylist();
        }

        private void itemMenu_MouseEnterAdd(object sender, EventArgs e)
        {
            if (fpHovered.Tag != null)
            {
                Item__Menu prev = (Item__Menu)fpHovered.Tag;

                prev.IsHovered = false;
            }

            if (sender is Guna2ImageButton || sender is Label)
            {
                Item__Menu itemMenuInside = Item__Menu__DAO.Instance.GetItemMenuFromControlIntoPanel(sender);

                itemMenuInside.IsHovered = true;

                if (itemMenuInside == itemMenuAddPlaylist)
                {
                    Dropdown__Playlist__DAO.Instance.AddPlaylistEventWhenHoverContextMenu(Context__Menu__DAO.Instance.currScreen);
                }
                else
                {
                    Dropdown__Playlist__DAO.Instance.HideMenu();
                }

                fpHovered.Tag = itemMenuInside;

                return;
            }

            Item__Menu itemMenuOutside = Item__Menu__DAO.Instance.GetItemMenuFromPanel(sender);

            itemMenuOutside.IsHovered = true;
        }

        private void itemMenu_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Guna2ImageButton || sender is Label)
            {
                Item__Menu itemMenuInside = Item__Menu__DAO.Instance.GetItemMenuFromControlIntoPanel(sender);

                itemMenuInside.IsHovered = false;

                return;
            }

            Item__Menu itemMenuOutside = Item__Menu__DAO.Instance.GetItemMenuFromPanel(sender);

            itemMenuOutside.IsHovered = false;
        }

        
    }
}
