using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class CmsPage : BaseEntity
    {
        public string Name { get; set; }

        public List<int> CmsPartIds { get; set; }
    }
}
