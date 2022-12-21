using Guna.UI2.WinForms;
using Music__Player.sources.Constant;
using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO.CustomDAO
{
    public class Dropdown__Playlist__DAO
    {
        private static Dropdown__Playlist__DAO instance;
        public static Dropdown__Playlist__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Dropdown__Playlist__DAO();

                return instance;
            }

            private set { instance = value; }
        }
        private Dropdown__Playlist__DAO() { }

        public Guna2ShadowPanel pnlBackground = new Guna2ShadowPanel();

        public void ShowDropDownPlaylist(Guna2GradientPanel panelHome, int locationX, int locationY)
        {
            pnlBackground.Controls.Clear();

            pnlBackground.Visible = true;

            pnlBackground.ShadowStyle = Guna2ShadowPanel.ShadowMode.ForwardDiagonal;

            Dropdown__Playlist dropdownPlaylist = new Dropdown__Playlist();

            pnlBackground.Size = dropdownPlaylist.Size;

            pnlBackground.Size = new Size(pnlBackground.Width + 6, pnlBackground.Height + 6);

            Point p = new Point(locationX, locationY);

            pnlBackground.Location = p;

            pnlBackground.Controls.Add(dropdownPlaylist);

            dropdownPlaylist.Location = new Point(0, 0);

            panelHome.Controls.Add(pnlBackground);

            pnlBackground.BringToFront();
        }

        

    }
}
