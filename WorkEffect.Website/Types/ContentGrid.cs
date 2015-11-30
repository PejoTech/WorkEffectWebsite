using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class ContentGrid : BaseEntity
    {
        public List<ContentPart> ContentParts { get; set; }

        public List<Guid> ContentPartIds { get; set; }

        public virtual List<ContentGrid> ContenGrids { get; set; }

        public List<Guid> ContenGridIds { get; set; }
    }
}
