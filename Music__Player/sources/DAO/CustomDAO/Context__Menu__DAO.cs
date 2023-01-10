using Guna.UI2.WinForms;
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
    public class Context__Menu__DAO
    {
        private static Context__Menu__DAO instance;
        public static Context__Menu__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Context__Menu__DAO();

                return instance;
            }
            private set { instance = value; }
        }
        private Context__Menu__DAO() { }

        public Guna2ShadowPanel pnlContextMenu = new Guna2ShadowPanel();

        int WIDTH_MENU = 310;

        int HEIGHT_MENU = 110;

        public bool isFirst = false;

        public void ShowDropDownPlaylistUserControl(UserControl control, int locationX, int locationY)
        {
            pnlContextMenu.Controls.Clear();

            pnlContextMenu.Visible = true;

            pnlContextMenu.ShadowStyle = Guna2ShadowPanel.ShadowMode.ForwardDiagonal;

            Context__Menu contextMenu = new Context__Menu();

            pnlContextMenu.Size = contextMenu.Size;

            pnlContextMenu.Size = new Size(pnlContextMenu.Width + 6, pnlContextMenu.Height + 6);

            Point p = new Point(locationX, locationY);

            pnlContextMenu.Location = p;

            pnlContextMenu.Controls.Add(contextMenu);

            contextMenu.Location = new Point(0, 0);

            control.Controls.Add(pnlContextMenu);

            pnlContextMenu.BringToFront();
        }

        public void GetAllControls(Control container)
        {
            foreach (Control c in container.Controls)
            {
                GetAllControls(c);

                c.MouseClick += Control_MouseClick;
            }
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (isFirst == false && e.Button == MouseButtons.Left)
            {
                pnlContextMenu.Visible = false;
            }

            isFirst = false;
        }

        public void ShowContextMenuInUserControl(UserControl screen)
        {
            Point clickedPoint = screen.PointToClient(Control.MousePosition);

            clickedPoint = CheckOutOfUserControl(screen, clickedPoint);

            ShowDropDownPlaylistUserControl(screen, clickedPoint.X, clickedPoint.Y);

            isFirst = true;
        }

        public Point CheckOutOfUserControl(UserControl screen, Point clickedPoint)
        {
            // check right
            int positionTopRight = clickedPoint.X + WIDTH_MENU;

            if (positionTopRight >= screen.Width)
            {
                clickedPoint = new Point(clickedPoint.X - WIDTH_MENU - 30, clickedPoint.Y);
            }

            // check bottom
            int positionBottom = clickedPoint.Y + HEIGHT_MENU;

            if (positionBottom >= screen.Height)
            {
                clickedPoint = new Point(clickedPoint.X, clickedPoint.Y - HEIGHT_MENU);
            }

            return clickedPoint;
        }
    }
}
