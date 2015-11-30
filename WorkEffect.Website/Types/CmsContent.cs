using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WorkEffect.Website.Types
{
    public class CmsContent : BaseEntity
    {
        public CmsContent() { }

        public CmsContent(Guid pageId, int index)
        {
            this.CmsPageId = pageId;
            this.Index = index;
        }

        [Required]
        [Index(IsUnique = true)]
        public Guid CmsPageId { get; set; }

        [Required]
        public int Index { get; set; }

        [Required]
        public Enums.Enums.CmsContentType Type { get; set; }

        [AllowHtml]
        public string Content { get; set; }
    }
}
