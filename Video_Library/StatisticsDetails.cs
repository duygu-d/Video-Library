using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Library
{
    [Serializable]
    public class StatisticsDetails
    {
        public string VideoUrl { get; set; }
        public string Date { get; set; }
        public long Views { get; set; }
        public long Likes { get; set; }

        public StatisticsDetails(string videoUrl, string date, long views, long likes)
        {
            VideoUrl = videoUrl;
            Date = date;
            Views = views;
            Likes = likes;
        }
    }
}
