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
    public partial class History : Form
    {
        private List<Video> _searchedVideos;
        private List<Video> _favouritesVideos;

        public History(List<Video> searchedVideos, List<Video> favouritesVideos)
        {
            _searchedVideos = searchedVideos;
            _favouritesVideos = favouritesVideos;
            InitializeComponent();
        }
        public History()
        {
            InitializeComponent();
        }

        private void favouritesMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Favourites favourites = new Favourites(_favouritesVideos, _searchedVideos);
            favourites.ShowDialog();
        }

        private void History_Load(object sender, EventArgs e)
        {
            historyListView.View = View.Details;

            historyListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            searchedVideos.TextAlign = HorizontalAlignment.Center;

            ImageList thumbnails = new ImageList();
            thumbnails.ImageSize = new Size(100, 50);

            foreach (var video in _searchedVideos)
            {
                thumbnails.Images.Add(ImageLoad.LoadImageFromURL(video.ImagineURL));
            }

            historyListView.SmallImageList = thumbnails;

            for (int index = 0; index < _searchedVideos.Count; index++)
            {

                historyListView.Items.Add(_searchedVideos[_searchedVideos.Count - 1 - index].Title, _searchedVideos.Count - 1 - index);
            }

            if (!File.Exists("favouritesData"))
            {
                return;
            }

            IFormatter favouritesFormatter = new BinaryFormatter();
            using (var fs = new FileStream("favouritesData", FileMode.Open))
            {
                _favouritesVideos = (List<Video>)(favouritesFormatter.Deserialize(fs));
            }
        }

        private void historyListView_Click(object sender, EventArgs e)
        {
            deleteButton.Visible = true;
            viewButton.Visible = true;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (historyListView.Items.Count >= 1)
            {
                #region DeleteMessage
                string message = "Are you sure that you would like to delete this video from your History?";
                string caption = "Action confirmation";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                #endregion

                if (result == DialogResult.Yes)
                {
                    Video delete = _searchedVideos.Where(video => video.Equals(_searchedVideos[_searchedVideos.Count - 1 - historyListView.SelectedIndices[0]])).FirstOrDefault();
                    _searchedVideos.Remove(delete);
                    if (_favouritesVideos.Contains(delete))
                    {
                        _favouritesVideos.Remove(delete);
                    }
                    historyListView.Items.RemoveAt(historyListView.SelectedIndices[0]);
                }
            }

            viewButton.Visible = false;
            deleteButton.Visible = false;
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            VideoLibrarySearchResult videoForm = new VideoLibrarySearchResult();
            var videoItemIndex = historyListView.SelectedItems[0].Index;
            Video video = _searchedVideos.Where(v => v.Equals(_searchedVideos[_searchedVideos.Count - 1 - videoItemIndex])).FirstOrDefault();
            this.Close();
            videoForm.SearchResult(video, _searchedVideos, _favouritesVideos);
            videoForm.ShowDialog();
        }
    }
}
