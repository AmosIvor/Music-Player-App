using Music__Player.sources.Custom;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Music__Player.sources.DAO.CustomDAO
{
    public class Info__Song__Panel__DAO
    {
        private static Info__Song__Panel__DAO instance;
        public static Info__Song__Panel__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Info__Song__Panel__DAO();
                return instance;
            }

            private set { instance = value; }
        }

        private Info__Song__Panel__DAO() { }

        public List<Info__Song__Panel> GetListInfoSongPanel()
        {
            List<Info__Song__Panel> listPanel = new List<Info__Song__Panel>();

            string query = "Select * from SONG";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Info__Song__Panel panel = new Info__Song__Panel(item);

                listPanel.Add(panel);
            }

            return listPanel;
        }

        public string ConvertID(int id)
        {
            if (id.ToString().Length == 1)
                return "0" + id;

            return id.ToString();
        }

        public Info__Song__Panel GetInfoSongPanelFromControlIntoPanel(object sender)
        {
            Control control = (Control)sender;

            Guna2ShadowPanel pnl = (Guna2ShadowPanel)control.Parent;

            Info__Song__Panel isp = (Info__Song__Panel)pnl.Parent;

            return isp;
        }

        public Info__Song__Panel GetInfoSongPanelFromPanel(object sender)
        {
            Guna2ShadowPanel pnl = (Guna2ShadowPanel)sender;

            Info__Song__Panel isp = (Info__Song__Panel)pnl.Parent;

            return isp;
        }
    }
}
