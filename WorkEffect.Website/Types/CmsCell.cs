using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class CmsCell : BaseEntityHtml
    {
        public Guid CmsRowId { get; set; }

        public virtual List<CmsPart> CmsParts { get; set; }

        public virtual List<Guid> CmsPartIds { get; set; }
    }
}
