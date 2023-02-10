using Guna.UI2.WinForms;
using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO.AlbumDAO
{
    public class Info__Album__DAO
    {
        private static Info__Album__DAO instance;
        public static Info__Album__DAO Instance
        {
            get
            {
                if (instance == null)

                    instance = new Info__Album__DAO();

                return instance;
            }
            private set { instance = value; }
        }

        private Info__Album__DAO() { }

        public List<Info__Album> GetListInfoAlbumGenre()
        {
            List<Info__Album> listInfo = new List<Info__Album>();

            string query = "Select * from GENRE";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Info__Album infoAlbum = new Info__Album(row, true);

                infoAlbum.IsArtist = false;

                listInfo.Add(infoAlbum);
            }

            return listInfo;
        }

        public List<Info__Album> GetListInfoAlbumArtist()
        {
            List<Info__Album> listInfo = new List<Info__Album>();

            string query = "EXEC PROC_Get_List_Album_Artist";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Info__Album infoAlbum = new Info__Album(row);

                infoAlbum.IsArtist = true;

                listInfo.Add(infoAlbum);
            }

            return listInfo;
        }

        public Info__Album GetInfoAlbumFromControlIntoPanel(object sender)
        {
            Control control = (Control)sender;

            Guna2Panel panel = (Guna2Panel)control.Parent;

            Info__Album artistPanel = (Info__Album)panel.Parent;

            return artistPanel;
        }

        public Info__Album GetInfoAlbumFromPanel(object sender)
        {
            Guna2Panel panel = (Guna2Panel)sender;

            Info__Album artistPanel = (Info__Album)panel.Parent;

            return artistPanel;
        }

    }
}
