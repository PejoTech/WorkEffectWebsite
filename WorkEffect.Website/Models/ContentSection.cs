using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkEffect.Website.Models
{
    public class ContentSection : BaseEntity
    {
        public string Content { get; set; }

        public int ContentLayoutId { get; set; }
        public virtual ContentLayout ContentLayout { get; set; }
    }
}