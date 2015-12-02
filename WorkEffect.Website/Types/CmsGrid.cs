using System;
using System.Collections.Generic;

namespace WorkEffect.Website.Types
{
    public class CmsGrid : BaseEntityHtml
    {
        public virtual List<CmsGrid> CmsGrids { get; set; }

        public virtual List<Guid> CmsGridIds { get; set; }

        public virtual List<CmsRow> CmsRows { get; set; }
    }
}