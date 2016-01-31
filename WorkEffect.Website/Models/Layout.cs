using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkEffect.Website.Models
{
    public class Layout : BaseEntity
    {
        public string Name { get; set; }

        public string HtmlContainer { get; set; }
    }
}