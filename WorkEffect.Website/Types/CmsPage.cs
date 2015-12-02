using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class CmsPage : BaseEntityHtml
    {
        public virtual CmsGrid CmsGrid { get; set; }

        public Guid CmsGridId { get; set; }

        [MaxLength(160)]
        public string Name { get; set; }
    }
}
