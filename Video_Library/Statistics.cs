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
        private StatisticsDetails _statistics;
        private string requestResult;
        private List<StatisticsDetails> _allStatistics = new List<StatisticsDetails>();
        private List<string> _videoURLs = new List<string>();
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
            string[] lines = File.ReadAllLines(@"C:\Users\Laptop\Desktop\Video_Library\Video_Library\bin\Debug\statistics.txt");

            if (lines.Length != 0)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    string[] line = lines[i].Split('\t');
                    _videoURLs.Add(line[0]);
                    StatisticsDetails lineStatistics = new StatisticsDetails(line[1], long.Parse(line[2]), long.Parse(line[3]));
                    if (_video.URL == line[0])
                    {
                        _videoStatistics.Add(lineStatistics);
                    }
                    _allStatistics.Add(lineStatistics);

                }
            }

            var dateTime = DateTime.Now;
            string date = dateTime.ToShortDateString();
            long views = GetCurrentViews(_video.URL);
            long likes = GetCurrentLikes(_video.URL);

            _statistics = new StatisticsDetails(date, views, likes);
            #region ListItemsRefactoring
            for (int i = 0; i < _videoURLs.Count; i++)
            {
                if (_videoURLs[i] == _video.URL)
                {
                    var repeated = _allStatistics.Where(s => s.Date == date).FirstOrDefault();
                    _allStatistics.Remove(repeated);
                    _videoStatistics.Remove(repeated);
                    _videoURLs.Remove(_videoURLs[i]);
                }
            }
            #endregion
            _videoURLs.Add(_video.URL);
            _allStatistics.Add(_statistics);
            _videoStatistics.Add(_statistics);



            for (int i = 0; i < _videoStatistics.Count; i++)
            {
                statisticsChart.Series["Views"].Points.AddXY(_videoStatistics[i].Date, _videoStatistics[i].Views);
                statisticsChart.Series["Views"].IsValueShownAsLabel = true;

                statisticsChart.Series["Likes"].Points.AddXY(_videoStatistics[i].Date, _videoStatistics[i].Likes);
                statisticsChart.Series["Likes"].IsValueShownAsLabel = true;
            }
        }

        private long GetCurrentViews(string videoUrl)
        {
            string views = _videoDetailsRegex.GetViews(requestResult);
            return FormatString(views);
        }
        private long GetCurrentLikes(string videoUrl)
        {
            string likes = _videoDetailsRegex.GetLikes(requestResult);
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
            using (StreamWriter statisticsWrite = new StreamWriter(@"C:\Users\Laptop\Desktop\Video_Library\Video_Library\bin\Debug\statistics.txt"))
            {
                for (int i = 0; i < _allStatistics.Count; i++)
                {
                    statisticsWrite.WriteLine($"{_videoURLs[i]}\t{_allStatistics[i].Date}\t{_allStatistics[i].Views}\t{_allStatistics[i].Likes}");
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            okButton.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
