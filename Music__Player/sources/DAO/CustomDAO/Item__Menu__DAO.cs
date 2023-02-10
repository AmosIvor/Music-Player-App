using Guna.UI2.WinForms;
using Music__Player.sources.Constant;
using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO.CustomDAO
{
    public class Item__Menu__DAO
    {
        private static Item__Menu__DAO instance;
        public static Item__Menu__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Item__Menu__DAO();

                return instance;
            }
        }

        private Item__Menu__DAO() { }

        public List<Item__Menu> GetListItemMenu(string nameMenu)
        {
            List<Item__Menu> listItem = new List<Item__Menu>();

            Item__Menu itemRemove = new Item__Menu("Remove from this " + nameMenu, ICON.Bin);

            listItem.Add(itemRemove);

            Item__Menu itemAddPlaylist = new Item__Menu("Add to playlist", ICON.Add_Playlist);

            listItem.Add(itemAddPlaylist);

            return listItem;
        }
        public Item__Menu GetItemMenuFromControlIntoPanel(object sender)
        {
            Control control = (Control)sender;

            Guna2Panel panel = (Guna2Panel)control.Parent;

            Item__Menu itemMenu = (Item__Menu)panel.Parent;

            return itemMenu;
        }

        public Item__Menu GetItemMenuFromPanel(object sender)
        {
            Guna2Panel panel = (Guna2Panel)sender;

            Item__Menu itemMenu = (Item__Menu)panel.Parent;

            return itemMenu;
        }
    }
}
