using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Video_Library
{
    [Serializable]
    public class YouTube : Video
    {
        public YouTube(string url, string imagineUrl, string title, string channelName, string description, string date, string views, string likes)
            : base(url, imagineUrl, title, channelName, description, date, views, likes)
        {

        }
    }
}
