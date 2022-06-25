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
    public partial class Statistics : Form
    {
        private string requestResult;
        private List<StatisticsDetails> _allStatistics = new List<StatisticsDetails>();
        private List<StatisticsDetails> _videoStatistics = new List<StatisticsDetails>();
        private Video _video;
        private VideoDetailsRegex _videoDetailsRegex;
        public Statistics(Video video)
        {
            InitializeComponent();
            _video = video;
            requestResult = GetCurrentVideoInformation(video.URL);

            if (_video.GetType().Equals(typeof(YouTube)))
            {
                _videoDetailsRegex = new YouTubeVideoDetails();
            }
            else
            {
                _videoDetailsRegex = new Vbox7VideoDetails();
            }

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            if (GetAllStatisticsDetails() != null)
            {
                _allStatistics = GetAllStatisticsDetails();
            }

            StatisticsDetails statistics = CreateStatistics(_video.URL);

            if (_allStatistics.Count != 0)
            {
                for (int i = 0; i < _allStatistics.Count; i++)
                {
                    if (_allStatistics[i].Date.Equals(statistics.Date) && _allStatistics[i].VideoUrl.Equals(statistics.VideoUrl))
                    {
                        _allStatistics.Remove(_allStatistics[i]);
                    }
                }
            }

            _allStatistics.Add(statistics);

            _videoStatistics = VideoStatisticsDetails(_video.URL);

            for (int i = 0; i < _videoStatistics.Count; i++)
            {
                statisticsChart.Series["Views"].Points.AddXY(_videoStatistics[i].Date, _videoStatistics[i].Views);
                statisticsChart.Series["Views"].IsValueShownAsLabel = true;

                statisticsChart.Series["Likes"].Points.AddXY(_videoStatistics[i].Date, _videoStatistics[i].Likes);
                statisticsChart.Series["Likes"].IsValueShownAsLabel = true;
            }
        }

        private long GetCurrentViews(string request)
        {
            string views = _videoDetailsRegex.GetViews(request);
            return FormatString(views);
        }
        private long GetCurrentLikes(string request)
        {
            string likes = _videoDetailsRegex.GetLikes(request);
            return FormatString(likes);
        }

        private string GetCurrentVideoInformation(string videoUrl)
        {
            return Request.Get(videoUrl);
        }

        private long FormatString(string input)
        {
            input = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
            return long.Parse(input);

        }

        private void Statistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            IFormatter historyFormatter = new BinaryFormatter();
            using (var fs = new FileStream("allStatisticsData", FileMode.Create))
            {
                historyFormatter.Serialize(fs, _allStatistics);
            }
        }

        private List<StatisticsDetails> VideoStatisticsDetails(string videoUrl)
        {
            return _allStatistics.Where(s => s.VideoUrl == videoUrl).ToList();
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            okButton.DialogResult = DialogResult.OK;
            this.Close();
        }

        private StatisticsDetails CreateStatistics(string videoUrl)
        {
            var dateTime = DateTime.Now;
            string date = dateTime.ToShortDateString();
            long views = GetCurrentViews(requestResult);
            long likes = GetCurrentLikes(requestResult);

            StatisticsDetails statistics = new StatisticsDetails(videoUrl, date, views, likes);

            return statistics;
        }
        private List<StatisticsDetails> GetAllStatisticsDetails()
        {
            if (!File.Exists("allStatisticsData"))
            {
                return null;
            }

            IFormatter statisticsFormatter = new BinaryFormatter();
            using (var fs = new FileStream("allStatisticsData", FileMode.Open))
            {
                return _allStatistics = (List<StatisticsDetails>)(statisticsFormatter.Deserialize(fs));
            }
        }
    }
}
