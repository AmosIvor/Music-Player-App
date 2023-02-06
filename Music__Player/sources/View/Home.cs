using Music__Player.sources.Custom;
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
using Guna.UI2.WinForms;
using Music__Player.sources.DAO.HomeDAO;
using Music__Player.sources.PlayMusic;
using WMPLib;
using System.Threading;

namespace Music__Player.sources.View
{
    public partial class Home : UserControl
    {
        private Panel fpSongHover = new Panel();

        private Panel fpArtistHover = new Panel();

        public static bool isClicked = false;

        public static Info__Song__Panel musicPlaying;
        
        public Home()
        {
            InitializeComponent();

            LoadHome();
        }

        private void LoadHome()
        {
            LoadListArtistPanel();

            LoadListInfoSongPanel();
        }

        #region Info Song Panel
        private void LoadListInfoSongPanel()
        {
            fpanelSongs.Controls.Clear();

            List<Info__Song__Panel> listSong = Info__Song__Panel__DAO.Instance.GetListInfoSongPanel();

            Song__Playing__DAO.Instance.SetSongPlayingByInfoSongPanel(listSong[0], pnlSongPlaying, pbPlaying, lblTitlePlaying, lblArtistPlaying, lblEnd);

            //musicPlaying = listSong[0];

            //musicPlaying.URL = "";

            int id = 1;

            foreach (Info__Song__Panel infoSongPanel in listSong)
            {
                infoSongPanel.ID = Info__Song__Panel__DAO.Instance.ConvertID(id++);

                infoSongPanel.MouseDoubleClickAdd += infoSongPanel_MouseDoubleClickAdd;

                infoSongPanel.MouseEnterAdd += infoSongPanel_MouseEnterAdd;

                infoSongPanel.MouseLeaveAdd += infoSongPanel_MouseLeaveAdd;

                infoSongPanel.MouseClickPlay += infoSongPanel_MouseClickPlay;

                fpanelSongs.Controls.Add(infoSongPanel);
            }

            lblCountFpanelsSong.Text = fpanelSongs.Controls.Count + " songs on the list";

            //musicPlaying = listSong[0];
        }

