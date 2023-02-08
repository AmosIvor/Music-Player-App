using Guna.UI2.WinForms;
using Music__Player.sources.Custom;
using Music__Player.sources.DAO.AlbumDAO;
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

namespace Music__Player.sources.View
{
    public partial class Albums : UserControl
    {
        Panel pnlGenreHovered = new Panel();

        Panel pnlClicked = new Panel();

        Info__Album currInfoAlbumPlaying;

        public Albums()
        {
            InitializeComponent();

            LoadAlbum();

            LoadEventClick();

            LoadInitialSongBottomBar();
        }

        public void LoadAlbum()
        {
            LoadAlbumGenre();

            LoadAlbumArtist();
        }

        #region Album Genre

        void LoadAlbumGenre()
        {
            List<Info__Album> listInfoAlbum = Info__Album__DAO.Instance.GetListInfoAlbumGenre();

            foreach (Info__Album album in listInfoAlbum)
            {
                album.MouseDoubleClickAdd += album_MouseDoubleClickAdd;

                album.MouseEnterAdd += album_MouseEnterAdd;

                album.MouseLeaveAdd += album_MouseLeaveAdd;

                album.MouseClickPlay += album_MouseClickPlay;

                fpnlGenre.Controls.Add(album);
            }
        }

        void LoadAlbumArtist()
        {
            List<Info__Album> listInfoAlbum = Info__Album__DAO.Instance.GetListInfoAlbumArtist();

            foreach (Info__Album album in listInfoAlbum)
            {
                album.MouseDoubleClickAdd += album_MouseDoubleClickAdd;

                album.MouseEnterAdd += album_MouseEnterAdd;

                album.MouseLeaveAdd += album_MouseLeaveAdd;

                album.MouseClickPlay += album_MouseClickPlay;

                fpnlArtist.Controls.Add(album);
            }
        }

        private void album_MouseClickPlay(object sender, MouseEventArgs e)
        {
            if (fpnlGenre.Tag != null)
            {
                Info__Album prev = (Info__Album)fpnlGenre.Tag;

                prev.IsSelected = false;

                prev.IsHovered = false;
            }

            Info__Album curr = Info__Album__DAO.Instance.GetInfoAlbumFromControlIntoPanel(sender);

            if (currInfoAlbumPlaying == curr)
            {
                Navigate.Navigation.Instance.mainScreen.LoadChildAlbum();

                pnlClicked.Tag = curr;

                return;
            }

            curr.IsSelected = true;

            fpnlGenre.Tag = curr;

            currInfoAlbumPlaying = curr;

            pnlClicked.Tag = curr;

            Navigate.Navigation.Instance.mainScreen.LoadChildAlbum();

            if (curr.IsArtist == false)
            {
                AlbumDAO.Instance.isArtist = false;

                Navigate.Navigation.Instance.childAlbumScreen.LoadTitle(curr.Image_Genre, curr.Title);

                Navigate.Navigation.Instance.childAlbumScreen.LoadChildAlbum(curr.ID_Genre.ToString());
            }
            else
            {
                AlbumDAO.Instance.isArtist = true;

                Navigate.Navigation.Instance.childAlbumScreen.LoadTitle(curr.Image_Genre, curr.Title);

                Navigate.Navigation.Instance.childAlbumScreen.LoadChildAlbum(curr.Title);
            }

            Navigate.Navigation.Instance.childAlbumScreen.PlayFirstSong();
        }
        private void album_MouseDoubleClickAdd(object sender, MouseEventArgs e)
        {
            if (fpnlGenre.Tag != null)
            {
                Info__Album prevSelected = (Info__Album)fpnlGenre.Tag;

                prevSelected.IsSelected = false;

                prevSelected.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Info__Album infoAlbumInside = Info__Album__DAO.Instance.GetInfoAlbumFromControlIntoPanel(sender);

                if (currInfoAlbumPlaying == infoAlbumInside)
                {
                    Navigate.Navigation.Instance.mainScreen.LoadChildAlbum();

                    pnlClicked.Tag = infoAlbumInside;

                    return;
                }

                infoAlbumInside.IsSelected = true;

                fpnlGenre.Tag = infoAlbumInside;

                currInfoAlbumPlaying = infoAlbumInside;

                pnlClicked.Tag = infoAlbumInside;

                Navigate.Navigation.Instance.mainScreen.LoadChildAlbum();

                if (infoAlbumInside.IsArtist == false)
                {
                    AlbumDAO.Instance.isArtist = false;

                    Navigate.Navigation.Instance.childAlbumScreen.LoadTitle(infoAlbumInside.Image_Genre, infoAlbumInside.Title);

                    Navigate.Navigation.Instance.childAlbumScreen.LoadChildAlbum(infoAlbumInside.ID_Genre.ToString());
                }
                else
                {
                    AlbumDAO.Instance.isArtist = true;

                    Navigate.Navigation.Instance.childAlbumScreen.LoadTitle(infoAlbumInside.Image_Genre, infoAlbumInside.Title);

                    Navigate.Navigation.Instance.childAlbumScreen.LoadChildAlbum(infoAlbumInside.Title);
                }

                Navigate.Navigation.Instance.childAlbumScreen.PlayFirstSong();

                return;
            }

            Info__Album infoAlbumOutside = Info__Album__DAO.Instance.GetInfoAlbumFromPanel(sender);

            if (currInfoAlbumPlaying == infoAlbumOutside)
            {
                Navigate.Navigation.Instance.mainScreen.LoadChildAlbum();

                pnlClicked.Tag = infoAlbumOutside;

                return;
            }

            fpnlGenre.Tag = infoAlbumOutside;

            infoAlbumOutside.IsSelected = true;

            currInfoAlbumPlaying = infoAlbumOutside;

            pnlClicked.Tag = infoAlbumOutside;

            Navigate.Navigation.Instance.mainScreen.LoadChildAlbum();

            if (infoAlbumOutside.IsArtist == false)
            {
                AlbumDAO.Instance.isArtist = false;

                Navigate.Navigation.Instance.childAlbumScreen.LoadTitle(infoAlbumOutside.Image_Genre, infoAlbumOutside.Title);

                Navigate.Navigation.Instance.childAlbumScreen.LoadChildAlbum(infoAlbumOutside.ID_Genre.ToString());
            }
            else
            {
                AlbumDAO.Instance.isArtist = true;

                Navigate.Navigation.Instance.childAlbumScreen.LoadTitle(infoAlbumOutside.Image_Genre, infoAlbumOutside.Title);

                Navigate.Navigation.Instance.childAlbumScreen.LoadChildAlbum(infoAlbumOutside.Title);
            }

            Navigate.Navigation.Instance.childAlbumScreen.PlayFirstSong();
        }
        private void album_MouseEnterAdd(object sender, EventArgs e)
        {
            if (pnlGenreHovered.Tag != null)
            {
                Info__Album prevHover = (Info__Album)pnlGenreHovered.Tag;

                prevHover.IsHovered = false;
            }

            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Info__Album infoAlbumInside = Info__Album__DAO.Instance.GetInfoAlbumFromControlIntoPanel(sender);

                infoAlbumInside.IsHovered = true;

                pnlGenreHovered.Tag = infoAlbumInside;

                return;
            }

