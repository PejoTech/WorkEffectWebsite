using System.Data.Linq.Mapping;

namespace WorkEffect.Website.Models
{
    public class Section : BaseEntity
    {
        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Order")]
        public int Order { get; set; }
    }
}
