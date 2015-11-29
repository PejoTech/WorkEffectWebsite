using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class CmsPart : BaseEntity
    {
        public CmsPart()
        {
            
        }

        public CmsPart(Guid pageId)
        {
            this.CmsPageId = pageId;
        }

        public Guid CmsPageId { get; set; }
    }
}
