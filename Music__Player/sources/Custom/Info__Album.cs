using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music__Player.sources.Custom
{
    public partial class Info__Album : UserControl
    {
        public Info__Album()
        {
            InitializeComponent();
        }

        public Info__Album(DataRow row, bool isGenre)
        {
            InitializeComponent();

            this.ID_Genre = (int)row["ID_GENRE"];

            this.Title = row["NAME_GENRE"].ToString();

            MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_GENRE"]);

            Image temp = Image.FromStream(stream);

            this.Image_Genre = temp;

            LoadEvent();
        }

        public Info__Album(DataRow row)
        {
            InitializeComponent();

            this.Title = row["ARTIST"].ToString();

            MemoryStream stream = new MemoryStream((Byte[])row["IMAGE_SONG"]);

            Image temp = Image.FromStream(stream);

            this.Image_Genre = temp;

            LoadEvent();
        }

        private void LoadEvent()
        {
            pnlBackground.FillColor = Color.FromArgb(10, Color.Black);

            btnPlay.MouseClick += btnPlay_MouseClickPlay;

            pnlBackground.MouseDoubleClick += userControl_DoubleClick;

            pnlBackground.MouseEnter += userControl_MouseEnter;

            pnlBackground.MouseLeave += userControl_MouseLeave;
        }

        private bool isArtist;
        public bool IsArtist
        {
            get { return isArtist; }
            set
            {
                isArtist = value;
            }
        }

        private int id_Genre;
        public int ID_Genre
        {
            get { return id_Genre; }

            set { id_Genre = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }

            set { title = value; lblTitle.Text = value; }
        }

        private Image image_Genre;
        public Image Image_Genre
        {
            get { return image_Genre; }

            set { image_Genre = value; pbImage.Image = value; }
        }

        private bool isPlay;
        public bool IsPlay
        {
            get { return isPlay; }
            set
            {
                isPlay = value;

                if (isPlay == true)
                {
                    btnPlay.Checked = true;
                }
                else
                {
                    btnPlay.Checked = false;
                }
            }
        }

        private bool isSelected;
        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;

                if (isSelected == true)
                {
                    btnPlay.Checked = true;

                    pnlBackground.FillColor = Color.FromArgb(30, Color.Black);

                }
                else
                {
                    btnPlay.Checked = false;

                    pnlBackground.FillColor = Color.FromArgb(10, Color.Black);
                }
            }
        }

        private bool isHovered;
        public bool IsHovered
        {
            get { return isHovered; }
            set
            {
                isHovered = value;

                if (isHovered == true || isSelected == true)
                {
                    pnlBackground.FillColor = Color.FromArgb(30, Color.Black);

                    btnPlay.Visible = true;
                }

                else
                {
                    pnlBackground.FillColor = Color.FromArgb(10, Color.Black);

                    btnPlay.Visible = false;
                }
            }
        }

        


        private event MouseEventHandler _mouseDoubleClickAdd;

        public event MouseEventHandler MouseDoubleClickAdd
        {
            add
            {
                this.Cursor = Cursors.Hand;

                _mouseDoubleClickAdd += value;

                foreach (Control control in pnlBackground.Controls)
                {
                    control.MouseDoubleClick += value;

                    control.Cursor = Cursors.Hand;
                }
            }
            remove
            {
                this.Cursor = Cursors.Default;

                _mouseDoubleClickAdd -= value;

                foreach (Control control in pnlBackground.Controls)
                {
                    control.MouseDoubleClick -= value;

                    Cursor = Cursors.Default;
                }
            }
        }


        private event EventHandler _mouseEnterAdd;

        public event EventHandler MouseEnterAdd
        {
            add
            {
                this.Cursor = Cursors.Hand;

                _mouseEnterAdd += value;

                foreach (Control control in pnlBackground.Controls)
                {
                    control.MouseEnter += value;

                    control.Cursor = Cursors.Hand;
                }
            }

            remove
            {
                this.Cursor = Cursors.Default;

                _mouseEnterAdd -= value;

                foreach (Control control in pnlBackground.Controls)
                {
                    control.MouseEnter -= value;

                    Cursor = Cursors.Default;
                }
            }
        }


        private event EventHandler _mouseLeaveAdd;

        public event EventHandler MouseLeaveAdd
        {
            add
            {
                _mouseLeaveAdd += value;
            }

            remove
            {
                _mouseLeaveAdd -= value;
            }
        }

        private event MouseEventHandler _mouseClickPlay;

        public event MouseEventHandler MouseClickPlay
        {
            add
            {
                _mouseClickPlay += value;
            }
            remove
            {
                _mouseClickPlay -= value;
            }
        }

        private void userControl_DoubleClick(object sender, MouseEventArgs e)
        {
            _mouseDoubleClickAdd?.Invoke(sender, e);
        }

        private void userControl_MouseEnter(object sender, EventArgs e)
        {
            _mouseEnterAdd?.Invoke(sender, e);
        }

        private void userControl_MouseLeave(object sender, EventArgs e)
        {
            _mouseLeaveAdd?.Invoke(sender, e);
        }

        private void btnPlay_MouseClickPlay(object sender, MouseEventArgs e)
        {
            _mouseClickPlay?.Invoke(sender, e);
        }

        private void btnPlay_MouseClick(object sender, MouseEventArgs e)
        {
            btnPlay.Checked = !btnPlay.Checked;

            isPlay = btnPlay.Checked;
        }
    }
}