            Info__Album infoAlbumOutside = Info__Album__DAO.Instance.GetInfoAlbumFromPanel(sender);

            pnlGenreHovered.Tag = infoAlbumOutside;

            infoAlbumOutside.IsHovered = true;
        }
        private void album_MouseLeaveAdd(object sender, EventArgs e)
        {
            if (sender is Label || sender is Guna2ImageButton || sender is Guna2PictureBox)
            {
                Info__Album infoAlbumInside = Info__Album__DAO.Instance.GetInfoAlbumFromControlIntoPanel(sender);

                infoAlbumInside.IsHovered = false;

                return;
            }

            Info__Album infoAlbumOutside = Info__Album__DAO.Instance.GetInfoAlbumFromPanel(sender);

            infoAlbumOutside.IsHovered = false;
        }

        #endregion

        #region Navigate

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pnlClicked.Tag == null)

                return;

            Navigate.Navigation.Instance.mainScreen.LoadChildAlbum();
        }

        #endregion

        private void LoadEventClick()
        {
            Dropdown__Playlist__DAO.Instance.GetAllControls(this);
        }

        #region Bottom Bar
        void LoadEventBottomBar()
        {
            songPlayingBottomBar.MouseClickAddPlaylist += SongPlayingBottomBar_MouseClickAddPlaylist;
        }

        private void SongPlayingBottomBar_MouseClickAddPlaylist(object sender, EventArgs e)
        {
            Dropdown__Playlist__DAO.Instance.AddPlaylistEventInUserControl(this);
        }

        public void LoadSongPlayingBottomBar()
        {
            songPlayingBottomBar.LoadSongPlayingByInfoSongPanel();
        }

        public void LoadInitialSongBottomBar()
        {
            songPlayingBottomBar.LoadInitialSong();

            LoadEventBottomBar();
        }

        #endregion
    }
}
