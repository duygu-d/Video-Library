using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Video_Library
{
    public static class ImageLoad
    {
        public static Image LoadImageFromURL(string url)
        {
            Image image;
            WebClient wb = new WebClient();
            byte[] imageByte = wb.DownloadData(url);
            using (MemoryStream ms = new MemoryStream(imageByte))
            {
                image = Image.FromStream(ms);
            }

            return image;

        }
    }
}
