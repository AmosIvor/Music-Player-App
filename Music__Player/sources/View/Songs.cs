﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Music__Player.sources.Custom;
using Music__Player.sources.DAO.SongDAO;
using Guna.UI2.WinForms;
using System.Runtime.InteropServices;
using Music__Player.sources.DAO.CustomDAO;

namespace Music__Player.sources.View
{
    public partial class Songs : UserControl
    {
        List<Songs_Display> listSongDisplay;
        public Songs()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Load_Display_Song();

            LoadInitialSongBottomBar();

            //LoadEventClick();
        }
        private void LoadNextSlide()
        {
            foreach(UserControl userControl in panel1.Controls)
            {
                Thread.Sleep(1000);
                userControl.BringToFront();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(LoadNextSlide);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }

        private void Songs_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
            flowLayoutPanel1.AutoScroll = true;
        }

        private void Load_Display_Song()
        {
            flowLayoutPanel1.Controls.Clear();
            listSongDisplay = SongDisplayDAO.Instance.GetListSongDisplay(songPlayingBottomBar);
            foreach(Songs_Display song in listSongDisplay)
            {
                flowLayoutPanel1.Controls.Add(song);
            }
            addListPlayingSong(listSongDisplay);
        }
        void searchNameSong(string findByName)
        {
            flowLayoutPanel1.Controls.Clear();
            List<Songs_Display> listSongSearch = SongDisplayDAO.Instance.GetListSongSearch(findByName, songPlayingBottomBar);
            foreach (Songs_Display song in listSongSearch)
            {
                song.BackColor = Color.Gray;
                flowLayoutPanel1.Controls.Add(song);
            }
        }
        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            string findByName = searchBar.Text;
            if (findByName != "")
            {
                flowLayoutPanel1.Controls.Clear();
                List<Songs_Display> listSongSearch = SongDisplayDAO.Instance.GetListSongSearch(findByName, songPlayingBottomBar);
                foreach (Songs_Display song in listSongSearch)
                {
                    flowLayoutPanel1.Controls.Add(song);
                }
                addListPlayingSong(listSongSearch);
            } else
                Load_Display_Song();
            searchBar.Focus();
        }

        public void addListPlayingSong(List<Songs_Display> list)
        {
            songPlayingBottomBar.ListSong = list;
            songPlayingBottomBar.FlowLayoutPanel1 = flowLayoutPanel1;
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

        private void LoadInitialSongBottomBar()
        {
            songPlayingBottomBar.LoadInitialSong();

            LoadEventBottomBar();
        }

        public void HandleButtonPlay(bool isPlay)
        {
            songPlayingBottomBar.IsPlay = isPlay;
        }

        #endregion

        #region Pause Song 

        public void PauseSongInSong()
        {
            foreach (Songs_Display songs in listSongDisplay)
            {
                if (songs.IsSelectedSong == true)
                    songs.IsSelectedSong = false;
            }
            
        }

        #endregion
    }
}
