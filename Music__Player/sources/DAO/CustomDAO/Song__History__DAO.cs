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
    public class Song__History__DAO
    {
        private static Song__History__DAO instance;
        public static Song__History__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Song__History__DAO();
                return instance;
            }
            private set { instance = value; }
        }
        private Song__History__DAO() { }
        public List<Song__History> GetListSongHistory()
        {
            List<Song__History> listSongHistory = new List<Song__History>();

            string query = "EXEC PROC_Get_List_Song_History";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Song__History song = new Song__History(row);

                listSongHistory.Add(song);
            }

            return listSongHistory;
        }

        public void InsertSongHistory(string title)
        {
            string query = "EXEC PROC_Insert_Song_History @name_song";

            DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { title });
        }
        public string ConvertID(int id)
        {
            if (id.ToString().Length == 1)
                return "0" + id;

            return id.ToString();
        }

        public Song__History GetSongHistoryFromControlIntoPanel(object sender)
        {
            Control control = (Control)sender;

            Guna2Panel pnl = (Guna2Panel)control.Parent;

            Song__History song = (Song__History)pnl.Parent;

            return song;
        }

        public Song__History GetSongHistoryFromPanel(object sender)
        {
            Guna2Panel pnl = (Guna2Panel)sender;

            Song__History song = (Song__History)pnl.Parent;

            return song;
        }

        public List<Song__History> GetListSongByDate(DateTime fromDate, DateTime toDate)
        {
            List<Song__History> listSong = new List<Song__History>();

            string query = "EXEC PROC_Get_List_Song_By_Date @fromDate , @toDate";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { fromDate, toDate });

            foreach (DataRow row in data.Rows)
            {
                Song__History song = new Song__History(row);

                listSong.Add(song);
            }

            return listSong;
        }
    }
}
