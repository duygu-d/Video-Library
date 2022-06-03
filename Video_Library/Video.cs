using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Video_Library
{
    [Serializable]
   public abstract class Video
    {
        public string ImagineURL { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string ChannelName { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string Views { get; set; }
        public string Likes { get; set; }

        public bool IsFavourite = false;

        public Video(string url, string imagineUrl, string title, string channelName, string description, string date, string views, string likes)
        {
            URL = url;
            ImagineURL = imagineUrl;
            Title = title;
            ChannelName = channelName;
            Description = description;
            Date = date;
            Views = views;
            Likes = likes;
        }
    }
}
