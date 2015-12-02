using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class CmsPage : BaseEntityHtml
    {
        public virtual CmsGrid CmsGrid { get; set; }
    }
}
