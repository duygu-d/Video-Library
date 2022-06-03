using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_Library
{
    public class StatisticsDetails
    {
        public string Date { get; set; }
        public long Views { get; set; }
        public long Likes { get; set; }

        public StatisticsDetails(string date, long views, long likes)
        {
            Date = date;
            Views = views;
            Likes = likes;
        }
    }
}
