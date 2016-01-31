using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;

namespace WorkEffect.Website.Models
{
    public class Section : BaseEntity
    {
        public string Name { get; set; }

        public int Order { get; set; }

        public string Content { get; set; }

        public string Image { get; set; }

        public int LayoutId { get; set; }
        public virtual Layout Layout { get; set; }
    }
}
