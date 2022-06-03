using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Video_Library
{
   public class Vbox7VideoDetails : VideoDetailsRegex
    {
        public override string GetImagineURL(string source)
        {
            Regex rg = new Regex("\"thumbnailUrl\": \"(.*?)\"");
            return GetDetails(rg, source);
        }
        public override string GetTitle(string source)
        {
            Regex rg = new Regex("'title': '(.*?)'");
            return FormatString(GetDetails(rg, source));
        }

        public override string GetChannelName(string source)
        {
            Regex rg = new Regex("<span>(.*?)</span>");
            var channelName = rg.Matches(source);
            return FormatString(channelName[15].Groups[1].Value);
        }
        public override string GetDate(string source)
        {
            Regex rg = new Regex("i> (\\d\\d.\\d\\d.\\d\\d\\d\\d)");
            return GetDetails(rg, source);
        }
        public override string GetViews(string source)
        {
            Regex rg = new Regex("\"interactionCount\": \"(.*?)\"");
            return GetDetails(rg, source);
        }
        public override string GetLikes(string source)
        {
            Regex rg = new Regex("\"icon-like-num\">(\\d*)<");
            return GetDetails(rg, source);
        }
        public override string GetDescription(string source)
        {
            Regex rg = new Regex("\"description\": \"(.*?)\"");
            return FormatString(GetDetails(rg, source));
        }

    }
}
