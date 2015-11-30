using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class CmsRow : BaseEntityHtml
    {
        public Guid GridId { get; set; }

        public virtual List<CmsCell> CmsCells { get; set; }
}
}
