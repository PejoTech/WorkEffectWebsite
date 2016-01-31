using System.Data.Linq.Mapping;

namespace WorkEffect.Website.Models
{
    [Table(Name = "company")]
    public class Content : BaseEntity
    {
        [Column(Name = "Text")]
        public string Text { get; set; }

        [Column(Name = "Image")]
        public string Image { get; set; }

        [Column(Name = "Layout")]
        public string Layout { get; set; }

        [Column(Name = "Section")]
        public Section Section { get; set; }

        [Column(Name = "SectionId")]
        public int SectionId { get; set; }
    }
}