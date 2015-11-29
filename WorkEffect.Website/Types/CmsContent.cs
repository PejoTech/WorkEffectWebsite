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
        [Required]
        public Enums.Enums.CmsContentType Type { get; set; }

        public string Content { get; set; }

        public Guid CmsPartId { get; set; }

        public virtual CmsPart CmsPart { get; set; }
    }
}
