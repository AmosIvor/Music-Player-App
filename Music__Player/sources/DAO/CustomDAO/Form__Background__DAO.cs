using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.DAO.CustomDAO
{
    public class Form__Background__DAO
    {
        private static Form__Background__DAO instance;
        public static Form__Background__DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new Form__Background__DAO();

                return instance;
            }
        }
        private Form__Background__DAO() { }

        public static Form formBackground;

        public void InitialForm()
        {
            formBackground = new Form();

            formBackground.StartPosition = FormStartPosition.CenterScreen;

            formBackground.FormBorderStyle = FormBorderStyle.None;

            formBackground.Opacity = 0.6;

            formBackground.BackColor = Color.Black;

            formBackground.WindowState = FormWindowState.Normal;

            formBackground.TopMost = true;

            formBackground.Location = Navigate.Navigation.Instance.mainScreen.Location;

            formBackground.ShowInTaskbar = false;

            formBackground.Size = Navigate.Navigation.Instance.mainScreen.Size;

            formBackground.Show();
        }
    }
}
