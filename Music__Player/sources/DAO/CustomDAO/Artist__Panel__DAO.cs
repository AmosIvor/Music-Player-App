using Guna.UI2.WinForms;
using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO.CustomDAO
{
    public class Artist__Panel__DAO
    {
        private static Artist__Panel__DAO instance;
        public static Artist__Panel__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Artist__Panel__DAO();

                return instance;
            }

            private set { instance = value; }
        }
        private Artist__Panel__DAO() { }

        public List<Artist__Panel> GetListAritistPanel()
        {
            List<Artist__Panel> listArtistPanel = new List<Artist__Panel>();

            string query = "Select top 5 NAME_SONG, ARTIST, IMAGE_SONG, DURATION, LINK From SONG";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Artist__Panel artistPanel = new Artist__Panel(item);

                listArtistPanel.Add(artistPanel);
            }

            return listArtistPanel;
        }

        public Artist__Panel GetArtistPanelFromControlIntoPanel(object sender)
        {
            Control control = (Control)sender;

            Guna2Panel panel = (Guna2Panel)control.Parent;

            Artist__Panel artistPanel = (Artist__Panel)panel.Parent;

            return artistPanel;
        }

        public Artist__Panel GetArtistPanelFromPanel(object sender)
        {
            Guna2Panel panel = (Guna2Panel)sender;

            Artist__Panel artistPanel = (Artist__Panel)panel.Parent;

            return artistPanel;
        }
    }
}
