using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class CmsPage : BaseEntity
    {
        [Required]
        [Index(IsUnique = true)]
        public int Index { get; set; }

        public string Name { get; set; }

        public virtual List<CmsContent> CmsContents { get; set; }
    }
}
