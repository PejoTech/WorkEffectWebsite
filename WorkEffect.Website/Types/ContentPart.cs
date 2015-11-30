using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class ContentPart : BaseEntity
    {
        public virtual List<ContentGrid> ContentGrids { get; set; }

        public virtual List<Guid> ContentGridId { get; set; }

        public virtual List<ContentResource> ContentResources { get; set; } 
    }
}
