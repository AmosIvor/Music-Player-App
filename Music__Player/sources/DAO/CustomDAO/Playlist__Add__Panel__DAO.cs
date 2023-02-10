using Guna.UI2.WinForms;
using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO.CustomDAO
{
    public class Playlist__Add__Panel__DAO
    {
        private static Playlist__Add__Panel__DAO instance;
        public static Playlist__Add__Panel__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Playlist__Add__Panel__DAO();
                return instance;
            }

            private set { instance = value; }
        }
        private Playlist__Add__Panel__DAO() { }

        public Playlist__Add__Panel GetPlaylistAddPanelFromControlIntoPanel(object sender)
        {
            Control control = sender as Control;

            Guna2ShadowPanel panel = (Guna2ShadowPanel)control.Parent;

            Playlist__Add__Panel parent = (Playlist__Add__Panel)panel.Parent;

            return parent;
        }
        public Playlist__Add__Panel GetPlaylistAddPanelFromPanel(object sender)
        {
            Guna2ShadowPanel panel = (Guna2ShadowPanel)sender;

            Playlist__Add__Panel parent = (Playlist__Add__Panel)panel.Parent;

            return parent;
        }
    }
}
