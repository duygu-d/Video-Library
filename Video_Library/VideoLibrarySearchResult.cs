using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Library
{
    public partial class VideoLibrarySearchResult : Form
    {
        private List<Video> _searchedVideos = new List<Video>();
        private List<Video> _favouriteVideos = new List<Video>();
        private Video _video;
        public VideoLibrarySearchResult()
        {
            InitializeComponent();
        }

        public void SearchResult(Video video, List<Video> searchedVideos, List<Video> _favouriteVideos)
        {
            Invalidate();
            Video fav = _favouriteVideos.Where(v => v.URL == video.URL).FirstOrDefault();
            if (fav != null)
            {
                FillVideo(fav);
            }
            _video = video;
            _searchedVideos = searchedVideos;
            FillVideo(_video);
        }
        private void favouritesImgButton_Click(object sender, EventArgs e)
        {
            if (_video != null)
            {
                if (_video.IsFavourite)
                {
                    _video.IsFavourite = false;
                    IsVideoFav(_video);
                    _favouriteVideos.Remove(_video);

                    IFormatter favouritesFormatter = new BinaryFormatter();
                    using (var fs = new FileStream("favouritesData", FileMode.Create))
                    {
                        favouritesFormatter.Serialize(fs, _favouriteVideos);
                    }
                }

                else
                {
                    _video.IsFavourite = true;
                    IsVideoFav(_video);
                    _favouriteVideos.Add(_video);

                    IFormatter favouritesFormatter = new BinaryFormatter();
                    using (var fs = new FileStream("favouritesData", FileMode.Create))
                    {
                        favouritesFormatter.Serialize(fs, _favouriteVideos);
                    }
                }

            }
        }

        private void FillVideo(Video video)
        {
            titleTextBox.Text = video.Title;
            channelTextBox.Text = video.ChannelName;
            dateTextBox.Text = video.Date;
            viewsTextBox.Text = video.Views;
            likesTextBox.Text = video.Likes;
            descriptionRichTextBox.Text = video.Description;
            videoPictureBox.Load(video.ImagineURL);
            videoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            IsVideoFav(video);
        }

        private void IsVideoFav(Video video)
        {
            var img = video.IsFavourite ? favouritesImgButton.Image = Image.FromFile(@"C:\Users\Laptop\Desktop\WF_Project_View\favourites.png") : favouritesImgButton.Image = Image.FromFile(@"C:\Users\Laptop\Desktop\WF_Project_View\free-favourite-icon-2765-thumb.png");
        }

        private void favouritesMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Favourites favourites = new Favourites(_favouriteVideos, _searchedVideos);
            favourites.Show();
        }

        private void historyMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            History history = new History(_searchedVideos, _favouriteVideos);
            history.ShowDialog();
        }

        private void VideoLibrarySearchResult_Load(object sender, EventArgs e)
        {
            if (!File.Exists("favouritesData"))
            {
                return;
            }

            IFormatter favouritesFormatter = new BinaryFormatter();
            using (var fs = new FileStream("favouritesData", FileMode.Open))
            {
                _favouriteVideos = (List<Video>)(favouritesFormatter.Deserialize(fs));
            }
        }
    }
}
