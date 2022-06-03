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
    public partial class Favourites : Form
    {
        private List<Video> _favouritesVideos;
        private List<Video> _searchedVideos;

        public Favourites(List<Video> favouritesVideos, List<Video> searchedVideos)
        {
            _favouritesVideos = favouritesVideos;
            _searchedVideos = searchedVideos;
            InitializeComponent();
        }
        public Favourites()
        {
            InitializeComponent();
        }

        private void historyMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History(_searchedVideos, _favouritesVideos);
            history.Show();
            this.Close();
        }

        private void Favourites_Load(object sender, EventArgs e)
        {
            if (!File.Exists("favouritesData"))
            {
                return;
            }

            IFormatter favouritesFormatter = new BinaryFormatter();
            using (var fs = new FileStream("favouritesData", FileMode.Open))
            {
                _favouritesVideos = (List<Video>)(favouritesFormatter.Deserialize(fs));
            }

            favouritesListView.View = View.Details;

            favouritesListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            favouriteVideos.TextAlign = HorizontalAlignment.Center;

            ImageList thumbnails = new ImageList();
            thumbnails.ImageSize = new Size(100, 50);

            if (_favouritesVideos != null)
            {
                foreach (var video in _favouritesVideos)
                {
                    thumbnails.Images.Add(ImageLoad.LoadImageFromURL(video.ImagineURL));
                }

                favouritesListView.SmallImageList = thumbnails;

                for (int index = 0; index < _favouritesVideos.Count; index++)
                {

                    favouritesListView.Items.Add(_favouritesVideos[_favouritesVideos.Count - 1 - index].Title, _favouritesVideos.Count - 1 - index);
                }
            }
        }
        private void favouritesListView_Click(object sender, EventArgs e)
        {
            removeButton.Visible = true;
            statisticsButton.Visible = true;
            viewButton.Visible = true;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (favouritesListView.Items.Count >= 1)
            {
                #region RemoveMessage
                string message = "Are you sure that you would like to remove this video from your Favourites?";
                string caption = "Action confirmation";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                #endregion

                if (result == DialogResult.Yes)
                {
                    var videoIndex = favouritesListView.SelectedItems[0].Index;
                    Video unfavorite = _favouritesVideos.Where(video => video.Equals(_favouritesVideos[_favouritesVideos.Count - 1 - videoIndex])).FirstOrDefault();
                    unfavorite.IsFavourite = false;
                    _favouritesVideos.Remove(unfavorite);

                    IFormatter favouritesFormatter = new BinaryFormatter();
                    using (var fs = new FileStream("favouritesData", FileMode.Create))
                    {
                        favouritesFormatter.Serialize(fs, _favouritesVideos);
                    }

                    favouritesListView.Items.RemoveAt(favouritesListView.SelectedIndices[0]);
                }
            }

            viewButton.Visible = false;
            statisticsButton.Visible = false;
            removeButton.Visible = false;
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            var videoItemIndex = favouritesListView.SelectedItems[0].Index;
            Video video = _favouritesVideos.Where(v => v.Equals(_favouritesVideos[_favouritesVideos.Count - 1 - videoItemIndex])).FirstOrDefault();
            Statistics statistics = new Statistics(video);
            statistics.ShowDialog();
            
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            VideoLibrarySearchResult videoForm = new VideoLibrarySearchResult();
            var videoItemIndex = favouritesListView.SelectedItems[0].Index;
            Video video = _favouritesVideos.Where(v => v.Equals(_favouritesVideos[_favouritesVideos.Count - 1 - videoItemIndex])).FirstOrDefault();
            videoForm.SearchResult(video, _searchedVideos, _favouritesVideos);
            this.Close();
            videoForm.ShowDialog();
        }
    }
}
