using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class ContentResource : BaseEntity
    {
        public Guid PartId { get; set; }

        [MaxLength(12500)]
        public string Text { get; set; }
    }
}