        private void infoSongPanel_MouseClickPlay(object sender, MouseEventArgs e)
        {
            if (fpanelArtists.Tag != null)
            {
                Artist__Panel prevSelectedArtist = (Artist__Panel)fpanelArtists.Tag;

                prevSelectedArtist.IsSelected = false;

                prevSelectedArtist.IsHovered = false;
            }

            if (fpanelSongs.Tag != null)
            {
                Info__Song__Panel prev = (Info__Song__Panel)fpanelSongs.Tag;

                prev.IsSelected = false;

                prev.IsHovered = false;
            }

            Info__Song__Panel curr = Info__Song__Panel__DAO.Instance.GetInfoSongPanelFromControlIntoPanel(sender);

            curr.IsSelected = true;

            Song__Playing__DAO.Instance.SetSongPlayingByInfoSongPanel(curr, pnlSongPlaying, pbPlaying, lblTitlePlaying, lblArtistPlaying, lblEnd);

            Media__Player.Instance.RunMP3(curr.URL, timerMusic);

            fpanelSongs.Tag = curr;

            musicPlaying = curr;

            //Playlist.Instance.LoadSongPlayingBottomBar();
            Navigate.Navigation.Instance.playlistScreen.LoadSongPlayingBottomBar();
        }
        private void infoSongPanel_MouseDoubleClickAdd(object sender, MouseEventArgs e)
        {
            if (fpanelArtists.Tag != null)
            {
                Artist__Panel prevSelectedArtist = (Artist__Panel)fpanelArtists.Tag;

                prevSelectedArtist.IsSelected = false;

                prevSelectedArtist.IsHovered = false;
            }

            if (fpanelSongs.Tag != null)
            {
                Info__Song__Panel prevSelected = (Info__Song__Panel)fpanelSongs.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Info__Song__Panel infoSongPanelInside = Info__Song__Panel__DAO.Instance.GetInfoSongPanelFromControlIntoPanel(sender);

                infoSongPanelInside.IsSelected = true;

                Song__Playing__DAO.Instance.SetSongPlayingByInfoSongPanel(infoSongPanelInside, pnlSongPlaying, pbPlaying, lblTitlePlaying, lblArtistPlaying, lblEnd);

                Media__Player.Instance.RunMP3(infoSongPanelInside.URL, timerMusic);

                musicPlaying = infoSongPanelInside;

                Navigate.Navigation.Instance.playlistScreen.LoadSongPlayingBottomBar();

                fpanelSongs.Tag = infoSongPanelInside;

                return;
            }

            Info__Song__Panel infoSongPanelOutside = Info__Song__Panel__DAO.Instance.GetInfoSongPanelFromPanel(sender);

            fpanelSongs.Tag = infoSongPanelOutside;

            infoSongPanelOutside.IsSelected = true;

            Song__Playing__DAO.Instance.SetSongPlayingByInfoSongPanel(infoSongPanelOutside, pnlSongPlaying, pbPlaying, lblTitlePlaying, lblArtistPlaying, lblEnd);

            Media__Player.Instance.RunMP3(infoSongPanelOutside.URL, timerMusic);

            musicPlaying = infoSongPanelOutside;

            Navigate.Navigation.Instance.playlistScreen.LoadSongPlayingBottomBar();
        }
        private void infoSongPanel_MouseEnterAdd(object sender, EventArgs e)
        {
            if (fpSongHover.Tag != null)
            {
                Info__Song__Panel prevHover = (Info__Song__Panel)fpSongHover.Tag;

                prevHover.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Info__Song__Panel infoSongPanelInside = Info__Song__Panel__DAO.Instance.GetInfoSongPanelFromControlIntoPanel(sender);

                infoSongPanelInside.IsHovered = true;

                fpSongHover.Tag = infoSongPanelInside;

                return;
            }

            Info__Song__Panel infoSongPanelOutside = Info__Song__Panel__DAO.Instance.GetInfoSongPanelFromPanel(sender);

            infoSongPanelOutside.IsHovered = true;
        }
        private void infoSongPanel_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Info__Song__Panel infoSongPanelInside = Info__Song__Panel__DAO.Instance.GetInfoSongPanelFromControlIntoPanel(sender);

                infoSongPanelInside.IsHovered = false;

                return;
            }

            Info__Song__Panel infoSongPanelOutside = Info__Song__Panel__DAO.Instance.GetInfoSongPanelFromPanel(sender);

