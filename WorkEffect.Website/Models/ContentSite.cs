using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkEffect.Website.Models
{
    public class ContentSite : BaseEntity
    {
        public string Name { get; set; }

        public int ContentSectionId { get; set; }
        public virtual ContentSection ContentSection { get; set; }
    }
}