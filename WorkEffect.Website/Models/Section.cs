using System.Data.Linq.Mapping;

namespace WorkEffect.Website.Models
{
    public class Section : BaseEntity
    {
        public string Name { get; set; }
        
        public int Order { get; set; }
    }
}
