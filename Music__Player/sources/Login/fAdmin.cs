using Music__Player.sources.DAO;
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

namespace Music__Player
{
    public partial class fAdmin : Form
    {
        #region Initial

        HashSet<SongAlbum> listSongAlbum = new HashSet<SongAlbum>();

        HashSet<string> listAlbum = new HashSet<string>();

        HashSet<string> listGenre = new HashSet<string>();

        string[] filePaths;

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        #endregion

        public fAdmin()
        {
            InitializeComponent();

            btnInsert.Enabled = false;
        }

        #region Exit

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        #endregion

        #region Insert Song From File

        private void btnInsert_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Multiselect = true;

            openFileDialog.Title = "Open Music File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePaths = openFileDialog.FileNames;
            }

            GetListAlbumAndGenre();

            LoadSongInDataGridView();

            btnInsert.Enabled = true;
        }

        #endregion

        #region Insert Album and Genre
        void GetListAlbumAndGenre()
        {
            foreach (string path in filePaths)
            {
                WMPLib.IWMPMedia info = (WMPLib.IWMPMedia)player.newMedia(path);

                string album = info.getItemInfo("Album").Trim();

                listAlbum.Add(album);

                string genre = info.getItemInfo("WM/Genre").Trim();

                listGenre.Add(genre);

                string nameSong = info.getItemInfo("Title").Trim();

                SongAlbum songAlbum = new SongAlbum(nameSong, album);

                listSongAlbum.Add(songAlbum);
            }
        }

        void InsertAlbum()
        {
            string query = "PROC_Insert_Album @name_album";

            foreach (string albumName in listAlbum)
            {
                DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { albumName });
            }
        }

        void InsertGenre()
        {
            string query = "PROC_Insert_Genre @name_genre";

            foreach (string genre in listGenre)
            {
                DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { genre });
            }
        }

        void InsertImageGenre()
        {
            string query = "EXEC PROC_Insert_Image_Into_Genre";

            DataProviderDAO.Instance.ExecuteNonQuery(query);
        }

        int GetIDAlbumByNameAlbum(string nameAlbum)
        {
            string query = "PROC_Get_ID_Album_By_Name @name_album";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { nameAlbum });

            return (int)data.Rows[0]["ID_ALBUM"];
        }
        int GetIDGenreByNameGenre(string nameGenre)
        {
            string query = "PROC_Get_ID_Genre_By_Name @name_genre";

            DataTable data = DataProviderDAO.Instance.ExecuteQuery(query, new object[] { nameGenre });

            return (int)data.Rows[0]["ID_GENRE"];
        }

        #endregion

        #region Insert Song

        void InsertSong()
        {
            foreach (string path in filePaths)
            {
                WMPLib.IWMPMedia info = (WMPLib.IWMPMedia)player.newMedia(path);

                string nameSong = info.getItemInfo("Title").Trim();

                string artist = info.getItemInfo("Author").Trim();

                string album = info.getItemInfo("Album").Trim();
                int idAlbum = GetIDAlbumByNameAlbum(album);

                string genre = info.getItemInfo("WM/Genre").Trim();
                int idGenre = GetIDGenreByNameGenre(genre);

                string duration = info.durationString;
                string link = info.getItemInfo("SourceURL").Trim();

                Image image = GetImageFromMusicFile(path);
                var imageConvert = new Bitmap(image);

                var imageStore = new ImageConverter().ConvertTo(imageConvert, typeof(Byte[]));

                string query = "Exec Proc_Insert_Song @name_song , @artist , @image_song , @duration , @link , @id_album , @id_genre";

                DataProviderDAO.Instance.ExecuteNonQuery(query, new object[] { nameSong, artist, imageStore, duration, link, idAlbum, idGenre });
            }


        }

        public Bitmap GetImageFromMusicFile(string path)
        {
            Bitmap image = null;

            var file = TagLib.File.Create(path);

            var mStream = new MemoryStream();

            var picture = file.Tag.Pictures.FirstOrDefault();

            if (picture != null)
            {
                byte[] pData = picture.Data.Data;

                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));

                image = new Bitmap(mStream, false);

                mStream.Dispose();
            }

            return image;
        }

        #endregion

        #region Insert SQL

        private void btnInsertSQL_Click(object sender, EventArgs e)
        {
            InsertAlbum();

            InsertGenre();

            InsertSong();

            LoadSongInDataGridView();

            InsertImageGenre();

            MessageBox.Show("Successful");
        }

        #endregion 

        void LoadSongInDataGridView()
        {
            dataSong.Rows.Clear();

            int id = 1;

            foreach (SongAlbum songAlbum in listSongAlbum)
            {
                string[] row = { ConvertID(id++), songAlbum.NameSong, songAlbum.NameAlbum };

                dataSong.Rows.Add(row);
            }
        }

        public string ConvertID(int id)
        {
            if (id.ToString().Length == 1)
                return "0" + id;

            return id.ToString();
        }
    }
    public class SongAlbum
    {
        public SongAlbum(string nameSong, string nameAlbum)
        {
            this.NameSong = nameSong;

            this.NameAlbum = nameAlbum;
        }
        public string NameSong { get; set; }

        public string NameAlbum { get; set; }
    }
}
