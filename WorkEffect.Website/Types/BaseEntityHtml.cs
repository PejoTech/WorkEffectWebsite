using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkEffect.Website.Types
{
    public class BaseEntityHtml : BaseEntity
    {
        [MaxLength(12500)]
        public string Html { get; set; }

        [MaxLength(12500)]
        public string Css { get; set; }

        [MaxLength(12500)]
        public string JavaScript { get; set; }
    }
}
