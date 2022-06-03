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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Library
{
    public partial class VideoLibraryMain : Form
    {
        private List<Video> _searchedVideos = new List<Video>();
        private List<Video> _favouriteVideos = new List<Video>();
        private VideoDetailsRegex _videoDetailsRegex;
        private Video _video;
        public VideoLibraryMain()
        {
            InitializeComponent();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (ValidateYoutubeURL(URLtextBox.Text)||ValidateVbox7URL(URLtextBox.Text))
            {
                string url = URLtextBox.Text;
                string requestResult = Request.Get(URLtextBox.Text);

                if (_video == null || _video.URL != url)
                {
                    if (url.ToLower().Contains("youtube"))
                    {
                        _videoDetailsRegex = new YouTubeVideoDetails();

                        string imgURL = _videoDetailsRegex.GetImagineURL(requestResult);
                        string title = _videoDetailsRegex.GetTitle(requestResult);
                        string channel = _videoDetailsRegex.GetChannelName(requestResult);
                        string date = _videoDetailsRegex.GetDate(requestResult);
                        string views = _videoDetailsRegex.GetViews(requestResult);
                        string likes = string.IsNullOrEmpty(_videoDetailsRegex.GetLikes(requestResult)) ? "0" : _videoDetailsRegex.GetLikes(requestResult);
                        string description = _videoDetailsRegex.GetDescription(requestResult);

                        _video = new YouTube(url, imgURL, title, channel, description, date, views, likes);

                    }
                    else if (url.ToLower().Contains("vbox7"))
                    {
                        _videoDetailsRegex = new Vbox7VideoDetails();

                        string imgURL = _videoDetailsRegex.GetImagineURL(requestResult);
                        string title = _videoDetailsRegex.GetTitle(requestResult);
                        string channel = _videoDetailsRegex.GetChannelName(requestResult);
                        string date = _videoDetailsRegex.GetDate(requestResult);
                        string views = _videoDetailsRegex.GetViews(requestResult);
                        string likes = string.IsNullOrEmpty(_videoDetailsRegex.GetLikes(requestResult))? "0" : _videoDetailsRegex.GetLikes(requestResult);
                        string description = _videoDetailsRegex.GetDescription(requestResult);

                        _video = new Vbox7(url, imgURL, title, channel, description, date, views, likes);
                    }
                }
                else
                {
                    if (_video.IsFavourite)
                    {
                        _favouriteVideos.Add(_video);
                    }
                }

                RefactorSearchHistory();
                _searchedVideos.Add(_video);
                VideoLibrarySearchResult videoLibrarySearchResult = new VideoLibrarySearchResult();
                videoLibrarySearchResult.SearchResult(_video, _searchedVideos, _favouriteVideos);
                videoLibrarySearchResult.Show();
            }
            else
            {
                unvalidURLlabel.Text = "Please enter a valid URL!";
                unvalidURLlabel.ForeColor = Color.Red;
            }
            
        }

        private bool ValidateYoutubeURL(string url)
        {
            Regex rg = new Regex("((http(s)?://)?)(www.)?((youtube.com/)|(youtu.be/))[\\S]+");
            return rg.IsMatch(url);
        }
        private bool ValidateVbox7URL(string url)
        {
            Regex rg = new Regex("((http(s)?://)?)(www.)?((vbox7.com/))(play:[\\S]+)");
            return rg.IsMatch(url);
        }
        private void RefactorSearchHistory()
        {
            if (_searchedVideos.Count > 0)
            {
                Video duplicate = _searchedVideos.Where(v => v.URL == _video.URL).FirstOrDefault();
                _searchedVideos.Remove(duplicate);
            }
        }
        private void favouritesMenuItem_Click(object sender, EventArgs e)
        {
            Favourites favourites = new Favourites(_favouriteVideos, _searchedVideos);
            favourites.Show();
        }
        private void historyMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History(_searchedVideos, _favouriteVideos);
            history.Show();
        }

        private void VideoLibraryMain_Load(object sender, EventArgs e)
        {
            if (!File.Exists("historyData"))
            {
                return;
            }

            IFormatter historyFormatter = new BinaryFormatter();
            using (var fs = new FileStream("historyData", FileMode.Open))
            {
                _searchedVideos = (List<Video>)(historyFormatter.Deserialize(fs));
            }

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

        private void VideoLibraryMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter historyFormatter = new BinaryFormatter();
            using (var fs = new FileStream("historyData", FileMode.Create))
            {
                historyFormatter.Serialize(fs, _searchedVideos);
            }
        }
    }
}