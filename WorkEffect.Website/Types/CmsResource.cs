using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class CmsResource : BaseEntity
    {
        [MaxLength(12500)]
        public string Content { get; set; }
    }
}
