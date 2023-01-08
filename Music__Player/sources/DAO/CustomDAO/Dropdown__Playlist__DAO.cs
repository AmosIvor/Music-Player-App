using Guna.UI2.WinForms;
using Music__Player.sources.Constant;
using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Data;
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

        public bool isFirst = false;

        int WIDTH_DROPDOWN = 293;

        int HEIGHT_DROPDOWN = 253;

        public string songSelecting;

        public void ShowDropDownPlaylistPanel(Panel panelHome, int locationX, int locationY)
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

        public void ShowDropDownPlaylistUserControl(UserControl control, int locationX, int locationY)
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

            control.Controls.Add(pnlBackground);

            pnlBackground.BringToFront();
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
                pnlBackground.Visible = false;
            }

            isFirst = false;
        }

        public void AddPlaylistEventInPanel(UserControl screen, Panel panelHome)
        {
            Point clickedPoint = screen.PointToClient(Control.MousePosition);

            clickedPoint = CheckOutOfUserControl(screen, clickedPoint);

            ShowDropDownPlaylistPanel(panelHome, clickedPoint.X + 20, clickedPoint.Y);

            isFirst = true;
        }

        public void AddPlaylistEventInUserControl(UserControl screen)
        {
            Point clickedPoint = screen.PointToClient(Control.MousePosition);

            clickedPoint = CheckOutOfUserControl(screen, clickedPoint);

            ShowDropDownPlaylistUserControl(screen, clickedPoint.X, clickedPoint.Y);

            isFirst = true;
        }

        public Point CheckOutOfUserControl(UserControl screen, Point clickedPoint)
        {
            // check right
            int positionTopRight = clickedPoint.X + WIDTH_DROPDOWN;
            
            if (positionTopRight >= screen.Width)
            {
                clickedPoint = new Point(clickedPoint.X - WIDTH_DROPDOWN - 30, clickedPoint.Y);
            }

            // check bottom
            int positionBottom = clickedPoint.Y + HEIGHT_DROPDOWN;

            if (positionBottom >= screen.Height)
            {
                clickedPoint = new Point(clickedPoint.X, clickedPoint.Y - HEIGHT_DROPDOWN);
            }

            return clickedPoint;
        }

        public void InsertSongPlaylist(int idPlaylist)
        {
            // check exist
            string query = "EXEC PROC_Check_Exist_Song_In_Playlist @name_song , @id_playlist";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { songSelecting, idPlaylist }); 

            if (data.Rows.Count > 0)
            {
                MessageBox.Show("Exist");

                return;
            }

            string queryInsert = "EXEC PROC_Insert_Song_Playlist @name_song , @id_playlist";

            DataProviderDAO.Instance.ExecuteNonQuery(queryInsert, new object[] { songSelecting, idPlaylist });

            Navigate.Navigation.Instance.playlistScreen.LoadPlaylists();
        }
    }
}
