using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkEffect.Website.Models
{
    public class ContentLayout : BaseEntity
    {
        public string Name { get; set; }

        public string Css { get; set; }

        public string Html { get; set; }
    }
}