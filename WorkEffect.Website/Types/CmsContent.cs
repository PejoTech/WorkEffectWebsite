using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class CmsContent : BaseEntity
    {
        public CmsContent() { }

        public CmsContent(Guid pageId)
        {
            this.CmsPageId = pageId;
        }

        [Required]
        public Guid CmsPageId { get; set; }

        [Required]
        public Enums.Enums.CmsContentType Type { get; set; }

        public string Content { get; set; }
    }
}
