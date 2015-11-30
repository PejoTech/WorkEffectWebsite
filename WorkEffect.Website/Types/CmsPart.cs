using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class CmsPart : BaseEntityHtml
    {
        public virtual List<CmsGrid> CmsGrids { get; set; }

        public virtual List<Guid> CmsGridIds { get; set; }

        public virtual List<CmsResource> CmsResources { get; set; }

        [Index(IsUnique = true)]
        public int Index { get; set; }

        public Enums.Enums.CmsContentType ContentType { get; set; }

        public bool Hidden { get; set; }
    }
}