            infoSongPanelOutside.IsHovered = false;
        }

        #endregion

        #region Artist Panel 
        private void LoadListArtistPanel()
        {
            fpanelArtists.Controls.Clear();

            List<Artist__Panel> listArtist = Artist__Panel__DAO.Instance.GetListAritistPanel();

            foreach (Artist__Panel artist in listArtist)
            {
                artist.MouseDoubleClickAdd += artistPanel_MouseDoubleClickAdd;

                artist.MouseEnterAdd += artistPanel_MouseEnterAdd;

                artist.MouseLeaveAdd += artistPanel_MouseLeaveAdd;

                artist.MouseClickPlay += artist_MouseClickPlay;

                fpanelArtists.Controls.Add(artist);
            }
        }

        private void artist_MouseClickPlay(object sender, MouseEventArgs e)
        {
            if (fpanelSongs.Tag != null)
            {
                Info__Song__Panel prevSelectedSong = (Info__Song__Panel)fpanelSongs.Tag;

                prevSelectedSong.IsSelected = false;

                prevSelectedSong.IsHovered = false;
            }

            if (fpanelArtists.Tag != null)
            {
                Artist__Panel prev = (Artist__Panel)fpanelArtists.Tag;

                prev.IsSelected = false;

                prev.IsHovered = false;
            }

            Artist__Panel curr = Artist__Panel__DAO.Instance.GetArtistPanelFromControlIntoPanel(sender);

            curr.IsSelected = true;

            fpanelArtists.Tag = curr;

            Song__Playing__DAO.Instance.SetSongPlayingByArtistPanel(curr, pnlSongPlaying, pbPlaying, lblTitlePlaying, lblArtistPlaying, lblEnd);

            Info__Song__Panel infoSongPanel = fpanelSongs.Controls.OfType<Info__Song__Panel>().FirstOrDefault(c => c.Title == curr.Title);

            infoSongPanel.IsSelected = true;

            infoSongPanel.IsHovered = true;

            fpanelSongs.Tag = infoSongPanel;

            Media__Player.Instance.RunMP3(curr.URL, timerMusic);

            musicPlaying = infoSongPanel;

            Navigate.Navigation.Instance.playlistScreen.LoadSongPlayingBottomBar();
        }
        private void artistPanel_MouseDoubleClickAdd(object sender, MouseEventArgs e)
        {
            if (fpanelSongs.Tag != null)
            {
                Info__Song__Panel prevSelectedSong = (Info__Song__Panel)fpanelSongs.Tag;

                prevSelectedSong.IsSelected = false;

                prevSelectedSong.IsHovered = false;
            }

            if (fpanelArtists.Tag != null)
            {
                Artist__Panel prevSelected = (Artist__Panel)fpanelArtists.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Artist__Panel artistPanelInside = Artist__Panel__DAO.Instance.GetArtistPanelFromControlIntoPanel(sender);

                artistPanelInside.IsSelected = true;

                fpanelArtists.Tag = artistPanelInside;

                Song__Playing__DAO.Instance.SetSongPlayingByArtistPanel(artistPanelInside, pnlSongPlaying, pbPlaying, lblTitlePlaying, lblArtistPlaying, lblEnd);

                Media__Player.Instance.RunMP3(artistPanelInside.URL, timerMusic);

                // Handle song
                Info__Song__Panel infoSongPanelInside = fpanelSongs.Controls.OfType<Info__Song__Panel>().FirstOrDefault(c => c.Title == artistPanelInside.Title);

                infoSongPanelInside.IsSelected = true;

                infoSongPanelInside.IsHovered = true;

                musicPlaying = infoSongPanelInside;

                Navigate.Navigation.Instance.playlistScreen.LoadSongPlayingBottomBar();

                fpanelSongs.Tag = infoSongPanelInside;

                return;
            }

            Artist__Panel artistPanelOutside = Artist__Panel__DAO.Instance.GetArtistPanelFromPanel(sender);

            fpanelArtists.Tag = artistPanelOutside;

            artistPanelOutside.IsSelected = true;

            Song__Playing__DAO.Instance.SetSongPlayingByArtistPanel(artistPanelOutside, pnlSongPlaying, pbPlaying, lblTitlePlaying, lblArtistPlaying, lblEnd);

            Info__Song__Panel infoSongPanelOutside = fpanelSongs.Controls.OfType<Info__Song__Panel>().FirstOrDefault(c => c.Title == artistPanelOutside.Title);

            infoSongPanelOutside.IsSelected = true;

            infoSongPanelOutside.IsHovered = true;

            Media__Player.Instance.RunMP3(artistPanelOutside.URL, timerMusic);

            fpanelSongs.Tag = infoSongPanelOutside;

            musicPlaying = infoSongPanelOutside;

            Navigate.Navigation.Instance.playlistScreen.LoadSongPlayingBottomBar();
        }
        private void artistPanel_MouseEnterAdd(object sender, EventArgs e)
        {
            if (fpArtistHover.Tag != null)
            {
                Artist__Panel prevHover = (Artist__Panel)fpArtistHover.Tag;

                prevHover.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Artist__Panel artistPanelInside = Artist__Panel__DAO.Instance.GetArtistPanelFromControlIntoPanel(sender);

                artistPanelInside.IsHovered = true;

                fpArtistHover.Tag = artistPanelInside;

                return;
            }

            Artist__Panel artistPanelOutside = Artist__Panel__DAO.Instance.GetArtistPanelFromPanel(sender);

            fpArtistHover.Tag = artistPanelOutside;

            artistPanelOutside.IsHovered = true;
        }
        private void artistPanel_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Artist__Panel artistPanelInside = Artist__Panel__DAO.Instance.GetArtistPanelFromControlIntoPanel(sender);

                artistPanelInside.IsHovered = false;

                return;
            }

            Artist__Panel artistPanelOutside = Artist__Panel__DAO.Instance.GetArtistPanelFromPanel(sender);

            artistPanelOutside.IsHovered = false;
        }

        #endregion

        #region Handle Playing Music
        private void timerMusic_Tick(object sender, EventArgs e)
        {
            Media__Player.Instance.EventTimer(timerMusic, btnPlay, sliderTimeMusic, lblStart, lblEnd);
        }

        private void sliderTimeMusic_Scroll(object sender, ScrollEventArgs e)
        {
            Media__Player.Instance.SliderTimeMusicScroll(sliderTimeMusic);
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            Media__Player.Instance.btnPlay_Click(btnPlay, null);
        }
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            try
            {
                if (fpanelSongs.Tag != null)
                {
                    Info__Song__Panel curr = (Info__Song__Panel)fpanelSongs.Tag;

                    Media__Player.Instance.RunMP3(curr.URL, timerMusic);
                }
            }
            catch { }
        }

        void NextSong()
        {
            Info__Song__Panel selected = fpanelSongs.Controls.OfType<Info__Song__Panel>().FirstOrDefault(c => c.IsSelected);

            selected.IsSelected = false;

            selected.IsHovered = false;

            int currIndex = fpanelSongs.Controls.GetChildIndex(selected) + 1;

            string nextIndex = Info__Song__Panel__DAO.Instance.ConvertID(++currIndex);

            if (Convert.ToInt32(nextIndex) == fpanelSongs.Controls.Count + 1)
            {
                nextIndex = "01";

                fpanelSongs.VerticalScroll.Value = 0;

                fpanelSongs.VerticalScroll.Value = 0;
            }

            Info__Song__Panel next = fpanelSongs.Controls.OfType<Info__Song__Panel>().FirstOrDefault(c => c.ID == nextIndex);

            next.IsSelected = true;

            Media__Player.Instance.RunMP3(next.URL, timerMusic);

            Song__Playing__DAO.Instance.SetSongPlayingByInfoSongPanel(next, pnlSongPlaying, pbPlaying, lblTitlePlaying, lblArtistPlaying, lblEnd);

            fpanelSongs.Tag = next;

            fpanelSongs.VerticalScroll.Value = (Convert.ToInt32(nextIndex) - 1) * 100;

            fpanelSongs.VerticalScroll.Value = (Convert.ToInt32(nextIndex) - 1) * 100;
        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            NextSong();
        }

        #endregion

        #region HandleExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        #endregion

        private void btnAddPlaylist_Click(object sender, EventArgs e)
        {
            //if (isClicked == false)
            //{
            //    Dropdown__Playlist dropdownPlaylist = new Dropdown__Playlist();

            //    pnlTest.Controls.Add(dropdownPlaylist);

            //    //dropdownPlaylist.Dock = DockStyle.Fill;

            //    pnlTest.Visible = true;

            //    pnlTest.BringToFront();

            //    dropdownPlaylist.Location = new Point(0, 0);

            //    isClicked = true;

            //    return;
            //}

            //pnlTest.Visible = false;

            //isClicked = false;

            if (isClicked == false)
            {
                Dropdown__Playlist__DAO.Instance.ShowDropDownPlaylist(panelHome, 513, 470);

                isClicked = true;

                return;
            }

            isClicked = false;

            Dropdown__Playlist__DAO.Instance.pnlBackground.Visible = false;
        }

       
    }
}
