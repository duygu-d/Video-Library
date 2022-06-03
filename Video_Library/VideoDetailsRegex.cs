using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Video_Library
{
    public abstract class VideoDetailsRegex
    {
        public abstract string GetImagineURL(string source);
        public abstract string GetTitle(string source);
        public abstract string GetChannelName(string source);
        public abstract string GetDate(string source);
        public abstract string GetViews(string source);
        public abstract string GetLikes(string source);
        public abstract string GetDescription(string source);
        protected static string GetDetails(Regex regex, string source)
        {
            var match = regex.Match(source).Groups[1];
            return match.Value;
        }

        protected static string FormatString(string str)
        {
           return str.Replace("&quot;", "\"").Replace("\\n", Environment.NewLine).Replace("\\u0026","&").Replace("#8","#");
        }
    }
}
