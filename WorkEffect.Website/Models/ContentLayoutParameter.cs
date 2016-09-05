using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkEffect.Website.Models
{
    public class ContentLayoutParameter : BaseEntity
    {
        public int Index { get; set; }

        public string Name { get; set; }

        [Required]
        public int ContentLayoutId { get; set; }
        public virtual ContentLayout ContentLayout { get; set; }
    }
}