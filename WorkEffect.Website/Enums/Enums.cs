using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Enums
{
    public static class Enums
    {
        public enum CmsContentType
        {
            Text = 0,
            Spacer = 1,
            Line = 2,
            Image = 3,
            Carousell = 4,
            FilmStrip = 5,
            Button = 6,
            Embed = 7,
            Link = 8
        }

        public enum CmsDisplayArea
        {
            Head = 0,
            Content = 1,
            Footer = 2,
            Other = 3
        }
    }
}
