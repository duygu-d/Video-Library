using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Video_Library
{
    public class YouTubeVideoDetails : VideoDetailsRegex
    {
        public override string GetImagineURL(string source)
        {
            Regex rg = new Regex("\"image_src\" href=\"(.*?)\"");
            return GetDetails(rg, source);
        }
        public override string GetTitle(string source)
        {
            Regex rg = new Regex("\"title\":\"(.*?)\"");
            return FormatString(GetDetails(rg, source));
        }

        public override string GetChannelName(string source)
        {
            Regex rg = new Regex("\"author\":\"(.*?)\"");
            return FormatString(GetDetails(rg, source));
        }
        public override string GetDate(string source)
        {
            Regex rg = new Regex("\"dateText\":{\"simpleText\":\"(\\d*.\\d*.\\d*)");
            return GetDetails(rg, source);
        }
        public override string GetViews(string source)
        {
            Regex rg = new Regex("\"viewCount\":{\"simpleText\":\"(.*?) ");
            return GetDetails(rg, source);
        }
        public override string GetLikes(string source)
        {
            Regex rg = new Regex("\"defaultText\":{\"accessibility\":{\"accessibilityData\":{\"label\":\"(.*?) ");
            return GetDetails(rg, source);
        }
        public override string GetDescription(string source)
        {
            Regex rg = new Regex("shortDescription\":\"(.*?)\",");
            return FormatString(GetDetails(rg, source));
        }
    }
}
