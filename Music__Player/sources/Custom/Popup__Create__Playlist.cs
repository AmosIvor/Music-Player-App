using Music__Player.sources.DAO.CustomDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.Custom
{
    public partial class Popup__Create__Playlist : Form
    {
        
        public Popup__Create__Playlist()
        {
            InitializeComponent();

            LoadPopup();
        }

        void LoadPopup()
        {
            txbNamePlaylist.Text = "";

            txbNamePlaylist.Focus();

            btnCreate.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbNamePlaylist_TextChanged(object sender, EventArgs e)
        {
            if (txbNamePlaylist.Text == "")
            {
                btnCreate.Enabled = false;

                return;
            }

            btnCreate.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int data = Popup__Create__Playlist__DAO.Instance.InsertPlaylist(txbNamePlaylist.Text);

            if (data >= 0)
            {
                MessageBox.Show("Name playlist already exist");

                txbNamePlaylist.Focus();

                return;
            }

            this.Close();

            Navigate.Navigation.Instance.playlistScreen.LoadPlaylists();

            Navigate.Navigation.Instance.mainScreen.LoadMenuBarPlaylists();

        }
    }
}
